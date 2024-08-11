namespace DVLD_PresentationLayer.Applications.Driving_Licence_Services
{
    partial class frmNewDrivingLicence
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
            this.btnGoBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlApplications = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInternationalLicenceApp = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLocalDrivingLicenceApp = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlApplicationsLoader.SuspendLayout();
            this.pnlApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlApplicationsLoader
            // 
            this.pnlApplicationsLoader.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlApplicationsLoader.Controls.Add(this.btnGoBack);
            this.pnlApplicationsLoader.Controls.Add(this.label1);
            this.pnlApplicationsLoader.Controls.Add(this.pnlApplications);
            this.pnlApplicationsLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlApplicationsLoader.Location = new System.Drawing.Point(0, 0);
            this.pnlApplicationsLoader.Name = "pnlApplicationsLoader";
            this.pnlApplicationsLoader.Size = new System.Drawing.Size(1005, 770);
            this.pnlApplicationsLoader.TabIndex = 2;
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.Transparent;
            this.btnGoBack.BackgroundImage = global::DVLD_PresentationLayer.Properties.Resources.back1;
            this.btnGoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGoBack.FlatAppearance.BorderSize = 0;
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBack.Location = new System.Drawing.Point(12, 18);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(69, 58);
            this.btnGoBack.TabIndex = 87;
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label1.Location = new System.Drawing.Point(83, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 50);
            this.label1.TabIndex = 28;
            this.label1.Text = "Licence Services";
            // 
            // pnlApplications
            // 
            this.pnlApplications.BackColor = System.Drawing.Color.White;
            this.pnlApplications.Controls.Add(this.pictureBox1);
            this.pnlApplications.Controls.Add(this.label2);
            this.pnlApplications.Controls.Add(this.btnInternationalLicenceApp);
            this.pnlApplications.Controls.Add(this.btnLocalDrivingLicenceApp);
            this.pnlApplications.Location = new System.Drawing.Point(156, 115);
            this.pnlApplications.Name = "pnlApplications";
            this.pnlApplications.Size = new System.Drawing.Size(691, 539);
            this.pnlApplications.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_PresentationLayer.Properties.Resources.icons8_administrative_tools_100;
            this.pictureBox1.Location = new System.Drawing.Point(193, 67);
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
            this.label2.Location = new System.Drawing.Point(249, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 50);
            this.label2.TabIndex = 29;
            this.label2.Text = "Applications";
            // 
            // btnInternationalLicenceApp
            // 
            this.btnInternationalLicenceApp.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(145)))), ((int)(((byte)(208)))));
            this.btnInternationalLicenceApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnInternationalLicenceApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInternationalLicenceApp.BorderRadius = 0;
            this.btnInternationalLicenceApp.ButtonText = "International Licence Application";
            this.btnInternationalLicenceApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInternationalLicenceApp.DisabledColor = System.Drawing.Color.Gray;
            this.btnInternationalLicenceApp.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInternationalLicenceApp.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInternationalLicenceApp.Iconimage = global::DVLD_PresentationLayer.Properties.Resources.icons8_economy_64;
            this.btnInternationalLicenceApp.Iconimage_right = null;
            this.btnInternationalLicenceApp.Iconimage_right_Selected = null;
            this.btnInternationalLicenceApp.Iconimage_Selected = null;
            this.btnInternationalLicenceApp.IconMarginLeft = 0;
            this.btnInternationalLicenceApp.IconMarginRight = 0;
            this.btnInternationalLicenceApp.IconRightVisible = true;
            this.btnInternationalLicenceApp.IconRightZoom = 0D;
            this.btnInternationalLicenceApp.IconVisible = true;
            this.btnInternationalLicenceApp.IconZoom = 90D;
            this.btnInternationalLicenceApp.IsTab = false;
            this.btnInternationalLicenceApp.Location = new System.Drawing.Point(193, 290);
            this.btnInternationalLicenceApp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnInternationalLicenceApp.Name = "btnInternationalLicenceApp";
            this.btnInternationalLicenceApp.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnInternationalLicenceApp.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(145)))), ((int)(((byte)(208)))));
            this.btnInternationalLicenceApp.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInternationalLicenceApp.selected = false;
            this.btnInternationalLicenceApp.Size = new System.Drawing.Size(311, 45);
            this.btnInternationalLicenceApp.TabIndex = 2;
            this.btnInternationalLicenceApp.Text = "International Licence Application";
            this.btnInternationalLicenceApp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInternationalLicenceApp.Textcolor = System.Drawing.Color.White;
            this.btnInternationalLicenceApp.TextFont = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInternationalLicenceApp.Click += new System.EventHandler(this.btnDrivingLicenceAppType_Click);
            // 
            // btnLocalDrivingLicenceApp
            // 
            this.btnLocalDrivingLicenceApp.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(145)))), ((int)(((byte)(208)))));
            this.btnLocalDrivingLicenceApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnLocalDrivingLicenceApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLocalDrivingLicenceApp.BorderRadius = 0;
            this.btnLocalDrivingLicenceApp.ButtonText = "Local Driving Licence Application";
            this.btnLocalDrivingLicenceApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLocalDrivingLicenceApp.DisabledColor = System.Drawing.Color.Gray;
            this.btnLocalDrivingLicenceApp.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalDrivingLicenceApp.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLocalDrivingLicenceApp.Iconimage = global::DVLD_PresentationLayer.Properties.Resources.icons8_local_50;
            this.btnLocalDrivingLicenceApp.Iconimage_right = null;
            this.btnLocalDrivingLicenceApp.Iconimage_right_Selected = null;
            this.btnLocalDrivingLicenceApp.Iconimage_Selected = null;
            this.btnLocalDrivingLicenceApp.IconMarginLeft = 0;
            this.btnLocalDrivingLicenceApp.IconMarginRight = 0;
            this.btnLocalDrivingLicenceApp.IconRightVisible = true;
            this.btnLocalDrivingLicenceApp.IconRightZoom = 0D;
            this.btnLocalDrivingLicenceApp.IconVisible = true;
            this.btnLocalDrivingLicenceApp.IconZoom = 90D;
            this.btnLocalDrivingLicenceApp.IsTab = false;
            this.btnLocalDrivingLicenceApp.Location = new System.Drawing.Point(193, 222);
            this.btnLocalDrivingLicenceApp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLocalDrivingLicenceApp.Name = "btnLocalDrivingLicenceApp";
            this.btnLocalDrivingLicenceApp.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnLocalDrivingLicenceApp.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(145)))), ((int)(((byte)(208)))));
            this.btnLocalDrivingLicenceApp.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLocalDrivingLicenceApp.selected = false;
            this.btnLocalDrivingLicenceApp.Size = new System.Drawing.Size(311, 45);
            this.btnLocalDrivingLicenceApp.TabIndex = 1;
            this.btnLocalDrivingLicenceApp.Text = "Local Driving Licence Application";
            this.btnLocalDrivingLicenceApp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocalDrivingLicenceApp.Textcolor = System.Drawing.Color.White;
            this.btnLocalDrivingLicenceApp.TextFont = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalDrivingLicenceApp.Click += new System.EventHandler(this.btnDrivingLicenceAppType_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 6;
            this.bunifuElipse1.TargetControl = this;
            // 
            // frmNewDrivingLicence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 770);
            this.Controls.Add(this.pnlApplicationsLoader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNewDrivingLicence";
            this.Text = "frmNewDrivingLicence";
            this.Load += new System.EventHandler(this.frmNewDrivingLicence_Load);
            this.pnlApplicationsLoader.ResumeLayout(false);
            this.pnlApplicationsLoader.PerformLayout();
            this.pnlApplications.ResumeLayout(false);
            this.pnlApplications.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlApplicationsLoader;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlApplications;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btnInternationalLicenceApp;
        private Bunifu.Framework.UI.BunifuFlatButton btnLocalDrivingLicenceApp;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}