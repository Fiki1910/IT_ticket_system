using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacja1
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSuperAdm_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                string login = textBoxUsername.Text;
                string password = textBoxPassword.Text;
                int superAdm;
                string hashedPassword = HashPassword(password);
                if (!int.TryParse(textBoxSuperAdm.Text, out superAdm))
                {
                    MessageBox.Show("Podaj poprawną wartość liczbową dla Super_ADM_Rights.");
                    return;
                }

                string connectionString = Properties.Settings.Default.System_Zgloszen_IT_C_ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        string query = @"
                INSERT INTO Administratorzy 
                    (Login, Hasło, Super_ADM_Rights)
                VALUES 
                    (@Login, @Haslo, @Super_ADM_Right)";

                        SqlCommand command = new SqlCommand(query, connection);

                        command.Parameters.AddWithValue("@Login", login);
                        command.Parameters.AddWithValue("@Haslo", hashedPassword);
                        command.Parameters.AddWithValue("@Super_ADM_Right", superAdm);
                        

                        // to ogólnie poniżej wykona zapytanie sql w/w

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Nowy administrator został dodany.");
                        }
                        else
                        {
                            MessageBox.Show("Błąd przy dodawaniu nowego administratora.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Błąd podczas dodawania danych: " + ex.Message);
                    }
                }
            }
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
            this.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            textBoxSuperAdm.Text = "";
        }
    }
}
