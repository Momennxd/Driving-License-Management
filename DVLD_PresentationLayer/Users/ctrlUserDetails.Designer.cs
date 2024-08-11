namespace DVLD_PresentationLayer
{
    partial class ctrlUserDetails
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlUserID = new System.Windows.Forms.Panel();
            this.lblUserID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlUserName = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlIsActive = new System.Windows.Forms.Panel();
            this.swtchIsActive = new MaterialSkin.Controls.MaterialSwitch();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ctrlUserPersonDetails = new DVLD_PresentationLayer.ctrlPersonDetails();
            this.pnlUserID.SuspendLayout();
            this.pnlUserName.SuspendLayout();
            this.pnlIsActive.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUserID
            // 
            this.pnlUserID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(250)))));
            this.pnlUserID.Controls.Add(this.lblUserID);
            this.pnlUserID.Controls.Add(this.label5);
            this.pnlUserID.Location = new System.Drawing.Point(53, 360);
            this.pnlUserID.Name = "pnlUserID";
            this.pnlUserID.Size = new System.Drawing.Size(154, 38);
            this.pnlUserID.TabIndex = 54;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(76, 10);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(24, 20);
            this.lblUserID.TabIndex = 6;
            this.lblUserID.Text = "-1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "User ID :";
            // 
            // pnlUserName
            // 
            this.pnlUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(250)))));
            this.pnlUserName.Controls.Add(this.lblUserName);
            this.pnlUserName.Controls.Add(this.label2);
            this.pnlUserName.Location = new System.Drawing.Point(213, 360);
            this.pnlUserName.Name = "pnlUserName";
            this.pnlUserName.Size = new System.Drawing.Size(301, 38);
            this.pnlUserName.TabIndex = 55;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUserName.Location = new System.Drawing.Point(105, 10);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(76, 20);
            this.lblUserName.TabIndex = 6;
            this.lblUserName.Text = "Unknown";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "User Name :";
            // 
            // pnlIsActive
            // 
            this.pnlIsActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(250)))));
            this.pnlIsActive.Controls.Add(this.swtchIsActive);
            this.pnlIsActive.Controls.Add(this.label4);
            this.pnlIsActive.Location = new System.Drawing.Point(520, 360);
            this.pnlIsActive.Name = "pnlIsActive";
            this.pnlIsActive.Size = new System.Drawing.Size(170, 38);
            this.pnlIsActive.TabIndex = 56;
            // 
            // swtchIsActive
            // 
            this.swtchIsActive.AutoSize = true;
            this.swtchIsActive.Depth = 0;
            this.swtchIsActive.Enabled = false;
            this.swtchIsActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.swtchIsActive.Location = new System.Drawing.Point(83, 1);
            this.swtchIsActive.Margin = new System.Windows.Forms.Padding(0);
            this.swtchIsActive.MouseLocation = new System.Drawing.Point(-1, -1);
            this.swtchIsActive.MouseState = MaterialSkin.MouseState.HOVER;
            this.swtchIsActive.Name = "swtchIsActive";
            this.swtchIsActive.Ripple = true;
            this.swtchIsActive.Size = new System.Drawing.Size(58, 37);
            this.swtchIsActive.TabIndex = 7;
            this.swtchIsActive.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Is Active :";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // ctrlUserPersonDetails
            // 
            this.ctrlUserPersonDetails.BackColor = System.Drawing.Color.White;
            this.ctrlUserPersonDetails.Location = new System.Drawing.Point(3, 0);
            this.ctrlUserPersonDetails.Name = "ctrlUserPersonDetails";
            this.ctrlUserPersonDetails.Size = new System.Drawing.Size(745, 327);
            this.ctrlUserPersonDetails.TabIndex = 0;
            // 
            // ctrlUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlIsActive);
            this.Controls.Add(this.pnlUserName);
            this.Controls.Add(this.pnlUserID);
            this.Controls.Add(this.ctrlUserPersonDetails);
            this.Name = "ctrlUserDetails";
            this.Size = new System.Drawing.Size(751, 473);
            this.pnlUserID.ResumeLayout(false);
            this.pnlUserID.PerformLayout();
            this.pnlUserName.ResumeLayout(false);
            this.pnlUserName.PerformLayout();
            this.pnlIsActive.ResumeLayout(false);
            this.pnlIsActive.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPersonDetails ctrlUserPersonDetails;
        private System.Windows.Forms.Panel pnlUserID;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private MaterialSkin.Controls.MaterialSwitch swtchIsActive;
        public System.Windows.Forms.Panel pnlIsActive;
    }
}
