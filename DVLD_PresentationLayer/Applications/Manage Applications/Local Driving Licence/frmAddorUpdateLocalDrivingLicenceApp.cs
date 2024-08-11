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

namespace DVLD_PresentationLayer.Applications.Manage_Applications
{
    public partial class frmAddorUpdateLocalDrivingLicenceApp : Form
    {
        public frmAddorUpdateLocalDrivingLicenceApp()
        {
            InitializeComponent();
            _Mode = enMode.eAddNew;

        }

        public frmAddorUpdateLocalDrivingLicenceApp(clsLDLApplication lDLApplication)
        {
            InitializeComponent();
            _SelectedLDLApp = lDLApplication;
            _ApplicantPerson = clsPerson.Find(clsApplication.Find(_SelectedLDLApp.ApplicationID).ApplicantPersonID);
        }


        enum enMode { eUpdate, eAddNew };

        enMode _Mode = enMode.eUpdate;


        static clsLDLApplication _SelectedLDLApp = new clsLDLApplication();

        static clsPerson _ApplicantPerson = new clsPerson();


        frmUser_PersonInfo _frmAddLDLApp_PersonInfo_v = new frmUser_PersonInfo();

        frmLDLApp_LDLAppInfoToAddorUpd _frmAddLDLApp_LDLAppInfo_v = new frmLDLApp_LDLAppInfoToAddorUpd(_ApplicantPerson.ID);

        frmLDLApp_LDLAppInfoToAddorUpd _frmUpdateLDLApp_LDLAppInfo_v = new frmLDLApp_LDLAppInfoToAddorUpd(_SelectedLDLApp);


        void _RoundControls()
        {
            Control[] controls = { pnlLDLAppLoader, cbSearchFilter, txtSearchBar, btnNext, btnBack, pnlLDLAppInfo };
            clsDVLDSettings.RoundControlsByCustomElips(bunifuElipse1, controls);

        }

        public void _GoBackToLDLAppsForm()
        {
            frmLocalDrivingLicenceApp frmLocalDrivingLicenceApp_v = new frmLocalDrivingLicenceApp();
            clsDVLDSettings.ShowFormInPanel(pnlLDLAppLoader, frmLocalDrivingLicenceApp_v);
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
            lblFormHeader.Text = "Update LDL App";
        }

        void _AlterFormToAddNewMode()
        {
            lblFormHeader.Text = "Add LDL App";
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
                        _frmAddLDLApp_PersonInfo_v.ctrlUserPersonDetails.DispalyPersonData(_ApplicantPerson.ID);
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
            if (_Mode == enMode.eUpdate) _AlterNextBackButtonEnable(true, false);
            clsDVLDSettings.ShowFormInPanel(pnlLDLAppInfo, _frmAddLDLApp_PersonInfo_v);
            clsDVLDSettings.ShowIndexOnSearchFilter(cbSearchFilter, 0);
        }

        void _LoadDataToPersonObj(dynamic SearchMethod)
        {
            _ApplicantPerson = clsPerson.Find(SearchMethod);
        }

        bool _DoesPersonExist(dynamic SearchMethod)
        {
            _LoadDataToPersonObj(SearchMethod);

            if (_ApplicantPerson == null)
                return false;
            else
                return true;
        }

        bool _ValidatePerson(dynamic SearchMethod)
        {
            if (_DoesPersonExist(SearchMethod))
            {
                _frmAddLDLApp_PersonInfo_v.ctrlUserPersonDetails.DispalyPersonData(_ApplicantPerson.ID) ;
                _AlterNextBackButtonEnable(true, false);
                           
                return true;
            }
            else
            {
                MessageBox.Show("Person Does not Exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
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

        void _SavePersonIDChangesToLDLApp()
        {
            if (_ApplicantPerson != null && _ApplicantPerson.ID > 0)
            {
                clsApplication _MainApp = clsApplication.Find(_SelectedLDLApp.ApplicationID);
                _MainApp.ApplicantPersonID = _ApplicantPerson.ID;
                _MainApp.Save();
            }

        }

        void _PerformNextClick()
        {

            switch (_Mode)
            {
                case enMode.eUpdate:
                    {
                        //to match the person ID change if any : 
                        _SavePersonIDChangesToLDLApp();
                        _frmUpdateLDLApp_LDLAppInfo_v = new frmLDLApp_LDLAppInfoToAddorUpd(_SelectedLDLApp);
                        clsDVLDSettings.ShowFormInPanel(pnlLDLAppInfo, _frmUpdateLDLApp_LDLAppInfo_v);
                        _AlterNextBackButtonEnable(false, true);
                        _AlterSearchControlsEnable(false, false, false, false);
                        clsDVLDSettings.In_VisibleControl(btnSave, true);
                        break;
                    }
                case enMode.eAddNew:
                    {
                        _frmAddLDLApp_LDLAppInfo_v = new frmLDLApp_LDLAppInfoToAddorUpd(_ApplicantPerson.ID);
                        clsDVLDSettings.ShowFormInPanel(pnlLDLAppInfo, _frmAddLDLApp_LDLAppInfo_v);
                        _AlterNextBackButtonEnable(false, true);
                        _AlterSearchControlsEnable(false, false, true, false);
                        clsDVLDSettings.In_VisibleControl(btnSave, true);
                        break;
                    }

            }

        }

        void _PerformBackClick()
        {
            clsDVLDSettings.ShowFormInPanel(pnlLDLAppInfo, _frmAddLDLApp_PersonInfo_v);

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

        private void frmAddorUpdateLocalDrivingLicenceApp_Load(object sender, EventArgs e)
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
            _GoBackToLDLAppsForm();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.eAddNew)
            {
                if (_frmAddLDLApp_LDLAppInfo_v.PerformSaving())
                    _GoBackToLDLAppsForm();
            }
            else
            {
                if (_frmUpdateLDLApp_LDLAppInfo_v.PerformSaving())
                    _GoBackToLDLAppsForm();

            }
        }
    }
}
