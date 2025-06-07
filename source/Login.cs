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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            // Prevent only allow letters in Firstname/Lastname inputs.
            txtFName.KeyPress += txtFName_KeyPress;
            txtLName.KeyPress += txtFName_KeyPress;
        }


        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allow numbers in Badge Number input.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {          
            // Cannot login unless all details entered.
            if (string.IsNullOrWhiteSpace(txtBadge.Text) ||
                string.IsNullOrWhiteSpace(txtFName.Text) ||
                string.IsNullOrWhiteSpace(txtLName.Text) ||
                cbRank.SelectedIndex == -1 ||
                cbAssignment.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter all relevant credentials before proceeding.", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Capitalize first letter, lowercase the rest in Firstname input.
            string FixFN = char.ToUpper(txtFName.Text.Trim()[0]) + txtFName.Text.Trim().Substring(1).ToLower();
            
            // Special Surname Option (allows users to capitalize anything).
            // Good for names like McDonald, etc.
            string FixLN;
            if (cbSpecialSurname.Checked)
            {
                FixLN = txtLName.Text.Trim();
            }
            else
            {
                string input = txtLName.Text.Trim();

                if (!string.IsNullOrEmpty(input))
                    FixLN = char.ToUpper(input[0]) + input.Substring(1).ToLower();
                else
                    FixLN = "";
            }
            
            // Session store values
            Session.Forename = FixFN;
            Session.Surname = FixLN;
            Session.depRank = cbRank.Text.Trim();
            Session.BadgeNumber = txtBadge.Text.Trim();
            Session.uAssignment = cbAssignment.Text.Trim();

            // Shows/hides new pages through the program.
            MenuForm menu = new MenuForm();
            menu.Show();
            this.Hide();
        }

        private void txtFName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Prevents non-letter characters in Firstname input.
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Prevents non-letter characters in Firstname input.
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
