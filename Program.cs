using RayCo_PMS_PC.Classes;
using RayCo_PMS_PC.Forms;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RayCo_PMS_PC
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login Startscherm = new Login();

            if (Startscherm.ShowDialog() == DialogResult.OK)
            {
                DBConnectie verbinding = new DBConnectie();
                SqlCommand command = new SqlCommand("SELECT Adminrechten FROM Projectleden WHERE Gebruikersnaam = @gebruikersnaam", verbinding.GetSqlConnection);
                string gebruikersnaam = Startscherm.gebruikersnaam;
                command.Parameters.AddWithValue("@gebruikersnaam", gebruikersnaam);
                verbinding.openVerbinding();
                int AdminCheck = Convert.ToInt32(command.ExecuteScalar());
                
                if (AdminCheck > 0)
                {
                    Application.Run(new DashboardAdmin());
                }
                else
                {
                    Application.Run(new Dashboard());
                    MessageBox.Show("Gebruikersdash");
                }
            }
            else
            {
                Application.Exit();
            }

        }

    }
}
