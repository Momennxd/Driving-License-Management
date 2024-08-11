namespace DVLD_PresentationLayer.Applications.Manage_Applications.Local_Driving_Licence
{
    partial class frmLDLAppDetails
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
            this.pnlLocalApplicationsLoader = new System.Windows.Forms.Panel();
            this.ctrlCurrentLDLApplicationInfo = new DVLD_PresentationLayer.Applications.Manage_Applications.Local_Driving_Licence.ctrlLDLApplicationInfo();
            this.ctrlCurrentApplicationInfo = new DVLD_PresentationLayer.Applications.Manage_Applications.Local_Driving_Licence.ctrlApplicationInfo();
            this.lblFormHeader = new System.Windows.Forms.Label();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlLocalApplicationsLoader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLocalApplicationsLoader
            // 
            this.pnlLocalApplicationsLoader.Controls.Add(this.lblFormHeader);
            this.pnlLocalApplicationsLoader.Controls.Add(this.btnGoBack);
            this.pnlLocalApplicationsLoader.Controls.Add(this.ctrlCurrentApplicationInfo);
            this.pnlLocalApplicationsLoader.Controls.Add(this.ctrlCurrentLDLApplicationInfo);
            this.pnlLocalApplicationsLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLocalApplicationsLoader.Location = new System.Drawing.Point(0, 0);
            this.pnlLocalApplicationsLoader.Name = "pnlLocalApplicationsLoader";
            this.pnlLocalApplicationsLoader.Size = new System.Drawing.Size(1005, 770);
            this.pnlLocalApplicationsLoader.TabIndex = 0;
            // 
            // ctrlCurrentLDLApplicationInfo
            // 
            this.ctrlCurrentLDLApplicationInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ctrlCurrentLDLApplicationInfo.Location = new System.Drawing.Point(212, 170);
            this.ctrlCurrentLDLApplicationInfo.Name = "ctrlCurrentLDLApplicationInfo";
            this.ctrlCurrentLDLApplicationInfo.Size = new System.Drawing.Size(551, 224);
            this.ctrlCurrentLDLApplicationInfo.TabIndex = 0;
            // 
            // ctrlCurrentApplicationInfo
            // 
            this.ctrlCurrentApplicationInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ctrlCurrentApplicationInfo.Location = new System.Drawing.Point(139, 410);
            this.ctrlCurrentApplicationInfo.Name = "ctrlCurrentApplicationInfo";
            this.ctrlCurrentApplicationInfo.Size = new System.Drawing.Size(729, 219);
            this.ctrlCurrentApplicationInfo.TabIndex = 1;
            // 
            // lblFormHeader
            // 
            this.lblFormHeader.AutoSize = true;
            this.lblFormHeader.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblFormHeader.Location = new System.Drawing.Point(78, 17);
            this.lblFormHeader.Name = "lblFormHeader";
            this.lblFormHeader.Size = new System.Drawing.Size(592, 50);
            this.lblFormHeader.TabIndex = 85;
            this.lblFormHeader.Text = "Local Licence Application Details";
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.Transparent;
            this.btnGoBack.BackgroundImage = global::DVLD_PresentationLayer.Properties.Resources.back1;
            this.btnGoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGoBack.FlatAppearance.BorderSize = 0;
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBack.Location = new System.Drawing.Point(11, 15);
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
            // frmLDLAppDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 770);
            this.Controls.Add(this.pnlLocalApplicationsLoader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLDLAppDetails";
            this.Text = "frmLDLAppDetails";
            this.Load += new System.EventHandler(this.frmLDLAppDetails_Load);
            this.pnlLocalApplicationsLoader.ResumeLayout(false);
            this.pnlLocalApplicationsLoader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLocalApplicationsLoader;
        private ctrlLDLApplicationInfo ctrlCurrentLDLApplicationInfo;
        private ctrlApplicationInfo ctrlCurrentApplicationInfo;
        private System.Windows.Forms.Label lblFormHeader;
        private System.Windows.Forms.Button btnGoBack;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}