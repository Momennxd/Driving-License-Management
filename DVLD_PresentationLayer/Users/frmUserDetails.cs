using DVLD_BusinessLayer;
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
    public partial class frmUserDetails : Form
    {
        public frmUserDetails(clsUser User)
        {
            InitializeComponent();
            _SelectedUser = User;
        }


        clsUser _SelectedUser = new clsUser();

        void _RoundControls()
        {
            Control[] controls = { ctrlUserDetails, pnlUsersLoader };
            clsDVLDSettings.RoundControlsByCustomElips(bunifuElipse1, controls);

        }

        void _GoBackToUsersForm()
        {
            frmUsers frmUsers_v = new frmUsers();
            clsDVLDSettings.ShowFormInPanel(pnlUsersLoader, frmUsers_v);
        }

        private void frmUserDetails_Load(object sender, EventArgs e)
        {
            _RoundControls();
            ctrlUserDetails.DispalyUserInfo(_SelectedUser.UserID);
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            _GoBackToUsersForm();
        }
     
        private void btnEditUser_Click(object sender, EventArgs e)
        {
            frmAddorUpdateUser frmAdd_UpdateUser_v = new frmAddorUpdateUser(_SelectedUser);
            clsDVLDSettings.ShowFormInPanel(pnlUsersLoader, frmAdd_UpdateUser_v);
        }
    }
}
