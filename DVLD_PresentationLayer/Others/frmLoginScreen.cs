using Bunifu.Framework.UI;
using DVLD_BusinessLayer;
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
    public partial class frmLoginScreen : Form
    {
        public frmLoginScreen()
        {
            InitializeComponent();
        }

        clsUser _CurrentUser = new clsUser();



        void _RoundControls()
        {
            Control[] C = {pbDrivingLiecenceImage, this, pnlLogin, btnSignIn };

            clsDVLDSettings.RoundControlsByCustomElips(bunifuElipse1, C);
        }

        void _ShowMainScreen()
        {
            this.Hide();
            frmMainScreen frmMainScreen_v = new frmMainScreen();
            clsDVLDSettings.ShowForm(frmMainScreen_v);
        }

        void _DisplayUserInfo(string UserName, string Password)
        {
            txtUserName.text = UserName;
            txtPassword.text = Password;
        }

        void _DispalyUserInfoIfAny()
        {
            string TextFileContent = clsDVLDSettings.GetFileTextContent(clsDVLDSettings.UserInfoFilePath);

            if (!string.IsNullOrEmpty(TextFileContent))
            {
                string UserName = "", Password = "";
                clsDVLDSettings.GetUserInfoByFile(ref UserName, ref Password,
                    clsDVLDSettings.UserInfoFilePath, clsDVLDSettings.Seperator);
                _DisplayUserInfo(UserName, Password);
            }
        }

        void _LoadDataToUserObj()
        {
            _CurrentUser = clsUser.FindByUserName(txtUserName.text.Trim());
        }

        bool _ValidateInfoCompletion()
        {
            return clsDVLDSettings.ValidateTxtBox(txtUserName, string.IsNullOrEmpty(txtUserName.text),
              "Please Enter Your User Name!", errorInfoValidation) &&

              clsDVLDSettings.ValidateTxtBox(txtPassword, string.IsNullOrEmpty(txtPassword.text),
              "Please Enter Your Password!", errorInfoValidation);

        }

        bool _ValidateIfUserExists()
        {
            return _CurrentUser != null;
        }

        bool _ValidatePassword()
        {
            return _CurrentUser.Password == txtPassword.text.Trim();
        }

        bool _ValidateIfUserActive()
        {
            return _CurrentUser.IsActive;
        }

        bool _ValidateInfo()
        {
            if (_ValidateInfoCompletion())
            {
                _LoadDataToUserObj();

                if (_ValidateIfUserExists() && _ValidatePassword())
                {
                    if (_ValidateIfUserActive())
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Your Account Has Been Suspended, Please Contact Your Admin", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("Account Does Not Exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return false;
        }

        void _RememberUser()
        {
            clsDVLDSettings.SaveUserInfoToLogin(txtUserName.text, txtPassword.text,
                clsDVLDSettings.UserInfoFilePath, clsDVLDSettings.Seperator);
        }

        void _MakeLoggerCurrentUser()
        {
            clsDVLDSettings.CurrentUser = _CurrentUser;
        }

        void _PerformSignIn()
        {
            if (_ValidateInfo())
            {
                if (chckRememberMe.Checked) _RememberUser();
                else clsDVLDSettings.ClearFileContent(clsDVLDSettings.UserInfoFilePath);

                _MakeLoggerCurrentUser();
                _ShowMainScreen();
            }
        }





        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void frmLoginScreen_Load(object sender, EventArgs e)
        {
            _RoundControls();
            _DispalyUserInfoIfAny();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            _PerformSignIn();
        }
    }
}
