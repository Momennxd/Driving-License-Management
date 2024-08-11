namespace DVLD_PresentationLayer.Users
{
    partial class frmUser_PersonInfo
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
            this.ctrlUserPersonDetails = new DVLD_PresentationLayer.ctrlPersonDetails();
            this.SuspendLayout();
            // 
            // ctrlUserPersonDetails
            // 
            this.ctrlUserPersonDetails.BackColor = System.Drawing.Color.White;
            this.ctrlUserPersonDetails.Location = new System.Drawing.Point(10, 5);
            this.ctrlUserPersonDetails.Name = "ctrlUserPersonDetails";
            this.ctrlUserPersonDetails.Size = new System.Drawing.Size(719, 362);
            this.ctrlUserPersonDetails.TabIndex = 45;
            // 
            // frmAddUserPersonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(741, 379);
            this.Controls.Add(this.ctrlUserPersonDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddUserPersonInfo";
            this.Text = "frmAddUserPersonInfo";
            this.ResumeLayout(false);

        }

        #endregion

        public ctrlPersonDetails ctrlUserPersonDetails;
    }
}