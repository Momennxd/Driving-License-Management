namespace DVLD_PresentationLayer
{
    partial class frmManagApplicationTypes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblFormHeader = new System.Windows.Forms.Label();
            this.dgAppTypes = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.cmsAppOperationsList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnGoBack = new System.Windows.Forms.Button();
            this.itemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlApplicationTypesLoader = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgAppTypes)).BeginInit();
            this.cmsAppOperationsList.SuspendLayout();
            this.pnlApplicationTypesLoader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFormHeader
            // 
            this.lblFormHeader.AutoSize = true;
            this.lblFormHeader.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblFormHeader.Location = new System.Drawing.Point(76, 14);
            this.lblFormHeader.Name = "lblFormHeader";
            this.lblFormHeader.Size = new System.Drawing.Size(483, 50);
            this.lblFormHeader.TabIndex = 83;
            this.lblFormHeader.Text = "Manage Application Types";
            // 
            // dgAppTypes
            // 
            this.dgAppTypes.AllowUserToAddRows = false;
            this.dgAppTypes.AllowUserToDeleteRows = false;
            this.dgAppTypes.AllowUserToResizeColumns = false;
            this.dgAppTypes.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgAppTypes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgAppTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgAppTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAppTypes.BackgroundColor = System.Drawing.Color.White;
            this.dgAppTypes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgAppTypes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgAppTypes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAppTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgAppTypes.ColumnHeadersHeight = 40;
            this.dgAppTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(144)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgAppTypes.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgAppTypes.DoubleBuffered = true;
            this.dgAppTypes.EnableHeadersVisualStyles = false;
            this.dgAppTypes.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.dgAppTypes.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.dgAppTypes.Location = new System.Drawing.Point(12, 184);
            this.dgAppTypes.MultiSelect = false;
            this.dgAppTypes.Name = "dgAppTypes";
            this.dgAppTypes.ReadOnly = true;
            this.dgAppTypes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAppTypes.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgAppTypes.RowHeadersVisible = false;
            this.dgAppTypes.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgAppTypes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(247)))));
            this.dgAppTypes.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgAppTypes.RowTemplate.DividerHeight = 1;
            this.dgAppTypes.RowTemplate.Height = 39;
            this.dgAppTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAppTypes.Size = new System.Drawing.Size(981, 574);
            this.dgAppTypes.TabIndex = 85;
            this.dgAppTypes.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgAppTypes_CellMouseDown);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
            // 
            // cmsAppOperationsList
            // 
            this.cmsAppOperationsList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemEdit});
            this.cmsAppOperationsList.Name = "cmsPeopleOperationsList";
            this.cmsAppOperationsList.Size = new System.Drawing.Size(181, 48);
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
            // itemEdit
            // 
            this.itemEdit.Image = global::DVLD_PresentationLayer.Properties.Resources.icons8_services_48;
            this.itemEdit.Name = "itemEdit";
            this.itemEdit.Size = new System.Drawing.Size(180, 22);
            this.itemEdit.Text = "Edit";
            this.itemEdit.Click += new System.EventHandler(this.itemEdit_Click);
            // 
            // pnlApplicationTypesLoader
            // 
            this.pnlApplicationTypesLoader.Controls.Add(this.lblFormHeader);
            this.pnlApplicationTypesLoader.Controls.Add(this.btnGoBack);
            this.pnlApplicationTypesLoader.Controls.Add(this.dgAppTypes);
            this.pnlApplicationTypesLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlApplicationTypesLoader.Location = new System.Drawing.Point(0, 0);
            this.pnlApplicationTypesLoader.Name = "pnlApplicationTypesLoader";
            this.pnlApplicationTypesLoader.Size = new System.Drawing.Size(1005, 770);
            this.pnlApplicationTypesLoader.TabIndex = 87;
            // 
            // frmManagApplicationTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 770);
            this.Controls.Add(this.pnlApplicationTypesLoader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManagApplicationTypes";
            this.Text = "frm_Manag_ApplicationTypes";
            this.Load += new System.EventHandler(this.frmManagApplicationTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAppTypes)).EndInit();
            this.cmsAppOperationsList.ResumeLayout(false);
            this.pnlApplicationTypesLoader.ResumeLayout(false);
            this.pnlApplicationTypesLoader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Label lblFormHeader;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgAppTypes;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ContextMenuStrip cmsAppOperationsList;
        private System.Windows.Forms.ToolStripMenuItem itemEdit;
        private System.Windows.Forms.Panel pnlApplicationTypesLoader;
    }
}