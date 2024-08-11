namespace DVLD_PresentationLayer.Dashboard
{
    partial class frmDashboard
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
            this.components = new System.ComponentModel.Container();
            this.lblFormHeader = new System.Windows.Forms.Label();
            this.pnlPeopleInfo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblPeopleNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumOfMales = new System.Windows.Forms.Label();
            this.lblNumOfFemales = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlDriversInfo = new System.Windows.Forms.Panel();
            this.lblNumOfFemaleDrivers = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNumOfMaleDrivers = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNumOfDrivers = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlUsersInfo = new System.Windows.Forms.Panel();
            this.lblNumOfInActiveUsers = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNumOfActiveUsers = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblNumOfUsers = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pnlLicences = new System.Windows.Forms.Panel();
            this.lblNumOfInActiveLicences = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblNumOfActiveLicences = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblNumOfLicences = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ctrlUserDetails1 = new DVLD_PresentationLayer.ctrlUserDetails();
            this.pnlPeopleInfo.SuspendLayout();
            this.pnlDriversInfo.SuspendLayout();
            this.pnlUsersInfo.SuspendLayout();
            this.pnlLicences.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFormHeader
            // 
            this.lblFormHeader.AutoSize = true;
            this.lblFormHeader.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblFormHeader.Location = new System.Drawing.Point(12, 9);
            this.lblFormHeader.Name = "lblFormHeader";
            this.lblFormHeader.Size = new System.Drawing.Size(126, 45);
            this.lblFormHeader.TabIndex = 101;
            this.lblFormHeader.Text = "Overall";
            // 
            // pnlPeopleInfo
            // 
            this.pnlPeopleInfo.BackColor = System.Drawing.Color.White;
            this.pnlPeopleInfo.Controls.Add(this.lblNumOfFemales);
            this.pnlPeopleInfo.Controls.Add(this.label4);
            this.pnlPeopleInfo.Controls.Add(this.lblNumOfMales);
            this.pnlPeopleInfo.Controls.Add(this.label2);
            this.pnlPeopleInfo.Controls.Add(this.lblPeopleNumber);
            this.pnlPeopleInfo.Controls.Add(this.label1);
            this.pnlPeopleInfo.Location = new System.Drawing.Point(75, 85);
            this.pnlPeopleInfo.Name = "pnlPeopleInfo";
            this.pnlPeopleInfo.Size = new System.Drawing.Size(196, 157);
            this.pnlPeopleInfo.TabIndex = 102;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.label1.Location = new System.Drawing.Point(26, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 103;
            this.label1.Text = "People";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 16;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lblPeopleNumber
            // 
            this.lblPeopleNumber.AutoSize = true;
            this.lblPeopleNumber.BackColor = System.Drawing.SystemColors.Window;
            this.lblPeopleNumber.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeopleNumber.ForeColor = System.Drawing.Color.Black;
            this.lblPeopleNumber.Location = new System.Drawing.Point(22, 45);
            this.lblPeopleNumber.Name = "lblPeopleNumber";
            this.lblPeopleNumber.Size = new System.Drawing.Size(64, 50);
            this.lblPeopleNumber.TabIndex = 104;
            this.lblPeopleNumber.Text = "20";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(111)))), ((int)(((byte)(120)))));
            this.label2.Location = new System.Drawing.Point(48, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 105;
            this.label2.Text = "Males";
            // 
            // lblNumOfMales
            // 
            this.lblNumOfMales.AutoSize = true;
            this.lblNumOfMales.BackColor = System.Drawing.Color.White;
            this.lblNumOfMales.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfMales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(185)))), ((int)(((byte)(44)))));
            this.lblNumOfMales.Location = new System.Drawing.Point(21, 108);
            this.lblNumOfMales.Name = "lblNumOfMales";
            this.lblNumOfMales.Size = new System.Drawing.Size(21, 15);
            this.lblNumOfMales.TabIndex = 106;
            this.lblNumOfMales.Text = "20";
            // 
            // lblNumOfFemales
            // 
            this.lblNumOfFemales.AutoSize = true;
            this.lblNumOfFemales.BackColor = System.Drawing.Color.White;
            this.lblNumOfFemales.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfFemales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(185)))), ((int)(((byte)(44)))));
            this.lblNumOfFemales.Location = new System.Drawing.Point(21, 132);
            this.lblNumOfFemales.Name = "lblNumOfFemales";
            this.lblNumOfFemales.Size = new System.Drawing.Size(21, 15);
            this.lblNumOfFemales.TabIndex = 108;
            this.lblNumOfFemales.Text = "20";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(111)))), ((int)(((byte)(120)))));
            this.label4.Location = new System.Drawing.Point(48, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 107;
            this.label4.Text = "Females";
            // 
            // pnlDriversInfo
            // 
            this.pnlDriversInfo.BackColor = System.Drawing.Color.White;
            this.pnlDriversInfo.Controls.Add(this.lblNumOfFemaleDrivers);
            this.pnlDriversInfo.Controls.Add(this.label5);
            this.pnlDriversInfo.Controls.Add(this.lblNumOfMaleDrivers);
            this.pnlDriversInfo.Controls.Add(this.label7);
            this.pnlDriversInfo.Controls.Add(this.lblNumOfDrivers);
            this.pnlDriversInfo.Controls.Add(this.label9);
            this.pnlDriversInfo.Location = new System.Drawing.Point(297, 85);
            this.pnlDriversInfo.Name = "pnlDriversInfo";
            this.pnlDriversInfo.Size = new System.Drawing.Size(196, 157);
            this.pnlDriversInfo.TabIndex = 109;
            // 
            // lblNumOfFemaleDrivers
            // 
            this.lblNumOfFemaleDrivers.AutoSize = true;
            this.lblNumOfFemaleDrivers.BackColor = System.Drawing.Color.White;
            this.lblNumOfFemaleDrivers.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfFemaleDrivers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(185)))), ((int)(((byte)(44)))));
            this.lblNumOfFemaleDrivers.Location = new System.Drawing.Point(21, 132);
            this.lblNumOfFemaleDrivers.Name = "lblNumOfFemaleDrivers";
            this.lblNumOfFemaleDrivers.Size = new System.Drawing.Size(21, 15);
            this.lblNumOfFemaleDrivers.TabIndex = 108;
            this.lblNumOfFemaleDrivers.Text = "20";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(111)))), ((int)(((byte)(120)))));
            this.label5.Location = new System.Drawing.Point(48, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 107;
            this.label5.Text = "Females";
            // 
            // lblNumOfMaleDrivers
            // 
            this.lblNumOfMaleDrivers.AutoSize = true;
            this.lblNumOfMaleDrivers.BackColor = System.Drawing.Color.White;
            this.lblNumOfMaleDrivers.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfMaleDrivers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(185)))), ((int)(((byte)(44)))));
            this.lblNumOfMaleDrivers.Location = new System.Drawing.Point(21, 108);
            this.lblNumOfMaleDrivers.Name = "lblNumOfMaleDrivers";
            this.lblNumOfMaleDrivers.Size = new System.Drawing.Size(21, 15);
            this.lblNumOfMaleDrivers.TabIndex = 106;
            this.lblNumOfMaleDrivers.Text = "20";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Window;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(111)))), ((int)(((byte)(120)))));
            this.label7.Location = new System.Drawing.Point(48, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 105;
            this.label7.Text = "Males";
            // 
            // lblNumOfDrivers
            // 
            this.lblNumOfDrivers.AutoSize = true;
            this.lblNumOfDrivers.BackColor = System.Drawing.SystemColors.Window;
            this.lblNumOfDrivers.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfDrivers.ForeColor = System.Drawing.Color.Black;
            this.lblNumOfDrivers.Location = new System.Drawing.Point(22, 45);
            this.lblNumOfDrivers.Name = "lblNumOfDrivers";
            this.lblNumOfDrivers.Size = new System.Drawing.Size(64, 50);
            this.lblNumOfDrivers.TabIndex = 104;
            this.lblNumOfDrivers.Text = "20";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Window;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.label9.Location = new System.Drawing.Point(26, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 17);
            this.label9.TabIndex = 103;
            this.label9.Text = "Drivers";
            // 
            // pnlUsersInfo
            // 
            this.pnlUsersInfo.BackColor = System.Drawing.Color.White;
            this.pnlUsersInfo.Controls.Add(this.lblNumOfInActiveUsers);
            this.pnlUsersInfo.Controls.Add(this.label6);
            this.pnlUsersInfo.Controls.Add(this.lblNumOfActiveUsers);
            this.pnlUsersInfo.Controls.Add(this.label10);
            this.pnlUsersInfo.Controls.Add(this.lblNumOfUsers);
            this.pnlUsersInfo.Controls.Add(this.label12);
            this.pnlUsersInfo.Location = new System.Drawing.Point(521, 85);
            this.pnlUsersInfo.Name = "pnlUsersInfo";
            this.pnlUsersInfo.Size = new System.Drawing.Size(196, 157);
            this.pnlUsersInfo.TabIndex = 110;
            // 
            // lblNumOfInActiveUsers
            // 
            this.lblNumOfInActiveUsers.AutoSize = true;
            this.lblNumOfInActiveUsers.BackColor = System.Drawing.Color.White;
            this.lblNumOfInActiveUsers.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfInActiveUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNumOfInActiveUsers.Location = new System.Drawing.Point(21, 132);
            this.lblNumOfInActiveUsers.Name = "lblNumOfInActiveUsers";
            this.lblNumOfInActiveUsers.Size = new System.Drawing.Size(21, 15);
            this.lblNumOfInActiveUsers.TabIndex = 108;
            this.lblNumOfInActiveUsers.Text = "20";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(111)))), ((int)(((byte)(120)))));
            this.label6.Location = new System.Drawing.Point(48, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 107;
            this.label6.Text = "InActive";
            // 
            // lblNumOfActiveUsers
            // 
            this.lblNumOfActiveUsers.AutoSize = true;
            this.lblNumOfActiveUsers.BackColor = System.Drawing.Color.White;
            this.lblNumOfActiveUsers.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfActiveUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(185)))), ((int)(((byte)(44)))));
            this.lblNumOfActiveUsers.Location = new System.Drawing.Point(21, 108);
            this.lblNumOfActiveUsers.Name = "lblNumOfActiveUsers";
            this.lblNumOfActiveUsers.Size = new System.Drawing.Size(21, 15);
            this.lblNumOfActiveUsers.TabIndex = 106;
            this.lblNumOfActiveUsers.Text = "20";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Window;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(111)))), ((int)(((byte)(120)))));
            this.label10.Location = new System.Drawing.Point(48, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 105;
            this.label10.Text = "Active";
            // 
            // lblNumOfUsers
            // 
            this.lblNumOfUsers.AutoSize = true;
            this.lblNumOfUsers.BackColor = System.Drawing.SystemColors.Window;
            this.lblNumOfUsers.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfUsers.ForeColor = System.Drawing.Color.Black;
            this.lblNumOfUsers.Location = new System.Drawing.Point(22, 45);
            this.lblNumOfUsers.Name = "lblNumOfUsers";
            this.lblNumOfUsers.Size = new System.Drawing.Size(64, 50);
            this.lblNumOfUsers.TabIndex = 104;
            this.lblNumOfUsers.Text = "20";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Window;
            this.label12.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.label12.Location = new System.Drawing.Point(26, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 17);
            this.label12.TabIndex = 103;
            this.label12.Text = "Users";
            // 
            // pnlLicences
            // 
            this.pnlLicences.BackColor = System.Drawing.Color.White;
            this.pnlLicences.Controls.Add(this.lblNumOfInActiveLicences);
            this.pnlLicences.Controls.Add(this.label8);
            this.pnlLicences.Controls.Add(this.lblNumOfActiveLicences);
            this.pnlLicences.Controls.Add(this.label13);
            this.pnlLicences.Controls.Add(this.lblNumOfLicences);
            this.pnlLicences.Controls.Add(this.label15);
            this.pnlLicences.Location = new System.Drawing.Point(749, 85);
            this.pnlLicences.Name = "pnlLicences";
            this.pnlLicences.Size = new System.Drawing.Size(196, 157);
            this.pnlLicences.TabIndex = 111;
            // 
            // lblNumOfInActiveLicences
            // 
            this.lblNumOfInActiveLicences.AutoSize = true;
            this.lblNumOfInActiveLicences.BackColor = System.Drawing.Color.White;
            this.lblNumOfInActiveLicences.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfInActiveLicences.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNumOfInActiveLicences.Location = new System.Drawing.Point(21, 132);
            this.lblNumOfInActiveLicences.Name = "lblNumOfInActiveLicences";
            this.lblNumOfInActiveLicences.Size = new System.Drawing.Size(21, 15);
            this.lblNumOfInActiveLicences.TabIndex = 108;
            this.lblNumOfInActiveLicences.Text = "20";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Window;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(111)))), ((int)(((byte)(120)))));
            this.label8.Location = new System.Drawing.Point(48, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 107;
            this.label8.Text = "InActive";
            // 
            // lblNumOfActiveLicences
            // 
            this.lblNumOfActiveLicences.AutoSize = true;
            this.lblNumOfActiveLicences.BackColor = System.Drawing.Color.White;
            this.lblNumOfActiveLicences.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfActiveLicences.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(185)))), ((int)(((byte)(44)))));
            this.lblNumOfActiveLicences.Location = new System.Drawing.Point(21, 108);
            this.lblNumOfActiveLicences.Name = "lblNumOfActiveLicences";
            this.lblNumOfActiveLicences.Size = new System.Drawing.Size(21, 15);
            this.lblNumOfActiveLicences.TabIndex = 106;
            this.lblNumOfActiveLicences.Text = "20";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.Window;
            this.label13.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(111)))), ((int)(((byte)(120)))));
            this.label13.Location = new System.Drawing.Point(48, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 105;
            this.label13.Text = "Active";
            // 
            // lblNumOfLicences
            // 
            this.lblNumOfLicences.AutoSize = true;
            this.lblNumOfLicences.BackColor = System.Drawing.SystemColors.Window;
            this.lblNumOfLicences.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfLicences.ForeColor = System.Drawing.Color.Black;
            this.lblNumOfLicences.Location = new System.Drawing.Point(22, 45);
            this.lblNumOfLicences.Name = "lblNumOfLicences";
            this.lblNumOfLicences.Size = new System.Drawing.Size(64, 50);
            this.lblNumOfLicences.TabIndex = 104;
            this.lblNumOfLicences.Text = "20";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.Window;
            this.label15.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.label15.Location = new System.Drawing.Point(26, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 17);
            this.label15.TabIndex = 103;
            this.label15.Text = "Licences";
            // 
            // ctrlUserDetails1
            // 
            this.ctrlUserDetails1.BackColor = System.Drawing.Color.White;
            this.ctrlUserDetails1.Location = new System.Drawing.Point(126, 293);
            this.ctrlUserDetails1.Name = "ctrlUserDetails1";
            this.ctrlUserDetails1.Size = new System.Drawing.Size(751, 414);
            this.ctrlUserDetails1.TabIndex = 112;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1005, 770);
            this.Controls.Add(this.ctrlUserDetails1);
            this.Controls.Add(this.pnlLicences);
            this.Controls.Add(this.pnlUsersInfo);
            this.Controls.Add(this.pnlDriversInfo);
            this.Controls.Add(this.pnlPeopleInfo);
            this.Controls.Add(this.lblFormHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashboard";
            this.Text = "frmDashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.pnlPeopleInfo.ResumeLayout(false);
            this.pnlPeopleInfo.PerformLayout();
            this.pnlDriversInfo.ResumeLayout(false);
            this.pnlDriversInfo.PerformLayout();
            this.pnlUsersInfo.ResumeLayout(false);
            this.pnlUsersInfo.PerformLayout();
            this.pnlLicences.ResumeLayout(false);
            this.pnlLicences.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormHeader;
        private System.Windows.Forms.Panel pnlPeopleInfo;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label lblPeopleNumber;
        private System.Windows.Forms.Label lblNumOfMales;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumOfFemales;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlDriversInfo;
        private System.Windows.Forms.Label lblNumOfFemaleDrivers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNumOfMaleDrivers;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNumOfDrivers;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlUsersInfo;
        private System.Windows.Forms.Label lblNumOfInActiveUsers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNumOfActiveUsers;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblNumOfUsers;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel pnlLicences;
        private System.Windows.Forms.Label lblNumOfInActiveLicences;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblNumOfActiveLicences;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblNumOfLicences;
        private System.Windows.Forms.Label label15;
        private ctrlUserDetails ctrlUserDetails1;
    }
}