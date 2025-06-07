
namespace RCSD_Computer
{
    partial class EvidForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvidForm));
            this.button1 = new System.Windows.Forms.Button();
            this.lblAccount = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtEvidDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cblClass = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOthers = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.rtbLineNumbers = new System.Windows.Forms.RichTextBox();
            this.txtEvidenceInput = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCircumstance = new System.Windows.Forms.TextBox();
            this.btnSuppNO = new System.Windows.Forms.RadioButton();
            this.btnSuppYES = new System.Windows.Forms.RadioButton();
            this.txtSuppReports = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnPRINT_SEIZURE = new System.Windows.Forms.Button();
            this.txtSignatureLink = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button1.Location = new System.Drawing.Point(50, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccount.Location = new System.Drawing.Point(9, 538);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(35, 15);
            this.lblAccount.TabIndex = 76;
            this.lblAccount.Text = "texx";
            this.lblAccount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RCSD_Computer.Properties.Resources.rd_270_t1;
            this.pictureBox2.Location = new System.Drawing.Point(661, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(311, 229);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 77;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RCSD_Computer.Properties.Resources.seal_400;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtEvidDate
            // 
            this.txtEvidDate.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.txtEvidDate.Location = new System.Drawing.Point(233, 26);
            this.txtEvidDate.Name = "txtEvidDate";
            this.txtEvidDate.Size = new System.Drawing.Size(142, 23);
            this.txtEvidDate.TabIndex = 0;
            this.txtEvidDate.Text = "MON/DD/YYYY";
            this.txtEvidDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(179, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 79;
            this.label4.Text = "Date";
            // 
            // cblClass
            // 
            this.cblClass.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cblClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cblClass.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cblClass.FormattingEnabled = true;
            this.cblClass.Items.AddRange(new object[] {
            "Weapons",
            "Narcotics",
            "Others"});
            this.cblClass.Location = new System.Drawing.Point(183, 107);
            this.cblClass.Name = "cblClass";
            this.cblClass.Size = new System.Drawing.Size(124, 75);
            this.cblClass.TabIndex = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 81;
            this.label1.Text = "Classification";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 82;
            this.label2.Text = "Others";
            // 
            // txtOthers
            // 
            this.txtOthers.Location = new System.Drawing.Point(324, 105);
            this.txtOthers.Name = "txtOthers";
            this.txtOthers.Size = new System.Drawing.Size(236, 20);
            this.txtOthers.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 216);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(264, 25);
            this.label15.TabIndex = 85;
            this.label15.Text = "EVIDENCE INVENTORY";
            // 
            // rtbLineNumbers
            // 
            this.rtbLineNumbers.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rtbLineNumbers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbLineNumbers.Location = new System.Drawing.Point(18, 257);
            this.rtbLineNumbers.Name = "rtbLineNumbers";
            this.rtbLineNumbers.ReadOnly = true;
            this.rtbLineNumbers.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtbLineNumbers.Size = new System.Drawing.Size(26, 161);
            this.rtbLineNumbers.TabIndex = 86;
            this.rtbLineNumbers.TabStop = false;
            this.rtbLineNumbers.Text = "";
            // 
            // txtEvidenceInput
            // 
            this.txtEvidenceInput.Location = new System.Drawing.Point(50, 254);
            this.txtEvidenceInput.Name = "txtEvidenceInput";
            this.txtEvidenceInput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtEvidenceInput.Size = new System.Drawing.Size(200, 164);
            this.txtEvidenceInput.TabIndex = 1;
            this.txtEvidenceInput.Text = "";
            this.txtEvidenceInput.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(329, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(349, 25);
            this.label3.TabIndex = 88;
            this.label3.Text = "CIRCUMSTANCES OF SEIZURE";
            // 
            // txtCircumstance
            // 
            this.txtCircumstance.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCircumstance.Location = new System.Drawing.Point(334, 257);
            this.txtCircumstance.Multiline = true;
            this.txtCircumstance.Name = "txtCircumstance";
            this.txtCircumstance.Size = new System.Drawing.Size(604, 161);
            this.txtCircumstance.TabIndex = 2;
            // 
            // btnSuppNO
            // 
            this.btnSuppNO.AutoSize = true;
            this.btnSuppNO.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppNO.Location = new System.Drawing.Point(610, 435);
            this.btnSuppNO.Name = "btnSuppNO";
            this.btnSuppNO.Size = new System.Drawing.Size(45, 23);
            this.btnSuppNO.TabIndex = 93;
            this.btnSuppNO.TabStop = true;
            this.btnSuppNO.Text = "No";
            this.btnSuppNO.UseVisualStyleBackColor = true;
            // 
            // btnSuppYES
            // 
            this.btnSuppYES.AutoSize = true;
            this.btnSuppYES.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppYES.Location = new System.Drawing.Point(541, 435);
            this.btnSuppYES.Name = "btnSuppYES";
            this.btnSuppYES.Size = new System.Drawing.Size(54, 23);
            this.btnSuppYES.TabIndex = 92;
            this.btnSuppYES.TabStop = true;
            this.btnSuppYES.Text = "Yes";
            this.btnSuppYES.UseVisualStyleBackColor = true;
            this.btnSuppYES.CheckedChanged += new System.EventHandler(this.btnSuppYES_CheckedChanged);
            // 
            // txtSuppReports
            // 
            this.txtSuppReports.Enabled = false;
            this.txtSuppReports.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.txtSuppReports.Location = new System.Drawing.Point(334, 467);
            this.txtSuppReports.Multiline = true;
            this.txtSuppReports.Name = "txtSuppReports";
            this.txtSuppReports.Size = new System.Drawing.Size(357, 54);
            this.txtSuppReports.TabIndex = 4;
            this.txtSuppReports.Text = "[url]URL1[/url], [url]URL2[/url]\r\nPlace links and seperate by commas.";
            this.txtSuppReports.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(330, 435);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(198, 20);
            this.label12.TabIndex = 90;
            this.label12.Text = "Supplementary Reports";
            // 
            // btnPRINT_SEIZURE
            // 
            this.btnPRINT_SEIZURE.Location = new System.Drawing.Point(866, 511);
            this.btnPRINT_SEIZURE.Name = "btnPRINT_SEIZURE";
            this.btnPRINT_SEIZURE.Size = new System.Drawing.Size(106, 42);
            this.btnPRINT_SEIZURE.TabIndex = 5;
            this.btnPRINT_SEIZURE.Text = "PRINT";
            this.btnPRINT_SEIZURE.UseVisualStyleBackColor = true;
            this.btnPRINT_SEIZURE.Click += new System.EventHandler(this.btnPRINT_SEIZURE_Click);
            // 
            // txtSignatureLink
            // 
            this.txtSignatureLink.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.txtSignatureLink.Location = new System.Drawing.Point(65, 487);
            this.txtSignatureLink.Name = "txtSignatureLink";
            this.txtSignatureLink.Size = new System.Drawing.Size(185, 23);
            this.txtSignatureLink.TabIndex = 3;
            this.txtSignatureLink.Text = ".png Imgur Link Only";
            this.txtSignatureLink.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(114, 464);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 20);
            this.label14.TabIndex = 95;
            this.label14.Text = "Signature";
            // 
            // EvidForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.txtSignatureLink);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnPRINT_SEIZURE);
            this.Controls.Add(this.btnSuppNO);
            this.Controls.Add(this.btnSuppYES);
            this.Controls.Add(this.txtSuppReports);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtCircumstance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEvidenceInput);
            this.Controls.Add(this.rtbLineNumbers);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtOthers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cblClass);
            this.Controls.Add(this.txtEvidDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EvidForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RCSD Computer - Evidence Submission Form";
            this.Load += new System.EventHandler(this.EvidForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtEvidDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox cblClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOthers;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RichTextBox rtbLineNumbers;
        private System.Windows.Forms.RichTextBox txtEvidenceInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCircumstance;
        private System.Windows.Forms.RadioButton btnSuppNO;
        private System.Windows.Forms.RadioButton btnSuppYES;
        private System.Windows.Forms.TextBox txtSuppReports;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnPRINT_SEIZURE;
        private System.Windows.Forms.TextBox txtSignatureLink;
        private System.Windows.Forms.Label label14;
    }
}