using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RayCo_PMS_PC.Forms
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void knopMinimaliseer_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void KnopAfsluiten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void projectenBekijkenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nog niet geïmplementeerd");
        }

        private void projectledenBeherenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectLedenOverzicht projectledenoverzicht = new ProjectLedenOverzicht();
            projectledenoverzicht.Show(this);
        }

        private void takenBeherenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaakBeheren taakBeheren = new TaakBeheren();
            taakBeheren.Show(this);
        }
    }
}
