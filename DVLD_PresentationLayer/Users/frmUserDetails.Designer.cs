namespace DVLD_PresentationLayer
{
    partial class frmUserDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ctrlUserDetails = new DVLD_PresentationLayer.ctrlUserDetails();
            this.pnlUsersLoader = new System.Windows.Forms.Panel();
            this.btnEditUser = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlUsersLoader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditUser)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label1.Location = new System.Drawing.Point(82, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 50);
            this.label1.TabIndex = 33;
            this.label1.Text = "User Details";
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.Transparent;
            this.btnGoBack.BackgroundImage = global::DVLD_PresentationLayer.Properties.Resources.back1;
            this.btnGoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGoBack.FlatAppearance.BorderSize = 0;
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBack.Location = new System.Drawing.Point(5, 18);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(69, 58);
            this.btnGoBack.TabIndex = 34;
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // ctrlUserDetails
            // 
            this.ctrlUserDetails.BackColor = System.Drawing.Color.White;
            this.ctrlUserDetails.Location = new System.Drawing.Point(128, 124);
            this.ctrlUserDetails.Name = "ctrlUserDetails";
            this.ctrlUserDetails.Size = new System.Drawing.Size(751, 500);
            this.ctrlUserDetails.TabIndex = 35;
            // 
            // pnlUsersLoader
            // 
            this.pnlUsersLoader.Controls.Add(this.btnEditUser);
            this.pnlUsersLoader.Controls.Add(this.btnGoBack);
            this.pnlUsersLoader.Controls.Add(this.label1);
            this.pnlUsersLoader.Controls.Add(this.ctrlUserDetails);
            this.pnlUsersLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUsersLoader.Location = new System.Drawing.Point(0, 0);
            this.pnlUsersLoader.Name = "pnlUsersLoader";
            this.pnlUsersLoader.Size = new System.Drawing.Size(1005, 770);
            this.pnlUsersLoader.TabIndex = 37;
            // 
            // btnEditUser
            // 
            this.btnEditUser.BackColor = System.Drawing.Color.White;
            this.btnEditUser.Image = global::DVLD_PresentationLayer.Properties.Resources.icons8_edit_48;
            this.btnEditUser.ImageActive = null;
            this.btnEditUser.Location = new System.Drawing.Point(486, 557);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(56, 43);
            this.btnEditUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEditUser.TabIndex = 37;
            this.btnEditUser.TabStop = false;
            this.btnEditUser.Zoom = 10;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // frmUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 770);
            this.Controls.Add(this.pnlUsersLoader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUserDetails";
            this.Text = "frmUserDetails";
            this.Load += new System.EventHandler(this.frmUserDetails_Load);
            this.pnlUsersLoader.ResumeLayout(false);
            this.pnlUsersLoader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private ctrlUserDetails ctrlUserDetails;
        private System.Windows.Forms.Panel pnlUsersLoader;
        private Bunifu.Framework.UI.BunifuImageButton btnEditUser;
    }
}