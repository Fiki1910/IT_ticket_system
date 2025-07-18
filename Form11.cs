using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacja1
{
    public partial class Form11 : Form
    {
        public Form11()
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
        private void buttonLogon_Click(object sender, EventArgs e)
        {
            string login = textBoxUsername.Text;
            string passwordHash = HashPassword(textBoxPassword.Text);

            string connectionString = Properties.Settings.Default.System_Zgloszen_IT_C_ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))


            {
                string query = "SELECT COUNT(*), MAX(Super_ADM_Rights) FROM Administratorzy WHERE Login = @login AND Hasło = @passwordHash";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@login", login); // tworzy paramentr login dla zapytania, ustawia jego wartość
                // na zmienną login -> czyli to co usr w textbox wpisał oraz ochrona przed SQL INJection
                command.Parameters.AddWithValue("@passwordHash", passwordHash);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader(); // Wykonuje zapytanie SQL i zwraca tylko pierwszą kolumnę pierwszego wiersza

                if (reader.HasRows)
                {
                    reader.Read();
                    int userCount = reader.GetInt32(0); // Liczba znalezionych użytkowników
                    int superAdminRights;

                    if (reader.IsDBNull(1))
                    {
                        superAdminRights = 0;
                    }
                    else
                    {
                        superAdminRights = reader.GetInt32(1);
                    }
// problem, jak podamy użytkownika, który nie istnieje, to Super_ADM_Rights będzie NULL, musimy zastosować w/w kod, aby rozwiązać ten problem.
                    if (userCount > 0)
                    {
                        if (superAdminRights == 1)
                        {
                            MessageBox.Show("Zalogowano pomyślnie!");
                            Form9 form9 = new Form9();
                            form9.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Nie masz wystarczających uprawnień, aby przeprowadzić tę akcję.");
                            ResetForm();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nieprawidłowy login lub hasło.");
                        ResetForm();
                    }
                }
                else
                {
                    MessageBox.Show("Nieprawidłowy login lub hasło.");
                    ResetForm();
                }
            }
        }



        private void ResetForm()
        {
            textBoxUsername.Clear(); 
            textBoxPassword.Clear();
            
        }



        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
            this.Close();
        }
    }
}
