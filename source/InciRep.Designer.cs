
namespace RCSD_Computer
{
    partial class InciForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InciForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBACK_AR = new System.Windows.Forms.Button();
            this.btnPRINT_AR = new System.Windows.Forms.Button();
            this.lblAccount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCaseNumber = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInciTime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbInciInit = new System.Windows.Forms.ComboBox();
            this.cbInciType = new System.Windows.Forms.ComboBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGang = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCOName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbCORank = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbAgency = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSignature = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtNarrative = new System.Windows.Forms.RichTextBox();
            this.txtCallsign = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnBACK_AR
            // 
            this.btnBACK_AR.Location = new System.Drawing.Point(48, 168);
            this.btnBACK_AR.Name = "btnBACK_AR";
            this.btnBACK_AR.Size = new System.Drawing.Size(75, 23);
            this.btnBACK_AR.TabIndex = 1;
            this.btnBACK_AR.Text = "BACK";
            this.btnBACK_AR.UseVisualStyleBackColor = true;
            this.btnBACK_AR.Click += new System.EventHandler(this.btnBACK_AR_Click);
            // 
            // btnPRINT_AR
            // 
            this.btnPRINT_AR.Location = new System.Drawing.Point(866, 508);
            this.btnPRINT_AR.Name = "btnPRINT_AR";
            this.btnPRINT_AR.Size = new System.Drawing.Size(106, 42);
            this.btnPRINT_AR.TabIndex = 2;
            this.btnPRINT_AR.Text = "PRINT";
            this.btnPRINT_AR.UseVisualStyleBackColor = true;
            this.btnPRINT_AR.Click += new System.EventHandler(this.btnPRINT_AR_Click);
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccount.Location = new System.Drawing.Point(9, 538);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(35, 15);
            this.lblAccount.TabIndex = 3;
            this.lblAccount.Text = "texx";
            this.lblAccount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Incident Number";
            // 
            // txtCaseNumber
            // 
            this.txtCaseNumber.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaseNumber.Location = new System.Drawing.Point(347, 32);
            this.txtCaseNumber.Name = "txtCaseNumber";
            this.txtCaseNumber.Size = new System.Drawing.Size(100, 23);
            this.txtCaseNumber.TabIndex = 5;
            this.txtCaseNumber.Text = "YYMMDD-00X";
            this.txtCaseNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.txtDate.Location = new System.Drawing.Point(645, 33);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 23);
            this.txtDate.TabIndex = 7;
            this.txtDate.Text = "MON/DD/YYYY";
            this.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(506, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Date of Report";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(863, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "FORM: RCSD-IR-485";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(197, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Incident Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(468, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Initiation";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(201, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(280, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "INCIDENT INFORMATION";
            // 
            // txtInciTime
            // 
            this.txtInciTime.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.txtInciTime.Location = new System.Drawing.Point(845, 123);
            this.txtInciTime.Name = "txtInciTime";
            this.txtInciTime.Size = new System.Drawing.Size(100, 23);
            this.txtInciTime.TabIndex = 15;
            this.txtInciTime.Text = "HH:MM AM/PM";
            this.txtInciTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(701, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Time of Incident";
            // 
            // cbInciInit
            // 
            this.cbInciInit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbInciInit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbInciInit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInciInit.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.cbInciInit.FormattingEnabled = true;
            this.cbInciInit.Items.AddRange(new object[] {
            "On-View",
            "911 Call",
            "Dispatch",
            "Traffic Stop",
            "Assistance Call",
            "Civilian Flag Down\t",
            "Other"});
            this.cbInciInit.Location = new System.Drawing.Point(553, 123);
            this.cbInciInit.Name = "cbInciInit";
            this.cbInciInit.Size = new System.Drawing.Size(142, 23);
            this.cbInciInit.TabIndex = 16;
            // 
            // cbInciType
            // 
            this.cbInciType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbInciType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbInciType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInciType.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.cbInciType.FormattingEnabled = true;
            this.cbInciType.Items.AddRange(new object[] {
            "Pursuit",
            "Shooting",
            "Domestic",
            "Assault",
            "Motor Vehicle Accident",
            "Officer Down",
            "Civilian Down",
            "Special Operation",
            "Other"});
            this.cbInciType.Location = new System.Drawing.Point(320, 123);
            this.cbInciType.Name = "cbInciType";
            this.cbInciType.Size = new System.Drawing.Size(133, 23);
            this.cbInciType.TabIndex = 17;
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.txtLocation.Location = new System.Drawing.Point(381, 162);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(273, 23);
            this.txtLocation.TabIndex = 19;
            this.txtLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(197, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Location of Incident";
            // 
            // txtGang
            // 
            this.txtGang.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.txtGang.Location = new System.Drawing.Point(806, 162);
            this.txtGang.Name = "txtGang";
            this.txtGang.Size = new System.Drawing.Size(139, 23);
            this.txtGang.TabIndex = 21;
            this.txtGang.Text = "No / Gang Name";
            this.txtGang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(676, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Gang Related";
            // 
            // txtCOName
            // 
            this.txtCOName.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.txtCOName.Location = new System.Drawing.Point(736, 203);
            this.txtCOName.Name = "txtCOName";
            this.txtCOName.Size = new System.Drawing.Size(209, 23);
            this.txtCOName.TabIndex = 23;
            this.txtCOName.Text = "Firstname Lastname";
            this.txtCOName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(377, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Incident Commander";
            // 
            // cbCORank
            // 
            this.cbCORank.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCORank.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCORank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCORank.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.cbCORank.FormattingEnabled = true;
            this.cbCORank.Items.AddRange(new object[] {
            "Deputy Sherif I",
            "Deputy Sheriff II",
            "Deputy Sheriff (FTO)",
            "Investigator",
            "Sergeant",
            "Lieutenant",
            "Captain",
            "Commander",
            "Assistant Sheriff",
            "Undersheriff",
            "Sheriff"});
            this.cbCORank.Location = new System.Drawing.Point(558, 203);
            this.cbCORank.Name = "cbCORank";
            this.cbCORank.Size = new System.Drawing.Size(163, 23);
            this.cbCORank.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(102, 204);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(240, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "_________________________________";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 237);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(267, 25);
            this.label12.TabIndex = 26;
            this.label12.Text = "DEPUTY INFORMATION";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(78, 274);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 20);
            this.label13.TabIndex = 27;
            this.label13.Text = "Deputy Callsign";
            // 
            // cbAgency
            // 
            this.cbAgency.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbAgency.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbAgency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAgency.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.cbAgency.FormattingEnabled = true;
            this.cbAgency.Items.AddRange(new object[] {
            "None",
            "RCFD",
            "FBI"});
            this.cbAgency.Location = new System.Drawing.Point(98, 362);
            this.cbAgency.Name = "cbAgency";
            this.cbAgency.Size = new System.Drawing.Size(91, 23);
            this.cbAgency.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(51, 336);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(184, 20);
            this.label14.TabIndex = 29;
            this.label14.Text = "Responding Agencies";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(102, 398);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 20);
            this.label15.TabIndex = 31;
            this.label15.Text = "Signature";
            // 
            // txtSignature
            // 
            this.txtSignature.Location = new System.Drawing.Point(38, 421);
            this.txtSignature.Name = "txtSignature";
            this.txtSignature.Size = new System.Drawing.Size(225, 20);
            this.txtSignature.TabIndex = 32;
            this.txtSignature.Text = "Imgur .png URL links only";
            this.txtSignature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(327, 237);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(252, 25);
            this.label16.TabIndex = 33;
            this.label16.Text = "INCIDENT NARRATIVE";
            // 
            // txtNarrative
            // 
            this.txtNarrative.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNarrative.Location = new System.Drawing.Point(332, 276);
            this.txtNarrative.Name = "txtNarrative";
            this.txtNarrative.Size = new System.Drawing.Size(613, 197);
            this.txtNarrative.TabIndex = 34;
            this.txtNarrative.Text = "";
            // 
            // txtCallsign
            // 
            this.txtCallsign.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.txtCallsign.Location = new System.Drawing.Point(57, 298);
            this.txtCallsign.Name = "txtCallsign";
            this.txtCallsign.Size = new System.Drawing.Size(183, 23);
            this.txtCallsign.TabIndex = 35;
            this.txtCallsign.Text = "e.g. 1-ALPHA, Car 1, 1A";
            this.txtCallsign.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.txtCallsign);
            this.Controls.Add(this.txtNarrative);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtSignature);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cbAgency);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbCORank);
            this.Controls.Add(this.txtCOName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtGang);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbInciType);
            this.Controls.Add(this.cbInciInit);
            this.Controls.Add(this.txtInciTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCaseNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.btnPRINT_AR);
            this.Controls.Add(this.btnBACK_AR);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InciForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RCSD Computer - Incident Report";
            this.Load += new System.EventHandler(this.ArrestRep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBACK_AR;
        private System.Windows.Forms.Button btnPRINT_AR;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCaseNumber;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtInciTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbInciInit;
        private System.Windows.Forms.ComboBox cbInciType;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCOName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbCORank;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbAgency;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSignature;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RichTextBox txtNarrative;
        private System.Windows.Forms.TextBox txtCallsign;
    }
}