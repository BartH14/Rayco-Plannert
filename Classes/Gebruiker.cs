using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayCo_PMS_PC.Classes
{
    // Gehele functie was een WIP'je om een admin bool te creëren, maar hij wou de variabelen niet over de forms heen dragen.
    internal class Gebruiker
    {
        string Gebruikersnaam;
        int Adminrechten { set; get; }

        public bool isAdmin()
        {
            DBConnectie verbinding = new DBConnectie();
            using (SqlCommand command = new SqlCommand($"SELECT Adminrechten FROM Projectleden WHERE Gebruikersnaam = {Gebruikersnaam}"))
            {
                if (Adminrechten >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }
    }
}
