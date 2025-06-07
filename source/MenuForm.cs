using RCSD_Computer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RCSD_Computer
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            string AccTitle = Session.depRank + ", " + Session.Forename + " " + Session.Surname + " (" + Session.BadgeNumber + ") - " + Session.uAssignment;


            lblAccount.Text = AccTitle;

        }

        private void btnArrest_Click(object sender, EventArgs e)
        {
            InciForm pg_Incident = new InciForm();
            pg_Incident.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://rcsd.redcountyrp.com/viewtopic.php?f=771&t=10846");
        }

        private void btnArrest_Click_1(object sender, EventArgs e)
        {

        }

        private void btnToArrestPage_Click(object sender, EventArgs e)
        {
            ArrestForm pg_arrest = new ArrestForm();
            pg_arrest.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSeizure_Click(object sender, EventArgs e)
        {
            EvidForm pg_Evidence = new EvidForm();
            pg_Evidence.Show();
            this.Close();
        }
    }
}
