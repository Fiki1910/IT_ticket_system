using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacja1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            string connectionString = Properties.Settings.Default.System_Zgloszen_IT_C_ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string queryName = "SELECT DISTINCT Nazwa FROM Serwis";
                    SqlCommand commandName = new SqlCommand(queryName, connection);
                    SqlDataReader readerName = commandName.ExecuteReader();

                    while (readerName.Read())
                    {
                        comboBoxChooseService.Items.Add(readerName["Nazwa"].ToString());
                    }

                    readerName.Close();
                  

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Błąd połączenia z bazą: " + ex.Message);
                }
            }
        }
       private void comboBoxChooseService_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = Properties.Settings.Default.System_Zgloszen_IT_C_ConnectionString;
            if (comboBoxChooseService.SelectedItem == null) return;
            string chosenName = comboBoxChooseService.SelectedItem.ToString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            { 
                try
                {
                    connection.Open();
                    string query = "SELECT TOP 1 Nazwa, Status_Serwisu, Wlasciciel FROM Serwis WHERE Nazwa = @Nazwa";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Nazwa", chosenName);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        textBoxServiceName.Text = reader["Nazwa"].ToString();
                        textBoxServiceStatus.Text = reader["Status_Serwisu"].ToString();
                        textBoxServiceOwner.Text = reader["Wlasciciel"].ToString();

                    }
                    else
                    {
                        textBoxServiceName.Text = "";
                        textBoxServiceStatus.Text = "";
                        textBoxServiceOwner.Text = "";
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd pobierania danych: " + ex.Message);
                }
            }
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }

        private void buttonCLearContent_Click(object sender, EventArgs e)
        {
            comboBoxChooseService.SelectedIndex = -1;

            textBoxServiceName.Text = "";
            textBoxServiceStatus.Text = "";
            textBoxServiceOwner.Text = "";
        }
    }
}
