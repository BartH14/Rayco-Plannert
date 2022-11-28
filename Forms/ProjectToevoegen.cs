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
    public partial class ProjectToevoegen : Form
    {
        public ProjectToevoegen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void knopAanmaken_Click(object sender, EventArgs e)
        {
            Project nieuwproject = new Project();
            string projectnaam = veldProjectnaam.Text;

            if (verifieer() == true)
            {
                nieuwproject.ProjectToevoegen(projectnaam);
            }
            else
            {
                MessageBox.Show("Vul alsjeblieft alle velden in", "Ongeldige invoer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            bool verifieer()
            {
                if (string.IsNullOrEmpty(projectnaam))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        private void knopAnnuleer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
