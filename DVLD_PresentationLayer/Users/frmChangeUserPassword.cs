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

namespace DVLD_PresentationLayer.Users
{
    public partial class frmChangeUserPassword : Form
    {
        public frmChangeUserPassword(clsUser User)
        {
            InitializeComponent();
            _User = User;
        }

        clsUser _User = new clsUser();


        void _RoundControls()
        {
            Control[] controls = { pnlUsersLoader, pnlPasswordInfo, pnlCurrentPassword,
                pnlNewPassword, pnlConfirmPassword };
            clsDVLDSettings.RoundControlsByCustomElips(bunifuElipse1, controls);

        }

        void _GoBackToUsersForm()
        {
            frmUsers frmUsers_v = new frmUsers();
            clsDVLDSettings.ShowFormInPanel(pnlUsersLoader, frmUsers_v);
        }

        void _DisplayUserInfoOnForm()
        {
            ctrlUserDetails.DispalyUserInfo(_User.UserID);
        }

        bool _ValidateUserInfo()
        {
            return (clsDVLDSettings.ValidateTxtBox(txtCurrentPassword, (txtCurrentPassword.Text.Trim() != _User.Password),
                "Passsword Is Wrong, Please Try Again.", errorInfoValidation) &&

                (clsDVLDSettings.ValidateTxtBox(txtNewPassword, "",
                "Please Enter A Valid Passwrod.", errorInfoValidation)) &&

                clsDVLDSettings.ValidateTxtBox(txtConfirmPassword, (txtNewPassword.Text != txtConfirmPassword.Text),
                "Confirmation Should Match Password", errorInfoValidation));
        }

        void _LoadDataToUserObj()
        {
            _User.Password = txtConfirmPassword.Text.Trim();
        }

        bool _SaveUser()
        {

            if (_ValidateUserInfo())
            {
                _LoadDataToUserObj();
                if (_User.Save())
                {
                    MessageBox.Show("User Saved Successfully");
                    return true;
                }
            }

            return false;

        }






        private void frmChangeUserPassword_Load(object sender, EventArgs e)
        {
            _RoundControls();
            _DisplayUserInfoOnForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_SaveUser())
            {
                _GoBackToUsersForm();
            }
          
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _GoBackToUsersForm();
        }
    }
}
