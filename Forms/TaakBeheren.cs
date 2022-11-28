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
    public partial class TaakBeheren : Form
    {
        public TaakBeheren()
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

        private void TaakBeheren_Load(object sender, EventArgs e)
        {
            // Combobox met projecten vullen
            Taken takendata = new Taken();
            comboTakenLijst.DataSource = takendata.MijnTaken();
            comboTakenLijst.DisplayMember = "Taaknaam";
            comboTakenLijst.ValueMember = "Project";
            comboTakenLijst.SelectedItem = null;

        }

        private void comboProjectenLijst_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboTakenLijst_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Hier wordt de waarde van de geboekte uren uit de database getrokken en als variabele gebruikt om het aantal uren weer te geven.
            string GekozenTaak = comboTakenLijst.Text;
            DBConnectie verbinding = new DBConnectie();

            SqlCommand command = new SqlCommand("SELECT GeboekteUren FROM Taken WHERE Taaknaam = @GekozenTaak", verbinding.GetSqlConnection);
            command.Parameters.AddWithValue("@GekozenTaak", GekozenTaak);
            verbinding.openVerbinding();
            string TotaleUren = Convert.ToString(command.ExecuteScalar());
            UrenDisplay.Text = TotaleUren;            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBConnectie verbinding = new DBConnectie();
            decimal TeBoeken = numericDeclaratie.Value;
            string GekozenTaak = comboTakenLijst.Text;

            decimal TotaleUren = Convert.ToDecimal(UrenDisplay.Text);
            TotaleUren += TeBoeken;
            UrenDisplay.Text = Convert.ToString(TotaleUren);

            // Update niet de waarde in de database
            SqlCommand command = new SqlCommand("UPDATE Taken SET GeboekteUren = @TotaleUren WHERE Project = @GekozenTaak", verbinding.GetSqlConnection);
            command.Parameters.AddWithValue("@TotaleUren", TotaleUren);
            command.Parameters.AddWithValue("@GekozenTaak", GekozenTaak);
            verbinding.openVerbinding();
            command.ExecuteNonQuery();

        }
    }
}
