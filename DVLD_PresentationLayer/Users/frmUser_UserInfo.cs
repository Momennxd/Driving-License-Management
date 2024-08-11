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
    public partial class frmUser_UserInfo : Form
    {
        public frmUser_UserInfo(clsPerson UserPerson)
        {
            InitializeComponent();
            _UserPerson = UserPerson;
            _Mode = enMode.eAddNew;
        }

        public frmUser_UserInfo(clsUser User)
        {
            InitializeComponent();
            _User = User;
        }


        enum enMode { eUpdate, eAddNew };

        enMode _Mode = enMode.eUpdate;

        clsPerson _UserPerson = new clsPerson();

        clsUser _User = new clsUser();

        void _RoundControls()
        {
            Control[] controls = { pnlUserName, pnlPassword, pnlConfirmPassword, pnlIsActive};
            clsDVLDSettings.RoundControlsByCustomElips(bunifuElipse1, controls);

        }
     
        void _LoadDataToUserObj()
        {
            if (_Mode == enMode.eAddNew) _User.PersonID = _UserPerson.ID;

            _User.UserName = txtUserName.Text.Trim();
            _User.Password = txtPassword.Text.Trim();
            _User.IsActive = swtchIsActive.Checked ? true : false;

        }

        bool _ValidateUserInfo()
        {
            return (clsDVLDSettings.ValidateTxtBox(txtUserName, "",
                "Please Enter A User Name", errorInfoValidation) &&

                clsDVLDSettings.ValidateTxtBox(txtConfirmPassword, (txtPassword.Text != txtConfirmPassword.Text),
                "Confirmation Should Match Password", errorInfoValidation));
        }

        void _DispalyUserInfoOnForm()
        {
            txtUserName.Text = _User.UserName;
            txtPassword.Text = _User.Password;
            txtConfirmPassword.Text = "";
            swtchIsActive.Checked = _User.IsActive ? true : false;
        }

        public bool SaveUser()
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

        void _PerformMode()
        {
            switch (_Mode)
            {
                case enMode.eUpdate:
                    {
                        _DispalyUserInfoOnForm();
                        break;
                    }
                case enMode.eAddNew:
                    {
                        //
                        break;
                    }

            }
        }







        private void frmUser_UserInfo_Load(object sender, EventArgs e)
        {
            _RoundControls();
            _PerformMode();
        }

       
    }
}
