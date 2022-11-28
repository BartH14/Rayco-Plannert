using RayCo_PMS_PC.Classes;
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
    public partial class TaakToevoegen : Form
    {
        Project project = new Project();
        public TaakToevoegen()
        {
            InitializeComponent();
        }

        private void knopAnnuleer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void knopAanmaken_Click(object sender, EventArgs e)
        {
            Taken taak = new Taken();
            string taaknaam = veldTaakNaam.Text;
            string gekoppeldeproject = comboProject.Text;
            string gekoppeldegebruiker = comboGebruiker.Text;
            int status = 0;
            decimal geboekteuren = 0;
            decimal verwachteuren = tijdIndicator.Value;

            //Als de invoer geldig is wordt de data in de database gestopt
            if (verifieer() == true)
            {
                taak.TaakToevoegen(taaknaam, gekoppeldegebruiker, gekoppeldeproject, status, geboekteuren, verwachteuren);
                this.Close();
            }
            else
            {
                MessageBox.Show("Vul alsjeblieft alle velden in", "Ongeldige invoer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Kijkt of alle invoer geldig is
            bool verifieer()
            {
                if ((veldTaakNaam.Text.Trim() == "") ||
                        (comboGebruiker.Text.Trim() == "") ||
                        (comboProject.Text.Trim() == "") ||
                        (tijdIndicator.Text.Trim() == ""))
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
        }

        private void comboProject_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void TaakToevoegen_Load(object sender, EventArgs e)
        {
            // Combobox met projecten vullen
            Project projectdata = new Project();
            comboProject.DataSource = projectdata.AlleProjecten();
            comboProject.DisplayMember = "Projectnaam";
            comboProject.ValueMember = "ProjectID";
            comboProject.SelectedItem = null;

            // Combobox met projectleden vullen
            Projectlid ledendata = new Projectlid();
            comboGebruiker.DataSource = ledendata.AlleProjectLeden();
            comboGebruiker.DisplayMember = "Achternaam";
            comboGebruiker.ValueMember = "MemID";
            comboGebruiker.SelectedItem = null;
        }
    }
}
