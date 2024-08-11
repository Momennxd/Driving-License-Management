namespace DVLD_PresentationLayer.Applications.Detain_Licences
{
    partial class frmDetainAndReleaseLicence
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetainAndReleaseLicence));
            this.pnlIntLicenceLoader = new System.Windows.Forms.Panel();
            this.pnlTotalFees = new System.Windows.Forms.Panel();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlDetainLicenceFees = new System.Windows.Forms.Panel();
            this.txtDetainFees = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlAppFees = new System.Windows.Forms.Panel();
            this.lblAppFees = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnSave = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.lblFormHeader = new System.Windows.Forms.Label();
            this.btnClearSearchBar = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblSearchBar = new System.Windows.Forms.Label();
            this.txtSearchBar = new Bunifu.Framework.UI.BunifuTextbox();
            this.btnSearch = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ctrlLicenceInfo1 = new DVLD_PresentationLayer.Licences.ctrlLicenceInfo();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlIntLicenceLoader.SuspendLayout();
            this.pnlTotalFees.SuspendLayout();
            this.pnlDetainLicenceFees.SuspendLayout();
            this.pnlAppFees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClearSearchBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlIntLicenceLoader
            // 
            this.pnlIntLicenceLoader.Controls.Add(this.pnlTotalFees);
            this.pnlIntLicenceLoader.Controls.Add(this.pnlDetainLicenceFees);
            this.pnlIntLicenceLoader.Controls.Add(this.pnlAppFees);
            this.pnlIntLicenceLoader.Controls.Add(this.btnCancel);
            this.pnlIntLicenceLoader.Controls.Add(this.btnSave);
            this.pnlIntLicenceLoader.Controls.Add(this.ctrlLicenceInfo1);
            this.pnlIntLicenceLoader.Controls.Add(this.btnGoBack);
            this.pnlIntLicenceLoader.Controls.Add(this.lblFormHeader);
            this.pnlIntLicenceLoader.Controls.Add(this.btnClearSearchBar);
            this.pnlIntLicenceLoader.Controls.Add(this.lblSearchBar);
            this.pnlIntLicenceLoader.Controls.Add(this.txtSearchBar);
            this.pnlIntLicenceLoader.Controls.Add(this.btnSearch);
            this.pnlIntLicenceLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlIntLicenceLoader.Location = new System.Drawing.Point(0, 0);
            this.pnlIntLicenceLoader.Name = "pnlIntLicenceLoader";
            this.pnlIntLicenceLoader.Size = new System.Drawing.Size(1005, 770);
            this.pnlIntLicenceLoader.TabIndex = 48;
            // 
            // pnlTotalFees
            // 
            this.pnlTotalFees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(250)))));
            this.pnlTotalFees.Controls.Add(this.lblTotalFees);
            this.pnlTotalFees.Controls.Add(this.label4);
            this.pnlTotalFees.Location = new System.Drawing.Point(652, 559);
            this.pnlTotalFees.Name = "pnlTotalFees";
            this.pnlTotalFees.Size = new System.Drawing.Size(231, 38);
            this.pnlTotalFees.TabIndex = 91;
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalFees.Location = new System.Drawing.Point(96, 9);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(18, 20);
            this.lblTotalFees.TabIndex = 6;
            this.lblTotalFees.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total Fees :";
            // 
            // pnlDetainLicenceFees
            // 
            this.pnlDetainLicenceFees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(250)))));
            this.pnlDetainLicenceFees.Controls.Add(this.txtDetainFees);
            this.pnlDetainLicenceFees.Controls.Add(this.label2);
            this.pnlDetainLicenceFees.Location = new System.Drawing.Point(375, 559);
            this.pnlDetainLicenceFees.Name = "pnlDetainLicenceFees";
            this.pnlDetainLicenceFees.Size = new System.Drawing.Size(271, 38);
            this.pnlDetainLicenceFees.TabIndex = 90;
            // 
            // txtDetainFees
            // 
            this.txtDetainFees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(250)))));
            this.txtDetainFees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDetainFees.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtDetainFees.Location = new System.Drawing.Point(107, 9);
            this.txtDetainFees.Name = "txtDetainFees";
            this.txtDetainFees.Size = new System.Drawing.Size(138, 20);
            this.txtDetainFees.TabIndex = 92;
            this.txtDetainFees.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Detain Fees :";
            // 
            // pnlAppFees
            // 
            this.pnlAppFees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(250)))));
            this.pnlAppFees.Controls.Add(this.lblAppFees);
            this.pnlAppFees.Controls.Add(this.label3);
            this.pnlAppFees.Location = new System.Drawing.Point(132, 559);
            this.pnlAppFees.Name = "pnlAppFees";
            this.pnlAppFees.Size = new System.Drawing.Size(237, 38);
            this.pnlAppFees.TabIndex = 89;
            // 
            // lblAppFees
            // 
            this.lblAppFees.AutoSize = true;
            this.lblAppFees.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAppFees.Location = new System.Drawing.Point(142, 9);
            this.lblAppFees.Name = "lblAppFees";
            this.lblAppFees.Size = new System.Drawing.Size(18, 20);
            this.lblAppFees.TabIndex = 6;
            this.lblAppFees.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Application Fees :";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Image = global::DVLD_PresentationLayer.Properties.Resources.exit7;
            this.btnCancel.ImageActive = null;
            this.btnCancel.Location = new System.Drawing.Point(372, 650);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(71, 52);
            this.btnCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCancel.TabIndex = 88;
            this.btnCancel.TabStop = false;
            this.btnCancel.Zoom = 10;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Enabled = false;
            this.btnSave.Image = global::DVLD_PresentationLayer.Properties.Resources.icons8_save_48;
            this.btnSave.ImageActive = null;
            this.btnSave.Location = new System.Drawing.Point(558, 650);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(71, 52);
            this.btnSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSave.TabIndex = 87;
            this.btnSave.TabStop = false;
            this.btnSave.Zoom = 10;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.Transparent;
            this.btnGoBack.BackgroundImage = global::DVLD_PresentationLayer.Properties.Resources.back1;
            this.btnGoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGoBack.FlatAppearance.BorderSize = 0;
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBack.Location = new System.Drawing.Point(10, 16);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(69, 58);
            this.btnGoBack.TabIndex = 84;
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // lblFormHeader
            // 
            this.lblFormHeader.AutoSize = true;
            this.lblFormHeader.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblFormHeader.Location = new System.Drawing.Point(87, 18);
            this.lblFormHeader.Name = "lblFormHeader";
            this.lblFormHeader.Size = new System.Drawing.Size(413, 50);
            this.lblFormHeader.TabIndex = 83;
            this.lblFormHeader.Text = "Detain Driving Licence";
            // 
            // btnClearSearchBar
            // 
            this.btnClearSearchBar.BackColor = System.Drawing.Color.White;
            this.btnClearSearchBar.Image = global::DVLD_PresentationLayer.Properties.Resources.icons8_multiply_50;
            this.btnClearSearchBar.ImageActive = null;
            this.btnClearSearchBar.Location = new System.Drawing.Point(788, 94);
            this.btnClearSearchBar.Name = "btnClearSearchBar";
            this.btnClearSearchBar.Size = new System.Drawing.Size(41, 34);
            this.btnClearSearchBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClearSearchBar.TabIndex = 41;
            this.btnClearSearchBar.TabStop = false;
            this.btnClearSearchBar.Zoom = 10;
            this.btnClearSearchBar.Click += new System.EventHandler(this.btnClearSearchBar_Click);
            // 
            // lblSearchBar
            // 
            this.lblSearchBar.AutoSize = true;
            this.lblSearchBar.BackColor = System.Drawing.Color.White;
            this.lblSearchBar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(202)))), ((int)(((byte)(219)))));
            this.lblSearchBar.Location = new System.Drawing.Point(595, 101);
            this.lblSearchBar.Name = "lblSearchBar";
            this.lblSearchBar.Size = new System.Drawing.Size(92, 19);
            this.lblSearchBar.TabIndex = 43;
            this.lblSearchBar.Text = "Licence ID..";
            // 
            // txtSearchBar
            // 
            this.txtSearchBar.BackColor = System.Drawing.Color.White;
            this.txtSearchBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearchBar.BackgroundImage")));
            this.txtSearchBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtSearchBar.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(206)))));
            this.txtSearchBar.Icon = ((System.Drawing.Image)(resources.GetObject("txtSearchBar.Icon")));
            this.txtSearchBar.Location = new System.Drawing.Point(546, 88);
            this.txtSearchBar.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearchBar.Name = "txtSearchBar";
            this.txtSearchBar.Size = new System.Drawing.Size(292, 46);
            this.txtSearchBar.TabIndex = 40;
            this.txtSearchBar.text = "";
            this.txtSearchBar.OnTextChange += new System.EventHandler(this.txtSearchBar_OnTextChange);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.Image = global::DVLD_PresentationLayer.Properties.Resources.icons8_search_24;
            this.btnSearch.ImageActive = null;
            this.btnSearch.Location = new System.Drawing.Point(846, 94);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(39, 34);
            this.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSearch.TabIndex = 42;
            this.btnSearch.TabStop = false;
            this.btnSearch.Zoom = 10;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 6;
            this.bunifuElipse1.TargetControl = this;
            // 
            // ctrlLicenceInfo1
            // 
            this.ctrlLicenceInfo1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ctrlLicenceInfo1.Location = new System.Drawing.Point(132, 135);
            this.ctrlLicenceInfo1.Name = "ctrlLicenceInfo1";
            this.ctrlLicenceInfo1.Size = new System.Drawing.Size(751, 418);
            this.ctrlLicenceInfo1.TabIndex = 85;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmDetainAndReleaseLicence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 770);
            this.Controls.Add(this.pnlIntLicenceLoader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDetainAndReleaseLicence";
            this.Text = "frmDetainLicence";
            this.Load += new System.EventHandler(this.frmDetainLicence_Load);
            this.pnlIntLicenceLoader.ResumeLayout(false);
            this.pnlIntLicenceLoader.PerformLayout();
            this.pnlTotalFees.ResumeLayout(false);
            this.pnlTotalFees.PerformLayout();
            this.pnlDetainLicenceFees.ResumeLayout(false);
            this.pnlDetainLicenceFees.PerformLayout();
            this.pnlAppFees.ResumeLayout(false);
            this.pnlAppFees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClearSearchBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlIntLicenceLoader;
        private System.Windows.Forms.Panel pnlTotalFees;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlDetainLicenceFees;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlAppFees;
        private System.Windows.Forms.Label lblAppFees;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuImageButton btnCancel;
        private Bunifu.Framework.UI.BunifuImageButton btnSave;
        private Licences.ctrlLicenceInfo ctrlLicenceInfo1;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Label lblFormHeader;
        private Bunifu.Framework.UI.BunifuImageButton btnClearSearchBar;
        private System.Windows.Forms.Label lblSearchBar;
        private Bunifu.Framework.UI.BunifuTextbox txtSearchBar;
        private Bunifu.Framework.UI.BunifuImageButton btnSearch;
        private System.Windows.Forms.TextBox txtDetainFees;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}