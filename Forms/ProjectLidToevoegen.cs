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
    public partial class ProjectLidToevoegen : Form
    {
        public ProjectLidToevoegen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void knopAanmaken_Click(object sender, EventArgs e)
        {
            //Projectlid toevoegen
            Projectlid nieuwlid = new Projectlid();
            string gebruikersnaam = veldGebruikersnaam.Text;
            string voornaam = veldVoornaam.Text;
            string achternaam = veldAchternaam.Text;
            string wachtwoord = veldWachtwoord.Text;
            int adminrechten = 0;

            if (buttonAdmin.Checked)
            {
                adminrechten = 1;
            }
            // Na verificatie projectlid toevoegen aan de database met de ingevulde gegevens
            if (verifieer() == true)
            {
                nieuwlid.ProjectlidToevoegen(gebruikersnaam, wachtwoord, voornaam, achternaam, adminrechten);
            }
            else
            {
                MessageBox.Show("Vul alsjeblieft alle velden in", "Ongeldige invoer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            }
            // Data verificatie
            bool verifieer()
            {
                if ((veldGebruikersnaam.Text.Trim() == "") ||
                        (veldVoornaam.Text.Trim() == "") ||
                        (veldAchternaam.Text.Trim() == "") ||
                        (veldWachtwoord.Text.Trim() == ""))
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }

        private void veldGebruikersnaam_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
