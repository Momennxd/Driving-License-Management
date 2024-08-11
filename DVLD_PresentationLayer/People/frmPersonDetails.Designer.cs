namespace DVLD_PresentationLayer
{
    partial class frmPersonDetails
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
            this.pnlPeopleLoader = new System.Windows.Forms.Panel();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnEditPerson = new Bunifu.Framework.UI.BunifuImageButton();
            this.ctrlPersonDetails = new DVLD_PresentationLayer.ctrlPersonDetails();
            this.pnlPeopleLoader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPeopleLoader
            // 
            this.pnlPeopleLoader.Controls.Add(this.btnEditPerson);
            this.pnlPeopleLoader.Controls.Add(this.btnGoBack);
            this.pnlPeopleLoader.Controls.Add(this.ctrlPersonDetails);
            this.pnlPeopleLoader.Controls.Add(this.label1);
            this.pnlPeopleLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPeopleLoader.Location = new System.Drawing.Point(0, 0);
            this.pnlPeopleLoader.Name = "pnlPeopleLoader";
            this.pnlPeopleLoader.Size = new System.Drawing.Size(1005, 770);
            this.pnlPeopleLoader.TabIndex = 2;
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
            this.btnGoBack.TabIndex = 32;
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label1.Location = new System.Drawing.Point(82, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 50);
            this.label1.TabIndex = 26;
            this.label1.Text = "Person Details";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnEditPerson
            // 
            this.btnEditPerson.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditPerson.Image = global::DVLD_PresentationLayer.Properties.Resources.icons8_edit_48;
            this.btnEditPerson.ImageActive = null;
            this.btnEditPerson.Location = new System.Drawing.Point(462, 505);
            this.btnEditPerson.Name = "btnEditPerson";
            this.btnEditPerson.Size = new System.Drawing.Size(56, 43);
            this.btnEditPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEditPerson.TabIndex = 34;
            this.btnEditPerson.TabStop = false;
            this.btnEditPerson.Zoom = 10;
            this.btnEditPerson.Click += new System.EventHandler(this.btnEditPerson_Click);
            // 
            // ctrlPersonDetails
            // 
            this.ctrlPersonDetails.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ctrlPersonDetails.Location = new System.Drawing.Point(125, 145);
            this.ctrlPersonDetails.Name = "ctrlPersonDetails";
            this.ctrlPersonDetails.Size = new System.Drawing.Size(724, 418);
            this.ctrlPersonDetails.TabIndex = 27;
            // 
            // frmPersonDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1005, 770);
            this.Controls.Add(this.pnlPeopleLoader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPersonDetails";
            this.Text = "frmPersonDetails";
            this.Load += new System.EventHandler(this.frmPersonDetails_Load);
            this.pnlPeopleLoader.ResumeLayout(false);
            this.pnlPeopleLoader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditPerson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPeopleLoader;
        private System.Windows.Forms.Label label1;
        private ctrlPersonDetails ctrlPersonDetails;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button btnGoBack;
        private Bunifu.Framework.UI.BunifuImageButton btnEditPerson;
    }
}