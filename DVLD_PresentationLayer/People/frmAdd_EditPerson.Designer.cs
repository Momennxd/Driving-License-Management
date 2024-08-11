namespace DVLD_PresentationLayer
{
    partial class frmAdd_EditPerson
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
            this.pnlNationality = new System.Windows.Forms.Panel();
            this.cbNationalities = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pnlEmail = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlPhoneNumber = new System.Windows.Forms.Panel();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlAddress = new System.Windows.Forms.Panel();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlGender = new System.Windows.Forms.Panel();
            this.cbGenders = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlDateOfBirth = new System.Windows.Forms.Panel();
            this.dpDateOfBirth = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlFirstName = new System.Windows.Forms.Panel();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlNationalNo = new System.Windows.Forms.Panel();
            this.txtNationalNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlSecondName = new System.Windows.Forms.Panel();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlThirdName = new System.Windows.Forms.Panel();
            this.txtThirdName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlLastName = new System.Windows.Forms.Panel();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.klblChooseImage = new System.Windows.Forms.LinkLabel();
            this.klblRemoveImage = new System.Windows.Forms.LinkLabel();
            this.pnlPersonLoader = new System.Windows.Forms.Panel();
            this.pnlPerson = new System.Windows.Forms.Panel();
            this.pbPersonPic = new System.Windows.Forms.PictureBox();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.lblFormHeader = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.errorInfoValidation = new System.Windows.Forms.ErrorProvider(this.components);
            this.ofdPersonImagePicker = new System.Windows.Forms.OpenFileDialog();
            this.btnSave = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnCancel = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlNationality.SuspendLayout();
            this.pnlEmail.SuspendLayout();
            this.pnlPhoneNumber.SuspendLayout();
            this.pnlAddress.SuspendLayout();
            this.pnlGender.SuspendLayout();
            this.pnlDateOfBirth.SuspendLayout();
            this.pnlFirstName.SuspendLayout();
            this.pnlNationalNo.SuspendLayout();
            this.pnlSecondName.SuspendLayout();
            this.pnlThirdName.SuspendLayout();
            this.pnlLastName.SuspendLayout();
            this.pnlPersonLoader.SuspendLayout();
            this.pnlPerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorInfoValidation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNationality
            // 
            this.pnlNationality.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(250)))));
            this.pnlNationality.Controls.Add(this.cbNationalities);
            this.pnlNationality.Controls.Add(this.label11);
            this.pnlNationality.Location = new System.Drawing.Point(17, 342);
            this.pnlNationality.Name = "pnlNationality";
            this.pnlNationality.Size = new System.Drawing.Size(276, 38);
            this.pnlNationality.TabIndex = 72;
            // 
            // cbNationalities
            // 
            this.cbNationalities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.cbNationalities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNationalities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbNationalities.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNationalities.ForeColor = System.Drawing.Color.White;
            this.cbNationalities.FormattingEnabled = true;
            this.cbNationalities.Location = new System.Drawing.Point(101, 5);
            this.cbNationalities.Name = "cbNationalities";
            this.cbNationalities.Size = new System.Drawing.Size(163, 28);
            this.cbNationalities.TabIndex = 80;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "Nationality :";
            // 
            // pnlEmail
            // 
            this.pnlEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(250)))));
            this.pnlEmail.Controls.Add(this.txtEmail);
            this.pnlEmail.Controls.Add(this.label10);
            this.pnlEmail.Location = new System.Drawing.Point(15, 298);
            this.pnlEmail.Name = "pnlEmail";
            this.pnlEmail.Size = new System.Drawing.Size(309, 38);
            this.pnlEmail.TabIndex = 71;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(250)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.Location = new System.Drawing.Point(64, 9);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(214, 20);
            this.txtEmail.TabIndex = 78;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Email :";
            // 
            // pnlPhoneNumber
            // 
            this.pnlPhoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(250)))));
            this.pnlPhoneNumber.Controls.Add(this.txtPhoneNumber);
            this.pnlPhoneNumber.Controls.Add(this.label9);
            this.pnlPhoneNumber.Location = new System.Drawing.Point(15, 254);
            this.pnlPhoneNumber.Name = "pnlPhoneNumber";
            this.pnlPhoneNumber.Size = new System.Drawing.Size(344, 38);
            this.pnlPhoneNumber.TabIndex = 70;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(250)))));
            this.txtPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPhoneNumber.Location = new System.Drawing.Point(132, 9);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(177, 20);
            this.txtPhoneNumber.TabIndex = 77;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Phone Number :";
            // 
            // pnlAddress
            // 
            this.pnlAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(250)))));
            this.pnlAddress.Controls.Add(this.txtAddress);
            this.pnlAddress.Controls.Add(this.label8);
            this.pnlAddress.Location = new System.Drawing.Point(16, 152);
            this.pnlAddress.Name = "pnlAddress";
            this.pnlAddress.Size = new System.Drawing.Size(413, 38);
            this.pnlAddress.TabIndex = 67;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(250)))));
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAddress.Location = new System.Drawing.Point(84, 9);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(296, 20);
            this.txtAddress.TabIndex = 76;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Address :";
            // 
            // pnlGender
            // 
            this.pnlGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(250)))));
            this.pnlGender.Controls.Add(this.cbGenders);
            this.pnlGender.Controls.Add(this.label6);
            this.pnlGender.Location = new System.Drawing.Point(278, 108);
            this.pnlGender.Name = "pnlGender";
            this.pnlGender.Size = new System.Drawing.Size(256, 38);
            this.pnlGender.TabIndex = 68;
            // 
            // cbGenders
            // 
            this.cbGenders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.cbGenders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbGenders.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGenders.ForeColor = System.Drawing.Color.White;
            this.cbGenders.FormattingEnabled = true;
            this.cbGenders.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cbGenders.Location = new System.Drawing.Point(75, 5);
            this.cbGenders.Name = "cbGenders";
            this.cbGenders.Size = new System.Drawing.Size(163, 28);
            this.cbGenders.TabIndex = 79;
            this.cbGenders.SelectedIndexChanged += new System.EventHandler(this.cbGenders_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Gender :";
            // 
            // pnlDateOfBirth
            // 
            this.pnlDateOfBirth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(250)))));
            this.pnlDateOfBirth.Controls.Add(this.dpDateOfBirth);
            this.pnlDateOfBirth.Controls.Add(this.label4);
            this.pnlDateOfBirth.Location = new System.Drawing.Point(16, 196);
            this.pnlDateOfBirth.Name = "pnlDateOfBirth";
            this.pnlDateOfBirth.Size = new System.Drawing.Size(373, 52);
            this.pnlDateOfBirth.TabIndex = 65;
            // 
            // dpDateOfBirth
            // 
            this.dpDateOfBirth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.dpDateOfBirth.BorderRadius = 0;
            this.dpDateOfBirth.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpDateOfBirth.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpDateOfBirth.FormatCustom = "dd/MM/yyyy";
            this.dpDateOfBirth.Location = new System.Drawing.Point(121, 9);
            this.dpDateOfBirth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dpDateOfBirth.Name = "dpDateOfBirth";
            this.dpDateOfBirth.Size = new System.Drawing.Size(222, 36);
            this.dpDateOfBirth.TabIndex = 16;
            this.dpDateOfBirth.Value = new System.DateTime(2023, 10, 10, 14, 11, 24, 420);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date Of Birth :";
            // 
            // pnlFirstName
            // 
            this.pnlFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(250)))));
            this.pnlFirstName.Controls.Add(this.txtFirstName);
            this.pnlFirstName.Controls.Add(this.label3);
            this.pnlFirstName.Location = new System.Drawing.Point(16, 20);
            this.pnlFirstName.Name = "pnlFirstName";
            this.pnlFirstName.Size = new System.Drawing.Size(256, 38);
            this.pnlFirstName.TabIndex = 69;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(250)))));
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstName.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFirstName.Location = new System.Drawing.Point(104, 9);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(112, 20);
            this.txtFirstName.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "First Name :";
            // 
            // pnlNationalNo
            // 
            this.pnlNationalNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(250)))));
            this.pnlNationalNo.Controls.Add(this.txtNationalNo);
            this.pnlNationalNo.Controls.Add(this.label2);
            this.pnlNationalNo.Location = new System.Drawing.Point(16, 108);
            this.pnlNationalNo.Name = "pnlNationalNo";
            this.pnlNationalNo.Size = new System.Drawing.Size(256, 38);
            this.pnlNationalNo.TabIndex = 66;
            // 
            // txtNationalNo
            // 
            this.txtNationalNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(250)))));
            this.txtNationalNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNationalNo.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtNationalNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNationalNo.Location = new System.Drawing.Point(149, 9);
            this.txtNationalNo.Name = "txtNationalNo";
            this.txtNationalNo.Size = new System.Drawing.Size(85, 20);
            this.txtNationalNo.TabIndex = 74;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "National Number :";
            // 
            // pnlSecondName
            // 
            this.pnlSecondName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(250)))));
            this.pnlSecondName.Controls.Add(this.txtSecondName);
            this.pnlSecondName.Controls.Add(this.label1);
            this.pnlSecondName.Location = new System.Drawing.Point(16, 64);
            this.pnlSecondName.Name = "pnlSecondName";
            this.pnlSecondName.Size = new System.Drawing.Size(256, 38);
            this.pnlSecondName.TabIndex = 76;
            // 
            // txtSecondName
            // 
            this.txtSecondName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(250)))));
            this.txtSecondName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSecondName.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtSecondName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSecondName.Location = new System.Drawing.Point(122, 9);
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(112, 20);
            this.txtSecondName.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Second Name :";
            // 
            // pnlThirdName
            // 
            this.pnlThirdName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(250)))));
            this.pnlThirdName.Controls.Add(this.txtThirdName);
            this.pnlThirdName.Controls.Add(this.label7);
            this.pnlThirdName.Location = new System.Drawing.Point(278, 20);
            this.pnlThirdName.Name = "pnlThirdName";
            this.pnlThirdName.Size = new System.Drawing.Size(256, 38);
            this.pnlThirdName.TabIndex = 77;
            // 
            // txtThirdName
            // 
            this.txtThirdName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(250)))));
            this.txtThirdName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtThirdName.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtThirdName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtThirdName.Location = new System.Drawing.Point(110, 9);
            this.txtThirdName.Name = "txtThirdName";
            this.txtThirdName.Size = new System.Drawing.Size(112, 20);
            this.txtThirdName.TabIndex = 75;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Third Name :";
            // 
            // pnlLastName
            // 
            this.pnlLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(250)))));
            this.pnlLastName.Controls.Add(this.txtLastName);
            this.pnlLastName.Controls.Add(this.label12);
            this.pnlLastName.Location = new System.Drawing.Point(278, 64);
            this.pnlLastName.Name = "pnlLastName";
            this.pnlLastName.Size = new System.Drawing.Size(256, 38);
            this.pnlLastName.TabIndex = 78;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(250)))));
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLastName.Location = new System.Drawing.Point(110, 9);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(112, 20);
            this.txtLastName.TabIndex = 75;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(4, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 20);
            this.label12.TabIndex = 5;
            this.label12.Text = "Last Name :";
            // 
            // klblChooseImage
            // 
            this.klblChooseImage.AutoSize = true;
            this.klblChooseImage.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblChooseImage.Location = new System.Drawing.Point(581, 200);
            this.klblChooseImage.Name = "klblChooseImage";
            this.klblChooseImage.Size = new System.Drawing.Size(92, 17);
            this.klblChooseImage.TabIndex = 80;
            this.klblChooseImage.TabStop = true;
            this.klblChooseImage.Text = "Choose Image";
            this.klblChooseImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.klblChooseImage_LinkClicked);
            // 
            // klblRemoveImage
            // 
            this.klblRemoveImage.AutoSize = true;
            this.klblRemoveImage.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblRemoveImage.Location = new System.Drawing.Point(578, 173);
            this.klblRemoveImage.Name = "klblRemoveImage";
            this.klblRemoveImage.Size = new System.Drawing.Size(95, 17);
            this.klblRemoveImage.TabIndex = 79;
            this.klblRemoveImage.TabStop = true;
            this.klblRemoveImage.Text = "Remove Image";
            this.klblRemoveImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.klblRemoveImage_LinkClicked);
            // 
            // pnlPersonLoader
            // 
            this.pnlPersonLoader.Controls.Add(this.pnlPerson);
            this.pnlPersonLoader.Controls.Add(this.btnGoBack);
            this.pnlPersonLoader.Controls.Add(this.lblFormHeader);
            this.pnlPersonLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPersonLoader.Location = new System.Drawing.Point(0, 0);
            this.pnlPersonLoader.Name = "pnlPersonLoader";
            this.pnlPersonLoader.Size = new System.Drawing.Size(1005, 770);
            this.pnlPersonLoader.TabIndex = 81;
            // 
            // pnlPerson
            // 
            this.pnlPerson.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlPerson.Controls.Add(this.btnCancel);
            this.pnlPerson.Controls.Add(this.btnSave);
            this.pnlPerson.Controls.Add(this.pnlFirstName);
            this.pnlPerson.Controls.Add(this.pbPersonPic);
            this.pnlPerson.Controls.Add(this.pnlThirdName);
            this.pnlPerson.Controls.Add(this.pnlNationality);
            this.pnlPerson.Controls.Add(this.pnlSecondName);
            this.pnlPerson.Controls.Add(this.klblChooseImage);
            this.pnlPerson.Controls.Add(this.pnlDateOfBirth);
            this.pnlPerson.Controls.Add(this.pnlEmail);
            this.pnlPerson.Controls.Add(this.pnlLastName);
            this.pnlPerson.Controls.Add(this.pnlNationalNo);
            this.pnlPerson.Controls.Add(this.pnlGender);
            this.pnlPerson.Controls.Add(this.pnlPhoneNumber);
            this.pnlPerson.Controls.Add(this.pnlAddress);
            this.pnlPerson.Controls.Add(this.klblRemoveImage);
            this.pnlPerson.Location = new System.Drawing.Point(124, 140);
            this.pnlPerson.Name = "pnlPerson";
            this.pnlPerson.Size = new System.Drawing.Size(724, 497);
            this.pnlPerson.TabIndex = 83;
            // 
            // pbPersonPic
            // 
            this.pbPersonPic.BackColor = System.Drawing.Color.Transparent;
            this.pbPersonPic.Image = global::DVLD_PresentationLayer.Properties.Resources.MaleUser;
            this.pbPersonPic.Location = new System.Drawing.Point(555, 20);
            this.pbPersonPic.Name = "pbPersonPic";
            this.pbPersonPic.Size = new System.Drawing.Size(143, 144);
            this.pbPersonPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPersonPic.TabIndex = 62;
            this.pbPersonPic.TabStop = false;
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.Transparent;
            this.btnGoBack.BackgroundImage = global::DVLD_PresentationLayer.Properties.Resources.back1;
            this.btnGoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGoBack.FlatAppearance.BorderSize = 0;
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBack.Location = new System.Drawing.Point(5, 18);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(69, 58);
            this.btnGoBack.TabIndex = 82;
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // lblFormHeader
            // 
            this.lblFormHeader.AutoSize = true;
            this.lblFormHeader.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblFormHeader.Location = new System.Drawing.Point(82, 20);
            this.lblFormHeader.Name = "lblFormHeader";
            this.lblFormHeader.Size = new System.Drawing.Size(277, 50);
            this.lblFormHeader.TabIndex = 81;
            this.lblFormHeader.Text = "Update Person";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // errorInfoValidation
            // 
            this.errorInfoValidation.ContainerControl = this;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Image = global::DVLD_PresentationLayer.Properties.Resources.icons8_save_48;
            this.btnSave.ImageActive = null;
            this.btnSave.Location = new System.Drawing.Point(253, 426);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(71, 52);
            this.btnSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSave.TabIndex = 83;
            this.btnSave.TabStop = false;
            this.btnSave.Zoom = 10;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Image = global::DVLD_PresentationLayer.Properties.Resources.exit7;
            this.btnCancel.ImageActive = null;
            this.btnCancel.Location = new System.Drawing.Point(417, 426);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(71, 52);
            this.btnCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCancel.TabIndex = 84;
            this.btnCancel.TabStop = false;
            this.btnCancel.Zoom = 10;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAdd_EditPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 770);
            this.Controls.Add(this.pnlPersonLoader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdd_EditPerson";
            this.Text = "frmAdd_EditPerson";
            this.Load += new System.EventHandler(this.frmAdd_EditPerson_Load);
            this.pnlNationality.ResumeLayout(false);
            this.pnlNationality.PerformLayout();
            this.pnlEmail.ResumeLayout(false);
            this.pnlEmail.PerformLayout();
            this.pnlPhoneNumber.ResumeLayout(false);
            this.pnlPhoneNumber.PerformLayout();
            this.pnlAddress.ResumeLayout(false);
            this.pnlAddress.PerformLayout();
            this.pnlGender.ResumeLayout(false);
            this.pnlGender.PerformLayout();
            this.pnlDateOfBirth.ResumeLayout(false);
            this.pnlDateOfBirth.PerformLayout();
            this.pnlFirstName.ResumeLayout(false);
            this.pnlFirstName.PerformLayout();
            this.pnlNationalNo.ResumeLayout(false);
            this.pnlNationalNo.PerformLayout();
            this.pnlSecondName.ResumeLayout(false);
            this.pnlSecondName.PerformLayout();
            this.pnlThirdName.ResumeLayout(false);
            this.pnlThirdName.PerformLayout();
            this.pnlLastName.ResumeLayout(false);
            this.pnlLastName.PerformLayout();
            this.pnlPersonLoader.ResumeLayout(false);
            this.pnlPersonLoader.PerformLayout();
            this.pnlPerson.ResumeLayout(false);
            this.pnlPerson.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorInfoValidation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNationality;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel pnlEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pnlPhoneNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlGender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlDateOfBirth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlNationalNo;
        private System.Windows.Forms.TextBox txtNationalNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbPersonPic;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Panel pnlSecondName;
        private System.Windows.Forms.TextBox txtSecondName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlThirdName;
        private System.Windows.Forms.TextBox txtThirdName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuDatepicker dpDateOfBirth;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ComboBox cbGenders;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.LinkLabel klblChooseImage;
        private System.Windows.Forms.LinkLabel klblRemoveImage;
        private System.Windows.Forms.Panel pnlPersonLoader;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Label lblFormHeader;
        private System.Windows.Forms.Panel pnlPerson;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ErrorProvider errorInfoValidation;
        private System.Windows.Forms.OpenFileDialog ofdPersonImagePicker;
        private System.Windows.Forms.ComboBox cbNationalities;
        private Bunifu.Framework.UI.BunifuImageButton btnSave;
        private Bunifu.Framework.UI.BunifuImageButton btnCancel;
    }
}