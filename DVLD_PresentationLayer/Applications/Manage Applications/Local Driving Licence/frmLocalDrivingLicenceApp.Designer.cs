namespace DVLD_PresentationLayer.Applications.Manage_Applications
{
    partial class frmLocalDrivingLicenceApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocalDrivingLicenceApp));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlLocalApplicationsLoader = new System.Windows.Forms.Panel();
            this.btnNew = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCancelled = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCompleted = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAddNewLDLApp = new Bunifu.Framework.UI.BunifuImageButton();
            this.cbSearchFilter = new System.Windows.Forms.ComboBox();
            this.btnClearSearchBar = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblSearchBar = new System.Windows.Forms.Label();
            this.txtSearchBar = new Bunifu.Framework.UI.BunifuTextbox();
            this.lblFormHeader = new System.Windows.Forms.Label();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.dgLocalLicenceApps = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.cmsLDLAppOperationsList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itemShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.itemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.itemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.itemCancelApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.toolScheduleTest = new System.Windows.Forms.ToolStripMenuItem();
            this.subItemScheduleVisionTest = new System.Windows.Forms.ToolStripMenuItem();
            this.subItemscheduleWrittenTest = new System.Windows.Forms.ToolStripMenuItem();
            this.subItemScheduleStreetTest = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.itemIssueDrivingLicence = new System.Windows.Forms.ToolStripMenuItem();
            this.itemShowLicence = new System.Windows.Forms.ToolStripMenuItem();
            this.itemShowPersonLicencesHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlLocalApplicationsLoader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddNewLDLApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClearSearchBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLocalLicenceApps)).BeginInit();
            this.cmsLDLAppOperationsList.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLocalApplicationsLoader
            // 
            this.pnlLocalApplicationsLoader.Controls.Add(this.btnNew);
            this.pnlLocalApplicationsLoader.Controls.Add(this.btnCancelled);
            this.pnlLocalApplicationsLoader.Controls.Add(this.btnCompleted);
            this.pnlLocalApplicationsLoader.Controls.Add(this.btnAddNewLDLApp);
            this.pnlLocalApplicationsLoader.Controls.Add(this.cbSearchFilter);
            this.pnlLocalApplicationsLoader.Controls.Add(this.btnClearSearchBar);
            this.pnlLocalApplicationsLoader.Controls.Add(this.lblSearchBar);
            this.pnlLocalApplicationsLoader.Controls.Add(this.txtSearchBar);
            this.pnlLocalApplicationsLoader.Controls.Add(this.lblFormHeader);
            this.pnlLocalApplicationsLoader.Controls.Add(this.btnGoBack);
            this.pnlLocalApplicationsLoader.Controls.Add(this.dgLocalLicenceApps);
            this.pnlLocalApplicationsLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLocalApplicationsLoader.Location = new System.Drawing.Point(0, 0);
            this.pnlLocalApplicationsLoader.Name = "pnlLocalApplicationsLoader";
            this.pnlLocalApplicationsLoader.Size = new System.Drawing.Size(1005, 770);
            this.pnlLocalApplicationsLoader.TabIndex = 88;
            // 
            // btnNew
            // 
            this.btnNew.ActiveBorderThickness = 1;
            this.btnNew.ActiveCornerRadius = 10;
            this.btnNew.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(247)))));
            this.btnNew.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(144)))), ((int)(((byte)(227)))));
            this.btnNew.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(144)))), ((int)(((byte)(227)))));
            this.btnNew.BackColor = System.Drawing.SystemColors.Control;
            this.btnNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNew.BackgroundImage")));
            this.btnNew.ButtonText = "New";
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.Black;
            this.btnNew.IdleBorderThickness = 2;
            this.btnNew.IdleCornerRadius = 10;
            this.btnNew.IdleFillColor = System.Drawing.Color.White;
            this.btnNew.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnNew.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(206)))));
            this.btnNew.Location = new System.Drawing.Point(531, 131);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(101, 53);
            this.btnNew.TabIndex = 93;
            this.btnNew.Tag = "0";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNew.Click += new System.EventHandler(this.btnStatusFilter_Click);
            // 
            // btnCancelled
            // 
            this.btnCancelled.ActiveBorderThickness = 1;
            this.btnCancelled.ActiveCornerRadius = 10;
            this.btnCancelled.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(247)))));
            this.btnCancelled.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(144)))), ((int)(((byte)(227)))));
            this.btnCancelled.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(144)))), ((int)(((byte)(227)))));
            this.btnCancelled.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelled.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelled.BackgroundImage")));
            this.btnCancelled.ButtonText = "Cancelled";
            this.btnCancelled.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelled.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelled.ForeColor = System.Drawing.Color.Black;
            this.btnCancelled.IdleBorderThickness = 2;
            this.btnCancelled.IdleCornerRadius = 10;
            this.btnCancelled.IdleFillColor = System.Drawing.Color.White;
            this.btnCancelled.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnCancelled.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(206)))));
            this.btnCancelled.Location = new System.Drawing.Point(422, 131);
            this.btnCancelled.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelled.Name = "btnCancelled";
            this.btnCancelled.Size = new System.Drawing.Size(101, 53);
            this.btnCancelled.TabIndex = 92;
            this.btnCancelled.Tag = "0";
            this.btnCancelled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancelled.Click += new System.EventHandler(this.btnStatusFilter_Click);
            // 
            // btnCompleted
            // 
            this.btnCompleted.ActiveBorderThickness = 1;
            this.btnCompleted.ActiveCornerRadius = 10;
            this.btnCompleted.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(247)))));
            this.btnCompleted.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(144)))), ((int)(((byte)(227)))));
            this.btnCompleted.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(144)))), ((int)(((byte)(227)))));
            this.btnCompleted.BackColor = System.Drawing.SystemColors.Control;
            this.btnCompleted.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCompleted.BackgroundImage")));
            this.btnCompleted.ButtonText = "Completed";
            this.btnCompleted.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompleted.ForeColor = System.Drawing.Color.Black;
            this.btnCompleted.IdleBorderThickness = 2;
            this.btnCompleted.IdleCornerRadius = 10;
            this.btnCompleted.IdleFillColor = System.Drawing.Color.White;
            this.btnCompleted.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnCompleted.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(206)))));
            this.btnCompleted.Location = new System.Drawing.Point(313, 131);
            this.btnCompleted.Margin = new System.Windows.Forms.Padding(4);
            this.btnCompleted.Name = "btnCompleted";
            this.btnCompleted.Size = new System.Drawing.Size(101, 53);
            this.btnCompleted.TabIndex = 91;
            this.btnCompleted.Tag = "0";
            this.btnCompleted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCompleted.Click += new System.EventHandler(this.btnStatusFilter_Click);
            // 
            // btnAddNewLDLApp
            // 
            this.btnAddNewLDLApp.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewLDLApp.Image = global::DVLD_PresentationLayer.Properties.Resources.icons8_create_order_48;
            this.btnAddNewLDLApp.ImageActive = null;
            this.btnAddNewLDLApp.Location = new System.Drawing.Point(937, 137);
            this.btnAddNewLDLApp.Name = "btnAddNewLDLApp";
            this.btnAddNewLDLApp.Size = new System.Drawing.Size(56, 40);
            this.btnAddNewLDLApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAddNewLDLApp.TabIndex = 90;
            this.btnAddNewLDLApp.TabStop = false;
            this.btnAddNewLDLApp.Zoom = 10;
            this.btnAddNewLDLApp.Click += new System.EventHandler(this.btnAddNewLDLApp_Click);
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
            "LDL App ID",
            "National No",
            "Full Name"});
            this.cbSearchFilter.Location = new System.Drawing.Point(800, 143);
            this.cbSearchFilter.Name = "cbSearchFilter";
            this.cbSearchFilter.Size = new System.Drawing.Size(131, 28);
            this.cbSearchFilter.TabIndex = 89;
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
            // lblFormHeader
            // 
            this.lblFormHeader.AutoSize = true;
            this.lblFormHeader.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblFormHeader.Location = new System.Drawing.Point(76, 14);
            this.lblFormHeader.Name = "lblFormHeader";
            this.lblFormHeader.Size = new System.Drawing.Size(479, 50);
            this.lblFormHeader.TabIndex = 83;
            this.lblFormHeader.Text = "Local Licence Applications";
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
            // dgLocalLicenceApps
            // 
            this.dgLocalLicenceApps.AllowUserToAddRows = false;
            this.dgLocalLicenceApps.AllowUserToDeleteRows = false;
            this.dgLocalLicenceApps.AllowUserToResizeColumns = false;
            this.dgLocalLicenceApps.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgLocalLicenceApps.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgLocalLicenceApps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgLocalLicenceApps.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgLocalLicenceApps.BackgroundColor = System.Drawing.Color.White;
            this.dgLocalLicenceApps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgLocalLicenceApps.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgLocalLicenceApps.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgLocalLicenceApps.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgLocalLicenceApps.ColumnHeadersHeight = 40;
            this.dgLocalLicenceApps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(144)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgLocalLicenceApps.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgLocalLicenceApps.DoubleBuffered = true;
            this.dgLocalLicenceApps.EnableHeadersVisualStyles = false;
            this.dgLocalLicenceApps.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.dgLocalLicenceApps.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.dgLocalLicenceApps.Location = new System.Drawing.Point(12, 191);
            this.dgLocalLicenceApps.MultiSelect = false;
            this.dgLocalLicenceApps.Name = "dgLocalLicenceApps";
            this.dgLocalLicenceApps.ReadOnly = true;
            this.dgLocalLicenceApps.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgLocalLicenceApps.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgLocalLicenceApps.RowHeadersVisible = false;
            this.dgLocalLicenceApps.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgLocalLicenceApps.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(247)))));
            this.dgLocalLicenceApps.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgLocalLicenceApps.RowTemplate.DividerHeight = 1;
            this.dgLocalLicenceApps.RowTemplate.Height = 39;
            this.dgLocalLicenceApps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgLocalLicenceApps.Size = new System.Drawing.Size(981, 567);
            this.dgLocalLicenceApps.TabIndex = 85;
            this.dgLocalLicenceApps.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLocalLicenceApps_CellContentDoubleClick);
            this.dgLocalLicenceApps.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgLocalLicenceApps_CellMouseDown);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
            // 
            // cmsLDLAppOperationsList
            // 
            this.cmsLDLAppOperationsList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemShowDetails,
            this.toolStripSeparator2,
            this.itemDelete,
            this.itemEdit,
            this.toolStripSeparator1,
            this.itemCancelApplication,
            this.toolScheduleTest,
            this.toolStripSeparator3,
            this.itemIssueDrivingLicence,
            this.itemShowLicence,
            this.itemShowPersonLicencesHistory});
            this.cmsLDLAppOperationsList.Name = "cmsPeopleOperationsList";
            this.cmsLDLAppOperationsList.Size = new System.Drawing.Size(247, 220);
            // 
            // itemShowDetails
            // 
            this.itemShowDetails.Image = global::DVLD_PresentationLayer.Properties.Resources.details;
            this.itemShowDetails.Name = "itemShowDetails";
            this.itemShowDetails.Size = new System.Drawing.Size(246, 22);
            this.itemShowDetails.Text = "Show Details";
            this.itemShowDetails.Click += new System.EventHandler(this.itemShowDetails_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(243, 6);
            // 
            // itemDelete
            // 
            this.itemDelete.Image = global::DVLD_PresentationLayer.Properties.Resources.delete;
            this.itemDelete.Name = "itemDelete";
            this.itemDelete.Size = new System.Drawing.Size(246, 22);
            this.itemDelete.Text = "Delete";
            this.itemDelete.Click += new System.EventHandler(this.itemDelete_Click);
            // 
            // itemEdit
            // 
            this.itemEdit.Image = global::DVLD_PresentationLayer.Properties.Resources.icons8_edit_profile_16;
            this.itemEdit.Name = "itemEdit";
            this.itemEdit.Size = new System.Drawing.Size(246, 22);
            this.itemEdit.Text = "Edit";
            this.itemEdit.Click += new System.EventHandler(this.itemEdit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(243, 6);
            // 
            // itemCancelApplication
            // 
            this.itemCancelApplication.Image = global::DVLD_PresentationLayer.Properties.Resources.icons8_cancel_48__1_;
            this.itemCancelApplication.Name = "itemCancelApplication";
            this.itemCancelApplication.Size = new System.Drawing.Size(246, 22);
            this.itemCancelApplication.Text = "Cancel Application";
            this.itemCancelApplication.Click += new System.EventHandler(this.itemCancelApplication_Click);
            // 
            // toolScheduleTest
            // 
            this.toolScheduleTest.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subItemScheduleVisionTest,
            this.subItemscheduleWrittenTest,
            this.subItemScheduleStreetTest});
            this.toolScheduleTest.Image = global::DVLD_PresentationLayer.Properties.Resources.icons8_test_48;
            this.toolScheduleTest.Name = "toolScheduleTest";
            this.toolScheduleTest.ShowShortcutKeys = false;
            this.toolScheduleTest.Size = new System.Drawing.Size(246, 22);
            this.toolScheduleTest.Text = "Schedule a Test ";
            // 
            // subItemScheduleVisionTest
            // 
            this.subItemScheduleVisionTest.Image = global::DVLD_PresentationLayer.Properties.Resources.icons8_eye_48;
            this.subItemScheduleVisionTest.Name = "subItemScheduleVisionTest";
            this.subItemScheduleVisionTest.Size = new System.Drawing.Size(186, 22);
            this.subItemScheduleVisionTest.Tag = "1";
            this.subItemScheduleVisionTest.Text = "Schedule Vision Test";
            this.subItemScheduleVisionTest.Click += new System.EventHandler(this.subItemScheduleTestType_Click);
            // 
            // subItemscheduleWrittenTest
            // 
            this.subItemscheduleWrittenTest.Image = global::DVLD_PresentationLayer.Properties.Resources.icons8_write_48;
            this.subItemscheduleWrittenTest.Name = "subItemscheduleWrittenTest";
            this.subItemscheduleWrittenTest.Size = new System.Drawing.Size(186, 22);
            this.subItemscheduleWrittenTest.Tag = "2";
            this.subItemscheduleWrittenTest.Text = "schedule Written Test";
            this.subItemscheduleWrittenTest.Click += new System.EventHandler(this.subItemScheduleTestType_Click);
            // 
            // subItemScheduleStreetTest
            // 
            this.subItemScheduleStreetTest.Image = global::DVLD_PresentationLayer.Properties.Resources.icons8_car_48;
            this.subItemScheduleStreetTest.Name = "subItemScheduleStreetTest";
            this.subItemScheduleStreetTest.Size = new System.Drawing.Size(186, 22);
            this.subItemScheduleStreetTest.Tag = "3";
            this.subItemScheduleStreetTest.Text = "Schedule Street Test";
            this.subItemScheduleStreetTest.Click += new System.EventHandler(this.subItemScheduleTestType_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(243, 6);
            // 
            // itemIssueDrivingLicence
            // 
            this.itemIssueDrivingLicence.Image = global::DVLD_PresentationLayer.Properties.Resources.icons8_car_insurance_48;
            this.itemIssueDrivingLicence.Name = "itemIssueDrivingLicence";
            this.itemIssueDrivingLicence.Size = new System.Drawing.Size(246, 22);
            this.itemIssueDrivingLicence.Text = "Issue Driving Licence (First Time)";
            this.itemIssueDrivingLicence.Click += new System.EventHandler(this.itemIssueDrivingLicence_Click);
            // 
            // itemShowLicence
            // 
            this.itemShowLicence.Image = global::DVLD_PresentationLayer.Properties.Resources.icons8_licence_48;
            this.itemShowLicence.Name = "itemShowLicence";
            this.itemShowLicence.Size = new System.Drawing.Size(246, 22);
            this.itemShowLicence.Text = "Show Licence";
            this.itemShowLicence.Click += new System.EventHandler(this.itemShowLicence_Click);
            // 
            // itemShowPersonLicencesHistory
            // 
            this.itemShowPersonLicencesHistory.Image = global::DVLD_PresentationLayer.Properties.Resources.icons8_history_48;
            this.itemShowPersonLicencesHistory.Name = "itemShowPersonLicencesHistory";
            this.itemShowPersonLicencesHistory.Size = new System.Drawing.Size(246, 22);
            this.itemShowPersonLicencesHistory.Text = "Show Person Licences History";
            this.itemShowPersonLicencesHistory.Click += new System.EventHandler(this.itemShowPersonLicencesHistory_Click);
            // 
            // frmLocalDrivingLicenceApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 770);
            this.Controls.Add(this.pnlLocalApplicationsLoader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLocalDrivingLicenceApp";
            this.Text = "frmLocalDrivingLicenceApp";
            this.Load += new System.EventHandler(this.frmLocalDrivingLicenceApp_Load);
            this.pnlLocalApplicationsLoader.ResumeLayout(false);
            this.pnlLocalApplicationsLoader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddNewLDLApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClearSearchBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLocalLicenceApps)).EndInit();
            this.cmsLDLAppOperationsList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLocalApplicationsLoader;
        private System.Windows.Forms.Label lblFormHeader;
        private System.Windows.Forms.Button btnGoBack;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgLocalLicenceApps;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton btnClearSearchBar;
        private System.Windows.Forms.Label lblSearchBar;
        private Bunifu.Framework.UI.BunifuTextbox txtSearchBar;
        private Bunifu.Framework.UI.BunifuImageButton btnAddNewLDLApp;
        private System.Windows.Forms.ComboBox cbSearchFilter;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCompleted;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancelled;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNew;
        private System.Windows.Forms.ContextMenuStrip cmsLDLAppOperationsList;
        private System.Windows.Forms.ToolStripMenuItem itemShowDetails;
        private System.Windows.Forms.ToolStripMenuItem itemDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem itemEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem itemCancelApplication;
        private System.Windows.Forms.ToolStripMenuItem toolScheduleTest;
        private System.Windows.Forms.ToolStripMenuItem subItemScheduleVisionTest;
        private System.Windows.Forms.ToolStripMenuItem subItemscheduleWrittenTest;
        private System.Windows.Forms.ToolStripMenuItem subItemScheduleStreetTest;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem itemIssueDrivingLicence;
        private System.Windows.Forms.ToolStripMenuItem itemShowLicence;
        private System.Windows.Forms.ToolStripMenuItem itemShowPersonLicencesHistory;
    }
}