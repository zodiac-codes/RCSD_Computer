
namespace RCSD_Computer
{
    partial class ArrestForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArrestForm));
            this.txtArrestDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtArrestLoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArrestTime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtArrestFN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtArrestLN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFEMALE = new System.Windows.Forms.RadioButton();
            this.btnMALE = new System.Windows.Forms.RadioButton();
            this.txtArrestDOB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGANG = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.cbxGANG = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSearchCharge = new System.Windows.Forms.TextBox();
            this.btnADDCharge = new System.Windows.Forms.Button();
            this.dgvCharges = new System.Windows.Forms.DataGridView();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtAlias = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSuppReports = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSuppNO = new System.Windows.Forms.RadioButton();
            this.btnSuppYES = new System.Windows.Forms.RadioButton();
            this.txtArrestNarrative = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnPRINT_ARREST = new System.Windows.Forms.Button();
            this.txtSignatureLink = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cbRace = new System.Windows.Forms.ComboBox();
            this.btnPENALCODE = new System.Windows.Forms.Button();
            this.lblAccount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpGender = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCharges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpGender.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtArrestDate
            // 
            this.txtArrestDate.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.txtArrestDate.Location = new System.Drawing.Point(318, 40);
            this.txtArrestDate.Name = "txtArrestDate";
            this.txtArrestDate.Size = new System.Drawing.Size(100, 23);
            this.txtArrestDate.TabIndex = 1;
            this.txtArrestDate.Text = "MON/DD/YYYY";
            this.txtArrestDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Date of Arrest";
            // 
            // txtArrestLoc
            // 
            this.txtArrestLoc.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.txtArrestLoc.Location = new System.Drawing.Point(600, 40);
            this.txtArrestLoc.Name = "txtArrestLoc";
            this.txtArrestLoc.Size = new System.Drawing.Size(100, 23);
            this.txtArrestLoc.TabIndex = 2;
            this.txtArrestLoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(441, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Location of Arrest";
            // 
            // txtArrestTime
            // 
            this.txtArrestTime.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.txtArrestTime.Location = new System.Drawing.Point(850, 40);
            this.txtArrestTime.Name = "txtArrestTime";
            this.txtArrestTime.Size = new System.Drawing.Size(100, 23);
            this.txtArrestTime.TabIndex = 3;
            this.txtArrestTime.Text = "HH:MM AM/PM";
            this.txtArrestTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(722, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 20);
            this.label7.TabIndex = 40;
            this.label7.Text = "Time of Arrest";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(863, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "FORM: RCSD-IR-225";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(188, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(281, 25);
            this.label6.TabIndex = 43;
            this.label6.Text = "SUSPECT INFORMATION";
            // 
            // txtArrestFN
            // 
            this.txtArrestFN.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.txtArrestFN.Location = new System.Drawing.Point(290, 121);
            this.txtArrestFN.Name = "txtArrestFN";
            this.txtArrestFN.Size = new System.Drawing.Size(142, 23);
            this.txtArrestFN.TabIndex = 4;
            this.txtArrestFN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(195, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 44;
            this.label8.Text = "Firstname";
            // 
            // txtArrestLN
            // 
            this.txtArrestLN.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.txtArrestLN.Location = new System.Drawing.Point(558, 123);
            this.txtArrestLN.Name = "txtArrestLN";
            this.txtArrestLN.Size = new System.Drawing.Size(142, 23);
            this.txtArrestLN.TabIndex = 5;
            this.txtArrestLN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(463, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 46;
            this.label4.Text = "Lastname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 48;
            this.label5.Text = "Gender";
            // 
            // btnFEMALE
            // 
            this.btnFEMALE.AutoSize = true;
            this.btnFEMALE.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFEMALE.Location = new System.Drawing.Point(160, 14);
            this.btnFEMALE.Name = "btnFEMALE";
            this.btnFEMALE.Size = new System.Drawing.Size(81, 23);
            this.btnFEMALE.TabIndex = 50;
            this.btnFEMALE.TabStop = true;
            this.btnFEMALE.Text = "FEMALE";
            this.btnFEMALE.UseVisualStyleBackColor = true;
            // 
            // btnMALE
            // 
            this.btnMALE.AutoSize = true;
            this.btnMALE.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMALE.Location = new System.Drawing.Point(89, 14);
            this.btnMALE.Name = "btnMALE";
            this.btnMALE.Size = new System.Drawing.Size(63, 23);
            this.btnMALE.TabIndex = 49;
            this.btnMALE.TabStop = true;
            this.btnMALE.Text = "MALE";
            this.btnMALE.UseVisualStyleBackColor = true;
            // 
            // txtArrestDOB
            // 
            this.txtArrestDOB.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.txtArrestDOB.Location = new System.Drawing.Point(332, 156);
            this.txtArrestDOB.Name = "txtArrestDOB";
            this.txtArrestDOB.Size = new System.Drawing.Size(100, 23);
            this.txtArrestDOB.TabIndex = 6;
            this.txtArrestDOB.Text = "MON/DD/YYYY";
            this.txtArrestDOB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(195, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 20);
            this.label9.TabIndex = 51;
            this.label9.Text = "Date of Birth";
            // 
            // txtGANG
            // 
            this.txtGANG.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.txtGANG.Location = new System.Drawing.Point(581, 152);
            this.txtGANG.Name = "txtGANG";
            this.txtGANG.Size = new System.Drawing.Size(146, 23);
            this.txtGANG.TabIndex = 7;
            this.txtGANG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(441, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 20);
            this.label10.TabIndex = 53;
            this.label10.Text = "Gang Affiliation";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 562);
            this.splitter1.TabIndex = 55;
            this.splitter1.TabStop = false;
            // 
            // cbxGANG
            // 
            this.cbxGANG.AutoSize = true;
            this.cbxGANG.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbxGANG.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGANG.Location = new System.Drawing.Point(743, 155);
            this.cbxGANG.Name = "cbxGANG";
            this.cbxGANG.Size = new System.Drawing.Size(208, 23);
            this.cbxGANG.TabIndex = 56;
            this.cbxGANG.Text = "NO GANG AFFILIATIONS";
            this.cbxGANG.UseVisualStyleBackColor = false;
            this.cbxGANG.CheckedChanged += new System.EventHandler(this.cbxGANG_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 247);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 20);
            this.label13.TabIndex = 57;
            this.label13.Text = "Charges";
            // 
            // txtSearchCharge
            // 
            this.txtSearchCharge.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.txtSearchCharge.Location = new System.Drawing.Point(94, 244);
            this.txtSearchCharge.Name = "txtSearchCharge";
            this.txtSearchCharge.Size = new System.Drawing.Size(279, 23);
            this.txtSearchCharge.TabIndex = 10;
            this.txtSearchCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnADDCharge
            // 
            this.btnADDCharge.Location = new System.Drawing.Point(379, 244);
            this.btnADDCharge.Name = "btnADDCharge";
            this.btnADDCharge.Size = new System.Drawing.Size(53, 23);
            this.btnADDCharge.TabIndex = 59;
            this.btnADDCharge.Text = "ADD";
            this.btnADDCharge.UseVisualStyleBackColor = true;
            this.btnADDCharge.Click += new System.EventHandler(this.btnADDCharge_Click);
            // 
            // dgvCharges
            // 
            this.dgvCharges.AllowUserToAddRows = false;
            this.dgvCharges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCharges.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCode,
            this.colTitle,
            this.colDelete});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCharges.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCharges.Location = new System.Drawing.Point(12, 291);
            this.dgvCharges.Name = "dgvCharges";
            this.dgvCharges.RowHeadersVisible = false;
            this.dgvCharges.Size = new System.Drawing.Size(420, 145);
            this.dgvCharges.TabIndex = 60;
            // 
            // colCode
            // 
            this.colCode.HeaderText = "Section Code";
            this.colCode.Name = "colCode";
            this.colCode.ReadOnly = true;
            this.colCode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colCode.Width = 95;
            // 
            // colTitle
            // 
            this.colTitle.HeaderText = "Title";
            this.colTitle.Name = "colTitle";
            this.colTitle.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colTitle.Width = 257;
            // 
            // colDelete
            // 
            this.colDelete.HeaderText = "";
            this.colDelete.Name = "colDelete";
            this.colDelete.Text = "X";
            this.colDelete.UseColumnTextForButtonValue = true;
            this.colDelete.Width = 50;
            // 
            // txtAlias
            // 
            this.txtAlias.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.txtAlias.Location = new System.Drawing.Point(249, 194);
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(411, 23);
            this.txtAlias.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(195, 195);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 20);
            this.label11.TabIndex = 61;
            this.label11.Text = "Alias";
            // 
            // txtSuppReports
            // 
            this.txtSuppReports.Enabled = false;
            this.txtSuppReports.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.txtSuppReports.Location = new System.Drawing.Point(29, 475);
            this.txtSuppReports.Multiline = true;
            this.txtSuppReports.Name = "txtSuppReports";
            this.txtSuppReports.Size = new System.Drawing.Size(357, 54);
            this.txtSuppReports.TabIndex = 64;
            this.txtSuppReports.Text = "[url]URL1[/url], [url]URL2[/url]\r\nPlace links and seperate by commas.";
            this.txtSuppReports.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(-4, 1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(198, 20);
            this.label12.TabIndex = 63;
            this.label12.Text = "Supplementary Reports";
            // 
            // btnSuppNO
            // 
            this.btnSuppNO.AutoSize = true;
            this.btnSuppNO.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppNO.Location = new System.Drawing.Point(276, 0);
            this.btnSuppNO.Name = "btnSuppNO";
            this.btnSuppNO.Size = new System.Drawing.Size(45, 23);
            this.btnSuppNO.TabIndex = 66;
            this.btnSuppNO.TabStop = true;
            this.btnSuppNO.Text = "No";
            this.btnSuppNO.UseVisualStyleBackColor = true;
            // 
            // btnSuppYES
            // 
            this.btnSuppYES.AutoSize = true;
            this.btnSuppYES.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppYES.Location = new System.Drawing.Point(207, 0);
            this.btnSuppYES.Name = "btnSuppYES";
            this.btnSuppYES.Size = new System.Drawing.Size(54, 23);
            this.btnSuppYES.TabIndex = 65;
            this.btnSuppYES.TabStop = true;
            this.btnSuppYES.Text = "Yes";
            this.btnSuppYES.UseVisualStyleBackColor = true;
            this.btnSuppYES.CheckedChanged += new System.EventHandler(this.btnSuppYES_CheckedChanged);
            // 
            // txtArrestNarrative
            // 
            this.txtArrestNarrative.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArrestNarrative.Location = new System.Drawing.Point(445, 291);
            this.txtArrestNarrative.Multiline = true;
            this.txtArrestNarrative.Name = "txtArrestNarrative";
            this.txtArrestNarrative.Size = new System.Drawing.Size(489, 199);
            this.txtArrestNarrative.TabIndex = 11;
            this.txtArrestNarrative.TextChanged += new System.EventHandler(this.txtArrestNarrative_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(576, 247);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(238, 25);
            this.label15.TabIndex = 69;
            this.label15.Text = "ARREST NARRATIVE";
            // 
            // btnPRINT_ARREST
            // 
            this.btnPRINT_ARREST.Location = new System.Drawing.Point(870, 508);
            this.btnPRINT_ARREST.Name = "btnPRINT_ARREST";
            this.btnPRINT_ARREST.Size = new System.Drawing.Size(106, 42);
            this.btnPRINT_ARREST.TabIndex = 13;
            this.btnPRINT_ARREST.Text = "PRINT";
            this.btnPRINT_ARREST.UseVisualStyleBackColor = true;
            this.btnPRINT_ARREST.Click += new System.EventHandler(this.btnPRINT_ARREST_Click);
            // 
            // txtSignatureLink
            // 
            this.txtSignatureLink.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.txtSignatureLink.Location = new System.Drawing.Point(606, 508);
            this.txtSignatureLink.Name = "txtSignatureLink";
            this.txtSignatureLink.Size = new System.Drawing.Size(185, 23);
            this.txtSignatureLink.TabIndex = 12;
            this.txtSignatureLink.Text = ".png Imgur Link Only";
            this.txtSignatureLink.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(511, 509);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 20);
            this.label14.TabIndex = 71;
            this.label14.Text = "Signature";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(709, 197);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 20);
            this.label16.TabIndex = 73;
            this.label16.Text = "Race";
            // 
            // cbRace
            // 
            this.cbRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRace.FormattingEnabled = true;
            this.cbRace.Items.AddRange(new object[] {
            "White",
            "Black",
            "Asian",
            "Hispanic / Latino",
            "European",
            "Arab / Middle Eastern",
            "Pacific Islander",
            "Carribean",
            "American Native",
            "Other"});
            this.cbRace.Location = new System.Drawing.Point(766, 195);
            this.cbRace.Name = "cbRace";
            this.cbRace.Size = new System.Drawing.Size(168, 21);
            this.cbRace.TabIndex = 9;
            // 
            // btnPENALCODE
            // 
            this.btnPENALCODE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPENALCODE.ForeColor = System.Drawing.Color.Maroon;
            this.btnPENALCODE.Location = new System.Drawing.Point(94, 215);
            this.btnPENALCODE.Name = "btnPENALCODE";
            this.btnPENALCODE.Size = new System.Drawing.Size(84, 23);
            this.btnPENALCODE.TabIndex = 74;
            this.btnPENALCODE.Text = "PENAL CODE";
            this.btnPENALCODE.UseVisualStyleBackColor = true;
            this.btnPENALCODE.Click += new System.EventHandler(this.btnPENALCODE_Click);
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccount.Location = new System.Drawing.Point(9, 538);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(35, 15);
            this.lblAccount.TabIndex = 75;
            this.lblAccount.Text = "texx";
            this.lblAccount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.btnMALE);
            this.grpGender.Controls.Add(this.btnFEMALE);
            this.grpGender.Controls.Add(this.label5);
            this.grpGender.Location = new System.Drawing.Point(706, 105);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(266, 44);
            this.grpGender.TabIndex = 76;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.btnSuppYES);
            this.panel1.Controls.Add(this.btnSuppNO);
            this.panel1.Location = new System.Drawing.Point(42, 442);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 28);
            this.panel1.TabIndex = 77;
            // 
            // ArrestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpGender);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.btnPENALCODE);
            this.Controls.Add(this.cbRace);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtSignatureLink);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnPRINT_ARREST);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtArrestNarrative);
            this.Controls.Add(this.txtSuppReports);
            this.Controls.Add(this.txtAlias);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvCharges);
            this.Controls.Add(this.btnADDCharge);
            this.Controls.Add(this.txtSearchCharge);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbxGANG);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.txtGANG);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtArrestDOB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtArrestLN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtArrestFN);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtArrestTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtArrestLoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtArrestDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ArrestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RCSD Computer - Arrest Report";
            this.Load += new System.EventHandler(this.ArrestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCharges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtArrestDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArrestLoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtArrestTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtArrestFN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtArrestLN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton btnFEMALE;
        private System.Windows.Forms.RadioButton btnMALE;
        private System.Windows.Forms.TextBox txtArrestDOB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGANG;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.CheckBox cbxGANG;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSearchCharge;
        private System.Windows.Forms.Button btnADDCharge;
        private System.Windows.Forms.DataGridView dgvCharges;
        private System.Windows.Forms.TextBox txtAlias;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSuppReports;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton btnSuppNO;
        private System.Windows.Forms.RadioButton btnSuppYES;
        private System.Windows.Forms.TextBox txtArrestNarrative;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnPRINT_ARREST;
        private System.Windows.Forms.TextBox txtSignatureLink;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbRace;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
        private System.Windows.Forms.Button btnPENALCODE;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel grpGender;
        private System.Windows.Forms.Panel panel1;
    }
}