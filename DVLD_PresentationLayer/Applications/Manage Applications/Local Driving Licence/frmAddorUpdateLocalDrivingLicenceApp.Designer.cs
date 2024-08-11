namespace DVLD_PresentationLayer.Applications.Manage_Applications
{
    partial class frmAddorUpdateLocalDrivingLicenceApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddorUpdateLocalDrivingLicenceApp));
            this.pnlLDLAppLoader = new System.Windows.Forms.Panel();
            this.pnlLDLAppInfo = new System.Windows.Forms.Panel();
            this.lblFormHeader = new System.Windows.Forms.Label();
            this.cbSearchFilter = new System.Windows.Forms.ComboBox();
            this.lblSearchBar = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnSave = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnBack = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnNext = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.btnClearSearchBar = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtSearchBar = new Bunifu.Framework.UI.BunifuTextbox();
            this.btnSearch = new Bunifu.Framework.UI.BunifuImageButton();
            this.ctrlPersonDetails = new DVLD_PresentationLayer.ctrlPersonDetails();
            this.pnlLDLAppLoader.SuspendLayout();
            this.pnlLDLAppInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClearSearchBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLDLAppLoader
            // 
            this.pnlLDLAppLoader.Controls.Add(this.btnSave);
            this.pnlLDLAppLoader.Controls.Add(this.btnBack);
            this.pnlLDLAppLoader.Controls.Add(this.btnNext);
            this.pnlLDLAppLoader.Controls.Add(this.pnlLDLAppInfo);
            this.pnlLDLAppLoader.Controls.Add(this.btnGoBack);
            this.pnlLDLAppLoader.Controls.Add(this.lblFormHeader);
            this.pnlLDLAppLoader.Controls.Add(this.btnClearSearchBar);
            this.pnlLDLAppLoader.Controls.Add(this.cbSearchFilter);
            this.pnlLDLAppLoader.Controls.Add(this.lblSearchBar);
            this.pnlLDLAppLoader.Controls.Add(this.txtSearchBar);
            this.pnlLDLAppLoader.Controls.Add(this.btnSearch);
            this.pnlLDLAppLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLDLAppLoader.Location = new System.Drawing.Point(0, 0);
            this.pnlLDLAppLoader.Name = "pnlLDLAppLoader";
            this.pnlLDLAppLoader.Size = new System.Drawing.Size(1005, 770);
            this.pnlLDLAppLoader.TabIndex = 46;
            // 
            // pnlLDLAppInfo
            // 
            this.pnlLDLAppInfo.BackColor = System.Drawing.Color.White;
            this.pnlLDLAppInfo.Controls.Add(this.ctrlPersonDetails);
            this.pnlLDLAppInfo.Location = new System.Drawing.Point(126, 189);
            this.pnlLDLAppInfo.Name = "pnlLDLAppInfo";
            this.pnlLDLAppInfo.Size = new System.Drawing.Size(746, 380);
            this.pnlLDLAppInfo.TabIndex = 85;
            // 
            // lblFormHeader
            // 
            this.lblFormHeader.AutoSize = true;
            this.lblFormHeader.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblFormHeader.Location = new System.Drawing.Point(87, 18);
            this.lblFormHeader.Name = "lblFormHeader";
            this.lblFormHeader.Size = new System.Drawing.Size(381, 50);
            this.lblFormHeader.TabIndex = 83;
            this.lblFormHeader.Text = "Add LDL Application";
            // 
            // cbSearchFilter
            // 
            this.cbSearchFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.cbSearchFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSearchFilter.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearchFilter.ForeColor = System.Drawing.Color.White;
            this.cbSearchFilter.FormattingEnabled = true;
            this.cbSearchFilter.Items.AddRange(new object[] {
            "PersonID",
            "National No"});
            this.cbSearchFilter.Location = new System.Drawing.Point(733, 150);
            this.cbSearchFilter.Name = "cbSearchFilter";
            this.cbSearchFilter.Size = new System.Drawing.Size(131, 28);
            this.cbSearchFilter.TabIndex = 39;
            // 
            // lblSearchBar
            // 
            this.lblSearchBar.AutoSize = true;
            this.lblSearchBar.BackColor = System.Drawing.Color.White;
            this.lblSearchBar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(202)))), ((int)(((byte)(219)))));
            this.lblSearchBar.Location = new System.Drawing.Point(183, 150);
            this.lblSearchBar.Name = "lblSearchBar";
            this.lblSearchBar.Size = new System.Drawing.Size(56, 19);
            this.lblSearchBar.TabIndex = 43;
            this.lblSearchBar.Text = "Search";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 6;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Image = global::DVLD_PresentationLayer.Properties.Resources.icons8_save_48;
            this.btnSave.ImageActive = null;
            this.btnSave.Location = new System.Drawing.Point(460, 575);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(71, 52);
            this.btnSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSave.TabIndex = 87;
            this.btnSave.TabStop = false;
            this.btnSave.Visible = false;
            this.btnSave.Zoom = 10;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.color = System.Drawing.Color.WhiteSmoke;
            this.btnBack.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Enabled = false;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Image = global::DVLD_PresentationLayer.Properties.Resources.icons8_next_48__1_;
            this.btnBack.ImagePosition = 13;
            this.btnBack.ImageZoom = 50;
            this.btnBack.LabelPosition = 26;
            this.btnBack.LabelText = "Back";
            this.btnBack.Location = new System.Drawing.Point(68, 328);
            this.btnBack.Margin = new System.Windows.Forms.Padding(6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(49, 71);
            this.btnBack.TabIndex = 86;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNext.color = System.Drawing.Color.WhiteSmoke;
            this.btnNext.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Enabled = false;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Image = global::DVLD_PresentationLayer.Properties.Resources.icons8_next_481;
            this.btnNext.ImagePosition = 13;
            this.btnNext.ImageZoom = 50;
            this.btnNext.LabelPosition = 26;
            this.btnNext.LabelText = "Next";
            this.btnNext.Location = new System.Drawing.Point(890, 328);
            this.btnNext.Margin = new System.Windows.Forms.Padding(6);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(49, 71);
            this.btnNext.TabIndex = 45;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
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
            // btnClearSearchBar
            // 
            this.btnClearSearchBar.BackColor = System.Drawing.Color.White;
            this.btnClearSearchBar.Image = global::DVLD_PresentationLayer.Properties.Resources.icons8_multiply_50;
            this.btnClearSearchBar.ImageActive = null;
            this.btnClearSearchBar.Location = new System.Drawing.Point(377, 143);
            this.btnClearSearchBar.Name = "btnClearSearchBar";
            this.btnClearSearchBar.Size = new System.Drawing.Size(41, 34);
            this.btnClearSearchBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClearSearchBar.TabIndex = 41;
            this.btnClearSearchBar.TabStop = false;
            this.btnClearSearchBar.Zoom = 10;
            this.btnClearSearchBar.Click += new System.EventHandler(this.btnClearSearchBar_Click);
            // 
            // txtSearchBar
            // 
            this.txtSearchBar.BackColor = System.Drawing.Color.White;
            this.txtSearchBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearchBar.BackgroundImage")));
            this.txtSearchBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtSearchBar.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(206)))));
            this.txtSearchBar.Icon = ((System.Drawing.Image)(resources.GetObject("txtSearchBar.Icon")));
            this.txtSearchBar.Location = new System.Drawing.Point(135, 137);
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
            this.btnSearch.Location = new System.Drawing.Point(435, 143);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(39, 34);
            this.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSearch.TabIndex = 42;
            this.btnSearch.TabStop = false;
            this.btnSearch.Zoom = 10;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ctrlPersonDetails
            // 
            this.ctrlPersonDetails.BackColor = System.Drawing.Color.White;
            this.ctrlPersonDetails.Location = new System.Drawing.Point(12, 7);
            this.ctrlPersonDetails.Name = "ctrlPersonDetails";
            this.ctrlPersonDetails.Size = new System.Drawing.Size(719, 362);
            this.ctrlPersonDetails.TabIndex = 44;
            // 
            // frmAddorUpdateLocalDrivingLicenceApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 770);
            this.Controls.Add(this.pnlLDLAppLoader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddorUpdateLocalDrivingLicenceApp";
            this.Text = "frmAddLocalDrivingLicenceApp";
            this.Load += new System.EventHandler(this.frmAddorUpdateLocalDrivingLicenceApp_Load);
            this.pnlLDLAppLoader.ResumeLayout(false);
            this.pnlLDLAppLoader.PerformLayout();
            this.pnlLDLAppInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClearSearchBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLDLAppLoader;
        private Bunifu.Framework.UI.BunifuImageButton btnSave;
        private Bunifu.Framework.UI.BunifuTileButton btnBack;
        private Bunifu.Framework.UI.BunifuTileButton btnNext;
        private System.Windows.Forms.Panel pnlLDLAppInfo;
        private ctrlPersonDetails ctrlPersonDetails;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Label lblFormHeader;
        private Bunifu.Framework.UI.BunifuImageButton btnClearSearchBar;
        private System.Windows.Forms.ComboBox cbSearchFilter;
        private System.Windows.Forms.Label lblSearchBar;
        private Bunifu.Framework.UI.BunifuTextbox txtSearchBar;
        private Bunifu.Framework.UI.BunifuImageButton btnSearch;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}