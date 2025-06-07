using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RCSD_Computer
{
    public partial class InciForm : Form
    {
        // Resets placeholders after PRINT is clicked.
        private void ResetPlaceholdersIfEmpty()
        {
            foreach (var pair in placeholders)
            {
                if (string.IsNullOrWhiteSpace(pair.Key.Text))
                {
                    pair.Key.Text = pair.Value;
                    pair.Key.ForeColor = Color.Maroon;
                }
            }
        }

        // Same as above for rtb (narrative)
        private void ResetRichPlaceholdersIfEmpty()
        {
            foreach (var pair in richPlaceholders)
            {
                if (string.IsNullOrWhiteSpace(pair.Key.Text))
                {
                    pair.Key.Text = pair.Value;
                    pair.Key.ForeColor = Color.Maroon;
                }
            }
        }


        // Placeholder Dictionary (for Textbox and Richtextbox)
        private Dictionary<TextBox, string> placeholders = new Dictionary<TextBox, string>();
        private Dictionary<RichTextBox, string> richPlaceholders = new Dictionary<RichTextBox, string>();


        public InciForm()
        {
            InitializeComponent();

            //Placeholder Data: Textbox
            placeholders[txtCaseNumber] = "YYMMDD-00X";
            placeholders[txtDate] = "MON/DD/YYYY";
            placeholders[txtInciTime] = "HH:MM AM/PM";
            placeholders[txtGang] = "No / Gang Name";
            placeholders[txtCOName] = "Firstname Lastname";
            placeholders[txtCallsign] = "e.g. 1-ALPHA, Car 1, 1A";
            placeholders[txtSignature] = "Imgur .png URLs only";

            //Placeholder Data: Richtextbox
            richPlaceholders[txtNarrative] = "Include as many details. Who responded/was involved. If shots were fired, suspect details, special unit response (SWAT). Mention the full address, etc.";


            foreach (var pair in placeholders)
            {
                pair.Key.Text = pair.Value;
                pair.Key.ForeColor = Color.Maroon;

                // Attach Textbox Placeholder Events
                pair.Key.Enter += Placeholder_Enter;
                pair.Key.Leave += Placeholder_Leave;
            }

            foreach (var pair in richPlaceholders)
            {
                pair.Key.Text = pair.Value;
                pair.Key.ForeColor = Color.Maroon;

                // Attach Richtextbox Placeholder Events
                pair.Key.Enter += RichPlaceholder_Enter;
                pair.Key.Leave += RichPlaceholder_Leave;
            }
                
        }

        /** --- PLACEHOLDER EVENTS --- **/
        private void RichPlaceholder_Enter(object sender, EventArgs e)
        {
            RichTextBox rtb = sender as RichTextBox;
            if (rtb != null && richPlaceholders.ContainsKey(rtb) && rtb.Text == richPlaceholders[rtb])
            {
                rtb.Text = "";
                rtb.ForeColor = SystemColors.WindowText;
            }
        }

        private void RichPlaceholder_Leave(object sender, EventArgs e)
        {
            RichTextBox rtb = sender as RichTextBox;
            if (rtb != null && richPlaceholders.ContainsKey(rtb) && string.IsNullOrWhiteSpace(rtb.Text))
            {
                rtb.Text = richPlaceholders[rtb];
                rtb.ForeColor = Color.Maroon;
            }
        }

        private void Placeholder_Enter(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb != null && placeholders.ContainsKey(tb) && tb.Text == placeholders[tb])
            {
                tb.Text = "";
                tb.ForeColor = SystemColors.WindowText;
            }
        }

        private void Placeholder_Leave(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb != null && placeholders.ContainsKey(tb) && string.IsNullOrWhiteSpace(tb.Text))
            {
                tb.Text = placeholders[tb];
                tb.ForeColor = Color.Maroon;
            }
        }
        /** --- PLACEHOLDER EVENTS END --- **/

        private void ArrestRep_Load(object sender, EventArgs e)
        {
            // Login Details Label
            string AccTitle = Session.depRank + ", " + Session.Forename + " " + Session.Surname + " (" + Session.BadgeNumber + ") - " + Session.uAssignment;
            lblAccount.Text = AccTitle;

            // Sets Agency list to "None" by default.
            cbAgency.SelectedIndex = 0;
        }

        private void btnBACK_AR_Click(object sender, EventArgs e)
        {
            // Back button.
            MenuForm menu = new MenuForm();
            menu.Show();
            this.Hide();
        }

        private void btnPRINT_AR_Click(object sender, EventArgs e)
        {

            /** ------ VALIDATION START ------ **/


            // PLACEHOLDER VALIDATION FIXER
            if (txtGang.Text.Trim() == "No / Gang Name")
                txtGang.Text = "";

            if (txtCOName.Text.Trim() == "Firstname Lastname")
                txtCOName.Text = "";

            if (txtCallsign.Text.Trim() == "e.g. 1-ALPHA, Car 1, 1A")
                txtCallsign.Text = "";

            if (txtNarrative.Text.Trim() == richPlaceholders[txtNarrative].Trim())
                txtNarrative.Text = "";

            // Validate Case Number
            if (string.IsNullOrWhiteSpace(txtCaseNumber.Text) || !Regex.IsMatch(txtCaseNumber.Text, @"^\d{6}-\d{3}$"))
            {
                MessageBox.Show("Missing or Invalid Incident Number:\nFormat is \"YYMMDD-0XX\"", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetPlaceholdersIfEmpty();
                return;
            }

            // Validate Date
            if (string.IsNullOrWhiteSpace(txtDate.Text) || !Regex.IsMatch(txtDate.Text, @"^[A-Za-z]{3}/\d{2}/\d{4}$"))
            {
                MessageBox.Show("Missing or Invalid Date:\nFormat is \"MON/DD/YYYY\"", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetPlaceholdersIfEmpty();
                return;
            }

            // Validate Incident Type
            if (cbInciType.SelectedIndex == -1)
            {
                MessageBox.Show("Missing:\nIncident Type", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetPlaceholdersIfEmpty();
                return;
            }

            // Validate Initiation
            if (cbInciInit.SelectedIndex == -1)
            {
                MessageBox.Show("Missing:\nInitiation", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetPlaceholdersIfEmpty();
                return;
            }

            // Validate Incident Commander Rank
            if (cbCORank.SelectedIndex == -1)
            {
                MessageBox.Show("Missing:\nIncident Commander Rank", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetPlaceholdersIfEmpty();
                return;
            }

            // Validate Time
            if (string.IsNullOrWhiteSpace(txtInciTime.Text) ||
                !Regex.IsMatch(txtInciTime.Text, @"^\d{2}:\d{2}(\s?(AM|PM))?$", RegexOptions.IgnoreCase))
            {
                MessageBox.Show("Missing or Invalid Time of Incident:\nFormat is HH:MM AM/PM", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetPlaceholdersIfEmpty();
                return;
            }

            // Validate Location
            if (string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show("Missing:\nLocation of Incident", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetPlaceholdersIfEmpty();
                return;
            }

            // Validate Gang Related
            if (string.IsNullOrWhiteSpace(txtGang.Text))
            {
                MessageBox.Show("Missing:\nGang Related", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetPlaceholdersIfEmpty();
                return;
            }

            // Validate Commander Name
            if (string.IsNullOrWhiteSpace(txtCOName.Text))
            {
                MessageBox.Show("Missing:\nIncident Commander Name", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetPlaceholdersIfEmpty();
                return;
            }

            // Validate Deputy Callsign
            if (string.IsNullOrWhiteSpace(txtCallsign.Text))
            {
                MessageBox.Show("Missing:\nDeputy Callsign", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetPlaceholdersIfEmpty();
                return;
            }

            // Validate Signature Link
            if (string.IsNullOrWhiteSpace(txtSignature.Text) ||
                !txtSignature.Text.Contains("imgur.com") ||
                !txtSignature.Text.Contains(".png"))
            {
                MessageBox.Show("Missing Signature:\nMust include \"imgur.com\" and \".png\"", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetPlaceholdersIfEmpty();
                return;
            }

            // Validate Incident Narrative
            if (string.IsNullOrWhiteSpace(txtNarrative.Text))
            {
                MessageBox.Show("Missing:\nIncident Narrative", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetRichPlaceholdersIfEmpty();
                return;
            }

            /** ------ VALIDATION END ------ **/



            /** ---- BB CODE OUTPUT TO CLIPBOARD --- **/

            // Login Details, Incident Commander formatting.
            string InCOMMANDER = cbCORank.Text + ", " + txtCOName.Text;
            string depFullName = Session.Forename + " " + Session.Surname;
            string u_Callsign = txtCallsign.Text.ToUpper();

            // BB code injection.
            string filled = Templates.IncidentTemplate
                .Replace("{OUTPUT_1}", txtCaseNumber.Text)
                .Replace("{OUTPUT_2}", txtDate.Text.ToUpper())
                .Replace("{OUTPUT_3}", cbInciType.Text)
                .Replace("{OUTPUT_4}", cbInciInit.Text)
                .Replace("{OUTPUT_5}", txtInciTime.Text)
                .Replace("{OUTPUT_6}", txtLocation.Text)
                .Replace("{OUTPUT_7}", txtGang.Text)
                .Replace("{OUTPUT_8}", InCOMMANDER)
                .Replace("{OUTPUT_9}", depFullName)
                .Replace("{OUTPUT_10}", Session.depRank)
                .Replace("{OUTPUT_11}", Session.uAssignment)
                .Replace("{OUTPUT_12}", u_Callsign)
                .Replace("{OUTPUT_13}", cbAgency.Text)
                .Replace("{OUTPUT_14}", txtNarrative.Text)
                .Replace("{OUTPUT_15}", depFullName)
                .Replace("{OUTPUT_16}", Session.BadgeNumber)
                .Replace("{OUTPUT_17}", txtDate.Text)
                .Replace("{OUTPUT_18}", txtSignature.Text);

            // Copy to Clipboard
            Clipboard.SetText(filled);
            MessageBox.Show("BB code has been copied to your clipboard!");

        }
    }
}
