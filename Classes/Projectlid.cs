using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RayCo_PMS_PC
{
    public class Projectlid
    {
        DBConnectie verbinding = new DBConnectie();

        // Functie maken om projectleden toe te voegen aan de database
        public bool ProjectlidToevoegen(string gebruikersnaam, string wachtwoord, string voornaam, string achternaam, int adminrechten)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Projectleden(Gebruikersnaam, Wachtwoord, Voornaam,Achternaam, Adminrechten) VALUES(@gebruikersnaam, @wachtwoord, @voornaam, @achternaam, @adminrechten)", verbinding.GetSqlConnection);

            // Variabelen toekennen
            command.Parameters.AddWithValue("@gebruikersnaam", gebruikersnaam);
            command.Parameters.AddWithValue("@wachtwoord", wachtwoord);
            command.Parameters.AddWithValue("@voornaam", voornaam);
            command.Parameters.AddWithValue("@achternaam", achternaam);
            command.Parameters.AddWithValue("@adminrechten", adminrechten);

            verbinding.openVerbinding();

            if (command.ExecuteNonQuery() == 1)
            {
                verbinding.sluitVerbinding();
                MessageBox.Show("Projectlid succesvol aangemaakt");
                return true;
            }
            else
            {
                verbinding.sluitVerbinding();
                return false;
            }
        }

        // Functie maken om de gebruikerstabel met informatie te vullen
        public DataTable verkrijgProjectleden(SqlCommand command)
        {
            command.Connection = verbinding.GetSqlConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable ledentabel = new DataTable();
            adapter.Fill(ledentabel);

            return ledentabel;
        }

        public DataTable AlleProjectLeden()
        {
            verbinding.openVerbinding();

            SqlCommand command = new SqlCommand("SELECT Voornaam,Achternaam, MemID FROM Projectleden", verbinding.GetSqlConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable tabel = new DataTable();

            adapter.Fill(tabel);
            Debug.WriteLine(tabel);

            verbinding.sluitVerbinding();

            return tabel;
        }
    }
}