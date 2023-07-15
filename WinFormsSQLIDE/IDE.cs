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
using System.Drawing;

namespace WinFormsSQLIDE
{
    public partial class IDE : Form
    {
        public IDE()
        {
            InitializeComponent();
            SetDGVSettings();
            CheckIfTheConnectionIsSet();
        }

        private void CheckIfTheConnectionIsSet()
        {
            if (SystemRegistry.getRegistryKey("Server") == "!@#<NoKey" ||
                SystemRegistry.getRegistryKey("Database") == "!@#<NoKey" ||
                SystemRegistry.getRegistryKey("Table") == "!@#<NoKey")
            {
                btnOdswiez.Enabled = false;
                btnConfig.BackColor = Color.White;
            }
            else
            {
                btnOdswiez.Enabled = true;
                btnConfig.BackColor = Color.AliceBlue;
            }
        }

        private void SetDGVSettings()
        {
            AdjustDataGV.AdjustCellColors(dataGridDB,Color.Green);
        }
        private void btnOdswiez_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void ShowData()
        {
            try
            {
                string connectionString = $@"Data Source={SystemRegistry.getRegistryKey("Server")};
            Initial Catalog={SystemRegistry.getRegistryKey("Database")};Integrated Security=True;Connect Timeout=30;Encrypt=False;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Wykonaj zapytanie do bazy danych
                    string query = $"SELECT * FROM {SystemRegistry.getRegistryKey("Table")}";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridDB.RowHeadersVisible = false;
                    dataGridDB.DataSource = dataTable;
                    AdjustDataGV.AdjustDataGridViewSize(dataGridDB);
                }
            }
            catch (Exception ex)
            {
                //nie wyświetli się błąd widoczny, lepiej messagebox
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_addCol_Click(object sender, EventArgs e)
        {
            string connectionString = $@"Data Source={SystemRegistry.getRegistryKey("Server")};
            Initial Catalog={SystemRegistry.getRegistryKey("Database")};Integrated Security=True;Connect Timeout=30;Encrypt=False;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                    connection.Open();
                    string query = $"ALTER TABLE {SystemRegistry.getRegistryKey("Table")} ADD " + tableColumnName.Text + " VARCHAR(50);";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridDB.RowHeadersVisible = false;
                    dataGridDB.DataSource = dataTable;
                    ShowData();
            }
        }

        private void btn_delCol_Click(object sender, EventArgs e)
        {
            string connectionString = $@"Data Source={SystemRegistry.getRegistryKey("Server")};
            Initial Catalog={SystemRegistry.getRegistryKey("Database")};Integrated Security=True;Connect Timeout=30;Encrypt=False;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                    connection.Open();

                    string query = $"ALTER TABLE {SystemRegistry.getRegistryKey("Table")} DROP COLUMN " + tableColumnName.Text + ";";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridDB.RowHeadersVisible = false;
                    dataGridDB.DataSource = dataTable;
                    ShowData();
            }
        }
        private void btnConfig_Click(object sender, EventArgs e)
        {
            ConfigureWindow window = new ConfigureWindow();
            window.Show();
        }
    }

}
