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

namespace RayCo_PMS_PC.Forms
{
    public partial class ProjectLedenOverzicht : Form
    {
        public ProjectLedenOverzicht()
        {
            InitializeComponent();
        }

        private void KnopAfsluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void knopMinimaliseer_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        Projectlid projectlid = new Projectlid();

        private void ProjectLedenOverzicht_Load(object sender, EventArgs e)
        {
            // Datagrid vullen met informatie van de projectleden
            SqlCommand command = new SqlCommand("SELECT Gebruikersnaam, Voornaam, Achternaam FROM Projectleden");
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.DataSource = projectlid.verkrijgProjectleden(command);
            dataGridView1.AllowUserToAddRows = false;
            }
    }
}
