using Microsoft.Win32;
using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.Win32;
using System.Threading.Tasks;

namespace WinFormsSQLIDE
{
    public partial class Form1 : Form
    {
        public string conStr;
        public Form1()
        {

            InitializeComponent();
            if (!String.IsNullOrEmpty(getRegistryKey()))
            {
                Z_S.Enabled = false;
                cbServer.Enabled = false;
            }
        }


        public static string getRegistryKey()
        {

            string keyName = "Software\\SQLService_Db";
            string valueName = "wersja";

            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(keyName, true);

            if (registryKey == null)
            {
                registryKey = Registry.CurrentUser.CreateSubKey(keyName);
            }

            string getValue = (string)registryKey.GetValue(valueName);

            registryKey.Close();
            return getValue;
        }

        public static void ModifyRegistry(string valueKey)
        {

            string keyName = "Software\\SQLService_Db";
            string valueName = "wersja";

            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(keyName, true);

            if (registryKey == null)
            {
                registryKey = Registry.CurrentUser.CreateSubKey(keyName);
            }

            string getValue = (string)registryKey.GetValue(valueName);

            if (String.IsNullOrEmpty(getValue))
            {
                registryKey.SetValue(valueName, valueKey);
            }

            registryKey.Close();
        }

        private void btnOdswiez_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conStr))
                {
                    if (cbTable.SelectedIndex > -1)
                    {
                        connection.Open();

                        // Wykonaj zapytanie do bazy danych
                        string query = $"SELECT * FROM {cbTable.SelectedItem.ToString()};";
                        SqlCommand command = new SqlCommand(query, connection);
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        dataGridDB.RowHeadersVisible = false;
                        dataGridDB.DataSource = dataTable;
                        AdjustDataGV.AdjustDataGridViewSize(dataGridDB);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void btn_addCol_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(conStr))
            {
                if (cbTable.SelectedIndex > -1)
                {
                    connection.Open();

                    string query = $"ALTER TABLE {cbTable.SelectedItem.ToString()} ADD " + tableColumnName.Text + " VARCHAR(50);";
                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridDB.RowHeadersVisible = false;
                    dataGridDB.DataSource = dataTable;
                }
            }
        }

        private void btn_delCol_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(conStr))
            {
                if (cbTable.SelectedIndex > -1)
                {
                    connection.Open();

                    string query = $"ALTER TABLE {cbTable.SelectedItem.ToString()} DROP COLUMN " + tableColumnName.Text + ";";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridDB.RowHeadersVisible = false;
                    dataGridDB.DataSource = dataTable;
                }
            }
        }

        private void btnSzukaj_Click(object sender, EventArgs e)
        {
            //cbServer.Items.Add("Yes");
            // Utwórz instancję SqlDataSourceEnumerator
            //await Task.Run(() =>
            //{
                SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;

                // Pobierz DataTable, który zawiera informacje o wszystkich dostępnych instancjach SQL Server
                DataTable table = instance.GetDataSources();

                // Przejdź przez każdy wiersz w tabeli
                cbServer.Items.Clear();
                cbServer.Text = string.Empty;
                foreach (DataRow row in table.Rows)
                {
                    // Wydrukuj informacje o serwerze SQL
                    cbServer.Items.Add(row["ServerName"].ToString() + @"\" + row["InstanceName"]?.ToString());
                    //Console.WriteLine("Nazwa serwera: " + row["ServerName"]);
                    //if (string.IsNullOrEmpty(row["InstanceName"].ToString()))
                    //{
                    //    Console.WriteLine("Instancja: Default");
                    //}
                    //else
                    //{
                    //    Console.WriteLine("Instancja: " + row["InstanceName"]);
                    //}
                    //Console.WriteLine("Wersja: " + row["Version"]);
                    //Console.WriteLine("****************************************");
                }
            //});
        }

        private void BtnBazyDanych_Click(object sender, EventArgs e)
        {
            string connectionString;
            if (String.IsNullOrEmpty(getRegistryKey()))
            {
                connectionString = $@"Data Source={cbServer.SelectedItem.ToString()};
            Integrated Security=True;Connect Timeout=30;Encrypt=False;";
                ModifyRegistry(cbServer.SelectedItem.ToString());
            }
            else
            {
                connectionString =  connectionString = $@"Data Source={getRegistryKey()};
            Integrated Security=True;Connect Timeout=30;Encrypt=False;";
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                DataTable databases = connection.GetSchema("Databases");
                cbBase.Items.Clear();
                cbBase.Text = string.Empty;
                foreach (DataRow database in databases.Rows)
                {
                    string databaseName = database.Field<string>("database_name");
                    cbBase.Items.Add(databaseName);
                }
            }
        }

        private void btnSzukajTabel_Click(object sender, EventArgs e)
        {
            string connectionString;
            if (String.IsNullOrEmpty(getRegistryKey()))
            {
                connectionString = $@"Data Source={cbServer.SelectedItem.ToString()};
                Initial Catalog={cbBase.SelectedItem.ToString()};Integrated Security=True;Connect Timeout=30;Encrypt=False;";
            }
            else
            {
                connectionString = $@"Data Source={getRegistryKey()};
                Initial Catalog={cbBase.SelectedItem.ToString()};Integrated Security=True;Connect Timeout=30;Encrypt=False;";
            }
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    DataTable schema = connection.GetSchema("Tables");
                    cbTable.Items.Clear();
                    cbTable.Text = string.Empty;
                    foreach (DataRow row in schema.Rows)
                    {
                        cbTable.Items.Add(row[2]);
                    }
                }
                conStr = connectionString;
            
        }
    }

}
