namespace DVLD_PresentationLayer.Applications
{
    partial class frmApplications
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
            this.pnlApplicationsLoader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlApplications = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnManageTestTypes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnManageApplicationTypes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDetainLicences = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnManageApplications = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDrivingLicencesServices = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlApplicationsLoader.SuspendLayout();
            this.pnlApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlApplicationsLoader
            // 
            this.pnlApplicationsLoader.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlApplicationsLoader.Controls.Add(this.label1);
            this.pnlApplicationsLoader.Controls.Add(this.pnlApplications);
            this.pnlApplicationsLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlApplicationsLoader.Location = new System.Drawing.Point(0, 0);
            this.pnlApplicationsLoader.Name = "pnlApplicationsLoader";
            this.pnlApplicationsLoader.Size = new System.Drawing.Size(1005, 770);
            this.pnlApplicationsLoader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 50);
            this.label1.TabIndex = 28;
            this.label1.Text = "Applications";
            // 
            // pnlApplications
            // 
            this.pnlApplications.BackColor = System.Drawing.Color.White;
            this.pnlApplications.Controls.Add(this.pictureBox1);
            this.pnlApplications.Controls.Add(this.label2);
            this.pnlApplications.Controls.Add(this.btnManageTestTypes);
            this.pnlApplications.Controls.Add(this.btnManageApplicationTypes);
            this.pnlApplications.Controls.Add(this.btnDetainLicences);
            this.pnlApplications.Controls.Add(this.btnManageApplications);
            this.pnlApplications.Controls.Add(this.btnDrivingLicencesServices);
            this.pnlApplications.Location = new System.Drawing.Point(156, 98);
            this.pnlApplications.Name = "pnlApplications";
            this.pnlApplications.Size = new System.Drawing.Size(691, 539);
            this.pnlApplications.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_PresentationLayer.Properties.Resources.icons8_administrative_tools_100;
            this.pictureBox1.Location = new System.Drawing.Point(195, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label2.Location = new System.Drawing.Point(251, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 50);
            this.label2.TabIndex = 29;
            this.label2.Text = "Applications";
            // 
            // btnManageTestTypes
            // 
            this.btnManageTestTypes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(145)))), ((int)(((byte)(208)))));
            this.btnManageTestTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnManageTestTypes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnManageTestTypes.BorderRadius = 0;
            this.btnManageTestTypes.ButtonText = "Manage Test Types";
            this.btnManageTestTypes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageTestTypes.DisabledColor = System.Drawing.Color.Gray;
            this.btnManageTestTypes.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageTestTypes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnManageTestTypes.Iconimage = global::DVLD_PresentationLayer.Properties.Resources.icons8_test_50;
            this.btnManageTestTypes.Iconimage_right = null;
            this.btnManageTestTypes.Iconimage_right_Selected = null;
            this.btnManageTestTypes.Iconimage_Selected = null;
            this.btnManageTestTypes.IconMarginLeft = 0;
            this.btnManageTestTypes.IconMarginRight = 0;
            this.btnManageTestTypes.IconRightVisible = true;
            this.btnManageTestTypes.IconRightZoom = 0D;
            this.btnManageTestTypes.IconVisible = true;
            this.btnManageTestTypes.IconZoom = 90D;
            this.btnManageTestTypes.IsTab = false;
            this.btnManageTestTypes.Location = new System.Drawing.Point(233, 433);
            this.btnManageTestTypes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnManageTestTypes.Name = "btnManageTestTypes";
            this.btnManageTestTypes.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnManageTestTypes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(145)))), ((int)(((byte)(208)))));
            this.btnManageTestTypes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnManageTestTypes.selected = false;
            this.btnManageTestTypes.Size = new System.Drawing.Size(239, 45);
            this.btnManageTestTypes.TabIndex = 5;
            this.btnManageTestTypes.Text = "Manage Test Types";
            this.btnManageTestTypes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageTestTypes.Textcolor = System.Drawing.Color.White;
            this.btnManageTestTypes.TextFont = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageTestTypes.Click += new System.EventHandler(this.btnService_Click);
            // 
            // btnManageApplicationTypes
            // 
            this.btnManageApplicationTypes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(145)))), ((int)(((byte)(208)))));
            this.btnManageApplicationTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnManageApplicationTypes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnManageApplicationTypes.BorderRadius = 0;
            this.btnManageApplicationTypes.ButtonText = "Manage Application Types";
            this.btnManageApplicationTypes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageApplicationTypes.DisabledColor = System.Drawing.Color.Gray;
            this.btnManageApplicationTypes.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageApplicationTypes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnManageApplicationTypes.Iconimage = global::DVLD_PresentationLayer.Properties.Resources.icons8_checklist_64;
            this.btnManageApplicationTypes.Iconimage_right = null;
            this.btnManageApplicationTypes.Iconimage_right_Selected = null;
            this.btnManageApplicationTypes.Iconimage_Selected = null;
            this.btnManageApplicationTypes.IconMarginLeft = 0;
            this.btnManageApplicationTypes.IconMarginRight = 0;
            this.btnManageApplicationTypes.IconRightVisible = true;
            this.btnManageApplicationTypes.IconRightZoom = 0D;
            this.btnManageApplicationTypes.IconVisible = true;
            this.btnManageApplicationTypes.IconZoom = 90D;
            this.btnManageApplicationTypes.IsTab = false;
            this.btnManageApplicationTypes.Location = new System.Drawing.Point(233, 365);
            this.btnManageApplicationTypes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnManageApplicationTypes.Name = "btnManageApplicationTypes";
            this.btnManageApplicationTypes.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnManageApplicationTypes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(145)))), ((int)(((byte)(208)))));
            this.btnManageApplicationTypes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnManageApplicationTypes.selected = false;
            this.btnManageApplicationTypes.Size = new System.Drawing.Size(239, 45);
            this.btnManageApplicationTypes.TabIndex = 4;
            this.btnManageApplicationTypes.Text = "Manage Application Types";
            this.btnManageApplicationTypes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageApplicationTypes.Textcolor = System.Drawing.Color.White;
            this.btnManageApplicationTypes.TextFont = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageApplicationTypes.Click += new System.EventHandler(this.btnService_Click);
            // 
            // btnDetainLicences
            // 
            this.btnDetainLicences.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(145)))), ((int)(((byte)(208)))));
            this.btnDetainLicences.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnDetainLicences.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDetainLicences.BorderRadius = 0;
            this.btnDetainLicences.ButtonText = "Detain Licences";
            this.btnDetainLicences.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetainLicences.DisabledColor = System.Drawing.Color.Gray;
            this.btnDetainLicences.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetainLicences.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDetainLicences.Iconimage = global::DVLD_PresentationLayer.Properties.Resources.icons8_detain_50;
            this.btnDetainLicences.Iconimage_right = null;
            this.btnDetainLicences.Iconimage_right_Selected = null;
            this.btnDetainLicences.Iconimage_Selected = null;
            this.btnDetainLicences.IconMarginLeft = 0;
            this.btnDetainLicences.IconMarginRight = 0;
            this.btnDetainLicences.IconRightVisible = true;
            this.btnDetainLicences.IconRightZoom = 0D;
            this.btnDetainLicences.IconVisible = true;
            this.btnDetainLicences.IconZoom = 90D;
            this.btnDetainLicences.IsTab = false;
            this.btnDetainLicences.Location = new System.Drawing.Point(233, 297);
            this.btnDetainLicences.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDetainLicences.Name = "btnDetainLicences";
            this.btnDetainLicences.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnDetainLicences.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(145)))), ((int)(((byte)(208)))));
            this.btnDetainLicences.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDetainLicences.selected = false;
            this.btnDetainLicences.Size = new System.Drawing.Size(239, 45);
            this.btnDetainLicences.TabIndex = 3;
            this.btnDetainLicences.Text = "Detain Licences";
            this.btnDetainLicences.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetainLicences.Textcolor = System.Drawing.Color.White;
            this.btnDetainLicences.TextFont = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetainLicences.Click += new System.EventHandler(this.btnService_Click);
            // 
            // btnManageApplications
            // 
            this.btnManageApplications.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(145)))), ((int)(((byte)(208)))));
            this.btnManageApplications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnManageApplications.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnManageApplications.BorderRadius = 0;
            this.btnManageApplications.ButtonText = "Manage Applications";
            this.btnManageApplications.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageApplications.DisabledColor = System.Drawing.Color.Gray;
            this.btnManageApplications.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageApplications.Iconcolor = System.Drawing.Color.Transparent;
            this.btnManageApplications.Iconimage = global::DVLD_PresentationLayer.Properties.Resources.icons8_manage_64;
            this.btnManageApplications.Iconimage_right = null;
            this.btnManageApplications.Iconimage_right_Selected = null;
            this.btnManageApplications.Iconimage_Selected = null;
            this.btnManageApplications.IconMarginLeft = 0;
            this.btnManageApplications.IconMarginRight = 0;
            this.btnManageApplications.IconRightVisible = true;
            this.btnManageApplications.IconRightZoom = 0D;
            this.btnManageApplications.IconVisible = true;
            this.btnManageApplications.IconZoom = 90D;
            this.btnManageApplications.IsTab = false;
            this.btnManageApplications.Location = new System.Drawing.Point(233, 229);
            this.btnManageApplications.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnManageApplications.Name = "btnManageApplications";
            this.btnManageApplications.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnManageApplications.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(145)))), ((int)(((byte)(208)))));
            this.btnManageApplications.OnHoverTextColor = System.Drawing.Color.White;
            this.btnManageApplications.selected = false;
            this.btnManageApplications.Size = new System.Drawing.Size(239, 45);
            this.btnManageApplications.TabIndex = 2;
            this.btnManageApplications.Text = "Manage Applications";
            this.btnManageApplications.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageApplications.Textcolor = System.Drawing.Color.White;
            this.btnManageApplications.TextFont = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageApplications.Click += new System.EventHandler(this.btnService_Click);
            // 
            // btnDrivingLicencesServices
            // 
            this.btnDrivingLicencesServices.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(145)))), ((int)(((byte)(208)))));
            this.btnDrivingLicencesServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnDrivingLicencesServices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDrivingLicencesServices.BorderRadius = 0;
            this.btnDrivingLicencesServices.ButtonText = "Driving Licences Services";
            this.btnDrivingLicencesServices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDrivingLicencesServices.DisabledColor = System.Drawing.Color.Gray;
            this.btnDrivingLicencesServices.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrivingLicencesServices.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDrivingLicencesServices.Iconimage = global::DVLD_PresentationLayer.Properties.Resources.icons8_services_50__3_;
            this.btnDrivingLicencesServices.Iconimage_right = null;
            this.btnDrivingLicencesServices.Iconimage_right_Selected = null;
            this.btnDrivingLicencesServices.Iconimage_Selected = null;
            this.btnDrivingLicencesServices.IconMarginLeft = 0;
            this.btnDrivingLicencesServices.IconMarginRight = 0;
            this.btnDrivingLicencesServices.IconRightVisible = true;
            this.btnDrivingLicencesServices.IconRightZoom = 0D;
            this.btnDrivingLicencesServices.IconVisible = true;
            this.btnDrivingLicencesServices.IconZoom = 90D;
            this.btnDrivingLicencesServices.IsTab = false;
            this.btnDrivingLicencesServices.Location = new System.Drawing.Point(233, 161);
            this.btnDrivingLicencesServices.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDrivingLicencesServices.Name = "btnDrivingLicencesServices";
            this.btnDrivingLicencesServices.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnDrivingLicencesServices.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(145)))), ((int)(((byte)(208)))));
            this.btnDrivingLicencesServices.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDrivingLicencesServices.selected = false;
            this.btnDrivingLicencesServices.Size = new System.Drawing.Size(239, 45);
            this.btnDrivingLicencesServices.TabIndex = 1;
            this.btnDrivingLicencesServices.Text = "Driving Licences Services";
            this.btnDrivingLicencesServices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrivingLicencesServices.Textcolor = System.Drawing.Color.White;
            this.btnDrivingLicencesServices.TextFont = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrivingLicencesServices.Click += new System.EventHandler(this.btnService_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 6;
            this.bunifuElipse1.TargetControl = this.btnDrivingLicencesServices;
            // 
            // frmApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 770);
            this.Controls.Add(this.pnlApplicationsLoader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmApplications";
            this.Text = "frmApplicationTypes";
            this.Load += new System.EventHandler(this.frmApplications_Load);
            this.pnlApplicationsLoader.ResumeLayout(false);
            this.pnlApplicationsLoader.PerformLayout();
            this.pnlApplications.ResumeLayout(false);
            this.pnlApplications.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlApplicationsLoader;
        private System.Windows.Forms.Panel pnlApplications;
        private Bunifu.Framework.UI.BunifuFlatButton btnDrivingLicencesServices;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton btnManageApplications;
        private Bunifu.Framework.UI.BunifuFlatButton btnDetainLicences;
        private Bunifu.Framework.UI.BunifuFlatButton btnManageApplicationTypes;
        private Bunifu.Framework.UI.BunifuFlatButton btnManageTestTypes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}