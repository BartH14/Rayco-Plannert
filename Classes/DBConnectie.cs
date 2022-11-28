using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayCo_PMS_PC
{
    internal class DBConnectie
    {
        // Verbinding variabele
        SqlConnection verbinding = new SqlConnection("Server=(local); Database=PMS; Integrated Security=true");
        
        // Functie maken om de verbinding te krijgen
        public SqlConnection GetSqlConnection
        {
            get { return verbinding; }
        }

        // Functie maken om de verbinding te openen
        public void openVerbinding()
        {
            if (verbinding.State == System.Data.ConnectionState.Closed)
            {
                verbinding.Open();
            }
        }

        // Functie maken om de verbinding te sluiten
        public void sluitVerbinding()
        {
            if (verbinding.State == System.Data.ConnectionState.Open)
            {
                verbinding.Close();
            }
        }
    }
}
