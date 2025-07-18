using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
namespace Aplikacja1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string connectionString = Properties.Settings.Default.System_Zgloszen_IT_C_ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT DISTINCT Imie FROM Uzytkownicy";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader["Imie"].ToString());
                    }

                    reader.Close();
                

                string queryNazwiska = "SELECT DISTINCT Nazwisko FROM Uzytkownicy";
                SqlCommand commandNazwiska = new SqlCommand(queryNazwiska, connection);
                SqlDataReader readerNazwiska = commandNazwiska.ExecuteReader();
                while (readerNazwiska.Read())
                {
                    comboBox2.Items.Add(readerNazwiska["Nazwisko"].ToString());
                }
                readerNazwiska.Close();

                string queryNumery = "SELECT DISTINCT Numer_Komputera FROM Uzytkownicy";
                SqlCommand commandNumery = new SqlCommand(queryNumery, connection);
                SqlDataReader readerNumery = commandNumery.ExecuteReader();
                while (readerNumery.Read())
                {
                    comboBox3.Items.Add(readerNumery["Numer_Komputera"].ToString());
                }
                readerNumery.Close();
            }

                catch (Exception ex)
                {
                    MessageBox.Show("Błąd połączenia z bazą: " + ex.Message);
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = Properties.Settings.Default.System_Zgloszen_IT_C_ConnectionString;
            if (comboBox1.SelectedItem == null) return;
            string wybraneImie = comboBox1.SelectedItem.ToString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT TOP 1 Imie, Nazwisko, Adres, Numer_Komputera, Numer_Telefonu, Email FROM Uzytkownicy WHERE Imie = @Imie";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Imie", wybraneImie);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        textBoxImie.Text = reader["Imie"].ToString();
                        textBoxNazwisko.Text = reader["Nazwisko"].ToString();
                        textBoxAdres.Text = reader["Adres"].ToString();
                        textBoxNumer_Komputera.Text = reader["Numer_Komputera"].ToString();
                        textBoxNumer_Telefonu.Text = reader["Numer_Telefonu"].ToString();
                        textBoxEmail.Text = reader["Email"].ToString();
                    }
                    else
                    {
                        textBoxImie.Text = "";
                        textBoxNazwisko.Text = "";
                        textBoxAdres.Text = "";
                        textBoxNumer_Komputera.Text = "";
                        textBoxNumer_Telefonu.Text = "";
                        textBoxEmail.Text = "";
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd pobierania danych: " + ex.Message);
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = Properties.Settings.Default.System_Zgloszen_IT_C_ConnectionString;
            if (comboBox2.SelectedItem == null) return;
            string wybraneNazwisko = comboBox2.SelectedItem.ToString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT TOP 1 Imie, Nazwisko, Adres, Numer_Komputera, Numer_Telefonu, Email FROM Uzytkownicy WHERE Nazwisko = @Nazwisko";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Nazwisko", wybraneNazwisko);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        textBoxImie.Text = reader["Imie"].ToString();
                        textBoxNazwisko.Text = reader["Nazwisko"].ToString();
                        textBoxAdres.Text = reader["Adres"].ToString();
                        textBoxNumer_Komputera.Text = reader["Numer_Komputera"].ToString();
                        textBoxNumer_Telefonu.Text = reader["Numer_Telefonu"].ToString();
                        textBoxEmail.Text = reader["Email"].ToString();
                    }
                    else
                    {
                        textBoxImie.Text = "";
                        textBoxNazwisko.Text = "";
                        textBoxAdres.Text = "";
                        textBoxNumer_Komputera.Text = "";
                        textBoxNumer_Telefonu.Text = "";
                        textBoxEmail.Text = "";
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd pobierania danych: " + ex.Message);
                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = Properties.Settings.Default.System_Zgloszen_IT_C_ConnectionString;
            if (comboBox3.SelectedItem == null) return;
            string wybranyNumerKomputera = comboBox3.SelectedItem.ToString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT TOP 1 Imie, Nazwisko, Adres, Numer_Komputera, Numer_Telefonu, Email FROM Uzytkownicy WHERE Numer_Komputera = @wybranyNumerKomputera";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@wybranyNumerKomputera", wybranyNumerKomputera);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        textBoxImie.Text = reader["Imie"].ToString();
                        textBoxNazwisko.Text = reader["Nazwisko"].ToString();
                        textBoxAdres.Text = reader["Adres"].ToString();
                        textBoxNumer_Komputera.Text = reader["Numer_Komputera"].ToString();
                        textBoxNumer_Telefonu.Text = reader["Numer_Telefonu"].ToString();
                        textBoxEmail.Text = reader["Email"].ToString();
                    }
                    else
                    {
                        textBoxImie.Text = "";
                        textBoxNazwisko.Text = "";
                        textBoxAdres.Text = "";
                        textBoxNumer_Komputera.Text = "";
                        textBoxNumer_Telefonu.Text = "";
                        textBoxEmail.Text = "";
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
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;

            textBoxImie.Text = "";
            textBoxNazwisko.Text = "";
            textBoxAdres.Text = "";
            textBoxNumer_Komputera.Text = "";
            textBoxNumer_Telefonu.Text = "";
            textBoxEmail.Text = "";
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string imie = textBoxImie.Text;
            string nazwisko = textBoxNazwisko.Text;
            string adres = textBoxAdres.Text;
            string numerKomputera = textBoxNumer_Komputera.Text;
            string numerTelefonu = textBoxNumer_Telefonu.Text;
            string email = textBoxEmail.Text;

            string connectionString = Properties.Settings.Default.System_Zgloszen_IT_C_ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"
                UPDATE Uzytkownicy 
                SET 
                    Imie = @Imie,   
                    Nazwisko = @Nazwisko,
                    Adres = @Adres, 
                    Numer_Komputera = @NumerKomputera, 
                    Numer_Telefonu = @NumerTelefonu, 
                    Email = @Email 
                WHERE 
                    Imie = @Imie";

                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@Imie", imie);
                    command.Parameters.AddWithValue("@Nazwisko", nazwisko);
                    command.Parameters.AddWithValue("@Adres", adres);
                    command.Parameters.AddWithValue("@NumerKomputera", numerKomputera);
                    command.Parameters.AddWithValue("@NumerTelefonu", numerTelefonu);
                    command.Parameters.AddWithValue("@Email", email);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Dane zostały zaktualizowane.");
                    }
                    else
                    {
                        MessageBox.Show("Brak pasujących danych do aktualizacji.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas aktualizacji danych: " + ex.Message);
                }
            }
        }
        private void buttonInsert_Click (object sender, EventArgs e)
        {
            string imie = textBoxImie.Text;
            string nazwisko = textBoxNazwisko.Text;
            string adres = textBoxAdres.Text;
            string numerKomputera = textBoxNumer_Komputera.Text;
            string numerTelefonu = textBoxNumer_Telefonu.Text;
            string email = textBoxEmail.Text;

            string connectionString = Properties.Settings.Default.System_Zgloszen_IT_C_ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"
                INSERT INTO Uzytkownicy 
                    (Imie, Nazwisko, Adres, Numer_Komputera, Numer_Telefonu, Email)
                VALUES 
                    (@Imie, @Nazwisko, @Adres, @NumerKomputera, @NumerTelefonu, @Email)";

                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@Imie", imie);
                    command.Parameters.AddWithValue("@Nazwisko", nazwisko);
                    command.Parameters.AddWithValue("@Adres", adres);
                    command.Parameters.AddWithValue("@NumerKomputera", numerKomputera);
                    command.Parameters.AddWithValue("@NumerTelefonu", numerTelefonu);
                    command.Parameters.AddWithValue("@Email", email);

                    // to ogólnie poniżej wykona zapytanie sql w/w

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Nowy użytkownik został dodany.");
                    }
                    else
                    {
                        MessageBox.Show("Błąd przy dodawaniu nowego użytkownika.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas dodawania danych: " + ex.Message);
                }
            }
        }
    }
    }
    
