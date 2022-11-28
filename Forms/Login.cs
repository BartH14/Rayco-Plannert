using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml;
using System.Security.Cryptography.X509Certificates;

namespace RayCo_PMS_PC
{
    public partial class Login : Form
    {
        public string gebruikersnaam { get; set; }

        public Login()
        {
            InitializeComponent();
                        
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void veldGebruikersnaam_TextChanged(object sender, EventArgs e)
        {

        }

        public void knopLogin_Click(object sender, EventArgs e)
        {
            DBConnectie Gebruikers = new DBConnectie();
            SqlDataAdapter datastekker = new SqlDataAdapter("SELECT COUNT(*) FROM Projectleden WHERE Gebruikersnaam = '" + veldGebruikersnaam.Text + "' AND Wachtwoord = '" + veldWachtwoord.Text + "'", Gebruikers.GetSqlConnection);
            DataTable infotafel = new DataTable();
            datastekker.Fill(infotafel);
            if (infotafel.Rows[0][0].ToString() == "1")
            {
                gebruikersnaam = veldGebruikersnaam.Text;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Ongeldige invoer","Login Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
