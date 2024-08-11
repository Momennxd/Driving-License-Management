namespace DVLD_PresentationLayer
{
    partial class frmAccountSettings
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
            this.pnlAccountSettingsLoader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChangePassword = new MaterialSkin.Controls.MaterialButton();
            this.ctrlCurrentlUserDetails = new DVLD_PresentationLayer.ctrlUserDetails();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlAccountSettingsLoader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAccountSettingsLoader
            // 
            this.pnlAccountSettingsLoader.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlAccountSettingsLoader.Controls.Add(this.label1);
            this.pnlAccountSettingsLoader.Controls.Add(this.btnChangePassword);
            this.pnlAccountSettingsLoader.Controls.Add(this.ctrlCurrentlUserDetails);
            this.pnlAccountSettingsLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAccountSettingsLoader.Location = new System.Drawing.Point(0, 0);
            this.pnlAccountSettingsLoader.Name = "pnlAccountSettingsLoader";
            this.pnlAccountSettingsLoader.Size = new System.Drawing.Size(1005, 770);
            this.pnlAccountSettingsLoader.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 50);
            this.label1.TabIndex = 27;
            this.label1.Text = "Account Settings";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnChangePassword.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.btnChangePassword.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnChangePassword.Depth = 0;
            this.btnChangePassword.HighEmphasis = true;
            this.btnChangePassword.Icon = null;
            this.btnChangePassword.Location = new System.Drawing.Point(689, 88);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnChangePassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnChangePassword.Size = new System.Drawing.Size(163, 36);
            this.btnChangePassword.TabIndex = 3;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnChangePassword.UseAccentColor = false;
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // ctrlCurrentlUserDetails
            // 
            this.ctrlCurrentlUserDetails.BackColor = System.Drawing.Color.White;
            this.ctrlCurrentlUserDetails.Location = new System.Drawing.Point(118, 133);
            this.ctrlCurrentlUserDetails.Name = "ctrlCurrentlUserDetails";
            this.ctrlCurrentlUserDetails.Size = new System.Drawing.Size(729, 477);
            this.ctrlCurrentlUserDetails.TabIndex = 0;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 6;
            this.bunifuElipse1.TargetControl = this;
            // 
            // frmAccountSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 770);
            this.Controls.Add(this.pnlAccountSettingsLoader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAccountSettings";
            this.Text = "frmAccountSettings";
            this.Load += new System.EventHandler(this.frmAccountSettings_Load);
            this.pnlAccountSettingsLoader.ResumeLayout(false);
            this.pnlAccountSettingsLoader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlAccountSettingsLoader;
        private ctrlUserDetails ctrlCurrentlUserDetails;
        private MaterialSkin.Controls.MaterialButton btnChangePassword;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label1;
    }
}