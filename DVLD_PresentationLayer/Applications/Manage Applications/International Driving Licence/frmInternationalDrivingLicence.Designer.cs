namespace DVLD_PresentationLayer.Applications.Manage_Applications.International_Driving_Licence
{
    partial class frmInternationalDrivingLicence
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInternationalDrivingLicence));
            this.pnlIntApplicationsLoader = new System.Windows.Forms.Panel();
            this.cbSearchFilter = new System.Windows.Forms.ComboBox();
            this.lblSearchBar = new System.Windows.Forms.Label();
            this.lblFormHeader = new System.Windows.Forms.Label();
            this.dgIntLicences = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.cmsIntLicenceOperationsList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnInActive = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnActive = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAddNewIntApp = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnClearSearchBar = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtSearchBar = new Bunifu.Framework.UI.BunifuTextbox();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.itemShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlIntApplicationsLoader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgIntLicences)).BeginInit();
            this.cmsIntLicenceOperationsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddNewIntApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClearSearchBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlIntApplicationsLoader
            // 
            this.pnlIntApplicationsLoader.Controls.Add(this.btnInActive);
            this.pnlIntApplicationsLoader.Controls.Add(this.btnActive);
            this.pnlIntApplicationsLoader.Controls.Add(this.btnAddNewIntApp);
            this.pnlIntApplicationsLoader.Controls.Add(this.cbSearchFilter);
            this.pnlIntApplicationsLoader.Controls.Add(this.btnClearSearchBar);
            this.pnlIntApplicationsLoader.Controls.Add(this.lblSearchBar);
            this.pnlIntApplicationsLoader.Controls.Add(this.txtSearchBar);
            this.pnlIntApplicationsLoader.Controls.Add(this.lblFormHeader);
            this.pnlIntApplicationsLoader.Controls.Add(this.btnGoBack);
            this.pnlIntApplicationsLoader.Controls.Add(this.dgIntLicences);
            this.pnlIntApplicationsLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlIntApplicationsLoader.Location = new System.Drawing.Point(0, 0);
            this.pnlIntApplicationsLoader.Name = "pnlIntApplicationsLoader";
            this.pnlIntApplicationsLoader.Size = new System.Drawing.Size(1005, 770);
            this.pnlIntApplicationsLoader.TabIndex = 89;
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
            "International Licence ID",
            "Application ID",
            "Local License ID",
            "Driver ID"});
            this.cbSearchFilter.Location = new System.Drawing.Point(724, 143);
            this.cbSearchFilter.Name = "cbSearchFilter";
            this.cbSearchFilter.Size = new System.Drawing.Size(198, 28);
            this.cbSearchFilter.TabIndex = 89;
            // 
            // lblSearchBar
            // 
            this.lblSearchBar.AutoSize = true;
            this.lblSearchBar.BackColor = System.Drawing.Color.White;
            this.lblSearchBar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(202)))), ((int)(((byte)(219)))));
            this.lblSearchBar.Location = new System.Drawing.Point(60, 150);
            this.lblSearchBar.Name = "lblSearchBar";
            this.lblSearchBar.Size = new System.Drawing.Size(56, 19);
            this.lblSearchBar.TabIndex = 87;
            this.lblSearchBar.Text = "Search";
            // 
            // lblFormHeader
            // 
            this.lblFormHeader.AutoSize = true;
            this.lblFormHeader.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblFormHeader.Location = new System.Drawing.Point(76, 14);
            this.lblFormHeader.Name = "lblFormHeader";
            this.lblFormHeader.Size = new System.Drawing.Size(614, 50);
            this.lblFormHeader.TabIndex = 83;
            this.lblFormHeader.Text = "International Licence Applications";
            // 
            // dgIntLicences
            // 
            this.dgIntLicences.AllowUserToAddRows = false;
            this.dgIntLicences.AllowUserToDeleteRows = false;
            this.dgIntLicences.AllowUserToResizeColumns = false;
            this.dgIntLicences.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgIntLicences.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgIntLicences.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgIntLicences.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgIntLicences.BackgroundColor = System.Drawing.Color.White;
            this.dgIntLicences.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgIntLicences.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgIntLicences.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgIntLicences.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgIntLicences.ColumnHeadersHeight = 40;
            this.dgIntLicences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(144)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgIntLicences.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgIntLicences.DoubleBuffered = true;
            this.dgIntLicences.EnableHeadersVisualStyles = false;
            this.dgIntLicences.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.dgIntLicences.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.dgIntLicences.Location = new System.Drawing.Point(12, 191);
            this.dgIntLicences.MultiSelect = false;
            this.dgIntLicences.Name = "dgIntLicences";
            this.dgIntLicences.ReadOnly = true;
            this.dgIntLicences.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgIntLicences.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgIntLicences.RowHeadersVisible = false;
            this.dgIntLicences.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgIntLicences.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(247)))));
            this.dgIntLicences.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgIntLicences.RowTemplate.DividerHeight = 1;
            this.dgIntLicences.RowTemplate.Height = 39;
            this.dgIntLicences.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgIntLicences.Size = new System.Drawing.Size(981, 567);
            this.dgIntLicences.TabIndex = 85;
            this.dgIntLicences.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgIntLicences_CellMouseDown);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
            // 
            // cmsIntLicenceOperationsList
            // 
            this.cmsIntLicenceOperationsList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemShowDetails});
            this.cmsIntLicenceOperationsList.Name = "cmsPeopleOperationsList";
            this.cmsIntLicenceOperationsList.Size = new System.Drawing.Size(142, 26);
            // 
            // btnInActive
            // 
            this.btnInActive.ActiveBorderThickness = 1;
            this.btnInActive.ActiveCornerRadius = 10;
            this.btnInActive.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(247)))));
            this.btnInActive.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(144)))), ((int)(((byte)(227)))));
            this.btnInActive.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(144)))), ((int)(((byte)(227)))));
            this.btnInActive.BackColor = System.Drawing.SystemColors.Control;
            this.btnInActive.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInActive.BackgroundImage")));
            this.btnInActive.ButtonText = "InActive";
            this.btnInActive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInActive.ForeColor = System.Drawing.Color.Black;
            this.btnInActive.IdleBorderThickness = 2;
            this.btnInActive.IdleCornerRadius = 10;
            this.btnInActive.IdleFillColor = System.Drawing.Color.White;
            this.btnInActive.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnInActive.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(206)))));
            this.btnInActive.Location = new System.Drawing.Point(422, 131);
            this.btnInActive.Margin = new System.Windows.Forms.Padding(4);
            this.btnInActive.Name = "btnInActive";
            this.btnInActive.Size = new System.Drawing.Size(101, 53);
            this.btnInActive.TabIndex = 92;
            this.btnInActive.Tag = "0";
            this.btnInActive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInActive.Click += new System.EventHandler(this.btnActiveFilter_Click);
            // 
            // btnActive
            // 
            this.btnActive.ActiveBorderThickness = 1;
            this.btnActive.ActiveCornerRadius = 10;
            this.btnActive.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(247)))));
            this.btnActive.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(144)))), ((int)(((byte)(227)))));
            this.btnActive.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(144)))), ((int)(((byte)(227)))));
            this.btnActive.BackColor = System.Drawing.SystemColors.Control;
            this.btnActive.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActive.BackgroundImage")));
            this.btnActive.ButtonText = "Active";
            this.btnActive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActive.ForeColor = System.Drawing.Color.Black;
            this.btnActive.IdleBorderThickness = 2;
            this.btnActive.IdleCornerRadius = 10;
            this.btnActive.IdleFillColor = System.Drawing.Color.White;
            this.btnActive.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnActive.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(206)))));
            this.btnActive.Location = new System.Drawing.Point(313, 131);
            this.btnActive.Margin = new System.Windows.Forms.Padding(4);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(101, 53);
            this.btnActive.TabIndex = 91;
            this.btnActive.Tag = "0";
            this.btnActive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnActive.Click += new System.EventHandler(this.btnActiveFilter_Click);
            // 
            // btnAddNewIntApp
            // 
            this.btnAddNewIntApp.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewIntApp.Image = global::DVLD_PresentationLayer.Properties.Resources.icons8_create_order_48;
            this.btnAddNewIntApp.ImageActive = null;
            this.btnAddNewIntApp.Location = new System.Drawing.Point(937, 137);
            this.btnAddNewIntApp.Name = "btnAddNewIntApp";
            this.btnAddNewIntApp.Size = new System.Drawing.Size(56, 40);
            this.btnAddNewIntApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAddNewIntApp.TabIndex = 90;
            this.btnAddNewIntApp.TabStop = false;
            this.btnAddNewIntApp.Zoom = 10;
            this.btnAddNewIntApp.Click += new System.EventHandler(this.btnAddNewIntApp_Click);
            // 
            // btnClearSearchBar
            // 
            this.btnClearSearchBar.BackColor = System.Drawing.Color.White;
            this.btnClearSearchBar.Image = global::DVLD_PresentationLayer.Properties.Resources.icons8_multiply_50;
            this.btnClearSearchBar.ImageActive = null;
            this.btnClearSearchBar.Location = new System.Drawing.Point(257, 143);
            this.btnClearSearchBar.Name = "btnClearSearchBar";
            this.btnClearSearchBar.Size = new System.Drawing.Size(41, 34);
            this.btnClearSearchBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClearSearchBar.TabIndex = 88;
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
            this.txtSearchBar.Location = new System.Drawing.Point(12, 137);
            this.txtSearchBar.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearchBar.Name = "txtSearchBar";
            this.txtSearchBar.Size = new System.Drawing.Size(292, 46);
            this.txtSearchBar.TabIndex = 86;
            this.txtSearchBar.text = "";
            this.txtSearchBar.OnTextChange += new System.EventHandler(this.txtSearchBar_OnTextChange);
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.Transparent;
            this.btnGoBack.BackgroundImage = global::DVLD_PresentationLayer.Properties.Resources.back1;
            this.btnGoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGoBack.FlatAppearance.BorderSize = 0;
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBack.Location = new System.Drawing.Point(9, 12);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(69, 58);
            this.btnGoBack.TabIndex = 84;
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // itemShowDetails
            // 
            this.itemShowDetails.Image = global::DVLD_PresentationLayer.Properties.Resources.details;
            this.itemShowDetails.Name = "itemShowDetails";
            this.itemShowDetails.Size = new System.Drawing.Size(141, 22);
            this.itemShowDetails.Text = "Show Details";
            this.itemShowDetails.Click += new System.EventHandler(this.itemShowDetails_Click);
            // 
            // frmInternationalDrivingLicence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 770);
            this.Controls.Add(this.pnlIntApplicationsLoader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInternationalDrivingLicence";
            this.Text = "frmInternationalDrivingLicence";
            this.Load += new System.EventHandler(this.frmInternationalDrivingLicence_Load);
            this.pnlIntApplicationsLoader.ResumeLayout(false);
            this.pnlIntApplicationsLoader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgIntLicences)).EndInit();
            this.cmsIntLicenceOperationsList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnAddNewIntApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClearSearchBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlIntApplicationsLoader;
        private Bunifu.Framework.UI.BunifuThinButton2 btnInActive;
        private Bunifu.Framework.UI.BunifuThinButton2 btnActive;
        private Bunifu.Framework.UI.BunifuImageButton btnAddNewIntApp;
        private System.Windows.Forms.ComboBox cbSearchFilter;
        private Bunifu.Framework.UI.BunifuImageButton btnClearSearchBar;
        private System.Windows.Forms.Label lblSearchBar;
        private Bunifu.Framework.UI.BunifuTextbox txtSearchBar;
        private System.Windows.Forms.Label lblFormHeader;
        private System.Windows.Forms.Button btnGoBack;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgIntLicences;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ContextMenuStrip cmsIntLicenceOperationsList;
        private System.Windows.Forms.ToolStripMenuItem itemShowDetails;
    }
}