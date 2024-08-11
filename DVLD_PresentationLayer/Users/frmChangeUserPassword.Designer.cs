namespace DVLD_PresentationLayer.Users
{
    partial class frmChangeUserPassword
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
            this.pnlUsersLoader = new System.Windows.Forms.Panel();
            this.ctrlUserDetails = new DVLD_PresentationLayer.ctrlUserDetails();
            this.pnlPasswordInfo = new System.Windows.Forms.Panel();
            this.pnlCurrentPassword = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlNewPassword = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlConfirmPassword = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnCancel = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnSave = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.errorInfoValidation = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlUsersLoader.SuspendLayout();
            this.pnlPasswordInfo.SuspendLayout();
            this.pnlCurrentPassword.SuspendLayout();
            this.pnlNewPassword.SuspendLayout();
            this.pnlConfirmPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorInfoValidation)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUsersLoader
            // 
            this.pnlUsersLoader.Controls.Add(this.pnlPasswordInfo);
            this.pnlUsersLoader.Controls.Add(this.ctrlUserDetails);
            this.pnlUsersLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUsersLoader.Location = new System.Drawing.Point(0, 0);
            this.pnlUsersLoader.Name = "pnlUsersLoader";
            this.pnlUsersLoader.Size = new System.Drawing.Size(1005, 770);
            this.pnlUsersLoader.TabIndex = 0;
            // 
            // ctrlUserDetails
            // 
            this.ctrlUserDetails.BackColor = System.Drawing.Color.White;
            this.ctrlUserDetails.Location = new System.Drawing.Point(104, 33);
            this.ctrlUserDetails.Name = "ctrlUserDetails";
            this.ctrlUserDetails.Size = new System.Drawing.Size(751, 473);
            this.ctrlUserDetails.TabIndex = 0;
            // 
            // pnlPasswordInfo
            // 
            this.pnlPasswordInfo.BackColor = System.Drawing.Color.White;
            this.pnlPasswordInfo.Controls.Add(this.btnCancel);
            this.pnlPasswordInfo.Controls.Add(this.btnSave);
            this.pnlPasswordInfo.Controls.Add(this.pnlConfirmPassword);
            this.pnlPasswordInfo.Controls.Add(this.pnlNewPassword);
            this.pnlPasswordInfo.Controls.Add(this.pnlCurrentPassword);
            this.pnlPasswordInfo.Location = new System.Drawing.Point(104, 512);
            this.pnlPasswordInfo.Name = "pnlPasswordInfo";
            this.pnlPasswordInfo.Size = new System.Drawing.Size(751, 177);
            this.pnlPasswordInfo.TabIndex = 1;
            // 
            // pnlCurrentPassword
            // 
            this.pnlCurrentPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(250)))));
            this.pnlCurrentPassword.Controls.Add(this.txtCurrentPassword);
            this.pnlCurrentPassword.Controls.Add(this.label2);
            this.pnlCurrentPassword.Location = new System.Drawing.Point(12, 14);
            this.pnlCurrentPassword.Name = "pnlCurrentPassword";
            this.pnlCurrentPassword.Size = new System.Drawing.Size(341, 38);
            this.pnlCurrentPassword.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Current Password :";
            // 
            // pnlNewPassword
            // 
            this.pnlNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(250)))));
            this.pnlNewPassword.Controls.Add(this.txtNewPassword);
            this.pnlNewPassword.Controls.Add(this.label3);
            this.pnlNewPassword.Location = new System.Drawing.Point(12, 65);
            this.pnlNewPassword.Name = "pnlNewPassword";
            this.pnlNewPassword.Size = new System.Drawing.Size(341, 38);
            this.pnlNewPassword.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "New Password :";
            // 
            // pnlConfirmPassword
            // 
            this.pnlConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(250)))));
            this.pnlConfirmPassword.Controls.Add(this.txtConfirmPassword);
            this.pnlConfirmPassword.Controls.Add(this.label5);
            this.pnlConfirmPassword.Location = new System.Drawing.Point(12, 116);
            this.pnlConfirmPassword.Name = "pnlConfirmPassword";
            this.pnlConfirmPassword.Size = new System.Drawing.Size(341, 38);
            this.pnlConfirmPassword.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Confirm Password :";
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(250)))));
            this.txtCurrentPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCurrentPassword.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtCurrentPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCurrentPassword.Location = new System.Drawing.Point(151, 9);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.Size = new System.Drawing.Size(156, 20);
            this.txtCurrentPassword.TabIndex = 78;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(250)))));
            this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewPassword.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNewPassword.Location = new System.Drawing.Point(130, 9);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(156, 20);
            this.txtNewPassword.TabIndex = 79;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(250)))));
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtConfirmPassword.Location = new System.Drawing.Point(151, 9);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(156, 20);
            this.txtConfirmPassword.TabIndex = 79;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Image = global::DVLD_PresentationLayer.Properties.Resources.exit7;
            this.btnCancel.ImageActive = null;
            this.btnCancel.Location = new System.Drawing.Point(556, 116);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(71, 52);
            this.btnCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCancel.TabIndex = 86;
            this.btnCancel.TabStop = false;
            this.btnCancel.Zoom = 10;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Image = global::DVLD_PresentationLayer.Properties.Resources.icons8_save_48;
            this.btnSave.ImageActive = null;
            this.btnSave.Location = new System.Drawing.Point(663, 116);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(71, 52);
            this.btnSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSave.TabIndex = 85;
            this.btnSave.TabStop = false;
            this.btnSave.Zoom = 10;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // errorInfoValidation
            // 
            this.errorInfoValidation.ContainerControl = this;
            // 
            // frmChangeUserPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 770);
            this.Controls.Add(this.pnlUsersLoader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChangeUserPassword";
            this.Text = "frmChangeUserPassword";
            this.Load += new System.EventHandler(this.frmChangeUserPassword_Load);
            this.pnlUsersLoader.ResumeLayout(false);
            this.pnlPasswordInfo.ResumeLayout(false);
            this.pnlCurrentPassword.ResumeLayout(false);
            this.pnlCurrentPassword.PerformLayout();
            this.pnlNewPassword.ResumeLayout(false);
            this.pnlNewPassword.PerformLayout();
            this.pnlConfirmPassword.ResumeLayout(false);
            this.pnlConfirmPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorInfoValidation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUsersLoader;
        private System.Windows.Forms.Panel pnlPasswordInfo;
        private ctrlUserDetails ctrlUserDetails;
        private System.Windows.Forms.Panel pnlConfirmPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlNewPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlCurrentPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private Bunifu.Framework.UI.BunifuImageButton btnCancel;
        private Bunifu.Framework.UI.BunifuImageButton btnSave;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ErrorProvider errorInfoValidation;
    }
}