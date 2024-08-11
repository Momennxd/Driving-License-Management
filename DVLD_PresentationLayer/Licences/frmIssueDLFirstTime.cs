using DVLD_BusinessLayer;
using DVLD_PresentationLayer.Applications.Manage_Applications;
using DVLD_PresentationLayer.Tests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Licences
{
    public partial class frmIssueDLFirstTime : Form
    {
        public frmIssueDLFirstTime(clsLDLApplication LDLApp)
        {
            InitializeComponent();
            stLicenceInfo.LDLApp = LDLApp;
            stLicenceInfo.MainApp = clsApplication.Find(LDLApp.ApplicationID);
            stLicenceInfo.ApplicantPerson = clsPerson.Find(stLicenceInfo.MainApp.ApplicantPersonID);
            stLicenceInfo.LicenceClass = clsLicenseClass.Find(stLicenceInfo.LDLApp.LicenseClassID);
            stLicenceInfo.Driver = clsDriver.FindByPersonID(stLicenceInfo.ApplicantPerson.ID);
        }

        struct stLicenceInfo
        {
            public static clsLDLApplication LDLApp = null;
            public static clsLicenseClass LicenceClass = null;
            public static clsApplication MainApp = null;
            public static clsPerson ApplicantPerson = null;
            public static clsDriver Driver = null;
            public static clsLicence Licence = new clsLicence();

        }

        void _RoundControls()
        {
            Control[] controls = {pnlNotes, ctrlApplicationInfo1, ctrlLDLApplicationInfo1, btnGoBack};
            clsDVLDSettings.RoundControlsByCustomElips(bunifuElipse1, controls);
        }

        void _DisplayDataOnForm()
        {
            ctrlApplicationInfo1.DispalyApplicationData(stLicenceInfo.MainApp.ApplicationID);
            ctrlLDLApplicationInfo1.DispalyLDLAppData(stLicenceInfo.LDLApp.LocalDrivingLicenseApplicationID);
        }

        void _GoBackToLDLAppsForm()
        {
            frmLocalDrivingLicenceApp frmLocalDrivingLicenceApp_v = new frmLocalDrivingLicenceApp();
            clsDVLDSettings.ShowFormInPanel(pnlLicenceLoader, frmLocalDrivingLicenceApp_v);
        }

        bool _MakeCurrentPersonDriver()
        {
            clsDriver _Driver = new clsDriver();

            _Driver.PersonID = stLicenceInfo.ApplicantPerson.ID;
            _Driver.CreatedByUserID = clsDVLDSettings.CurrentUser.UserID;
            _Driver.CreatedDate = DateTime.Now;
            return _Driver.Save();
        }

        void _LoadDataToLicenceObj()
        {
            stLicenceInfo.Licence.ApplicationID = stLicenceInfo.MainApp.ApplicationID;
            stLicenceInfo.Licence.DriverID = clsDriver.FindByPersonID(stLicenceInfo.ApplicantPerson.ID).DriverID;
            stLicenceInfo.Licence.LicenseClass = stLicenceInfo.LDLApp.LicenseClassID;
            stLicenceInfo.Licence.IssueDate = DateTime.Now;
            stLicenceInfo.Licence.ExpirationDate = DateTime.Now.AddYears(stLicenceInfo.LicenceClass.DefaultValidityLength);
            stLicenceInfo.Licence.Notes = txtNotes.Text.Trim();
            stLicenceInfo.Licence.PaidFees = stLicenceInfo.LicenceClass.ClassFees;
            stLicenceInfo.Licence.IsActive = true;
            stLicenceInfo.Licence.IssueReason = 1;
            stLicenceInfo.Licence.CreatedByUserID = clsDVLDSettings.CurrentUser.UserID;

            //completing the app
            stLicenceInfo.MainApp.ApplicationStatus = 3;
        }


        bool _SaveLicence()
        {
            stLicenceInfo.Licence = new clsLicence();

            if (!clsDriver.DoesDriverExist(stLicenceInfo.Driver.DriverID))
                _MakeCurrentPersonDriver();

            _LoadDataToLicenceObj();
            return stLicenceInfo.Licence.Save() && stLicenceInfo.MainApp.Save();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_SaveLicence())
            {
                MessageBox.Show("Licence Issued Successfully!", "Successed",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                _GoBackToLDLAppsForm();
            }
            else
            {
                MessageBox.Show("Licence Issue Failed!", "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _GoBackToLDLAppsForm();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            _GoBackToLDLAppsForm();
        }

        private void frmIssueDLFirstTime_Load(object sender, EventArgs e)
        {
            _RoundControls();
            _DisplayDataOnForm();
        }
    }
}
