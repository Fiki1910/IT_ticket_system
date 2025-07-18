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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Aplikacja1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            string connectionString = Properties.Settings.Default.System_Zgloszen_IT_C_ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string queryName= "SELECT DISTINCT Nazwa_Grupy FROM Grupa_Wsparcia";
                    SqlCommand commandName = new SqlCommand(queryName, connection);
                    SqlDataReader readerName = commandName.ExecuteReader();

                    while (readerName.Read())
                    {
                        comboBoxNameOfGroup.Items.Add(readerName["Nazwa_Grupy"].ToString());
                    }

                    readerName.Close();


                    string queryManager = "SELECT DISTINCT Manager FROM Grupa_Wsparcia";
                    SqlCommand commandManager = new SqlCommand(queryManager, connection);
                    SqlDataReader readerManager = commandManager.ExecuteReader();
                    while (readerManager.Read())
                    {
                        comboBoxManager.Items.Add(readerManager["Manager"].ToString());
                    }
                    readerManager.Close();

                    
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Błąd połączenia z bazą: " + ex.Message);
                }
            }
        }
        private void comboBoxNameOfGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = Properties.Settings.Default.System_Zgloszen_IT_C_ConnectionString;
            if (comboBoxNameOfGroup.SelectedItem == null) return;
            string chosenName = comboBoxNameOfGroup.SelectedItem.ToString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT TOP 1 Nazwa_Grupy, Manager, Drugi_Manager, Ilosc_Pracownikow FROM Grupa_Wsparcia WHERE Nazwa_Grupy = @Nazwa_Grupy";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Nazwa_Grupy", chosenName);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        textBoxGroupName.Text = reader["Nazwa_Grupy"].ToString();
                        textBoxManager.Text = reader["Manager"].ToString();
                        textBoxSecondManager.Text = reader["Drugi_Manager"].ToString();
                        textBoxAmountOfEmployees.Text = reader["Ilosc_Pracownikow"].ToString();
                        
                    }
                    else
                    {
                        textBoxGroupName.Text = "";
                        textBoxManager.Text = "";
                        textBoxSecondManager.Text = "";
                        textBoxAmountOfEmployees.Text = "";
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd pobierania danych: " + ex.Message);
                }
            }
        }

        private void comboBoxManager_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = Properties.Settings.Default.System_Zgloszen_IT_C_ConnectionString;
            if (comboBoxManager.SelectedItem == null) return;
            string chosenManager = comboBoxManager.SelectedItem.ToString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT TOP 1 Nazwa_Grupy, Manager, Drugi_Manager, Ilosc_Pracownikow FROM Grupa_Wsparcia WHERE Manager = @Manager";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Manager", chosenManager);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        textBoxGroupName.Text = reader["Nazwa_Grupy"].ToString();
                        textBoxManager.Text = reader["Manager"].ToString();
                        textBoxSecondManager.Text = reader["Drugi_Manager"].ToString();
                        textBoxAmountOfEmployees.Text = reader["Ilosc_Pracownikow"].ToString();

                    }
                    else
                    {
                        textBoxGroupName.Text = "";
                        textBoxManager.Text = "";
                        textBoxSecondManager.Text = "";
                        textBoxAmountOfEmployees.Text = "";
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd pobierania danych: " + ex.Message);
                }
            }
        }

        private void buttonCLearContent_Click(object sender, EventArgs e)
        {
            comboBoxNameOfGroup.SelectedIndex = -1;
            comboBoxManager.SelectedIndex = -1;

            textBoxGroupName.Text = "";
            textBoxManager.Text = "";
            textBoxSecondManager.Text = "";
            textBoxAmountOfEmployees.Text = "";
           
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }
    }
}
