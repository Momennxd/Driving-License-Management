namespace DVLD_PresentationLayer.Applications.Driving_Licence_Services.Replace_licence_for_lost_or_damaged
{
    partial class frmReplaceLicence
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReplaceLicence));
            this.pnlIntLicenceLoader = new System.Windows.Forms.Panel();
            this.gbLicenceAppType = new System.Windows.Forms.GroupBox();
            this.rbDamaged = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbLost = new MaterialSkin.Controls.MaterialRadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pnlTotalFees = new System.Windows.Forms.Panel();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlNewLicenceFees = new System.Windows.Forms.Panel();
            this.lblNewLicnceFees = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlAppFees = new System.Windows.Forms.Panel();
            this.lblAppFees = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnSave = new Bunifu.Framework.UI.BunifuImageButton();
            this.ctrlLicenceInfo1 = new DVLD_PresentationLayer.Licences.ctrlLicenceInfo();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.lblFormHeader = new System.Windows.Forms.Label();
            this.btnClearSearchBar = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblSearchBar = new System.Windows.Forms.Label();
            this.txtSearchBar = new Bunifu.Framework.UI.BunifuTextbox();
            this.btnSearch = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlIntLicenceLoader.SuspendLayout();
            this.gbLicenceAppType.SuspendLayout();
            this.pnlTotalFees.SuspendLayout();
            this.pnlNewLicenceFees.SuspendLayout();
            this.pnlAppFees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClearSearchBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlIntLicenceLoader
            // 
            this.pnlIntLicenceLoader.Controls.Add(this.gbLicenceAppType);
            this.pnlIntLicenceLoader.Controls.Add(this.pnlTotalFees);
            this.pnlIntLicenceLoader.Controls.Add(this.pnlNewLicenceFees);
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
            // gbLicenceAppType
            // 
            this.gbLicenceAppType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbLicenceAppType.Controls.Add(this.rbDamaged);
            this.gbLicenceAppType.Controls.Add(this.rbLost);
            this.gbLicenceAppType.Controls.Add(this.label11);
            this.gbLicenceAppType.Controls.Add(this.label12);
            this.gbLicenceAppType.Location = new System.Drawing.Point(663, 345);
            this.gbLicenceAppType.Name = "gbLicenceAppType";
            this.gbLicenceAppType.Size = new System.Drawing.Size(220, 79);
            this.gbLicenceAppType.TabIndex = 95;
            this.gbLicenceAppType.TabStop = false;
            // 
            // rbDamaged
            // 
            this.rbDamaged.AutoSize = true;
            this.rbDamaged.Depth = 0;
            this.rbDamaged.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbDamaged.Location = new System.Drawing.Point(180, 43);
            this.rbDamaged.Margin = new System.Windows.Forms.Padding(0);
            this.rbDamaged.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbDamaged.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbDamaged.Name = "rbDamaged";
            this.rbDamaged.Ripple = true;
            this.rbDamaged.Size = new System.Drawing.Size(35, 37);
            this.rbDamaged.TabIndex = 96;
            this.rbDamaged.TabStop = true;
            this.rbDamaged.UseVisualStyleBackColor = true;
            this.rbDamaged.Click += new System.EventHandler(this.rbReplacementType_CheckedChanged);
            // 
            // rbLost
            // 
            this.rbLost.AutoSize = true;
            this.rbLost.Checked = true;
            this.rbLost.Depth = 0;
            this.rbLost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbLost.Location = new System.Drawing.Point(180, 6);
            this.rbLost.Margin = new System.Windows.Forms.Padding(0);
            this.rbLost.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbLost.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbLost.Name = "rbLost";
            this.rbLost.Ripple = true;
            this.rbLost.Size = new System.Drawing.Size(35, 37);
            this.rbLost.TabIndex = 95;
            this.rbLost.TabStop = true;
            this.rbLost.UseVisualStyleBackColor = true;
            this.rbLost.Click += new System.EventHandler(this.rbReplacementType_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(169, 20);
            this.label11.TabIndex = 7;
            this.label11.Text = "Replace For Damaged :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 20);
            this.label12.TabIndex = 5;
            this.label12.Text = "Replace For Lost :";
            // 
            // pnlTotalFees
            // 
            this.pnlTotalFees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(250)))));
            this.pnlTotalFees.Controls.Add(this.lblTotalFees);
            this.pnlTotalFees.Controls.Add(this.label4);
            this.pnlTotalFees.Location = new System.Drawing.Point(605, 553);
            this.pnlTotalFees.Name = "pnlTotalFees";
            this.pnlTotalFees.Size = new System.Drawing.Size(269, 38);
            this.pnlTotalFees.TabIndex = 91;
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalFees.Location = new System.Drawing.Point(96, 9);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(24, 20);
            this.lblTotalFees.TabIndex = 6;
            this.lblTotalFees.Text = "-1";
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
            // pnlNewLicenceFees
            // 
            this.pnlNewLicenceFees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(250)))));
            this.pnlNewLicenceFees.Controls.Add(this.lblNewLicnceFees);
            this.pnlNewLicenceFees.Controls.Add(this.label2);
            this.pnlNewLicenceFees.Location = new System.Drawing.Point(366, 553);
            this.pnlNewLicenceFees.Name = "pnlNewLicenceFees";
            this.pnlNewLicenceFees.Size = new System.Drawing.Size(233, 38);
            this.pnlNewLicenceFees.TabIndex = 90;
            // 
            // lblNewLicnceFees
            // 
            this.lblNewLicnceFees.AutoSize = true;
            this.lblNewLicnceFees.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewLicnceFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNewLicnceFees.Location = new System.Drawing.Point(149, 9);
            this.lblNewLicnceFees.Name = "lblNewLicnceFees";
            this.lblNewLicnceFees.Size = new System.Drawing.Size(24, 20);
            this.lblNewLicnceFees.TabIndex = 6;
            this.lblNewLicnceFees.Text = "-1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "New Licence Fees :";
            // 
            // pnlAppFees
            // 
            this.pnlAppFees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(250)))));
            this.pnlAppFees.Controls.Add(this.lblAppFees);
            this.pnlAppFees.Controls.Add(this.label3);
            this.pnlAppFees.Location = new System.Drawing.Point(123, 553);
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
            this.lblAppFees.Size = new System.Drawing.Size(24, 20);
            this.lblAppFees.TabIndex = 6;
            this.lblAppFees.Text = "-1";
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
            this.btnCancel.Location = new System.Drawing.Point(351, 637);
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
            this.btnSave.Location = new System.Drawing.Point(537, 637);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(71, 52);
            this.btnSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSave.TabIndex = 87;
            this.btnSave.TabStop = false;
            this.btnSave.Zoom = 10;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ctrlLicenceInfo1
            // 
            this.ctrlLicenceInfo1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ctrlLicenceInfo1.Location = new System.Drawing.Point(111, 128);
            this.ctrlLicenceInfo1.Name = "ctrlLicenceInfo1";
            this.ctrlLicenceInfo1.Size = new System.Drawing.Size(780, 418);
            this.ctrlLicenceInfo1.TabIndex = 85;
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
            this.lblFormHeader.Size = new System.Drawing.Size(377, 50);
            this.lblFormHeader.TabIndex = 83;
            this.lblFormHeader.Text = "Replace Lost Licence";
            // 
            // btnClearSearchBar
            // 
            this.btnClearSearchBar.BackColor = System.Drawing.Color.White;
            this.btnClearSearchBar.Image = global::DVLD_PresentationLayer.Properties.Resources.icons8_multiply_50;
            this.btnClearSearchBar.ImageActive = null;
            this.btnClearSearchBar.Location = new System.Drawing.Point(798, 89);
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
            this.lblSearchBar.Location = new System.Drawing.Point(605, 96);
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
            this.txtSearchBar.Location = new System.Drawing.Point(556, 83);
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
            this.btnSearch.Location = new System.Drawing.Point(856, 89);
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
            // frmReplaceLicence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 770);
            this.Controls.Add(this.pnlIntLicenceLoader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReplaceLicence";
            this.Text = "frmReplaceLicence";
            this.Load += new System.EventHandler(this.frmReplaceLicence_Load);
            this.pnlIntLicenceLoader.ResumeLayout(false);
            this.pnlIntLicenceLoader.PerformLayout();
            this.gbLicenceAppType.ResumeLayout(false);
            this.gbLicenceAppType.PerformLayout();
            this.pnlTotalFees.ResumeLayout(false);
            this.pnlTotalFees.PerformLayout();
            this.pnlNewLicenceFees.ResumeLayout(false);
            this.pnlNewLicenceFees.PerformLayout();
            this.pnlAppFees.ResumeLayout(false);
            this.pnlAppFees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClearSearchBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlIntLicenceLoader;
        private System.Windows.Forms.Panel pnlTotalFees;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlNewLicenceFees;
        private System.Windows.Forms.Label lblNewLicnceFees;
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
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.GroupBox gbLicenceAppType;
        private MaterialSkin.Controls.MaterialRadioButton rbDamaged;
        private MaterialSkin.Controls.MaterialRadioButton rbLost;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}