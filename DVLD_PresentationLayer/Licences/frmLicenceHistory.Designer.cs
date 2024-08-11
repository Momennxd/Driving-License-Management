namespace DVLD_PresentationLayer.Licences
{
    partial class frmLicenceHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlLicenceLoader = new System.Windows.Forms.Panel();
            this.tabCtrlLicencesHistory = new System.Windows.Forms.TabControl();
            this.tabLocal = new System.Windows.Forms.TabPage();
            this.dgLocalLicences = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.tabInternational = new System.Windows.Forms.TabPage();
            this.dgInternationalLicences = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.lblFormHeader = new System.Windows.Forms.Label();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ctrlPersonDetails1 = new DVLD_PresentationLayer.ctrlPersonDetails();
            this.pnlLicenceLoader.SuspendLayout();
            this.tabCtrlLicencesHistory.SuspendLayout();
            this.tabLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLocalLicences)).BeginInit();
            this.tabInternational.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInternationalLicences)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLicenceLoader
            // 
            this.pnlLicenceLoader.Controls.Add(this.tabCtrlLicencesHistory);
            this.pnlLicenceLoader.Controls.Add(this.ctrlPersonDetails1);
            this.pnlLicenceLoader.Controls.Add(this.lblFormHeader);
            this.pnlLicenceLoader.Controls.Add(this.btnGoBack);
            this.pnlLicenceLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLicenceLoader.Location = new System.Drawing.Point(0, 0);
            this.pnlLicenceLoader.Name = "pnlLicenceLoader";
            this.pnlLicenceLoader.Size = new System.Drawing.Size(1005, 770);
            this.pnlLicenceLoader.TabIndex = 88;
            // 
            // tabCtrlLicencesHistory
            // 
            this.tabCtrlLicencesHistory.Controls.Add(this.tabLocal);
            this.tabCtrlLicencesHistory.Controls.Add(this.tabInternational);
            this.tabCtrlLicencesHistory.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCtrlLicencesHistory.Location = new System.Drawing.Point(37, 465);
            this.tabCtrlLicencesHistory.Name = "tabCtrlLicencesHistory";
            this.tabCtrlLicencesHistory.SelectedIndex = 0;
            this.tabCtrlLicencesHistory.Size = new System.Drawing.Size(915, 279);
            this.tabCtrlLicencesHistory.TabIndex = 88;
            // 
            // tabLocal
            // 
            this.tabLocal.Controls.Add(this.dgLocalLicences);
            this.tabLocal.Location = new System.Drawing.Point(4, 24);
            this.tabLocal.Name = "tabLocal";
            this.tabLocal.Padding = new System.Windows.Forms.Padding(3);
            this.tabLocal.Size = new System.Drawing.Size(907, 251);
            this.tabLocal.TabIndex = 0;
            this.tabLocal.Text = "Local";
            this.tabLocal.UseVisualStyleBackColor = true;
            // 
            // dgLocalLicences
            // 
            this.dgLocalLicences.AllowUserToAddRows = false;
            this.dgLocalLicences.AllowUserToDeleteRows = false;
            this.dgLocalLicences.AllowUserToResizeColumns = false;
            this.dgLocalLicences.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgLocalLicences.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgLocalLicences.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgLocalLicences.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgLocalLicences.BackgroundColor = System.Drawing.Color.White;
            this.dgLocalLicences.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgLocalLicences.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgLocalLicences.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgLocalLicences.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgLocalLicences.ColumnHeadersHeight = 40;
            this.dgLocalLicences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(144)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgLocalLicences.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgLocalLicences.DoubleBuffered = true;
            this.dgLocalLicences.EnableHeadersVisualStyles = false;
            this.dgLocalLicences.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.dgLocalLicences.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.dgLocalLicences.Location = new System.Drawing.Point(6, 6);
            this.dgLocalLicences.MultiSelect = false;
            this.dgLocalLicences.Name = "dgLocalLicences";
            this.dgLocalLicences.ReadOnly = true;
            this.dgLocalLicences.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgLocalLicences.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgLocalLicences.RowHeadersVisible = false;
            this.dgLocalLicences.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgLocalLicences.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(247)))));
            this.dgLocalLicences.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgLocalLicences.RowTemplate.DividerHeight = 1;
            this.dgLocalLicences.RowTemplate.Height = 39;
            this.dgLocalLicences.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgLocalLicences.Size = new System.Drawing.Size(895, 239);
            this.dgLocalLicences.TabIndex = 89;
            // 
            // tabInternational
            // 
            this.tabInternational.Controls.Add(this.dgInternationalLicences);
            this.tabInternational.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabInternational.Location = new System.Drawing.Point(4, 24);
            this.tabInternational.Name = "tabInternational";
            this.tabInternational.Padding = new System.Windows.Forms.Padding(3);
            this.tabInternational.Size = new System.Drawing.Size(907, 251);
            this.tabInternational.TabIndex = 1;
            this.tabInternational.Text = "International";
            this.tabInternational.UseVisualStyleBackColor = true;
            // 
            // dgInternationalLicences
            // 
            this.dgInternationalLicences.AllowUserToAddRows = false;
            this.dgInternationalLicences.AllowUserToDeleteRows = false;
            this.dgInternationalLicences.AllowUserToResizeColumns = false;
            this.dgInternationalLicences.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgInternationalLicences.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgInternationalLicences.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgInternationalLicences.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgInternationalLicences.BackgroundColor = System.Drawing.Color.White;
            this.dgInternationalLicences.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgInternationalLicences.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgInternationalLicences.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgInternationalLicences.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgInternationalLicences.ColumnHeadersHeight = 40;
            this.dgInternationalLicences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(144)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgInternationalLicences.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgInternationalLicences.DoubleBuffered = true;
            this.dgInternationalLicences.EnableHeadersVisualStyles = false;
            this.dgInternationalLicences.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.dgInternationalLicences.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.dgInternationalLicences.Location = new System.Drawing.Point(6, 6);
            this.dgInternationalLicences.MultiSelect = false;
            this.dgInternationalLicences.Name = "dgInternationalLicences";
            this.dgInternationalLicences.ReadOnly = true;
            this.dgInternationalLicences.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgInternationalLicences.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgInternationalLicences.RowHeadersVisible = false;
            this.dgInternationalLicences.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgInternationalLicences.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(247)))));
            this.dgInternationalLicences.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgInternationalLicences.RowTemplate.DividerHeight = 1;
            this.dgInternationalLicences.RowTemplate.Height = 39;
            this.dgInternationalLicences.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgInternationalLicences.Size = new System.Drawing.Size(895, 239);
            this.dgInternationalLicences.TabIndex = 90;
            // 
            // lblFormHeader
            // 
            this.lblFormHeader.AutoSize = true;
            this.lblFormHeader.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblFormHeader.Location = new System.Drawing.Point(75, 19);
            this.lblFormHeader.Name = "lblFormHeader";
            this.lblFormHeader.Size = new System.Drawing.Size(288, 50);
            this.lblFormHeader.TabIndex = 85;
            this.lblFormHeader.Text = "Licence History";
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.Transparent;
            this.btnGoBack.BackgroundImage = global::DVLD_PresentationLayer.Properties.Resources.back1;
            this.btnGoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGoBack.FlatAppearance.BorderSize = 0;
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBack.Location = new System.Drawing.Point(8, 17);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(69, 58);
            this.btnGoBack.TabIndex = 86;
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
            // 
            // ctrlPersonDetails1
            // 
            this.ctrlPersonDetails1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonDetails1.Location = new System.Drawing.Point(132, 107);
            this.ctrlPersonDetails1.Name = "ctrlPersonDetails1";
            this.ctrlPersonDetails1.Size = new System.Drawing.Size(729, 346);
            this.ctrlPersonDetails1.TabIndex = 87;
            // 
            // frmLicenceHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 770);
            this.Controls.Add(this.pnlLicenceLoader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLicenceHistory";
            this.Text = "frmLicenceHistory";
            this.Load += new System.EventHandler(this.frmLicenceHistory_Load);
            this.pnlLicenceLoader.ResumeLayout(false);
            this.pnlLicenceLoader.PerformLayout();
            this.tabCtrlLicencesHistory.ResumeLayout(false);
            this.tabLocal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgLocalLicences)).EndInit();
            this.tabInternational.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgInternationalLicences)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLicenceLoader;
        private System.Windows.Forms.Label lblFormHeader;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.TabControl tabCtrlLicencesHistory;
        private System.Windows.Forms.TabPage tabLocal;
        private System.Windows.Forms.TabPage tabInternational;
        private ctrlPersonDetails ctrlPersonDetails1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgInternationalLicences;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public Bunifu.Framework.UI.BunifuCustomDataGrid dgLocalLicences;
    }
}