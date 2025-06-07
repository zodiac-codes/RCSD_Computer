
namespace RCSD_Computer
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.cbRank = new System.Windows.Forms.ComboBox();
            this.txtBadge = new System.Windows.Forms.TextBox();
            this.cbAssignment = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSpecialSurname = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(417, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(205, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(575, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "RED COUNTY SHERIFF\'S DEPARTMENT";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(440, 485);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(105, 37);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // cbRank
            // 
            this.cbRank.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbRank.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbRank.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRank.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRank.ForeColor = System.Drawing.Color.Green;
            this.cbRank.FormattingEnabled = true;
            this.cbRank.Items.AddRange(new object[] {
            "Deputy Sheriff Trainee",
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
            this.cbRank.Location = new System.Drawing.Point(364, 298);
            this.cbRank.Name = "cbRank";
            this.cbRank.Size = new System.Drawing.Size(257, 30);
            this.cbRank.TabIndex = 1;
            // 
            // txtBadge
            // 
            this.txtBadge.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBadge.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBadge.ForeColor = System.Drawing.Color.Green;
            this.txtBadge.Location = new System.Drawing.Point(251, 298);
            this.txtBadge.Name = "txtBadge";
            this.txtBadge.Size = new System.Drawing.Size(69, 30);
            this.txtBadge.TabIndex = 0;
            this.txtBadge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBadge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // cbAssignment
            // 
            this.cbAssignment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbAssignment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbAssignment.BackColor = System.Drawing.Color.Black;
            this.cbAssignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAssignment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAssignment.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAssignment.ForeColor = System.Drawing.Color.Green;
            this.cbAssignment.FormattingEnabled = true;
            this.cbAssignment.Items.AddRange(new object[] {
            "Patrol",
            "Traffic",
            "Aero",
            "CIB",
            "SEB"});
            this.cbAssignment.Location = new System.Drawing.Point(640, 298);
            this.cbAssignment.Name = "cbAssignment";
            this.cbAssignment.Size = new System.Drawing.Size(124, 30);
            this.cbAssignment.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(429, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Employee Rank";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(227, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Badge Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(653, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "Assignment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(336, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Firstname";
            // 
            // txtFName
            // 
            this.txtFName.BackColor = System.Drawing.Color.Black;
            this.txtFName.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFName.ForeColor = System.Drawing.Color.Green;
            this.txtFName.Location = new System.Drawing.Point(270, 390);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(221, 30);
            this.txtFName.TabIndex = 3;
            this.txtFName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLName
            // 
            this.txtLName.BackColor = System.Drawing.Color.Black;
            this.txtLName.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLName.ForeColor = System.Drawing.Color.Green;
            this.txtLName.Location = new System.Drawing.Point(519, 390);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(221, 30);
            this.txtLName.TabIndex = 4;
            this.txtLName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(581, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 19);
            this.label6.TabIndex = 21;
            this.label6.Text = "Lastname";
            // 
            // cbSpecialSurname
            // 
            this.cbSpecialSurname.AutoSize = true;
            this.cbSpecialSurname.ForeColor = System.Drawing.Color.Olive;
            this.cbSpecialSurname.Location = new System.Drawing.Point(569, 426);
            this.cbSpecialSurname.Name = "cbSpecialSurname";
            this.cbSpecialSurname.Size = new System.Drawing.Size(109, 17);
            this.cbSpecialSurname.TabIndex = 22;
            this.cbSpecialSurname.Text = "Surname Adjuster";
            this.cbSpecialSurname.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.cbSpecialSurname);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbAssignment);
            this.Controls.Add(this.txtBadge);
            this.Controls.Add(this.cbRank);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RCSD Computer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ComboBox cbRank;
        private System.Windows.Forms.TextBox txtBadge;
        private System.Windows.Forms.ComboBox cbAssignment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbSpecialSurname;
    }
}

