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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            string connectionString = Properties.Settings.Default.System_Zgloszen_IT_C_ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT ID_Zgloszenia FROM Zgloszenia";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        comboBoxTIcketID.Items.Add(reader["ID_Zgloszenia"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas ładowania ID: " + ex.Message);
                }
            }
        }

        private void comboBoxTIcketID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = Properties.Settings.Default.System_Zgloszen_IT_C_ConnectionString;
            if (comboBoxTIcketID.SelectedItem == null) return;
            string chosenID = comboBoxTIcketID.SelectedItem.ToString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                SELECT 
                    U.Imie + ' ' + U.Nazwisko AS Uzytkownik,
                    G.Nazwa_Grupy AS Przypisana_Grupa,
                    S.Nazwa AS Serwis,
                    Z.Pilnosc,
                    Z.Opis_Problemu,
                    Z.Rozwiazanie,
                    Z.Data_Zgloszenia
                FROM Zgloszenia Z
                JOIN Uzytkownicy U ON Z.Uzytkownik = U.ID_Uzytkownika
                JOIN Grupa_Wsparcia G ON Z.Przypisana_Grupa = G.ID_Grupy_Wsparcia
                JOIN Serwis S ON Z.Serwis = S.ID_Serwisu
                WHERE Z.ID_Zgloszenia = @ID";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID", chosenID);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        textBoxUser.Text = reader["Uzytkownik"].ToString();
                        textBoxAssignmentGroup.Text = reader["Przypisana_Grupa"].ToString();
                        textBoxService.Text = reader["Serwis"].ToString();
                        textBoxPriority.Text = reader["Pilnosc"].ToString();
                        textBoxDescription.Text = reader["Opis_Problemu"].ToString();
                        textBoxSolution.Text = reader["Rozwiazanie"].ToString();
                        textBoxReportedDate.Text = Convert.ToDateTime(reader["Data_Zgloszenia"]).ToString("yyyy-MM-dd");
                    }
                    else
                    {
                        textBoxUser.Text = "";
                        textBoxAssignmentGroup.Text = "";
                        textBoxService.Text = "";
                        textBoxPriority.Text = "";
                        textBoxDescription.Text = "";
                        textBoxSolution.Text = "";
                        textBoxReportedDate.Text = "";
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
            comboBoxTIcketID.SelectedIndex = -1;

            textBoxUser.Text = "";
            textBoxAssignmentGroup.Text = "";
            textBoxService.Text = "";
            textBoxPriority.Text = "";
            textBoxDescription.Text = "";
            textBoxSolution.Text = "";
            textBoxReportedDate.Text = "";
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }
    }
}
