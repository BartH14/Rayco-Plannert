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
    public partial class ProjectenBeheren : Form
    {
        public ProjectenBeheren()
        {
            InitializeComponent();
        }

        private void comboProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gekozenproject = comboProject.Text;
        }

        private void ProjectenBeheren_Load(object sender, EventArgs e)
        {
            Project projectdata = new Project();
            comboProject.DataSource = projectdata.AlleProjecten();
            comboProject.DisplayMember = "Projectnaam";
            comboProject.ValueMember = "ProjectID";
            comboProject.SelectedItem = null;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void knopVerwijderen_Click(object sender, EventArgs e)
        {
            DBConnectie verbinding = new DBConnectie;

            SqlCommand command = new SqlCommand();
            command =  ("e", verbinding.GetSqlConnection); 
        }
    }
}
