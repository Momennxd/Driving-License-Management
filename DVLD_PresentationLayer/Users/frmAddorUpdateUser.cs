using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Users
{
    public partial class frmAddorUpdateUser : Form
    {
        public frmAddorUpdateUser()
        {
            InitializeComponent();
            _Mode = enMode.eAddNew;

        }

        public frmAddorUpdateUser(clsUser User)
        {
            InitializeComponent();
            _User = User;
        }


        enum enMode { eUpdate, eAddNew };

        enMode _Mode = enMode.eUpdate;

        static clsUser _User = new clsUser();

        static clsPerson _Person = new clsPerson();

        frmUser_PersonInfo _frmAddUserPersonInfo_v = new frmUser_PersonInfo();

        frmUser_UserInfo _frmUser_UserInfo_AddNewMode = new frmUser_UserInfo(_Person);

        frmUser_UserInfo _frmUser_UserInfo_UpdateMode = new frmUser_UserInfo(_User);


        void _RoundControls()
        {
            Control[] controls = { pnlUsersLoader, cbSearchFilter, txtSearchBar, btnNext, btnBack, pnlUserInfo };
            clsDVLDSettings.RoundControlsByCustomElips(bunifuElipse1, controls);

        }

        public void _GoBackToUsersForm()
        {
            frmUsers frmUsers_v = new frmUsers();
            clsDVLDSettings.ShowFormInPanel(pnlUsersLoader, frmUsers_v);
        }

        void _AlterNextBackButtonEnable(bool NextEnbale, bool BackEnable)
        {
            clsDVLDSettings.Dis_EnableContol(btnNext, NextEnbale);
            clsDVLDSettings.Dis_EnableContol(btnBack, BackEnable);

        }

        void _AlterSearchControlsEnable(bool txtSearchBarEnable, bool btnSearchEnable,
            bool cbSearchFiltersEnbale, bool btnClearSearchBarEnbale)
        {
            clsDVLDSettings.Dis_EnableContol(txtSearchBar, txtSearchBarEnable);
            clsDVLDSettings.Dis_EnableContol(btnSearch, btnSearchEnable);
            clsDVLDSettings.Dis_EnableContol(cbSearchFilter, cbSearchFiltersEnbale);
            clsDVLDSettings.Dis_EnableContol(btnClearSearchBar, btnClearSearchBarEnbale);

        }

        void _AlterFormToUpdateMode()
        {
            lblFormHeader.Text = "Update User";
        }

        void _AlterFormToAddNewMode()
        {
            lblFormHeader.Text = "Add User";
        }

        void _AlterForm(enMode Mode)
        {
            switch (Mode)
            {
                case enMode.eUpdate:
                    {
                        _AlterFormToUpdateMode();
                        break;
                    }
                case enMode.eAddNew:
                    {
                        _AlterFormToAddNewMode();
                        break;
                    }
            }
        }

        void _PerformMode()
        {
            switch (_Mode)
            {
                case enMode.eUpdate:
                    {
                        _AlterForm(_Mode);
                        _frmAddUserPersonInfo_v.ctrlUserPersonDetails.DispalyPersonData(_User.PersonID);
                        break;
                    }
                case enMode.eAddNew:
                    {
                        _AlterForm(_Mode);
                        break;
                    }

            }
        }

        void _PerformFormLoad()
        {
            _RoundControls();
            if(_Mode == enMode.eUpdate) _AlterNextBackButtonEnable(true, false);
            clsDVLDSettings.ShowFormInPanel(pnlUserInfo, _frmAddUserPersonInfo_v);
            clsDVLDSettings.ShowIndexOnSearchFilter(cbSearchFilter, 0);
        }

        void _LoadDataToPersonObj(dynamic SearchMethod)
        {
            _Person = clsPerson.Find(SearchMethod);
        }

        bool _DoesPersonExist(dynamic SearchMethod)
        {
            _LoadDataToPersonObj(SearchMethod);

            if (_Person == null)
                return false;
            else
                return true;
        }

        bool _ValidatePerson(dynamic SearchMethod)
        {
            if (_DoesPersonExist(SearchMethod))
            {
                if (!_DoesPersonHaveUser(_Person.ID))
                {
                    _frmAddUserPersonInfo_v.ctrlUserPersonDetails.DispalyPersonData(_Person.ID);
                    _AlterNextBackButtonEnable(true, false);
                }
                else
                {
                    MessageBox.Show("Person Already Has A User!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return true;
            }
            else
            {
                MessageBox.Show("Person Does not Exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        bool _DoesPersonHaveUser(int PersonID)
        {
            return clsUser.FindByPersonID(PersonID) != null;
        }

        void _PerformPersonSearch(dynamic SearchMethod)
        {
            _ValidatePerson(SearchMethod);
        }
      
        void _PerformSearch()
        {

            switch (cbSearchFilter.SelectedIndex)
            {
                case 0:
                    {
                        _PerformPersonSearch(clsDVLDSettings.IsNumber(txtSearchBar.text) ?
                Convert.ToInt32(txtSearchBar.text) : -1);

                        break;
                    }
                case 1:
                    {
                        _PerformPersonSearch(txtSearchBar.text);                       
                        break;
                    }


            }
        }

        void _PerformNextClick()
        {

            switch (_Mode)
            {
                case enMode.eUpdate:
                    {
                        //to match the person ID change if any : 
                        if (_Person != null && _Person.ID > 0) _User.PersonID = _Person.ID;
                        _frmUser_UserInfo_UpdateMode = new frmUser_UserInfo(_User);
                        clsDVLDSettings.ShowFormInPanel(pnlUserInfo, _frmUser_UserInfo_UpdateMode);
                        _AlterNextBackButtonEnable(false, true);
                        _AlterSearchControlsEnable(false, false, false, false);
                        clsDVLDSettings.In_VisibleControl(btnSave, true);
                        break;
                    }
                case enMode.eAddNew:
                    {
                        _frmUser_UserInfo_AddNewMode = new frmUser_UserInfo(_Person);
                        clsDVLDSettings.ShowFormInPanel(pnlUserInfo, _frmUser_UserInfo_AddNewMode);
                        _AlterNextBackButtonEnable(false, true);
                        _AlterSearchControlsEnable(false, false, true, false);
                        clsDVLDSettings.In_VisibleControl(btnSave, true);
                        break;
                    }

            }

        }

        void _PerformBackClick()
        {
            clsDVLDSettings.ShowFormInPanel(pnlUserInfo, _frmAddUserPersonInfo_v);

            switch (_Mode)
            {
                case enMode.eUpdate:
                    {                     
                        _AlterNextBackButtonEnable(true, false);
                        _AlterSearchControlsEnable(false, false, false, false);
                        clsDVLDSettings.In_VisibleControl(btnSave, false);
                        break;
                    }
                case enMode.eAddNew:
                    {
                        _AlterNextBackButtonEnable(true, false);
                        _AlterSearchControlsEnable(true, true, true, true);
                        clsDVLDSettings.In_VisibleControl(btnSave, false);
                        break;
                    }

            }
        }



        private void btnClearSearchBar_Click(object sender, EventArgs e)
        {
            clsDVLDSettings.ResetCustomSearchBar(txtSearchBar, lblSearchBar);
            clsDVLDSettings.ShowIndexOnSearchFilter(cbSearchFilter, 0);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _PerformSearch();
        }

        private void txtSearchBar_OnTextChange(object sender, EventArgs e)
        {
            lblSearchBar.Text = "";
        }

        private void frmAdd_UpdateUser_Load(object sender, EventArgs e)
        {
            _PerformFormLoad();
            _PerformMode();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _PerformNextClick();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _PerformBackClick();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            _GoBackToUsersForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.eAddNew)
            {
                if (_frmUser_UserInfo_AddNewMode.SaveUser())
                    _GoBackToUsersForm();
            }           
            else
            {
                if (_frmUser_UserInfo_UpdateMode.SaveUser())
                    _GoBackToUsersForm();

            }
        }
    }
    
}
