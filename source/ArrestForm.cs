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
    public partial class ArrestForm : Form
    {
        // Placeholder Dictionary (for Textbox and Richtextbox)
        private Dictionary<TextBox, string> placeholders = new Dictionary<TextBox, string>();
        private Dictionary<RichTextBox, string> richPlaceholders = new Dictionary<RichTextBox, string>();

        public ArrestForm()
        {
            InitializeComponent();
            dgvCharges.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            //Placeholder Data: Textbox
            placeholders[txtArrestDate] = "MON/DD/YYYY";
            placeholders[txtArrestTime] = "HH:MM AM/PM";
            placeholders[txtArrestDOB] = "MON/DD/YYYY";
            placeholders[txtGANG] = "Gang Name";
            placeholders[txtAlias] = "Insert any nicknames here.";
            placeholders[txtArrestNarrative] = "[!] SENSITIVE REPORT TO BE USED IN STATE COURT"
                + Environment.NewLine + Environment.NewLine +
                "Mention all context leading up to the arrest, including address, subject name(s), vehicles, weapons, the crime itself, etc.";

            placeholders[txtSignatureLink] = "Imgur .png URL only";
            placeholders[txtSuppReports] = "[url]URL1[/url], [url]URL2[/url]" + Environment.NewLine + "Place links and seperate by commas.";

            //Placeholder Data: Richtextbox
            //richPlaceholders[txtNarrative] = "Include as many details. Who responded/was involved. If shots were fired, suspect details, special unit response (SWAT). Mention the full address, etc.";


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

        private void ArrestForm_Load(object sender, EventArgs e)
        {
            // Supp Report Enabler
            txtSuppReports.Enabled = false;
            btnSuppNO.Checked = true;

            // Label: Login User Details
            string AccTitle = Session.depRank + ", " + Session.Forename + " " + Session.Surname + " (" + Session.BadgeNumber + ") - " + Session.uAssignment;
            lblAccount.Text = AccTitle;

            // CHARGES LOOKER
            try
            {
                foreach (DataGridViewColumn col in dgvCharges.Columns)
                {
                    if (col.Name == "colCode")
                    {
                        col.Width = 90;
                    }
                    else if (col.Name == "colTitle")
                    {
                        col.Width = 250;
                    }
                    else if (col.Name == "colDelete")
                    {
                        col.Width = 30;
                        col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to set column widths:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            txtSearchCharge.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtSearchCharge.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSearchCharge.TextChanged += txtSearchCharge_TextChanged;

            dgvCharges.CellContentClick += dgvCharges_CellContentClick;
        }

        private void cbxGANG_CheckedChanged(object sender, EventArgs e)
        {
            // Disable gang textbox if checked.
            txtGANG.Enabled = !cbxGANG.Checked;
        }

        private void btnSuppYES_CheckedChanged(object sender, EventArgs e)
        {
            // Enable supplementary report textbox if clicked yes.
            txtSuppReports.Enabled = btnSuppYES.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuForm menu = new MenuForm();
            menu.Show();
            this.Hide();
        }

        private void txtSearchCharge_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchCharge.Text.ToLower();

            var matches = ChargeData.Charges
                .Where(c => c.Title.ToLower().Contains(searchText))
                .Select(c => c.Title)
                .ToArray();

            AutoCompleteStringCollection filtered = new AutoCompleteStringCollection();
            filtered.AddRange(matches);

            txtSearchCharge.AutoCompleteCustomSource = filtered;
        }

        private void btnADDCharge_Click(object sender, EventArgs e)
        {
            string input = txtSearchCharge.Text.Trim().ToLower();

            var charge = ChargeData.Charges
                .FirstOrDefault(c => c.Title.ToLower() == input);

            if (charge != null)
            {
                dgvCharges.Rows.Add(charge.Code, charge.Title, charge.Classification);
                txtSearchCharge.Clear();
            }
            else
            {
                MessageBox.Show("No matching charge found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvCharges_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCharges.Columns[e.ColumnIndex].Name == "colDelete" && e.RowIndex >= 0)
            {
                dgvCharges.Rows.RemoveAt(e.RowIndex);
            }
        }

             

        private void btnPENALCODE_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://forum.redcountyrp.com/threads/san-andreas-penal-code-2024.186906/");
        }

        private void btnPRINT_ARREST_Click(object sender, EventArgs e)
        {

            /** ---------- VALIDATION EVENT START ---------- **/
            // Validate Arrest Date
            if (string.IsNullOrWhiteSpace(txtArrestDate.Text) || !Regex.IsMatch(txtArrestDate.Text, @"^[A-Za-z]{3}/\d{2}/\d{4}$"))
            {
                MessageBox.Show("Missing or Invalid Arrest Date:\nMON/DD/YYYY", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Arrest Narrative
            if (string.IsNullOrWhiteSpace(txtArrestNarrative.Text))
            {
                MessageBox.Show("Missing:\nArrest Narrative", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Arrest Location
            if (string.IsNullOrWhiteSpace(txtArrestLoc.Text))
            {
                MessageBox.Show("Missing Location of Arrest", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Arrest Time
            if (string.IsNullOrWhiteSpace(txtArrestTime.Text) ||
                !Regex.IsMatch(txtArrestTime.Text, @"^\d{2}:\d{2}(\s?(AM|PM))?$", RegexOptions.IgnoreCase))
            {
                MessageBox.Show("Missing or Invalid Time of Arrest:\nHH:MM / HH:MM AM / HH:MM PM", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Signature Link (Must be PNG, must contain imgur.com
            if (string.IsNullOrWhiteSpace(txtSignatureLink.Text) || !txtSignatureLink.Text.Contains(".png") || !txtSignatureLink.Text.Contains("imgur.com"))
            {
                MessageBox.Show("Missing or Invalid Signature:\nMust include imgur.com and .png", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Gender Selection
            if (!btnMALE.Checked && !btnFEMALE.Checked)
            {
                MessageBox.Show("Missing:\nGender", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Suspect Name
            if (string.IsNullOrWhiteSpace(txtArrestFN.Text) || string.IsNullOrWhiteSpace(txtArrestLN.Text))
            {
                MessageBox.Show("Missing or Incomplete:\nSuspect Name", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Suspect DOB
            if (string.IsNullOrWhiteSpace(txtArrestDOB.Text) || !Regex.IsMatch(txtArrestDOB.Text, @"^[A-Za-z]{3}/\d{2}/\d{4}$"))
            {
                MessageBox.Show("Missing or Invalid Suspect DOB:\nMON/DD/YYYY", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Supplementary Report Option (Yes/No selected)
            if (!btnSuppYES.Checked && !btnSuppNO.Checked)
            {
                MessageBox.Show("Missing:\nSupplementary Report Option (Select Yes or No)", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // If YES selected, check Supplementary Report content
            if (btnSuppYES.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtSuppReports.Text) ||
                    !txtSuppReports.Text.Contains("[url") ||
                    !txtSuppReports.Text.Contains("[/url]"))
                {
                    MessageBox.Show("Missing or Invalid Supplementary Report:\nMust contain at least one [url and [/url]", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Validate Gang Affiliation
            if (!cbxGANG.Checked && string.IsNullOrWhiteSpace(txtGANG.Text))
            {
                MessageBox.Show("Error:\nGang Affiliation not determined.\nSelect \"NO GANG AFFILIATION\" or enter the gang name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!cbxGANG.Checked && txtGANG.Text.Trim() == "")
            {
                MessageBox.Show("Missing:\nGang Affiliation", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Validate Race ComboBox
            if (cbRace.SelectedIndex == -1)
            {
                MessageBox.Show("Missing:\nSuspect Race", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Signature Link
            if (string.IsNullOrWhiteSpace(txtSignatureLink.Text) || !txtSignatureLink.Text.Contains(".png"))
            {
                MessageBox.Show("Missing or Invalid Signature:\nURL link must include .png!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Charges DataGridView
            if (dgvCharges.Rows.Count == 0 || dgvCharges.Rows.Cast<DataGridViewRow>().All(r => r.IsNewRow))
            {
                MessageBox.Show("Missing:\nCharges", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Supplementary Report Option (Yes/No)
            if (!btnSuppYES.Checked && !btnSuppNO.Checked)
            {
                MessageBox.Show("Missing:\nSupplementary Report Option (Select Yes or No)", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // If YES selected, check Supplementary Report textbox.
            if (btnSuppYES.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtSuppReports.Text) ||
                    !txtSuppReports.Text.Contains("[url") ||
                    !txtSuppReports.Text.Contains("[/url]"))
                {
                    MessageBox.Show("Missing or Invalid Supplementary Report:\nMust contain at least one [url and [/url]", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            /** ---------- VALIDATION EVENT END ---------- **/

            string OUTPUT_8 = "Misdemeanor";
            //CLASSIFICATION CHECKER
            foreach (DataGridViewRow row in dgvCharges.Rows)
            {
                if (row.IsNewRow) continue; // skip empty new row if any

                string code = row.Cells["colCode"].Value.ToString().Trim();
                string title = row.Cells["colTitle"].Value.ToString().Trim();

                var charge = ChargeData.Charges.FirstOrDefault(c =>
                    c.Code == code && c.Title == title);

                if (charge != null && charge.Classification.ToUpper() == "F")
                {
                    OUTPUT_8 = "Felony";
                    break; // no need to continue checking
                }
            }

                string FixSFN = char.ToUpper(txtArrestFN.Text.Trim()[0]) + txtArrestFN.Text.Trim().Substring(1).ToLower();
                string FixSLN = char.ToUpper(txtArrestLN.Text.Trim()[0]) + txtArrestLN.Text.Trim().Substring(1).ToLower();
                string arGender = "NOT SELECTED!";

                // Gender shit
                if (btnMALE.Checked)
                    arGender = "Male";
                else if (btnFEMALE.Checked)
                    arGender = "Female";

                // Gang Affiliation
                string gStats = cbxGANG.Checked ? "None" : txtGANG.Text.Trim();

                //Charges Formatting
                List<string> fCharges = new List<string>();

                foreach (DataGridViewRow crow in dgvCharges.Rows)
                {
                    if (crow.IsNewRow) continue;

                    string fCode = crow.Cells["colCode"].Value.ToString().Trim();
                    string fTitle = crow.Cells["colTitle"].Value.ToString().Trim();

                    fCharges.Add($"- {fCode} {fTitle}");
                }

                string formattedCharges = string.Join("\n", fCharges);


                //Supplementary Reports
                string sReports = "";
                if (txtSuppReports.Enabled && !string.IsNullOrWhiteSpace(txtSuppReports.Text))
                {
                    string[] links = txtSuppReports.Text.Split(',');

                    List<string> sLines = new List<string>();
                    foreach (string link in links)
                    {
                        string trimmed = link.Trim();
                        if (!string.IsNullOrWhiteSpace(trimmed))
                            sLines.Add($"- {trimmed}");
                    }

                    sReports = string.Join("\n", sLines);
                }
            else
            {
                // Count how many lines are in formattedCharges
                int chargeCount = formattedCharges
                    .Split(new[] { "\r\n", "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries)
                    .Length;

                // Repeat placeholder line for each charge
                sReports = string.Join("\n", Enumerable.Repeat("[color=white]_________________[/color]", chargeCount));
            }

            /** --- REMOVE PLACEHOLDER TEXT BEFORE OUTPUT --- **/
            string narrativePlaceholder = "[!] SENSITIVE REPORT TO BE USED IN STATE COURT"
                + Environment.NewLine + Environment.NewLine +
                "Mention all context leading up to the arrest, including address, subject name(s), vehicles, weapons, the crime itself, etc.";

            if (txtArrestNarrative.Text.Trim() == narrativePlaceholder.Trim())
                txtArrestNarrative.Text = "";

            if (txtAlias.Text.Trim() == "Insert any nicknames here.")
                txtAlias.Text = "";
            
            // Prevent stupid narrative warning from not triggering
            if (string.IsNullOrWhiteSpace(txtArrestNarrative.Text))
            {
                MessageBox.Show("Missing:\nArrest Narrative", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            /** --------------------------------------------- **/



            string a_depFullName = Session.Forename + " " + Session.Surname;
                string a_Sig = txtSignatureLink.Text;
                string a_Signature = $"[img]{a_Sig}[/img]";

            string aliasOutput = string.IsNullOrWhiteSpace(txtAlias.Text)
                ? "[color=white]__[/color]"
                : txtAlias.Text;


            string filled = Templates.ArrestTemplate
                    .Replace("{OUTPUT_1}", txtArrestDate.Text.ToUpper())
                    .Replace("{OUTPUT_2}", FixSFN)
                    .Replace("{OUTPUT_3}", FixSLN)
                    .Replace("{OUTPUT_4}", arGender)
                    .Replace("{OUTPUT_5}", txtArrestDOB.Text.ToUpper())
                    .Replace("{OUTPUT_6}", cbRace.Text)
                    .Replace("{OUTPUT_7}", aliasOutput)
                    .Replace("{OUTPUT_8}", OUTPUT_8)
                    .Replace("{OUTPUT_9}", gStats)
                    .Replace("{OUTPUT_10}", formattedCharges)
                    .Replace("{OUTPUT_11}", sReports)
                    .Replace("{OUTPUT_12}", txtArrestLoc.Text)
                    .Replace("{OUTPUT_13}", txtArrestTime.Text)
                    .Replace("{OUTPUT_14}", txtArrestNarrative.Text)
                    .Replace("{OUTPUT_15}", a_depFullName)
                    .Replace("{OUTPUT_16}", Session.depRank)
                    .Replace("{OUTPUT_17}", Session.BadgeNumber)
                    .Replace("{OUTPUT_18}", Session.uAssignment)
                    .Replace("{OUTPUT_19}", a_Signature);

                // Copy to Clipboard after print.
                Clipboard.SetText(filled);
                MessageBox.Show("BB code has been copied to your clipboard!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        private void txtArrestNarrative_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
