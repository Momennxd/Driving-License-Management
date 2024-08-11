using Bunifu.Framework.UI;
using DVLD_PresentationLayer.Users;
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
    public partial class frmAccountSettings : Form
    {
        public frmAccountSettings()
        {
            InitializeComponent();
        }

        void _RoundControls()
        {
            Control[] C = { ctrlCurrentlUserDetails };

            clsDVLDSettings.RoundControlsByCustomElips(bunifuElipse1, C);
        }


        void _DisplayUserInfo()
        {
            ctrlCurrentlUserDetails.DispalyUserInfo(clsDVLDSettings.CurrentUser.UserID);
        }

        void _ShowChangePasswordForm()
        {
            frmChangeUserPassword frmChangeUserPassword_v = new frmChangeUserPassword(clsDVLDSettings.CurrentUser);
            clsDVLDSettings.ShowFormInPanel(pnlAccountSettingsLoader, frmChangeUserPassword_v);
        }





        private void frmAccountSettings_Load(object sender, EventArgs e)
        {
            _RoundControls();
            _DisplayUserInfo();
        }

      
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            _ShowChangePasswordForm();
        }
    }
}
