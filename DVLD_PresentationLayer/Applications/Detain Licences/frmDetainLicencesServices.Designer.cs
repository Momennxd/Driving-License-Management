namespace DVLD_PresentationLayer.Applications.Detain_Licences
{
    partial class frmDetainLicencesServices
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
            this.pnlServices = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDetainLicence = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnReleaseLicence = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnManageDetainedLicences = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlApplicationsLoader.SuspendLayout();
            this.pnlServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlApplicationsLoader
            // 
            this.pnlApplicationsLoader.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlApplicationsLoader.Controls.Add(this.btnGoBack);
            this.pnlApplicationsLoader.Controls.Add(this.label1);
            this.pnlApplicationsLoader.Controls.Add(this.pnlServices);
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
            this.btnGoBack.TabIndex = 88;
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label1.Location = new System.Drawing.Point(90, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 50);
            this.label1.TabIndex = 28;
            this.label1.Text = "Detain Licences Services";
            // 
            // pnlServices
            // 
            this.pnlServices.BackColor = System.Drawing.Color.White;
            this.pnlServices.Controls.Add(this.pictureBox1);
            this.pnlServices.Controls.Add(this.label2);
            this.pnlServices.Controls.Add(this.btnDetainLicence);
            this.pnlServices.Controls.Add(this.btnReleaseLicence);
            this.pnlServices.Controls.Add(this.btnManageDetainedLicences);
            this.pnlServices.Location = new System.Drawing.Point(156, 98);
            this.pnlServices.Name = "pnlServices";
            this.pnlServices.Size = new System.Drawing.Size(691, 539);
            this.pnlServices.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_PresentationLayer.Properties.Resources.icons8_administrative_tools_100;
            this.pictureBox1.Location = new System.Drawing.Point(169, 63);
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
            this.label2.Location = new System.Drawing.Point(225, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 50);
            this.label2.TabIndex = 29;
            this.label2.Text = "Detain Licences";
            // 
            // btnDetainLicence
            // 
            this.btnDetainLicence.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(145)))), ((int)(((byte)(208)))));
            this.btnDetainLicence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnDetainLicence.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDetainLicence.BorderRadius = 0;
            this.btnDetainLicence.ButtonText = "Detain Licence";
            this.btnDetainLicence.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetainLicence.DisabledColor = System.Drawing.Color.Gray;
            this.btnDetainLicence.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetainLicence.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDetainLicence.Iconimage = global::DVLD_PresentationLayer.Properties.Resources.icons8_detain_50;
            this.btnDetainLicence.Iconimage_right = null;
            this.btnDetainLicence.Iconimage_right_Selected = null;
            this.btnDetainLicence.Iconimage_Selected = null;
            this.btnDetainLicence.IconMarginLeft = 0;
            this.btnDetainLicence.IconMarginRight = 0;
            this.btnDetainLicence.IconRightVisible = true;
            this.btnDetainLicence.IconRightZoom = 0D;
            this.btnDetainLicence.IconVisible = true;
            this.btnDetainLicence.IconZoom = 90D;
            this.btnDetainLicence.IsTab = false;
            this.btnDetainLicence.Location = new System.Drawing.Point(234, 265);
            this.btnDetainLicence.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDetainLicence.Name = "btnDetainLicence";
            this.btnDetainLicence.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnDetainLicence.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(145)))), ((int)(((byte)(208)))));
            this.btnDetainLicence.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDetainLicence.selected = false;
            this.btnDetainLicence.Size = new System.Drawing.Size(239, 45);
            this.btnDetainLicence.TabIndex = 3;
            this.btnDetainLicence.Text = "Detain Licence";
            this.btnDetainLicence.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetainLicence.Textcolor = System.Drawing.Color.White;
            this.btnDetainLicence.TextFont = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetainLicence.Click += new System.EventHandler(this.btnLicenceService_Click);
            // 
            // btnReleaseLicence
            // 
            this.btnReleaseLicence.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(145)))), ((int)(((byte)(208)))));
            this.btnReleaseLicence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnReleaseLicence.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReleaseLicence.BorderRadius = 0;
            this.btnReleaseLicence.ButtonText = "Release Licence";
            this.btnReleaseLicence.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReleaseLicence.DisabledColor = System.Drawing.Color.Gray;
            this.btnReleaseLicence.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReleaseLicence.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReleaseLicence.Iconimage = global::DVLD_PresentationLayer.Properties.Resources.icons8_access_control_64__1_;
            this.btnReleaseLicence.Iconimage_right = null;
            this.btnReleaseLicence.Iconimage_right_Selected = null;
            this.btnReleaseLicence.Iconimage_Selected = null;
            this.btnReleaseLicence.IconMarginLeft = 0;
            this.btnReleaseLicence.IconMarginRight = 0;
            this.btnReleaseLicence.IconRightVisible = true;
            this.btnReleaseLicence.IconRightZoom = 0D;
            this.btnReleaseLicence.IconVisible = true;
            this.btnReleaseLicence.IconZoom = 90D;
            this.btnReleaseLicence.IsTab = false;
            this.btnReleaseLicence.Location = new System.Drawing.Point(234, 330);
            this.btnReleaseLicence.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnReleaseLicence.Name = "btnReleaseLicence";
            this.btnReleaseLicence.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnReleaseLicence.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(145)))), ((int)(((byte)(208)))));
            this.btnReleaseLicence.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReleaseLicence.selected = false;
            this.btnReleaseLicence.Size = new System.Drawing.Size(239, 45);
            this.btnReleaseLicence.TabIndex = 2;
            this.btnReleaseLicence.Text = "Release Licence";
            this.btnReleaseLicence.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReleaseLicence.Textcolor = System.Drawing.Color.White;
            this.btnReleaseLicence.TextFont = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReleaseLicence.Click += new System.EventHandler(this.btnLicenceService_Click);
            // 
            // btnManageDetainedLicences
            // 
            this.btnManageDetainedLicences.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(145)))), ((int)(((byte)(208)))));
            this.btnManageDetainedLicences.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnManageDetainedLicences.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnManageDetainedLicences.BorderRadius = 0;
            this.btnManageDetainedLicences.ButtonText = "Manage Detained Licences";
            this.btnManageDetainedLicences.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageDetainedLicences.DisabledColor = System.Drawing.Color.Gray;
            this.btnManageDetainedLicences.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageDetainedLicences.Iconcolor = System.Drawing.Color.Transparent;
            this.btnManageDetainedLicences.Iconimage = global::DVLD_PresentationLayer.Properties.Resources.icons8_services_50__3_;
            this.btnManageDetainedLicences.Iconimage_right = null;
            this.btnManageDetainedLicences.Iconimage_right_Selected = null;
            this.btnManageDetainedLicences.Iconimage_Selected = null;
            this.btnManageDetainedLicences.IconMarginLeft = 0;
            this.btnManageDetainedLicences.IconMarginRight = 0;
            this.btnManageDetainedLicences.IconRightVisible = true;
            this.btnManageDetainedLicences.IconRightZoom = 0D;
            this.btnManageDetainedLicences.IconVisible = true;
            this.btnManageDetainedLicences.IconZoom = 90D;
            this.btnManageDetainedLicences.IsTab = false;
            this.btnManageDetainedLicences.Location = new System.Drawing.Point(234, 204);
            this.btnManageDetainedLicences.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnManageDetainedLicences.Name = "btnManageDetainedLicences";
            this.btnManageDetainedLicences.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnManageDetainedLicences.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(145)))), ((int)(((byte)(208)))));
            this.btnManageDetainedLicences.OnHoverTextColor = System.Drawing.Color.White;
            this.btnManageDetainedLicences.selected = false;
            this.btnManageDetainedLicences.Size = new System.Drawing.Size(239, 45);
            this.btnManageDetainedLicences.TabIndex = 1;
            this.btnManageDetainedLicences.Text = "Manage Detained Licences";
            this.btnManageDetainedLicences.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageDetainedLicences.Textcolor = System.Drawing.Color.White;
            this.btnManageDetainedLicences.TextFont = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageDetainedLicences.Click += new System.EventHandler(this.btnLicenceService_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 6;
            this.bunifuElipse1.TargetControl = this;
            // 
            // frmDetainLicencesServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 770);
            this.Controls.Add(this.pnlApplicationsLoader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDetainLicencesServices";
            this.Text = "frmDetainLicencesServices";
            this.Load += new System.EventHandler(this.frmDetainLicencesServices_Load);
            this.pnlApplicationsLoader.ResumeLayout(false);
            this.pnlApplicationsLoader.PerformLayout();
            this.pnlServices.ResumeLayout(false);
            this.pnlServices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlApplicationsLoader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlServices;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btnDetainLicence;
        private Bunifu.Framework.UI.BunifuFlatButton btnReleaseLicence;
        private Bunifu.Framework.UI.BunifuFlatButton btnManageDetainedLicences;
        private System.Windows.Forms.Button btnGoBack;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}