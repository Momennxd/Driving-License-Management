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

namespace DVLD_PresentationLayer.Applications.Manage_Applications.International_Driving_Licence
{
    public partial class frmAddInternationalLicence : Form
    {
        public frmAddInternationalLicence()
        {
            InitializeComponent();
        }

        struct stLicenceInfo
        {
            public static clsApplication MainApp = null;
            public static clsPerson ApplicantPerson = null;
            public static clsDriver Driver = null;
            public static clsLicence Licence = null;
            public static clsInternationalLicense IntLicence = null;

        }


        void _RoundControls()
        {
            Control[] controls = { pnlIntLicenceLoader, ctrlLicenceInfo1, txtSearchBar, btnGoBack};
            clsDVLDSettings.RoundControlsByCustomElips(bunifuElipse1, controls);

        }

        void _LoadDataToObjcts()
        {
            stLicenceInfo.Driver = clsDriver.FindByDriverID(stLicenceInfo.Licence.DriverID);
            stLicenceInfo.ApplicantPerson = clsPerson.Find(stLicenceInfo.Driver.PersonID);

        }

        void _GoBackToAppsForm()
        {
            frmInternationalDrivingLicence frmInternationalDrivingLicence_v = new frmInternationalDrivingLicence();
            clsDVLDSettings.ShowFormInPanel(pnlIntLicenceLoader, frmInternationalDrivingLicence_v);
        }

        bool _CreateIntLicencMainApp()
        {
            stLicenceInfo.MainApp = new clsApplication();
            stLicenceInfo.MainApp.ApplicantPersonID = stLicenceInfo.ApplicantPerson.ID;
            stLicenceInfo.MainApp.ApplicationDate = DateTime.Now;
            stLicenceInfo.MainApp.ApplicationTypeID = 6;
            stLicenceInfo.MainApp.ApplicationStatus = 3;
            stLicenceInfo.MainApp.LastStatusDate = DateTime.Now;
            stLicenceInfo.MainApp.PaidFees = clsApplicationType.Find(6).ApplicationFees;
            stLicenceInfo.MainApp.CreatedByUserID = clsDVLDSettings.CurrentUser.UserID;
            return stLicenceInfo.MainApp.Save();

        }

        bool _CreateIntLicencObj()
        {
            stLicenceInfo.IntLicence = new clsInternationalLicense();

            stLicenceInfo.IntLicence.ApplicationID = clsApplication.LastAppIDAdded;
            stLicenceInfo.IntLicence.DriverID = stLicenceInfo.Driver.DriverID;
            stLicenceInfo.IntLicence.IssuedUsingLocalLicenseID = stLicenceInfo.Licence.LicenseID;
            stLicenceInfo.IntLicence.IssueDate = DateTime.Now;
            stLicenceInfo.IntLicence.ExpirationDate = DateTime.Now.AddYears(clsLicenseClass.Find(
                stLicenceInfo.Licence.LicenseClass).DefaultValidityLength);
            stLicenceInfo.IntLicence.IsActive = true;
            stLicenceInfo.IntLicence.CreatedByUserID = clsDVLDSettings.CurrentUser.UserID;
            return stLicenceInfo.IntLicence.Save();

        }

        bool _SaveIntLicence()
        {
            return _CreateIntLicencMainApp() && _CreateIntLicencObj();
        }

        void _ResetObjcts()
        {
            stLicenceInfo.MainApp = null;
            stLicenceInfo.ApplicantPerson = null;
            stLicenceInfo.Driver = null;
            stLicenceInfo.Licence = null;
            stLicenceInfo.IntLicence = null;        
        }


        void _LoadDataToLicenceObj(dynamic SearchMethod)
        {
            stLicenceInfo.Licence = clsLicence.FindByLicenceID(SearchMethod);
        }

        bool _DoesLicenceExist(dynamic SearchMethod)
        {
            _LoadDataToLicenceObj(SearchMethod);

            if (stLicenceInfo.Licence == null)
                return false;
            else
                return true;
        }

        bool _ValidateLicence(dynamic SearchMethod)
        {
            if (_DoesLicenceExist(SearchMethod))
            {
                if (!stLicenceInfo.Licence.IsActive)
                {
                    MessageBox.Show("Licence Is Not Active!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (clsDVLDSettings.IsDate1GreaterThanDate2(DateTime.Now, stLicenceInfo.Licence.ExpirationDate))
                {
                    MessageBox.Show("Licence Is Expired!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (stLicenceInfo.Licence.LicenseClass != 3)
                {
                    MessageBox.Show("Licence Class Should Be (Class 3 - Ordinary driving license)!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (clsInternationalLicense.DoesIntLicenceExistByLicence(stLicenceInfo.Licence.LicenseID))
                {
                    MessageBox.Show("This Licence's Owner Already Has An International Licence!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }


                ctrlLicenceInfo1.DispalyLicenceData(stLicenceInfo.Licence.LicenseID);
                btnSave.Enabled = true;
                return true;
            }
            else
            {
                MessageBox.Show("Licence Does not Exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        void _PerformLicenceSearch(dynamic SearchMethod)
        {
            if (_ValidateLicence(SearchMethod)) _LoadDataToObjcts();
        }












        private void btnSearch_Click(object sender, EventArgs e)
        {
            _PerformLicenceSearch(clsDVLDSettings.IsNumber(txtSearchBar.text) ?
                Convert.ToInt32(txtSearchBar.text) : -1);
        }

        private void txtSearchBar_OnTextChange(object sender, EventArgs e)
        {
            lblSearchBar.Text = "";
        }

        private void btnClearSearchBar_Click(object sender, EventArgs e)
        {
            clsDVLDSettings.ResetCustomSearchBar(txtSearchBar, lblSearchBar, "LicenceID..");
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            _GoBackToAppsForm();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _GoBackToAppsForm();
        }

        private void frmAddInternationalLicence_Load(object sender, EventArgs e)
        {
            _RoundControls();
            _ResetObjcts();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_SaveIntLicence())
            {
                MessageBox.Show("Local Licence Saved Successfully", "Successed", MessageBoxButtons.OK);
                _GoBackToAppsForm();
            }
            else
            {
                MessageBox.Show("Failed To Save Local Licencey", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
