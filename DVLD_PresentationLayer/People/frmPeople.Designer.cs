namespace DVLD_PresentationLayer
{
    partial class frmPeople
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPeople));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.cmsPeopleOperationsList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itemShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.itemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pnlPeopleLoader = new System.Windows.Forms.Panel();
            this.btnAddNewPerson = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnClearSearchBar = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblSearchBar = new System.Windows.Forms.Label();
            this.cbSearchFilter = new System.Windows.Forms.ComboBox();
            this.btnFemales = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnMales = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchBar = new Bunifu.Framework.UI.BunifuTextbox();
            this.dgPeople = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.cmsPeopleOperationsList.SuspendLayout();
            this.pnlPeopleLoader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddNewPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClearSearchBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
            // 
            // cmsPeopleOperationsList
            // 
            this.cmsPeopleOperationsList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemShowDetails,
            this.itemDelete,
            this.itemEdit,
            this.toolStripSeparator2});
            this.cmsPeopleOperationsList.Name = "cmsPeopleOperationsList";
            this.cmsPeopleOperationsList.Size = new System.Drawing.Size(142, 76);
            // 
            // itemShowDetails
            // 
            this.itemShowDetails.Image = global::DVLD_PresentationLayer.Properties.Resources.details;
            this.itemShowDetails.Name = "itemShowDetails";
            this.itemShowDetails.Size = new System.Drawing.Size(141, 22);
            this.itemShowDetails.Text = "Show Details";
            this.itemShowDetails.Click += new System.EventHandler(this.itemShowDetails_Click);
            // 
            // itemDelete
            // 
            this.itemDelete.Image = global::DVLD_PresentationLayer.Properties.Resources.delete;
            this.itemDelete.Name = "itemDelete";
            this.itemDelete.Size = new System.Drawing.Size(141, 22);
            this.itemDelete.Text = "Delete";
            this.itemDelete.Click += new System.EventHandler(this.itemDelete_Click);
            // 
            // itemEdit
            // 
            this.itemEdit.Image = global::DVLD_PresentationLayer.Properties.Resources.icons8_edit_profile_16;
            this.itemEdit.Name = "itemEdit";
            this.itemEdit.Size = new System.Drawing.Size(141, 22);
            this.itemEdit.Text = "Edit";
            this.itemEdit.Click += new System.EventHandler(this.itemEdit_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(138, 6);
            // 
            // pnlPeopleLoader
            // 
            this.pnlPeopleLoader.Controls.Add(this.btnAddNewPerson);
            this.pnlPeopleLoader.Controls.Add(this.btnClearSearchBar);
            this.pnlPeopleLoader.Controls.Add(this.lblSearchBar);
            this.pnlPeopleLoader.Controls.Add(this.cbSearchFilter);
            this.pnlPeopleLoader.Controls.Add(this.btnFemales);
            this.pnlPeopleLoader.Controls.Add(this.btnMales);
            this.pnlPeopleLoader.Controls.Add(this.label1);
            this.pnlPeopleLoader.Controls.Add(this.txtSearchBar);
            this.pnlPeopleLoader.Controls.Add(this.dgPeople);
            this.pnlPeopleLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPeopleLoader.Location = new System.Drawing.Point(0, 0);
            this.pnlPeopleLoader.Name = "pnlPeopleLoader";
            this.pnlPeopleLoader.Size = new System.Drawing.Size(1005, 770);
            this.pnlPeopleLoader.TabIndex = 1;
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewPerson.Image = global::DVLD_PresentationLayer.Properties.Resources.add_new_user1;
            this.btnAddNewPerson.ImageActive = null;
            this.btnAddNewPerson.Location = new System.Drawing.Point(937, 111);
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.Size = new System.Drawing.Size(56, 40);
            this.btnAddNewPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAddNewPerson.TabIndex = 33;
            this.btnAddNewPerson.TabStop = false;
            this.btnAddNewPerson.Zoom = 10;
            this.btnAddNewPerson.Click += new System.EventHandler(this.btnAddNewPerson_Click);
            // 
            // btnClearSearchBar
            // 
            this.btnClearSearchBar.BackColor = System.Drawing.Color.Transparent;
            this.btnClearSearchBar.Image = global::DVLD_PresentationLayer.Properties.Resources.icons8_multiply_50;
            this.btnClearSearchBar.ImageActive = null;
            this.btnClearSearchBar.Location = new System.Drawing.Point(249, 101);
            this.btnClearSearchBar.Name = "btnClearSearchBar";
            this.btnClearSearchBar.Size = new System.Drawing.Size(41, 34);
            this.btnClearSearchBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClearSearchBar.TabIndex = 32;
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
            this.lblSearchBar.Location = new System.Drawing.Point(52, 108);
            this.lblSearchBar.Name = "lblSearchBar";
            this.lblSearchBar.Size = new System.Drawing.Size(56, 19);
            this.lblSearchBar.TabIndex = 31;
            this.lblSearchBar.Text = "Search";
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
            "National No",
            "First Name",
            "Second Name",
            "Third Name",
            "Last Name"});
            this.cbSearchFilter.Location = new System.Drawing.Point(800, 117);
            this.cbSearchFilter.Name = "cbSearchFilter";
            this.cbSearchFilter.Size = new System.Drawing.Size(131, 28);
            this.cbSearchFilter.TabIndex = 30;
            // 
            // btnFemales
            // 
            this.btnFemales.ActiveBorderThickness = 1;
            this.btnFemales.ActiveCornerRadius = 10;
            this.btnFemales.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(247)))));
            this.btnFemales.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(144)))), ((int)(((byte)(227)))));
            this.btnFemales.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(144)))), ((int)(((byte)(227)))));
            this.btnFemales.BackColor = System.Drawing.Color.White;
            this.btnFemales.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFemales.BackgroundImage")));
            this.btnFemales.ButtonText = "Females";
            this.btnFemales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFemales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFemales.ForeColor = System.Drawing.Color.Black;
            this.btnFemales.IdleBorderThickness = 2;
            this.btnFemales.IdleCornerRadius = 10;
            this.btnFemales.IdleFillColor = System.Drawing.Color.White;
            this.btnFemales.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnFemales.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(206)))));
            this.btnFemales.Location = new System.Drawing.Point(414, 86);
            this.btnFemales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFemales.Name = "btnFemales";
            this.btnFemales.Size = new System.Drawing.Size(101, 59);
            this.btnFemales.TabIndex = 28;
            this.btnFemales.Tag = "0";
            this.btnFemales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFemales.Click += new System.EventHandler(this.btnGenderFilter_Click);
            // 
            // btnMales
            // 
            this.btnMales.ActiveBorderThickness = 1;
            this.btnMales.ActiveCornerRadius = 10;
            this.btnMales.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(247)))));
            this.btnMales.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(144)))), ((int)(((byte)(227)))));
            this.btnMales.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(144)))), ((int)(((byte)(227)))));
            this.btnMales.BackColor = System.Drawing.Color.White;
            this.btnMales.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMales.BackgroundImage")));
            this.btnMales.ButtonText = "Males";
            this.btnMales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMales.ForeColor = System.Drawing.Color.Black;
            this.btnMales.IdleBorderThickness = 2;
            this.btnMales.IdleCornerRadius = 10;
            this.btnMales.IdleFillColor = System.Drawing.Color.White;
            this.btnMales.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnMales.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(206)))));
            this.btnMales.Location = new System.Drawing.Point(305, 86);
            this.btnMales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMales.Name = "btnMales";
            this.btnMales.Size = new System.Drawing.Size(101, 59);
            this.btnMales.TabIndex = 27;
            this.btnMales.Tag = "0";
            this.btnMales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMales.Click += new System.EventHandler(this.btnGenderFilter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 50);
            this.label1.TabIndex = 26;
            this.label1.Text = "People";
            // 
            // txtSearchBar
            // 
            this.txtSearchBar.BackColor = System.Drawing.Color.White;
            this.txtSearchBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearchBar.BackgroundImage")));
            this.txtSearchBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtSearchBar.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(206)))));
            this.txtSearchBar.Icon = ((System.Drawing.Image)(resources.GetObject("txtSearchBar.Icon")));
            this.txtSearchBar.Location = new System.Drawing.Point(4, 95);
            this.txtSearchBar.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearchBar.Name = "txtSearchBar";
            this.txtSearchBar.Size = new System.Drawing.Size(292, 46);
            this.txtSearchBar.TabIndex = 25;
            this.txtSearchBar.text = "";
            this.txtSearchBar.OnTextChange += new System.EventHandler(this.txtSearchBar_OnTextChange);
            // 
            // dgPeople
            // 
            this.dgPeople.AllowUserToAddRows = false;
            this.dgPeople.AllowUserToDeleteRows = false;
            this.dgPeople.AllowUserToResizeColumns = false;
            this.dgPeople.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgPeople.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgPeople.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPeople.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPeople.BackgroundColor = System.Drawing.Color.White;
            this.dgPeople.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgPeople.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgPeople.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPeople.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgPeople.ColumnHeadersHeight = 40;
            this.dgPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(144)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPeople.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgPeople.DoubleBuffered = true;
            this.dgPeople.EnableHeadersVisualStyles = false;
            this.dgPeople.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.dgPeople.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.dgPeople.Location = new System.Drawing.Point(4, 158);
            this.dgPeople.MultiSelect = false;
            this.dgPeople.Name = "dgPeople";
            this.dgPeople.ReadOnly = true;
            this.dgPeople.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPeople.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgPeople.RowHeadersVisible = false;
            this.dgPeople.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgPeople.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(247)))));
            this.dgPeople.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgPeople.RowTemplate.DividerHeight = 1;
            this.dgPeople.RowTemplate.Height = 39;
            this.dgPeople.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPeople.Size = new System.Drawing.Size(996, 597);
            this.dgPeople.TabIndex = 24;
            this.dgPeople.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPeople_CellContentDoubleClick);
            this.dgPeople.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgPeople_CellMouseDown);
            // 
            // frmPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1005, 770);
            this.Controls.Add(this.pnlPeopleLoader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPeople";
            this.Text = "frmAdd_UpdatePerson";
            this.Load += new System.EventHandler(this.frmPeople_Load);
            this.cmsPeopleOperationsList.ResumeLayout(false);
            this.pnlPeopleLoader.ResumeLayout(false);
            this.pnlPeopleLoader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddNewPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClearSearchBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPeople)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ContextMenuStrip cmsPeopleOperationsList;
        private System.Windows.Forms.ToolStripMenuItem itemShowDetails;
        private System.Windows.Forms.ToolStripMenuItem itemDelete;
        private System.Windows.Forms.ToolStripMenuItem itemEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Panel pnlPeopleLoader;
        private System.Windows.Forms.Label lblSearchBar;
        private System.Windows.Forms.ComboBox cbSearchFilter;
        private Bunifu.Framework.UI.BunifuThinButton2 btnFemales;
        private Bunifu.Framework.UI.BunifuThinButton2 btnMales;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuTextbox txtSearchBar;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgPeople;
        private Bunifu.Framework.UI.BunifuImageButton btnClearSearchBar;
        private Bunifu.Framework.UI.BunifuImageButton btnAddNewPerson;
    }
}