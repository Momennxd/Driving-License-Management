using DVLD_BusinessLayer;
using DVLD_PresentationLayer.Applications;
using DVLD_PresentationLayer.Dashboard;
using DVLD_PresentationLayer.Drivers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_PresentationLayer
{
    public partial class frmMainScreen : Form
    {
        public frmMainScreen()
        {
            InitializeComponent();
        }

        void _RoundControls()
        {
            Control[] C = { pnlMainScreenLoader, btnDashBoard, btnApplications, btnPeople,
            btnDrivers, btnUsers, btnAccountSettings, btnSignOut, pbCurrentUserPic };

            clsDVLDSettings.RoundControlsByCustomElips(bunifuElipse1, C);
        }

        void _ShowCurrentUserInfo()
        {
            clsPerson UserPerson = clsPerson.Find(clsDVLDSettings.CurrentUser.PersonID);
            pbCurrentUserPic.ImageLocation = UserPerson.ImagePath;
            lblCurrentUserName.Text = clsDVLDSettings.GetPersonFullName(UserPerson);

        }

        void _ColorButton(Color Clr, Button btn)
        {
            btn.BackColor = Clr;
        }

        void _ColorAllMSButtonsExcept(Button btn, Color Clr)
        {
            if (btnDashBoard.Name != btn.Name)
                _ColorButton(Clr, btnDashBoard);

            if (btnApplications.Name != btn.Name)
                _ColorButton(Clr, btnApplications);

            if (btnPeople.Name != btn.Name)
                _ColorButton(Clr, btnPeople);

            if (btnDrivers.Name != btn.Name)
                _ColorButton(Clr, btnDrivers);

            if (btnUsers.Name != btn.Name)
                _ColorButton(Clr, btnUsers);

            if (btnAccountSettings.Name != btn.Name)
                _ColorButton(Clr, btnAccountSettings);

        }

        void _StyleButton(object sender)
        {            
            ((Button)sender).BackColor = Color.FromArgb(16, 75, 160);
            _ColorAllMSButtonsExcept(((Button)sender), Color.Transparent);

        }

        void _FocusOnDashBoard()
        {
            btn_Click(btnDashBoard, EventArgs.Empty);
        }

        void _ShowInnerForm(Button btn)
        {
            pnlMainScreenLoader.Controls.Clear();

            switch (btn.Name)
            {
                case "btnPeople":
                    frmPeople frmPeople_v = new frmPeople();
                    clsDVLDSettings.ShowFormInPanel(pnlMainScreenLoader, frmPeople_v);
                    break;

                case "btnUsers":
                    frmUsers frmUsers_v = new frmUsers();
                    clsDVLDSettings.ShowFormInPanel(pnlMainScreenLoader, frmUsers_v);
                    break;

                case "btnAccountSettings":
                    frmAccountSettings frmAccountSettings_v = new frmAccountSettings();
                    clsDVLDSettings.ShowFormInPanel(pnlMainScreenLoader, frmAccountSettings_v);
                    break;

                case "btnApplications":
                    frmApplications frmApplications_v = new frmApplications();
                    clsDVLDSettings.ShowFormInPanel(pnlMainScreenLoader, frmApplications_v);
                    break;
                case "btnDrivers":
                    frmDrivers frmDrivers_v = new frmDrivers();
                    clsDVLDSettings.ShowFormInPanel(pnlMainScreenLoader, frmDrivers_v);
                    break;
                case "btnDashBoard":
                    frmDashboard frmDashboard_v = new frmDashboard();
                    clsDVLDSettings.ShowFormInPanel(pnlMainScreenLoader, frmDashboard_v);
                    break;


            }

        }



        private void frmMainScreen_Load(object sender, EventArgs e)
        {
            _RoundControls();
            _ShowCurrentUserInfo();
            _FocusOnDashBoard();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            _StyleButton((Button)sender);
            _ShowInnerForm((Button)sender);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLoginScreen frmLoginScreen_v = new frmLoginScreen();
            clsDVLDSettings.ShowForm(frmLoginScreen_v);
        }
    }
}
