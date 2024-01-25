using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Linq;

namespace DataBaseNetWorkTool
{
    public partial class DataBaseConnectionForm : Form
    {
        private Dictionary<string, Action> dataBaseTypeStrategy = new Dictionary<string, Action>();
        private string host = null;
        private string port = null;
        private string userName = null;
        private string password = null;
        private string databaseType = null;

        public DataBaseConnectionForm()
        {
            InitializeComponent();
            dataBaseTypeStrategy.Add("MySQL", MySQLHandler);
            dataBaseTypeStrategy.Add("Sqlite", SqliteHandler);
            dataBaseTypeStrategy.Add("Sql Server", SQLServerHandler);
            dataBaseTypeStrategy.Add("Access", AccessHandler);
        }
        private void Connect_Click(object sender, EventArgs e)
        {
            if (DataBaseType.Text.Length == 0)
            {
                MessageBox.Show("请选择数据库类型！");
                return;
            }
            if (DataBaseType.Text == "MySQL" || DataBaseType.Text == "Sql Server")
            {
                bool flag = CheckParam();
                if (!flag)
                    return;
            }
            host = Host.Text;
            port = Port.Text;
            userName = UserName.Text;
            password = Password.Text;
            databaseType = DataBaseType.Text;
            DataBaseTreeView.Nodes.Clear();
            dataBaseTypeStrategy[databaseType]();
        }
        private bool CheckParam()
        {
            if (Host.Text.Length == 0)
            {
                MessageBox.Show("主机IP不能为空！");
                return false;
            }
            if (UserName.Text.Length == 0)
            {
                MessageBox.Show("用户名不能为空");
                return false;
            }
            if (Password.Text.Length == 0)
            {
                MessageBox.Show("密码不能为空！");
                return false;
            }
            return true;
        }
        private void SQLServerHandler()
        {
            //1、连接SQL Server，获取该连接下的所有数据库
            string connectionString = $"Data Source={host};Initial Catalog=master;User ID={userName};Password={password};";
            SqlConnection dataBaseConnection = new SqlConnection(connectionString);
            dataBaseConnection.Open();
            string dataBaseQuery = "SELECT name FROM sys.databases WHERE owner_sid = SUSER_SID()";
            SqlCommand sqlCommand = new SqlCommand(dataBaseQuery, dataBaseConnection);
            SqlDataReader databaseReader = sqlCommand.ExecuteReader();
            while (databaseReader.Read())
            {
                DataBaseTreeView.Nodes.Add(databaseReader.GetString(0));
            }
            databaseReader.Close();
            dataBaseConnection.Close();
            foreach(TreeNode tempDatabase in DataBaseTreeView.Nodes)
            {
                string tempDatabaseName = tempDatabase.Text;
                string databaseConnection = $"Data Source={host};Initial Catalog={tempDatabaseName};User ID={userName};Password={password};";
                SqlConnection databaseConnect = new SqlConnection(databaseConnection);
                databaseConnect.Open();
                string schemaQuery = "SELECT name FROM sys.schemas";
                SqlCommand schemaCommand = new SqlCommand(schemaQuery, databaseConnect);
                SqlDataReader schemasReader=schemaCommand.ExecuteReader();
                while (schemasReader.Read())
                {
                    tempDatabase.Nodes.Add(schemasReader.GetString(0));
                }
                schemasReader.Close();
                databaseConnect.Close();
                foreach(TreeNode tempSchema in tempDatabase.Nodes)
                {
                    string tempSchemaName = tempSchema.Text;
                    SqlConnection tempSchemaConnection = new SqlConnection(databaseConnection);
                    tempSchemaConnection.Open();
                    string tableQuery = $"SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = '{tempSchemaName}'"; ;
                    SqlCommand tableCommand = new SqlCommand(tableQuery,tempSchemaConnection);
                    SqlDataReader tablesReader=tableCommand.ExecuteReader();
                    while (tablesReader.Read())
                    {
                        tempSchema.Nodes.Add(tablesReader.GetString(0));
                    }
                    tablesReader.Close();
                    tempSchemaConnection.Close();
                }
            }
        }
        private void MySQLHandler()
        {
            string connectionString = $"server = {host};port={port}; username = {userName}; password = {password};SslMode=none;CharSet = utf8";
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                MySqlCommand databases = new MySqlCommand("SELECT schema_name FROM information_schema.SCHEMATA; ", connection);
                MySqlDataReader databasesReader = databases.ExecuteReader();
                while (databasesReader.Read())
                {
                    string tempDatabase = databasesReader.GetString(0);
                    DataBaseTreeView.Nodes.Add(tempDatabase);
                }
                connection.Close();
                foreach (TreeNode tempNode in DataBaseTreeView.Nodes)
                {
                    connection.Open();
                    MySqlCommand tables = new MySqlCommand("select TABLE_NAME from information_schema.TABLES where TABLE_SCHEMA='" + tempNode.Text + "';", connection);
                    MySqlDataReader tablesReader = tables.ExecuteReader();
                    while (tablesReader.Read())
                    {
                        string tempTable = tablesReader.GetString(0);
                        TreeNode childNode = tempNode.Nodes.Add(tempTable);
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AccessHandler()
        {
            if (DBlocation.Text == "")
            {
                MessageBox.Show("请选择数据库文件！");
                return;
            }
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+DBlocation.Text+";";
            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();
            var tableNames = connection.GetSchema("Tables").Rows
                    .Cast<DataRow>()
                    .Where(row => row["TABLE_TYPE"].ToString() == "TABLE")
                    .Select(row => row["TABLE_NAME"].ToString())
                    .ToList();
            foreach(string tableName in tableNames)
            {
                DataBaseTreeView.Nodes.Add(tableName);
            }
            connection.Close();
        }
        private void SqliteHandler()
        {
            if (DBlocation.Text == "")
            {
                MessageBox.Show("请选择数据库文件！");
                return;
            }
            string connectionString = "Data Source=" + DBlocation.Text + ";Version=3;";
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();
            string sql = "SELECT name FROM sqlite_master WHERE type='table';";
            SQLiteCommand sqlCommand = new SQLiteCommand(sql, connection);
            SQLiteDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                DataBaseTreeView.Nodes.Add(reader.GetString(0));
            }
            reader.Close();
            connection.Close();
        }
        private void DataBaseTreeView_DoubleClick(object sender, EventArgs e)
        {
            if (sender is TreeView treeView)
            {
                TreeNode selectedNode = treeView.SelectedNode;

                if (DataBaseType.Text == "MySQL" && selectedNode != null && selectedNode.Parent != null)
                {
                    string database = selectedNode.Parent.Text;
                    string table = selectedNode.Text;
                    string connectionString = $"server = {host};port={port}; database={database}; username = {userName}; password = {password};SslMode=none;CharSet = utf8";
                    MySqlConnection tempConnection = new MySqlConnection(connectionString);
                    try
                    {
                        tempConnection.Open();
                        string allDataSql = "SELECT * FROM " + table;
                        MySqlCommand tableDataCommand = new MySqlCommand(allDataSql, tempConnection);
                        MySqlDataAdapter adapter = new MySqlDataAdapter(tableDataCommand);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        DataSet.DataSource = dataTable;
                        tempConnection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        tempConnection.Close();
                    }
                }
                if (DataBaseType.Text == "Access" && selectedNode != null)
                {
                    try
                    {
                        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + DBlocation.Text + ";";
                        OleDbConnection connection = new OleDbConnection(connectionString);
                        connection.Open();
                        string tableName = selectedNode.Text;
                        string query = $"SELECT * FROM [{tableName}]";
                        OleDbCommand command = new OleDbCommand(query, connection);
                        OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        DataSet.DataSource = dataTable;
                        connection.Close();
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                if (DataBaseType.Text == "Sql Lite" && selectedNode != null)
                {
                    string connectionString = "Data Source=" + DBlocation.Text + ";Version=3;";
                    SQLiteConnection connection = new SQLiteConnection(connectionString);
                    connection.Open();
                    string sqlString = "select * from '" + selectedNode.Text + "'";
                    SQLiteCommand sqlCommand = new SQLiteCommand(sqlString, connection);
                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(sqlCommand);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    DataSet.DataSource = dataTable;
                    connection.Close();
                }
                if(DataBaseType.Text=="Sql Server" && selectedNode != null && selectedNode.Parent != null && selectedNode.Parent.Parent != null)
                {
                    try
                    {
                        string database = selectedNode.Parent.Parent.Text;
                        string schema = selectedNode.Parent.Text;
                        string table = selectedNode.Text;
                        string databaseConnection = $"Data Source={host};Initial Catalog={database};User ID={userName};Password={password};";
                        SqlConnection sqlConnection = new SqlConnection(databaseConnection);
                        sqlConnection.Open();
                        string dataQuery = $"select * from {schema}.{table}";
                        SqlCommand sqlCommand = new SqlCommand(dataQuery, sqlConnection);
                        SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        DataSet.DataSource = dataTable;
                        sqlConnection.Close();
                    } catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void Exec_Click(object sender, EventArgs e)
        {
            string sql = Sql.Text;
            if (sql.Length == 0)
            {
                MessageBox.Show("Sql语句不可为空！");
                return;
            }
            if (DataBaseType.Text == "MySQL")
            {
                MySQLExecute(sql);
            }
            if (DataBaseType.Text == "SQL Lite")
            {
                SqliteExecute(sql);
            }
            if(DataBaseType.Text=="Sql Server")
            {
                SqlServerExecute(sql);
            }
        }
        private void SqlServerExecute(string sql)
        {
            if (DataBaseTreeView.SelectedNode == null)
            {
                MessageBox.Show("请选择左侧数据库！");
                return;
            }
            string database = null;
            if (DataBaseTreeView.SelectedNode.Parent == null)
            {
                database = DataBaseTreeView.SelectedNode.Text;
            }else if (DataBaseTreeView.SelectedNode.Parent.Parent == null)
            {
                database = DataBaseTreeView.SelectedNode.Parent.Text;
            }else if (DataBaseTreeView.SelectedNode.Parent.Parent.Parent == null){
                database = DataBaseTreeView.SelectedNode.Parent.Parent.Text;
            }
            try
            {
                string databaseConnection = $"Data Source={host};Initial Catalog={database};User ID={userName};Password={password};";
                SqlConnection sqlConnection = new SqlConnection(databaseConnection);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                if (sql.StartsWith("SELECT") || sql.StartsWith("select"))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    DataSet.DataSource = dataTable;
                }
                else
                {
                    int result = sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("影响结果：" + result);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SqliteExecute(string sql)
        {
            try
            {
                string connectionString = "Data Source=" + DBlocation.Text + ";Version=3;";
                SQLiteConnection connection = new SQLiteConnection(connectionString);
                connection.Open();
                SQLiteCommand sqlCommand = new SQLiteCommand(sql, connection);
                if (sql.StartsWith("select") || sql.StartsWith("SELECT"))
                {
                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(sqlCommand);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    DataSet.DataSource = dataTable;
                }
                else
                {
                    int result = sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("影响结果：" + result);
                }
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        private void MySQLExecute(string sql)
        {
            if (DataBaseTreeView.SelectedNode == null || DataBaseTreeView.SelectedNode.Text.Length == 0)
            {
                MessageBox.Show("请选择左侧的一个数据库！");
                return;
            }
            string database = null;
            if (DataBaseTreeView.SelectedNode.Parent == null)
            {
                database = DataBaseTreeView.SelectedNode.Text;
            }
            else
            {
                database = DataBaseTreeView.SelectedNode.Parent.Text;
            }
            string connectionString = $"server = {host};port={port}; database={database}; username = {userName}; password = {password};SslMode=none;CharSet = utf8";
            MySqlConnection tempConnection = new MySqlConnection(connectionString);
            try
            {
                tempConnection.Open();
                if (sql.StartsWith("select") || sql.StartsWith("SELECT"))
                {
                    MySqlCommand tempCommand = new MySqlCommand(sql, tempConnection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(tempCommand);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    DataSet.DataSource = dataTable;
                }
                else
                {
                    MySqlCommand tempCommand = new MySqlCommand(sql, tempConnection);
                    int result = tempCommand.ExecuteNonQuery();
                    MessageBox.Show("影响行数：" + result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tempConnection.Close();
            }
        }

        private void DataBaseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DataBaseType.SelectedItem.ToString().Equals("Sql Lite")||DataBaseType.SelectedItem.ToString().Equals("Access"))
            {
                SelectDB.Visible = true;
                DBlocation.Visible = true;
            }
        }

        private void SelectDB_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "所有文件 (*.*)|*.*";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                DBlocation.Text = selectedFilePath;
            }
        }
    }
}