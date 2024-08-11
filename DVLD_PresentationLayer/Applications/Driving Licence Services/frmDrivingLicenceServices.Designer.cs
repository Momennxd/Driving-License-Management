namespace DVLD_PresentationLayer.Applications.Driving_Licence_Services
{
    partial class frmDrivingLicenceServices
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
            this.btnLicenceRemplacement = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnRnewDrivingLicence = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnNewDrivingLicences = new Bunifu.Framework.UI.BunifuFlatButton();
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
            this.pnlApplicationsLoader.TabIndex = 1;
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.Transparent;
            this.btnGoBack.BackgroundImage = global::DVLD_PresentationLayer.Properties.Resources.back1;
            this.btnGoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGoBack.FlatAppearance.BorderSize = 0;
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBack.Location = new System.Drawing.Point(12, 12);
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
            this.label1.Location = new System.Drawing.Point(83, 15);
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
            this.pnlApplications.Controls.Add(this.btnLicenceRemplacement);
            this.pnlApplications.Controls.Add(this.btnRnewDrivingLicence);
            this.pnlApplications.Controls.Add(this.btnNewDrivingLicences);
            this.pnlApplications.Location = new System.Drawing.Point(156, 98);
            this.pnlApplications.Name = "pnlApplications";
            this.pnlApplications.Size = new System.Drawing.Size(691, 539);
            this.pnlApplications.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_PresentationLayer.Properties.Resources.icons8_administrative_tools_100;
            this.pictureBox1.Location = new System.Drawing.Point(229, 40);
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
            this.label2.Location = new System.Drawing.Point(285, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 50);
            this.label2.TabIndex = 29;
            this.label2.Text = "Services";
            // 
            // btnLicenceRemplacement
            // 
            this.btnLicenceRemplacement.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(145)))), ((int)(((byte)(208)))));
            this.btnLicenceRemplacement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnLicenceRemplacement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLicenceRemplacement.BorderRadius = 0;
            this.btnLicenceRemplacement.ButtonText = "Remplacement for Lost Or Damadged Licence";
            this.btnLicenceRemplacement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLicenceRemplacement.DisabledColor = System.Drawing.Color.Gray;
            this.btnLicenceRemplacement.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLicenceRemplacement.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLicenceRemplacement.Iconimage = global::DVLD_PresentationLayer.Properties.Resources.icons8_replace_50;
            this.btnLicenceRemplacement.Iconimage_right = null;
            this.btnLicenceRemplacement.Iconimage_right_Selected = null;
            this.btnLicenceRemplacement.Iconimage_Selected = null;
            this.btnLicenceRemplacement.IconMarginLeft = 0;
            this.btnLicenceRemplacement.IconMarginRight = 0;
            this.btnLicenceRemplacement.IconRightVisible = true;
            this.btnLicenceRemplacement.IconRightZoom = 0D;
            this.btnLicenceRemplacement.IconVisible = true;
            this.btnLicenceRemplacement.IconZoom = 90D;
            this.btnLicenceRemplacement.IsTab = false;
            this.btnLicenceRemplacement.Location = new System.Drawing.Point(219, 348);
            this.btnLicenceRemplacement.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLicenceRemplacement.Name = "btnLicenceRemplacement";
            this.btnLicenceRemplacement.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnLicenceRemplacement.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(145)))), ((int)(((byte)(208)))));
            this.btnLicenceRemplacement.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLicenceRemplacement.selected = false;
            this.btnLicenceRemplacement.Size = new System.Drawing.Size(239, 55);
            this.btnLicenceRemplacement.TabIndex = 3;
            this.btnLicenceRemplacement.Text = "Remplacement for Lost Or Damadged Licence";
            this.btnLicenceRemplacement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLicenceRemplacement.Textcolor = System.Drawing.Color.White;
            this.btnLicenceRemplacement.TextFont = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLicenceRemplacement.Click += new System.EventHandler(this.btnServices_Click);
            // 
            // btnRnewDrivingLicence
            // 
            this.btnRnewDrivingLicence.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(145)))), ((int)(((byte)(208)))));
            this.btnRnewDrivingLicence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnRnewDrivingLicence.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRnewDrivingLicence.BorderRadius = 0;
            this.btnRnewDrivingLicence.ButtonText = "Rnew Driving Licence";
            this.btnRnewDrivingLicence.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRnewDrivingLicence.DisabledColor = System.Drawing.Color.Gray;
            this.btnRnewDrivingLicence.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRnewDrivingLicence.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRnewDrivingLicence.Iconimage = global::DVLD_PresentationLayer.Properties.Resources.icons8_renew_50;
            this.btnRnewDrivingLicence.Iconimage_right = null;
            this.btnRnewDrivingLicence.Iconimage_right_Selected = null;
            this.btnRnewDrivingLicence.Iconimage_Selected = null;
            this.btnRnewDrivingLicence.IconMarginLeft = 0;
            this.btnRnewDrivingLicence.IconMarginRight = 0;
            this.btnRnewDrivingLicence.IconRightVisible = true;
            this.btnRnewDrivingLicence.IconRightZoom = 0D;
            this.btnRnewDrivingLicence.IconVisible = true;
            this.btnRnewDrivingLicence.IconZoom = 90D;
            this.btnRnewDrivingLicence.IsTab = false;
            this.btnRnewDrivingLicence.Location = new System.Drawing.Point(219, 286);
            this.btnRnewDrivingLicence.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRnewDrivingLicence.Name = "btnRnewDrivingLicence";
            this.btnRnewDrivingLicence.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnRnewDrivingLicence.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(145)))), ((int)(((byte)(208)))));
            this.btnRnewDrivingLicence.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRnewDrivingLicence.selected = false;
            this.btnRnewDrivingLicence.Size = new System.Drawing.Size(239, 45);
            this.btnRnewDrivingLicence.TabIndex = 2;
            this.btnRnewDrivingLicence.Text = "Rnew Driving Licence";
            this.btnRnewDrivingLicence.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRnewDrivingLicence.Textcolor = System.Drawing.Color.White;
            this.btnRnewDrivingLicence.TextFont = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRnewDrivingLicence.Click += new System.EventHandler(this.btnServices_Click);
            // 
            // btnNewDrivingLicences
            // 
            this.btnNewDrivingLicences.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(145)))), ((int)(((byte)(208)))));
            this.btnNewDrivingLicences.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnNewDrivingLicences.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNewDrivingLicences.BorderRadius = 0;
            this.btnNewDrivingLicences.ButtonText = "New Driving Licences";
            this.btnNewDrivingLicences.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewDrivingLicences.DisabledColor = System.Drawing.Color.Gray;
            this.btnNewDrivingLicences.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewDrivingLicences.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNewDrivingLicences.Iconimage = global::DVLD_PresentationLayer.Properties.Resources.icons8_new_50;
            this.btnNewDrivingLicences.Iconimage_right = null;
            this.btnNewDrivingLicences.Iconimage_right_Selected = null;
            this.btnNewDrivingLicences.Iconimage_Selected = null;
            this.btnNewDrivingLicences.IconMarginLeft = 0;
            this.btnNewDrivingLicences.IconMarginRight = 0;
            this.btnNewDrivingLicences.IconRightVisible = true;
            this.btnNewDrivingLicences.IconRightZoom = 0D;
            this.btnNewDrivingLicences.IconVisible = true;
            this.btnNewDrivingLicences.IconZoom = 90D;
            this.btnNewDrivingLicences.IsTab = false;
            this.btnNewDrivingLicences.Location = new System.Drawing.Point(219, 218);
            this.btnNewDrivingLicences.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNewDrivingLicences.Name = "btnNewDrivingLicences";
            this.btnNewDrivingLicences.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnNewDrivingLicences.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(145)))), ((int)(((byte)(208)))));
            this.btnNewDrivingLicences.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNewDrivingLicences.selected = false;
            this.btnNewDrivingLicences.Size = new System.Drawing.Size(239, 45);
            this.btnNewDrivingLicences.TabIndex = 1;
            this.btnNewDrivingLicences.Text = "New Driving Licences";
            this.btnNewDrivingLicences.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewDrivingLicences.Textcolor = System.Drawing.Color.White;
            this.btnNewDrivingLicences.TextFont = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewDrivingLicences.Click += new System.EventHandler(this.btnServices_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 6;
            this.bunifuElipse1.TargetControl = this;
            // 
            // frmDrivingLicenceServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 770);
            this.Controls.Add(this.pnlApplicationsLoader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDrivingLicenceServices";
            this.Text = "frmDrivingLicenceServices";
            this.Load += new System.EventHandler(this.frmDrivingLicenceServices_Load);
            this.pnlApplicationsLoader.ResumeLayout(false);
            this.pnlApplicationsLoader.PerformLayout();
            this.pnlApplications.ResumeLayout(false);
            this.pnlApplications.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlApplicationsLoader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlApplications;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btnLicenceRemplacement;
        private Bunifu.Framework.UI.BunifuFlatButton btnRnewDrivingLicence;
        private Bunifu.Framework.UI.BunifuFlatButton btnNewDrivingLicences;
        private System.Windows.Forms.Button btnGoBack;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}