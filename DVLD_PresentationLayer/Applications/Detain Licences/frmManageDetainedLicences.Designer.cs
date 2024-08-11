namespace DVLD_PresentationLayer.Applications.Detain_Licences
{
    partial class frmManageDetainedLicences
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageDetainedLicences));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlDetainedLicencesLoader = new System.Windows.Forms.Panel();
            this.btnReleaseLicence = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnUnReleased = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnReleased = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDetainLicence = new Bunifu.Framework.UI.BunifuImageButton();
            this.cbSearchFilter = new System.Windows.Forms.ComboBox();
            this.btnClearSearchBar = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblSearchBar = new System.Windows.Forms.Label();
            this.txtSearchBar = new Bunifu.Framework.UI.BunifuTextbox();
            this.lblFormHeader = new System.Windows.Forms.Label();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.dgDetainedLicences = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.cmsLicenceOperationsList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itemRelease = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDetainedLicencesLoader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnReleaseLicence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDetainLicence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClearSearchBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetainedLicences)).BeginInit();
            this.cmsLicenceOperationsList.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDetainedLicencesLoader
            // 
            this.pnlDetainedLicencesLoader.Controls.Add(this.btnReleaseLicence);
            this.pnlDetainedLicencesLoader.Controls.Add(this.btnUnReleased);
            this.pnlDetainedLicencesLoader.Controls.Add(this.btnReleased);
            this.pnlDetainedLicencesLoader.Controls.Add(this.btnDetainLicence);
            this.pnlDetainedLicencesLoader.Controls.Add(this.cbSearchFilter);
            this.pnlDetainedLicencesLoader.Controls.Add(this.btnClearSearchBar);
            this.pnlDetainedLicencesLoader.Controls.Add(this.lblSearchBar);
            this.pnlDetainedLicencesLoader.Controls.Add(this.txtSearchBar);
            this.pnlDetainedLicencesLoader.Controls.Add(this.lblFormHeader);
            this.pnlDetainedLicencesLoader.Controls.Add(this.btnGoBack);
            this.pnlDetainedLicencesLoader.Controls.Add(this.dgDetainedLicences);
            this.pnlDetainedLicencesLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetainedLicencesLoader.Location = new System.Drawing.Point(0, 0);
            this.pnlDetainedLicencesLoader.Name = "pnlDetainedLicencesLoader";
            this.pnlDetainedLicencesLoader.Size = new System.Drawing.Size(1005, 770);
            this.pnlDetainedLicencesLoader.TabIndex = 90;
            // 
            // btnReleaseLicence
            // 
            this.btnReleaseLicence.BackColor = System.Drawing.Color.Transparent;
            this.btnReleaseLicence.Image = global::DVLD_PresentationLayer.Properties.Resources.icons8_access_control_64__2_;
            this.btnReleaseLicence.ImageActive = null;
            this.btnReleaseLicence.Location = new System.Drawing.Point(865, 143);
            this.btnReleaseLicence.Name = "btnReleaseLicence";
            this.btnReleaseLicence.Size = new System.Drawing.Size(56, 40);
            this.btnReleaseLicence.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnReleaseLicence.TabIndex = 93;
            this.btnReleaseLicence.TabStop = false;
            this.btnReleaseLicence.Zoom = 10;
            this.btnReleaseLicence.Click += new System.EventHandler(this.btnReleaseLicence_Click);
            // 
            // btnUnReleased
            // 
            this.btnUnReleased.ActiveBorderThickness = 1;
            this.btnUnReleased.ActiveCornerRadius = 10;
            this.btnUnReleased.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(247)))));
            this.btnUnReleased.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(144)))), ((int)(((byte)(227)))));
            this.btnUnReleased.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(144)))), ((int)(((byte)(227)))));
            this.btnUnReleased.BackColor = System.Drawing.SystemColors.Control;
            this.btnUnReleased.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUnReleased.BackgroundImage")));
            this.btnUnReleased.ButtonText = "UnReleased";
            this.btnUnReleased.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnReleased.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnReleased.ForeColor = System.Drawing.Color.Black;
            this.btnUnReleased.IdleBorderThickness = 2;
            this.btnUnReleased.IdleCornerRadius = 10;
            this.btnUnReleased.IdleFillColor = System.Drawing.Color.White;
            this.btnUnReleased.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnUnReleased.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(206)))));
            this.btnUnReleased.Location = new System.Drawing.Point(430, 131);
            this.btnUnReleased.Margin = new System.Windows.Forms.Padding(4);
            this.btnUnReleased.Name = "btnUnReleased";
            this.btnUnReleased.Size = new System.Drawing.Size(110, 53);
            this.btnUnReleased.TabIndex = 92;
            this.btnUnReleased.Tag = "0";
            this.btnUnReleased.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUnReleased.Click += new System.EventHandler(this.btnIsReleased_Click);
            // 
            // btnReleased
            // 
            this.btnReleased.ActiveBorderThickness = 1;
            this.btnReleased.ActiveCornerRadius = 10;
            this.btnReleased.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(247)))));
            this.btnReleased.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(144)))), ((int)(((byte)(227)))));
            this.btnReleased.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(144)))), ((int)(((byte)(227)))));
            this.btnReleased.BackColor = System.Drawing.SystemColors.Control;
            this.btnReleased.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReleased.BackgroundImage")));
            this.btnReleased.ButtonText = "Released";
            this.btnReleased.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReleased.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReleased.ForeColor = System.Drawing.Color.Black;
            this.btnReleased.IdleBorderThickness = 2;
            this.btnReleased.IdleCornerRadius = 10;
            this.btnReleased.IdleFillColor = System.Drawing.Color.White;
            this.btnReleased.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnReleased.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(206)))));
            this.btnReleased.Location = new System.Drawing.Point(313, 131);
            this.btnReleased.Margin = new System.Windows.Forms.Padding(4);
            this.btnReleased.Name = "btnReleased";
            this.btnReleased.Size = new System.Drawing.Size(110, 53);
            this.btnReleased.TabIndex = 91;
            this.btnReleased.Tag = "0";
            this.btnReleased.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReleased.Click += new System.EventHandler(this.btnIsReleased_Click);
            // 
            // btnDetainLicence
            // 
            this.btnDetainLicence.BackColor = System.Drawing.Color.Transparent;
            this.btnDetainLicence.Image = global::DVLD_PresentationLayer.Properties.Resources.icons8_detain_48;
            this.btnDetainLicence.ImageActive = null;
            this.btnDetainLicence.Location = new System.Drawing.Point(937, 143);
            this.btnDetainLicence.Name = "btnDetainLicence";
            this.btnDetainLicence.Size = new System.Drawing.Size(56, 40);
            this.btnDetainLicence.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDetainLicence.TabIndex = 90;
            this.btnDetainLicence.TabStop = false;
            this.btnDetainLicence.Zoom = 10;
            this.btnDetainLicence.Click += new System.EventHandler(this.btnDetainLicence_Click);
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
            "Detain ID",
            "Released Application ID",
            "Licence ID"});
            this.cbSearchFilter.Location = new System.Drawing.Point(713, 150);
            this.cbSearchFilter.Name = "cbSearchFilter";
            this.cbSearchFilter.Size = new System.Drawing.Size(136, 28);
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
            this.lblFormHeader.Size = new System.Drawing.Size(333, 50);
            this.lblFormHeader.TabIndex = 83;
            this.lblFormHeader.Text = "Detained Licences";
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
            // dgDetainedLicences
            // 
            this.dgDetainedLicences.AllowUserToAddRows = false;
            this.dgDetainedLicences.AllowUserToDeleteRows = false;
            this.dgDetainedLicences.AllowUserToResizeColumns = false;
            this.dgDetainedLicences.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgDetainedLicences.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgDetainedLicences.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgDetainedLicences.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDetainedLicences.BackgroundColor = System.Drawing.Color.White;
            this.dgDetainedLicences.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgDetainedLicences.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgDetainedLicences.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDetainedLicences.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgDetainedLicences.ColumnHeadersHeight = 40;
            this.dgDetainedLicences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(144)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgDetainedLicences.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgDetainedLicences.DoubleBuffered = true;
            this.dgDetainedLicences.EnableHeadersVisualStyles = false;
            this.dgDetainedLicences.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.dgDetainedLicences.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.dgDetainedLicences.Location = new System.Drawing.Point(12, 191);
            this.dgDetainedLicences.MultiSelect = false;
            this.dgDetainedLicences.Name = "dgDetainedLicences";
            this.dgDetainedLicences.ReadOnly = true;
            this.dgDetainedLicences.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDetainedLicences.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgDetainedLicences.RowHeadersVisible = false;
            this.dgDetainedLicences.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgDetainedLicences.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(247)))));
            this.dgDetainedLicences.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgDetainedLicences.RowTemplate.DividerHeight = 1;
            this.dgDetainedLicences.RowTemplate.Height = 39;
            this.dgDetainedLicences.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDetainedLicences.Size = new System.Drawing.Size(981, 567);
            this.dgDetainedLicences.TabIndex = 85;
            this.dgDetainedLicences.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgDetainedLicences_CellMouseDown);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
            // 
            // cmsLicenceOperationsList
            // 
            this.cmsLicenceOperationsList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemRelease});
            this.cmsLicenceOperationsList.Name = "cmsPeopleOperationsList";
            this.cmsLicenceOperationsList.Size = new System.Drawing.Size(181, 48);
            // 
            // itemRelease
            // 
            this.itemRelease.Image = global::DVLD_PresentationLayer.Properties.Resources.icons8_access_control_64__2_;
            this.itemRelease.Name = "itemRelease";
            this.itemRelease.Size = new System.Drawing.Size(180, 22);
            this.itemRelease.Text = "Release";
            this.itemRelease.Click += new System.EventHandler(this.itemRelease_Click);
            // 
            // frmManageDetainedLicences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 770);
            this.Controls.Add(this.pnlDetainedLicencesLoader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageDetainedLicences";
            this.Text = "frmManageDetainedLicences";
            this.Load += new System.EventHandler(this.frmManageDetainedLicences_Load);
            this.pnlDetainedLicencesLoader.ResumeLayout(false);
            this.pnlDetainedLicencesLoader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnReleaseLicence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDetainLicence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClearSearchBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetainedLicences)).EndInit();
            this.cmsLicenceOperationsList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDetainedLicencesLoader;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUnReleased;
        private Bunifu.Framework.UI.BunifuThinButton2 btnReleased;
        private Bunifu.Framework.UI.BunifuImageButton btnDetainLicence;
        private System.Windows.Forms.ComboBox cbSearchFilter;
        private Bunifu.Framework.UI.BunifuImageButton btnClearSearchBar;
        private System.Windows.Forms.Label lblSearchBar;
        private Bunifu.Framework.UI.BunifuTextbox txtSearchBar;
        private System.Windows.Forms.Label lblFormHeader;
        private System.Windows.Forms.Button btnGoBack;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgDetainedLicences;
        private Bunifu.Framework.UI.BunifuImageButton btnReleaseLicence;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ContextMenuStrip cmsLicenceOperationsList;
        private System.Windows.Forms.ToolStripMenuItem itemRelease;
    }
}