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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            string connectionString = Properties.Settings.Default.System_Zgloszen_IT_C_ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT DISTINCT Login FROM Administratorzy";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader["Login"].ToString());
                    }

                    reader.Close();


                    
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Błąd połączenia z bazą: " + ex.Message);
                }
            }
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = Properties.Settings.Default.System_Zgloszen_IT_C_ConnectionString;
            if (comboBox1.SelectedItem == null) return;
            string wybranyAdmin = comboBox1.SelectedItem.ToString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT TOP 1 Login, Super_ADM_Rights FROM Administratorzy WHERE Login = @wybranyAdmin";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@wybranyAdmin", wybranyAdmin);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        textBoxUsername.Text = reader["Login"].ToString();
                        textBoxSuperAdm.Text = reader["Super_ADM_Rights"].ToString();
                        
                    }
                    else
                    {
                        textBoxUsername.Text = "";
                        textBoxSuperAdm.Text = "";
                       
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd pobierania danych: " + ex.Message);
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            

           textBoxUsername.Text = "";
           textBoxSuperAdm.Text = "";
         
       }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
            this.Close();
        }
    }
}
