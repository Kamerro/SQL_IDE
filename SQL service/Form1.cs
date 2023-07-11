using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_service
{
    public partial class Form1 : Form
    {
       public string conStr;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnOdswiez_Click(object sender, EventArgs e)
        {
            
            try
            {
                using (SqlConnection connection = new SqlConnection(conStr))
                {
                    connection.Open();

                    // Wykonaj zapytanie do bazy danych
                    string query = $"SELECT * FROM {cbTab.SelectedItem.ToString()};";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dataGridDB.RowHeadersVisible = false;
                    dataGridDB.DataSource = dataTable;
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
                connection.Open();

                string query = "ALTER TABLE dbo.Pracownicy ADD " + tbNameCol.Text + " VARCHAR(50);";
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridDB.RowHeadersVisible = false;
                dataGridDB.DataSource = dataTable;
            }
        }

        private void btn_delCol_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(conStr))
            {
                connection.Open();

                string query = "ALTER TABLE dbo.Pracownicy DROP COLUMN " + tbNameCol.Text + ";";
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridDB.RowHeadersVisible = false;
                dataGridDB.DataSource = dataTable;
            }
        }

        private void btn_Ser(object sender, EventArgs e)
        {
            cbSer.Items.Add("Yes");
            // Utwórz instancję SqlDataSourceEnumerator
            SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;

            // Pobierz DataTable, który zawiera informacje o wszystkich dostępnych instancjach SQL Server
            DataTable table = instance.GetDataSources();

            // Przejdź przez każdy wiersz w tabeli
            foreach (DataRow row in table.Rows)
            {
                // Wydrukuj informacje o serwerze SQL
                cbSer.Items.Add(row["ServerName"].ToString() + @"\" + row["InstanceName"]?.ToString());
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
        }

        private void btn_Baz(object sender, EventArgs e)
        {
            string connectionString = $@"Data Source={cbSer.SelectedItem.ToString()};
            Integrated Security=True;Connect Timeout=30;Encrypt=False;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                DataTable databases = connection.GetSchema("Databases");
                foreach (DataRow database in databases.Rows)
                {
                    string databaseName = database.Field<string>("database_name");
                    cbBaz.Items.Add(databaseName);
                }
            }
        }

        private void btn_Tab(object sender, EventArgs e)
        {
            string connectionString = $@"Data Source={cbSer.SelectedItem.ToString()};
            Initial Catalog={cbBaz.SelectedItem.ToString()};Integrated Security=True;Connect Timeout=30;Encrypt=False;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                DataTable schema = connection.GetSchema("Tables");
                foreach (DataRow row in schema.Rows)
                {
                    cbTab.Items.Add(row[2]);
                }
            }
            conStr = connectionString;
        }
    }
}
