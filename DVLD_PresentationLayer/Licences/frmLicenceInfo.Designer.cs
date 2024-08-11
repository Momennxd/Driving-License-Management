namespace DVLD_PresentationLayer.Licences
{
    partial class frmLicenceInfo
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
            this.lblFormHeader = new System.Windows.Forms.Label();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.pnlLicenceLoader = new System.Windows.Forms.Panel();
            this.ctrlLicenceInfo1 = new DVLD_PresentationLayer.Licences.ctrlLicenceInfo();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlLicenceLoader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFormHeader
            // 
            this.lblFormHeader.AutoSize = true;
            this.lblFormHeader.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblFormHeader.Location = new System.Drawing.Point(75, 19);
            this.lblFormHeader.Name = "lblFormHeader";
            this.lblFormHeader.Size = new System.Drawing.Size(231, 50);
            this.lblFormHeader.TabIndex = 85;
            this.lblFormHeader.Text = "Licence Info";
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
            // pnlLicenceLoader
            // 
            this.pnlLicenceLoader.Controls.Add(this.ctrlLicenceInfo1);
            this.pnlLicenceLoader.Controls.Add(this.lblFormHeader);
            this.pnlLicenceLoader.Controls.Add(this.btnGoBack);
            this.pnlLicenceLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLicenceLoader.Location = new System.Drawing.Point(0, 0);
            this.pnlLicenceLoader.Name = "pnlLicenceLoader";
            this.pnlLicenceLoader.Size = new System.Drawing.Size(1005, 770);
            this.pnlLicenceLoader.TabIndex = 87;
            // 
            // ctrlLicenceInfo1
            // 
            this.ctrlLicenceInfo1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ctrlLicenceInfo1.Location = new System.Drawing.Point(106, 174);
            this.ctrlLicenceInfo1.Name = "ctrlLicenceInfo1";
            this.ctrlLicenceInfo1.Size = new System.Drawing.Size(770, 435);
            this.ctrlLicenceInfo1.TabIndex = 87;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
            // 
            // frmLicenceInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 770);
            this.Controls.Add(this.pnlLicenceLoader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLicenceInfo";
            this.Text = "frmLicenceInfo";
            this.Load += new System.EventHandler(this.frmLicenceInfo_Load);
            this.pnlLicenceLoader.ResumeLayout(false);
            this.pnlLicenceLoader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFormHeader;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Panel pnlLicenceLoader;
        private ctrlLicenceInfo ctrlLicenceInfo1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}