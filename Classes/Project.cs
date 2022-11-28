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
    internal class Project
    {
        DBConnectie verbinding = new DBConnectie();

        public bool ProjectToevoegen(string projectnaam)
        {
            int projectstatus = 0;
            SqlCommand command = new SqlCommand("INSERT INTO Projecten(Projectnaam, Projectstatus) VALUES(@projectnaam, @projectstatus)", verbinding.GetSqlConnection);

            command.Parameters.AddWithValue("@projectnaam", projectnaam);
            command.Parameters.AddWithValue("@projectstatus", projectstatus);

            verbinding.openVerbinding();

            if (command.ExecuteNonQuery() == 1)
            {
                verbinding.sluitVerbinding();
                MessageBox.Show("Project succesvol aangemaakt");
                return true;
            }
            else
            {
                verbinding.sluitVerbinding();
                return false;
            }
        }
        public DataTable AlleProjecten()
        {
            verbinding.openVerbinding();

            SqlCommand command = new SqlCommand("SELECT Projectnaam,ProjectID FROM Projecten", verbinding.GetSqlConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable tabel = new DataTable();

            adapter.Fill(tabel);

            verbinding.sluitVerbinding();

            return tabel;
        }
    }
}