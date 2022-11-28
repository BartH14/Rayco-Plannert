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
    public partial class DashboardAdmin : Form
    {
        public DashboardAdmin()
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

        private void projectToevoegenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectToevoegen projecttoevoegen = new ProjectToevoegen();
            projecttoevoegen.Show(this);
        }

        private void projectledenToevoegenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectLidToevoegen projectledentoevoegen = new ProjectLidToevoegen();
            projectledentoevoegen.Show(this);
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

        private void takenToevoegenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaakToevoegen taakToevoegen = new TaakToevoegen();
            taakToevoegen.Show(this);
        }

        private void takenBeherenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaakBeheren taakBeheren = new TaakBeheren();
            taakBeheren.Show(this);
        }

        private void projectTemplateToevoegenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectTemplateToevoegen templateMaken = new ProjectTemplateToevoegen();
            templateMaken.Show(this);
        }

        private void DashboardAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
