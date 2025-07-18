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
    public partial class Form1 : Form
    {

        private DateTime startTime;
        private void Form1_Load(object sender, EventArgs e)
        {
            startTime = DateTime.Now;
            timer1.Start();
            if(usernameTextBox.Text != "" && passwordTextBox.Text != "")
            {
                usernameTextBox.Text = "";
                passwordTextBox.Text = "";
            }
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

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void logonButton_Click(object sender, EventArgs e)
        {

            string login = usernameTextBox.Text;
            string passwordHash = HashPassword(passwordTextBox.Text);

            string connectionString = Properties.Settings.Default.System_Zgloszen_IT_C_ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))


            {
                string query = "SELECT COUNT(*) FROM Administratorzy WHERE Login = @login AND Hasło = @passwordHash";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@login", login); // tworzy paramentr login dla zapytania, ustawia jego wartość
                // na zmienną login -> czyli to co usr w textbox wpisał oraz ochrona przed SQL INJection
                command.Parameters.AddWithValue("@passwordHash", passwordHash);

                connection.Open();
                int userCount = (int)command.ExecuteScalar(); // Wykonuje zapytanie SQL i zwraca tylko pierwszą kolumnę pierwszego wiersza

                if (userCount > 0)
                {
                    MessageBox.Show("Zalogowano pomyślnie!");
                    Form2 form2 = new Form2();
                    form2.Show();
                }
                else
                {
                    MessageBox.Show("Nieprawidłowy login lub hasło.");
                }
            }
        }

            //if (usernameTextBox.Text == "admin" && passwordTextBox.Text == "admin")
            //{
            //    Form2 form2 = new Form2();
            //    form2.Show();
            //    usernameTextBox.Text = "";
            //    passwordTextBox.Text = "";
            //}
            //else
            //{
            //    MessageBox.Show("Wprowadzono niepoprawny login lub hasło.");
            //}
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan uptime = DateTime.Now - startTime;
            label1.Text = uptime.ToString(@"hh\:mm\:ss");
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void oAplikacjiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
        }
    }
}
