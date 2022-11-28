using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RayCo_PMS_PC.Classes
{
    public class Taken
    {
        DBConnectie verbinding = new DBConnectie();


        public bool TaakToevoegen(string taaknaam, string gekoppeldegebruiker, string gekoppeldeproject, int status, decimal geboekteuren, decimal verwachteuren)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Taken(Taaknaam, Gebruiker, Project, Status, GeboekteUren, VerwachteUren) VALUES(@taaknaam, @gebruiker, @project, @status, @geboekteuren, @verwachteuren)", verbinding.GetSqlConnection);

            command.Parameters.AddWithValue("@taaknaam", taaknaam);
            command.Parameters.AddWithValue("@gebruiker", gekoppeldegebruiker);
            command.Parameters.AddWithValue("@project", gekoppeldeproject);
            command.Parameters.AddWithValue("@status", status);
            command.Parameters.AddWithValue("@geboekteuren", geboekteuren);
            command.Parameters.AddWithValue("@verwachteuren", verwachteuren);

            verbinding.openVerbinding();

            if (command.ExecuteNonQuery() == 1)
            {
                verbinding.sluitVerbinding();
                MessageBox.Show("Taak succesvol aangemaakt");
                return true;
            }
            else
            {
                verbinding.sluitVerbinding();
                return false;
            }
        }

         public void BoekUren(int uren, string gekkoppeldeproject)
        {
            SqlCommand command = new SqlCommand("UPDATE Deeltaken SET GeboekteUren = GeboekteUren + uren WHERE Project = gekoppeldeproject", verbinding.GetSqlConnection);
        }

        public DataTable MijnTaken()
        {
            verbinding.openVerbinding();

            SqlCommand command = new SqlCommand("SELECT * FROM Taken", verbinding.GetSqlConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable tabel = new DataTable();

            adapter.Fill(tabel);

            verbinding.sluitVerbinding();

            return tabel;
        }
    }
}
