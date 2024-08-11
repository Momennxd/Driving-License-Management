namespace DVLD_PresentationLayer.Tests
{
    partial class frmTestAppointments
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
            this.lblFormHeader = new System.Windows.Forms.Label();
            this.lblTestTypeName = new System.Windows.Forms.Label();
            this.pnlTestAppointmentsLoader = new System.Windows.Forms.Panel();
            this.btnAddNewTestAppointment = new Bunifu.Framework.UI.BunifuImageButton();
            this.dgTestAppointments = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.ctrlCurrentApplicationInfo = new DVLD_PresentationLayer.Applications.Manage_Applications.Local_Driving_Licence.ctrlApplicationInfo();
            this.pbTestTypePic = new System.Windows.Forms.PictureBox();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.ctrlCurrentLDLApplicationInfo = new DVLD_PresentationLayer.Applications.Manage_Applications.Local_Driving_Licence.ctrlLDLApplicationInfo();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.cmsTestAppointmentsOpList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.itemTakeTest = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTestAppointmentsLoader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddNewTestAppointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTestAppointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestTypePic)).BeginInit();
            this.cmsTestAppointmentsOpList.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFormHeader
            // 
            this.lblFormHeader.AutoSize = true;
            this.lblFormHeader.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblFormHeader.Location = new System.Drawing.Point(93, 21);
            this.lblFormHeader.Name = "lblFormHeader";
            this.lblFormHeader.Size = new System.Drawing.Size(466, 50);
            this.lblFormHeader.TabIndex = 85;
            this.lblFormHeader.Text = "Vision Test Appointments";
            // 
            // lblTestTypeName
            // 
            this.lblTestTypeName.AutoSize = true;
            this.lblTestTypeName.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestTypeName.ForeColor = System.Drawing.Color.Black;
            this.lblTestTypeName.Location = new System.Drawing.Point(861, 130);
            this.lblTestTypeName.Name = "lblTestTypeName";
            this.lblTestTypeName.Size = new System.Drawing.Size(118, 30);
            this.lblTestTypeName.TabIndex = 87;
            this.lblTestTypeName.Text = "Vision Test";
            // 
            // pnlTestAppointmentsLoader
            // 
            this.pnlTestAppointmentsLoader.Controls.Add(this.btnAddNewTestAppointment);
            this.pnlTestAppointmentsLoader.Controls.Add(this.dgTestAppointments);
            this.pnlTestAppointmentsLoader.Controls.Add(this.lblTestTypeName);
            this.pnlTestAppointmentsLoader.Controls.Add(this.ctrlCurrentApplicationInfo);
            this.pnlTestAppointmentsLoader.Controls.Add(this.pbTestTypePic);
            this.pnlTestAppointmentsLoader.Controls.Add(this.btnGoBack);
            this.pnlTestAppointmentsLoader.Controls.Add(this.lblFormHeader);
            this.pnlTestAppointmentsLoader.Controls.Add(this.ctrlCurrentLDLApplicationInfo);
            this.pnlTestAppointmentsLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTestAppointmentsLoader.Location = new System.Drawing.Point(0, 0);
            this.pnlTestAppointmentsLoader.Name = "pnlTestAppointmentsLoader";
            this.pnlTestAppointmentsLoader.Size = new System.Drawing.Size(1005, 770);
            this.pnlTestAppointmentsLoader.TabIndex = 88;
            // 
            // btnAddNewTestAppointment
            // 
            this.btnAddNewTestAppointment.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewTestAppointment.Image = global::DVLD_PresentationLayer.Properties.Resources.icons8_add_to_clipboard_48;
            this.btnAddNewTestAppointment.ImageActive = null;
            this.btnAddNewTestAppointment.Location = new System.Drawing.Point(937, 431);
            this.btnAddNewTestAppointment.Name = "btnAddNewTestAppointment";
            this.btnAddNewTestAppointment.Size = new System.Drawing.Size(56, 40);
            this.btnAddNewTestAppointment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAddNewTestAppointment.TabIndex = 91;
            this.btnAddNewTestAppointment.TabStop = false;
            this.btnAddNewTestAppointment.Zoom = 10;
            this.btnAddNewTestAppointment.Click += new System.EventHandler(this.btnAddNewTestAppointment_Click);
            // 
            // dgTestAppointments
            // 
            this.dgTestAppointments.AllowUserToAddRows = false;
            this.dgTestAppointments.AllowUserToDeleteRows = false;
            this.dgTestAppointments.AllowUserToResizeColumns = false;
            this.dgTestAppointments.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgTestAppointments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgTestAppointments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgTestAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTestAppointments.BackgroundColor = System.Drawing.Color.White;
            this.dgTestAppointments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgTestAppointments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgTestAppointments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTestAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgTestAppointments.ColumnHeadersHeight = 40;
            this.dgTestAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(144)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgTestAppointments.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgTestAppointments.DoubleBuffered = true;
            this.dgTestAppointments.EnableHeadersVisualStyles = false;
            this.dgTestAppointments.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.dgTestAppointments.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.dgTestAppointments.Location = new System.Drawing.Point(18, 477);
            this.dgTestAppointments.MultiSelect = false;
            this.dgTestAppointments.Name = "dgTestAppointments";
            this.dgTestAppointments.ReadOnly = true;
            this.dgTestAppointments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTestAppointments.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgTestAppointments.RowHeadersVisible = false;
            this.dgTestAppointments.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgTestAppointments.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(247)))));
            this.dgTestAppointments.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgTestAppointments.RowTemplate.DividerHeight = 1;
            this.dgTestAppointments.RowTemplate.Height = 39;
            this.dgTestAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTestAppointments.Size = new System.Drawing.Size(975, 281);
            this.dgTestAppointments.TabIndex = 88;
            this.dgTestAppointments.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgTestAppointments_CellMouseDown);
            // 
            // ctrlCurrentApplicationInfo
            // 
            this.ctrlCurrentApplicationInfo.Location = new System.Drawing.Point(11, 81);
            this.ctrlCurrentApplicationInfo.Name = "ctrlCurrentApplicationInfo";
            this.ctrlCurrentApplicationInfo.Size = new System.Drawing.Size(718, 209);
            this.ctrlCurrentApplicationInfo.TabIndex = 0;
            // 
            // pbTestTypePic
            // 
            this.pbTestTypePic.Image = global::DVLD_PresentationLayer.Properties.Resources.TestTypeVision1;
            this.pbTestTypePic.Location = new System.Drawing.Point(866, 21);
            this.pbTestTypePic.Name = "pbTestTypePic";
            this.pbTestTypePic.Size = new System.Drawing.Size(119, 106);
            this.pbTestTypePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTestTypePic.TabIndex = 2;
            this.pbTestTypePic.TabStop = false;
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.Transparent;
            this.btnGoBack.BackgroundImage = global::DVLD_PresentationLayer.Properties.Resources.back1;
            this.btnGoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGoBack.FlatAppearance.BorderSize = 0;
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBack.Location = new System.Drawing.Point(18, 12);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(69, 58);
            this.btnGoBack.TabIndex = 86;
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // ctrlCurrentLDLApplicationInfo
            // 
            this.ctrlCurrentLDLApplicationInfo.Location = new System.Drawing.Point(-1, 260);
            this.ctrlCurrentLDLApplicationInfo.Name = "ctrlCurrentLDLApplicationInfo";
            this.ctrlCurrentLDLApplicationInfo.Size = new System.Drawing.Size(530, 211);
            this.ctrlCurrentLDLApplicationInfo.TabIndex = 1;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
            // 
            // cmsTestAppointmentsOpList
            // 
            this.cmsTestAppointmentsOpList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemEdit,
            this.itemTakeTest});
            this.cmsTestAppointmentsOpList.Name = "cmsPeopleOperationsList";
            this.cmsTestAppointmentsOpList.Size = new System.Drawing.Size(181, 70);
            // 
            // itemEdit
            // 
            this.itemEdit.Image = global::DVLD_PresentationLayer.Properties.Resources.icons8_edit_text_file_48;
            this.itemEdit.Name = "itemEdit";
            this.itemEdit.Size = new System.Drawing.Size(180, 22);
            this.itemEdit.Text = "Edit";
            this.itemEdit.Click += new System.EventHandler(this.itemEdit_Click);
            // 
            // itemTakeTest
            // 
            this.itemTakeTest.Image = global::DVLD_PresentationLayer.Properties.Resources.icons8_exam_48;
            this.itemTakeTest.Name = "itemTakeTest";
            this.itemTakeTest.Size = new System.Drawing.Size(180, 22);
            this.itemTakeTest.Text = "Take Test";
            this.itemTakeTest.Click += new System.EventHandler(this.itemTakeTest_Click_1);
            // 
            // frmTestAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 770);
            this.Controls.Add(this.pnlTestAppointmentsLoader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTestAppointments";
            this.Text = "frmTestAppointments";
            this.Load += new System.EventHandler(this.frmTestAppointments_Load);
            this.pnlTestAppointmentsLoader.ResumeLayout(false);
            this.pnlTestAppointmentsLoader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddNewTestAppointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTestAppointments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestTypePic)).EndInit();
            this.cmsTestAppointmentsOpList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Applications.Manage_Applications.Local_Driving_Licence.ctrlApplicationInfo ctrlCurrentApplicationInfo;
        private Applications.Manage_Applications.Local_Driving_Licence.ctrlLDLApplicationInfo ctrlCurrentLDLApplicationInfo;
        private System.Windows.Forms.PictureBox pbTestTypePic;
        private System.Windows.Forms.Label lblFormHeader;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Label lblTestTypeName;
        private System.Windows.Forms.Panel pnlTestAppointmentsLoader;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgTestAppointments;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton btnAddNewTestAppointment;
        private System.Windows.Forms.ContextMenuStrip cmsTestAppointmentsOpList;
        private System.Windows.Forms.ToolStripMenuItem itemEdit;
        private System.Windows.Forms.ToolStripMenuItem itemTakeTest;
    }
}