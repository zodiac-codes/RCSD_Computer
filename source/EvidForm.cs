using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace RCSD_Computer
{
    public partial class EvidForm : Form
    {
        // Placeholders Reset
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

        private void ResetPlaceholdersIfEmpty()
        {
            foreach (var pair in placeholders)
            {
                // FIX: Check both empty and disabled (because disabled skips validation)
                if (string.IsNullOrWhiteSpace(pair.Key.Text))
                {
                    pair.Key.Text = pair.Value;
                    pair.Key.ForeColor = Color.Maroon;
                }
            }
        }

        private void ResetAllPlaceholdersIfEmpty()
        {
            ResetPlaceholdersIfEmpty();
            ResetRichPlaceholdersIfEmpty();
        }


        // DLL for number lining and shit (left of Evidence Inventory)
        [DllImport("user32.dll")]
        private static extern int GetScrollPos(IntPtr hWnd, int nBar);
        private const int SB_VERT = 1;

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        private const int WM_VSCROLL = 0x115;
        private const int SB_THUMBPOSITION = 4;

        // Placeholder Dictionary (for Textbox and Richtextbox)
        private Dictionary<TextBox, string> placeholders = new Dictionary<TextBox, string>();
        private Dictionary<RichTextBox, string> richPlaceholders = new Dictionary<RichTextBox, string>();



        private void UpdateLineNumbers()
        {
            // Numbering label left of Evidence Inventory.
            int totalLines = txtEvidenceInput.Lines.Length;
            rtbLineNumbers.Text = "";

            for (int i = 1; i <= totalLines; i++)
            {
                rtbLineNumbers.AppendText(i.ToString() + " -" + Environment.NewLine);
            }

            // Get scroll position of the main textbox (scrolling).
            int scrollPos = GetScrollPos(txtEvidenceInput.Handle, SB_VERT);
            SendMessage(rtbLineNumbers.Handle, WM_VSCROLL, (scrollPos << 16) | SB_THUMBPOSITION, 0);
        }

        private void txtEvidenceInput_VScroll(object sender, EventArgs e)
        {
            UpdateLineNumbers(); // Sync the line numbers when scrolling.
        }

        public EvidForm()
        {
            InitializeComponent();

            // Render line numbers.
            txtEvidenceInput.TextChanged += (s, e) => UpdateLineNumbers();
            txtEvidenceInput.VScroll += (s, e) => UpdateLineNumbers();
            UpdateLineNumbers(); 

            // One click checking for the checkboxes.
            cblClass.MouseUp += cblClass_MouseUp;

            //Placeholder Data: Textbox
            placeholders[txtEvidDate] = "MON/DD/YYYY";
            placeholders[txtCircumstance] = "Events leading up to seizure, include probable cause/suspicions, where the items were found (vehicle, person, etc).";
            placeholders[txtSignatureLink] = "Imgur .png URL only";
            placeholders[txtSuppReports] = "[url]URL1[/url], [url]URL2[/url]" + Environment.NewLine + "Place links and seperate by commas.";

            //Placeholder Data: Richtextbox
            richPlaceholders[txtEvidenceInput] = "Item 1, Quantity.\n Item 2, Quantity. \n Item 3: Description/Details";


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

        private void button1_Click(object sender, EventArgs e)
        {
            // Back button.
            MenuForm menu = new MenuForm();
            menu.Show();
            this.Hide();
        }

        private void cblClass_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // If Others Checkbox clicked, enable Others textbox.
            string item = cblClass.Items[e.Index].ToString();

            if (item == "Others")
            {
                txtOthers.Enabled = (e.NewValue == CheckState.Checked);
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

        private void EvidForm_Load(object sender, EventArgs e)
        {
            // Label: Login User Details
            string AccTitle = Session.depRank + ", " + Session.Forename + " " + Session.Surname + " (" + Session.BadgeNumber + ") - " + Session.uAssignment;
            lblAccount.Text = AccTitle;

            // Disable Others Textbox unless Others Checkbox is selected.
            txtOthers.Enabled = false;
            cblClass.ItemCheck += cblClass_ItemCheck;
            
            // Supplementary Report Enabler
            txtSuppReports.Enabled = false;
            btnSuppNO.Checked = true;
        }

        private void btnSuppYES_CheckedChanged(object sender, EventArgs e)
        {
            // If radio button yes selected, user may use supplementary report textbox.
            txtSuppReports.Enabled = btnSuppYES.Checked;
        }

        private void cblClass_MouseUp(object sender, MouseEventArgs e)
        {
            // Select checkboxes using mouse with one click (on text instead of box / QoL).
            int index = cblClass.IndexFromPoint(e.Location);
            if (index >= 0)
            {
                // Prevents default select behavior from interrupting.
                bool isChecked = cblClass.GetItemChecked(index);
                cblClass.SetItemChecked(index, !isChecked);
            }
        }

        private void btnPRINT_SEIZURE_Click(object sender, EventArgs e)
        {
            foreach (var pair in placeholders)
            {
                if (pair.Key.Text.Trim() == pair.Value.Trim())
                    pair.Key.Text = "";
            }

            foreach (var pair in richPlaceholders)
            {
                if (pair.Key.Text.Trim() == pair.Value.Trim())
                    pair.Key.Text = "";
            }

            /** ---- VALIDATION START ---- **/

            // PLACEHOLDER VALIDATION FIXER
            if (txtEvidenceInput.Text.Trim() == richPlaceholders[txtEvidenceInput].Trim())
                txtEvidenceInput.Text = "";

            // Validate Date
            if (string.IsNullOrWhiteSpace(txtEvidDate.Text) || !Regex.IsMatch(txtEvidDate.Text, @"^[A-Za-z]{3}/\d{2}/\d{4}$"))
            {
                MessageBox.Show("Missing or Invalid Date Format:\nMON/DD/YYYY", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetAllPlaceholdersIfEmpty();
                return;
            }

            // Validate Classification (at least 1 checked)
            if (!cblClass.CheckedItems.Cast<object>().Any())
            {
                MessageBox.Show("No Classification Input:\nMust select at least 1 category to proceed.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetAllPlaceholdersIfEmpty();
                return;
            }

            // If "Others" is checked, validate txtOthers
            bool othersChecked = cblClass.CheckedItems.Cast<string>().Any(item => item.Equals("Others", StringComparison.OrdinalIgnoreCase));
            if (othersChecked && string.IsNullOrWhiteSpace(txtOthers.Text))
            {
                MessageBox.Show("Missing Classification:\nOthers", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetAllPlaceholdersIfEmpty();
                return;
            }

            // Validate Evidence Input (RichTextBox)
            if (string.IsNullOrWhiteSpace(txtEvidenceInput.Text))
            {
                MessageBox.Show("Missing:\nEvidence Information", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetAllPlaceholdersIfEmpty();
                return;
            }

            // Validate Signature
            if (string.IsNullOrWhiteSpace(txtSignatureLink.Text) ||
                !txtSignatureLink.Text.Contains("imgur.com") ||
                !txtSignatureLink.Text.Contains(".png"))
            {
                MessageBox.Show("Missing Signature:\nMust include \"imgur.com\" and \".png\"", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetAllPlaceholdersIfEmpty();
                return;
            }

            // Validate Circumstance
            if (string.IsNullOrWhiteSpace(txtCircumstance.Text))
            {
                MessageBox.Show("Missing:\nCircumstances of Seizure", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetAllPlaceholdersIfEmpty();
                return;
            }

            // Validate Supplementary Reports
            if (btnSuppYES.Checked && string.IsNullOrWhiteSpace(txtSuppReports.Text))
            {
                MessageBox.Show("Missing:\nSupplementary Reports", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetAllPlaceholdersIfEmpty();
                return;
            }

            /** ----- VALIDATION END ----- **/

            // Supplementary Report Section
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

                sReports = string.Join("\n", sLines); // Final Output
            }

            // Organizes output for [list].
            string[] lines = txtEvidenceInput.Text
                .Split(new[] { "\r\n", "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries);


            // Format each line with a [*] prefix.
            string[] formattedLines = lines.Select(line => "[*]" + line.Trim()).ToArray();

            // Create final output by joining strings.
            string EvidInventory = "[list=1]" + Environment.NewLine +
                string.Join(Environment.NewLine, formattedLines) +
                Environment.NewLine + "[/list]";


            // Checkbox organization for Classification.
            string weaponsBox = cblClass.CheckedItems.Contains("Weapons") ? "[CBOX_YES][/CBOX_YES]" : "[CBOX_NO][/CBOX_NO]";
            string narcoticsBox = cblClass.CheckedItems.Contains("Narcotics") ? "[CBOX_YES][/CBOX_YES]" : "[CBOX_NO][/CBOX_NO]";
            string othersBox = cblClass.CheckedItems.Contains("Others") ? "[CBOX_YES][/CBOX_YES]" : "[CBOX_NO][/CBOX_NO]";
            string OUTPUT_1 = $"Weapons {weaponsBox} Narcotics {narcoticsBox} Others {othersBox}";

            // String for the Others textbox.
            string OUTPUT_2;

            if (cblClass.CheckedItems.Contains("Others") && txtOthers.Enabled)
            {
                OUTPUT_2 = txtOthers.Text.Trim();
            }
            else
            {
                // If Others is not selected, it inputs this empty white code (aesthetic).
                OUTPUT_2 = "[color=white]_________________[/color]";
            }


            /** ---- BB CODE OUTPUT TO CLIPBOARD --- **/

            // Login Details and Signature Formatting
            string e_depFullName = Session.Forename + " " + Session.Surname;
            string e_Sig = txtSignatureLink.Text;
            string e_Signature = $"[yimg=60]{e_Sig}[/yimg]";

            // BB Code Injection
            string filled = Templates.SeizureTemplate
                .Replace("{OUTPUT_1}", OUTPUT_1)
                .Replace("{OUTPUT_2}", OUTPUT_2)
                .Replace("{OUTPUT_3}", EvidInventory)
                .Replace("{OUTPUT_4}", txtCircumstance.Text)
                .Replace("{OUTPUT_5}", sReports)
                .Replace("{OUTPUT_6}", e_depFullName)
                .Replace("{OUTPUT_7}", Session.depRank)
                .Replace("{OUTPUT_8}", Session.BadgeNumber)
                .Replace("{OUTPUT_9}", e_Signature)
                .Replace("{OUTPUT_10}", txtEvidDate.Text.ToUpper());

            ResetAllPlaceholdersIfEmpty();

            // Copy to Clipboard
            Clipboard.SetText(filled);
            MessageBox.Show("BB code has been copied to your clipboard!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

    }
}
