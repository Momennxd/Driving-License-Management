namespace DVLD_PresentationLayer.Drivers
{
    partial class frmDrivers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDrivers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlDriversLoader = new System.Windows.Forms.Panel();
            this.btnClearSearchBar = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblSearchBar = new System.Windows.Forms.Label();
            this.cbSearchFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchBar = new Bunifu.Framework.UI.BunifuTextbox();
            this.dgDrivers = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlDriversLoader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClearSearchBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDrivers)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDriversLoader
            // 
            this.pnlDriversLoader.Controls.Add(this.btnClearSearchBar);
            this.pnlDriversLoader.Controls.Add(this.lblSearchBar);
            this.pnlDriversLoader.Controls.Add(this.cbSearchFilter);
            this.pnlDriversLoader.Controls.Add(this.label1);
            this.pnlDriversLoader.Controls.Add(this.txtSearchBar);
            this.pnlDriversLoader.Controls.Add(this.dgDrivers);
            this.pnlDriversLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDriversLoader.Location = new System.Drawing.Point(0, 0);
            this.pnlDriversLoader.Name = "pnlDriversLoader";
            this.pnlDriversLoader.Size = new System.Drawing.Size(1005, 770);
            this.pnlDriversLoader.TabIndex = 2;
            // 
            // btnClearSearchBar
            // 
            this.btnClearSearchBar.BackColor = System.Drawing.Color.White;
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
            "DriverID",
            "PersonID",
            "National No",
            "Full Name"});
            this.cbSearchFilter.Location = new System.Drawing.Point(862, 113);
            this.cbSearchFilter.Name = "cbSearchFilter";
            this.cbSearchFilter.Size = new System.Drawing.Size(131, 28);
            this.cbSearchFilter.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 50);
            this.label1.TabIndex = 26;
            this.label1.Text = "Drivers";
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
            // dgDrivers
            // 
            this.dgDrivers.AllowUserToAddRows = false;
            this.dgDrivers.AllowUserToDeleteRows = false;
            this.dgDrivers.AllowUserToResizeColumns = false;
            this.dgDrivers.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgDrivers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgDrivers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgDrivers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDrivers.BackgroundColor = System.Drawing.Color.White;
            this.dgDrivers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgDrivers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgDrivers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDrivers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgDrivers.ColumnHeadersHeight = 40;
            this.dgDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(144)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgDrivers.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgDrivers.DoubleBuffered = true;
            this.dgDrivers.EnableHeadersVisualStyles = false;
            this.dgDrivers.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.dgDrivers.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.dgDrivers.Location = new System.Drawing.Point(4, 158);
            this.dgDrivers.MultiSelect = false;
            this.dgDrivers.Name = "dgDrivers";
            this.dgDrivers.ReadOnly = true;
            this.dgDrivers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDrivers.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgDrivers.RowHeadersVisible = false;
            this.dgDrivers.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgDrivers.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(247)))));
            this.dgDrivers.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgDrivers.RowTemplate.DividerHeight = 1;
            this.dgDrivers.RowTemplate.Height = 39;
            this.dgDrivers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDrivers.Size = new System.Drawing.Size(996, 597);
            this.dgDrivers.TabIndex = 24;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
            // 
            // frmDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 770);
            this.Controls.Add(this.pnlDriversLoader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDrivers";
            this.Text = "frmDrivers";
            this.Load += new System.EventHandler(this.frmDrivers_Load);
            this.pnlDriversLoader.ResumeLayout(false);
            this.pnlDriversLoader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClearSearchBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDrivers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDriversLoader;
        private Bunifu.Framework.UI.BunifuImageButton btnClearSearchBar;
        private System.Windows.Forms.Label lblSearchBar;
        private System.Windows.Forms.ComboBox cbSearchFilter;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuTextbox txtSearchBar;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgDrivers;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}