using DVLD_BusinessLayer;
using DVLD_PresentationLayer.Applications.Driving_Licence_Services;
using DVLD_PresentationLayer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Applications.Detain_Licences
{
    public partial class frmDetainAndReleaseLicence : Form
    {
        public frmDetainAndReleaseLicence(byte Mode, clsLicence Licence = null)
        {
            InitializeComponent();
            stLicenceInfo.Licence = Licence;
            _Mode = (enMode)Mode;
            stLicenceInfo.IsLiceneSelected = Licence != null;
        }

        struct stLicenceInfo
        {
            public static clsApplication NewReleaseLicenceMainApp = null;
            public static clsPerson ApplicantPerson = null;
            public static clsDriver Driver = null;
            public static clsLicence Licence = null;
            public static clsDetainedLicence DetainedLicence = null;
            public static int NewAppType = 5;    //5 is for releasing the licence
            public static bool IsLiceneSelected = false;


        }

        enum enMode { eDetain = 1, eRelease = 2 }

        enMode _Mode = enMode.eDetain;

        void _RoundControls()
        {
            Control[] controls = { pnlIntLicenceLoader, ctrlLicenceInfo1, txtSearchBar, btnGoBack,
            pnlAppFees, pnlDetainLicenceFees, pnlTotalFees};
            clsDVLDSettings.RoundControlsByCustomElips(bunifuElipse1, controls);

        }


        void _LoadDataToObjcts()
        {
            stLicenceInfo.Driver = clsDriver.FindByDriverID(stLicenceInfo.Licence.DriverID);
            stLicenceInfo.ApplicantPerson = clsPerson.Find(stLicenceInfo.Driver.PersonID);

            if (clsLicence.IsLicenceDetained(stLicenceInfo.Licence.LicenseID))
                stLicenceInfo.DetainedLicence = clsDetainedLicence.FindUnReleasedByLicenseID(stLicenceInfo.Licence.LicenseID);
        }

        void _GoBackToAppsForm()
        {
            frmManageDetainedLicences frmManageDetainedLicences_v = new frmManageDetainedLicences();
            clsDVLDSettings.ShowFormInPanel(pnlIntLicenceLoader, frmManageDetainedLicences_v);
        }

        bool _CreateReleaseLicenceMainApp()
        {
            stLicenceInfo.NewReleaseLicenceMainApp = new clsApplication();
            stLicenceInfo.NewReleaseLicenceMainApp.ApplicantPersonID = stLicenceInfo.ApplicantPerson.ID;
            stLicenceInfo.NewReleaseLicenceMainApp.ApplicationDate = DateTime.Now;
            stLicenceInfo.NewReleaseLicenceMainApp.ApplicationTypeID = stLicenceInfo.NewAppType;
            stLicenceInfo.NewReleaseLicenceMainApp.ApplicationStatus = 3;
            stLicenceInfo.NewReleaseLicenceMainApp.LastStatusDate = DateTime.Now;
            stLicenceInfo.NewReleaseLicenceMainApp.PaidFees = clsApplicationType.Find(stLicenceInfo.NewAppType).ApplicationFees;
            stLicenceInfo.NewReleaseLicenceMainApp.CreatedByUserID = clsDVLDSettings.CurrentUser.UserID;
            return stLicenceInfo.NewReleaseLicenceMainApp.Save();

        }

        bool _CreateDetainedLicence()
        {
            stLicenceInfo.DetainedLicence = new clsDetainedLicence();
            stLicenceInfo.DetainedLicence.LicenseID = stLicenceInfo.Licence.LicenseID;
            stLicenceInfo.DetainedLicence.DetainDate = DateTime.Now;
            stLicenceInfo.DetainedLicence.FineFees = Convert.ToDecimal(txtDetainFees.Text);
            stLicenceInfo.DetainedLicence.IsReleased = false;
            stLicenceInfo.DetainedLicence.CreatedByUserID = clsDVLDSettings.CurrentUser.UserID;
            return stLicenceInfo.DetainedLicence.Save();

        }

        bool _ReleaseDetainedLicence()
        {
            stLicenceInfo.DetainedLicence.IsReleased = true;
            stLicenceInfo.DetainedLicence.ReleaseDate = DateTime.Now;
            stLicenceInfo.DetainedLicence.ReleasedByUserID = clsDVLDSettings.CurrentUser.UserID;
            stLicenceInfo.DetainedLicence.ReleaseApplicationID = clsApplication.LastAppIDAdded;
            return stLicenceInfo.DetainedLicence.Save();
        }

        bool _Save()
        {
            switch (_Mode)
            {
                case enMode.eDetain:
                    {
                        return _CreateDetainedLicence();
                    }
                case enMode.eRelease:
                    {
                        return _CreateReleaseLicenceMainApp() && _ReleaseDetainedLicence();
                    }
            }

            return false;

        }

        void _ResetObjcts()
        {
            stLicenceInfo.NewReleaseLicenceMainApp = null;
            stLicenceInfo.ApplicantPerson = null;
            stLicenceInfo.Driver = null;
            if (!stLicenceInfo.IsLiceneSelected) stLicenceInfo.Licence = null;
            stLicenceInfo.DetainedLicence = null;
        }

        void _ShowAppFeesInfo()
        {
            if (_Mode == enMode.eRelease)
                lblAppFees.Text = clsApplicationType.Find(stLicenceInfo.NewAppType).ApplicationFees.ToString();
        }

        void _ShowLicenceFeesInfo()
        {
            if (_Mode == enMode.eRelease)
            {
                lblTotalFees.Text = lblAppFees.Text;
            }
            else
            {
                lblTotalFees.Text = (Convert.ToDecimal(lblAppFees.Text) +
                Convert.ToDecimal(txtDetainFees.Text.Trim())).ToString();
            }
                
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
                    MessageBox.Show($"Licence Is Expired",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (_Mode == enMode.eRelease && !clsLicence.IsLicenceDetained(stLicenceInfo.Licence.LicenseID))
                {
                    MessageBox.Show($"Licence Is Not Detained",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (_Mode == enMode.eDetain && clsLicence.IsLicenceDetained(stLicenceInfo.Licence.LicenseID))
                {
                    MessageBox.Show($"Licence Is Detained Aleady",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (_ValidateLicence(SearchMethod))
            {
                _LoadDataToObjcts();
                _ShowLicenceFeesInfo();
            }
        }

        void _AlterFormForMode()
        {
            switch (_Mode)
            {
                case enMode.eDetain:
                    {
                        btnSave.Image = Resources.icons8_detain_48;
                        lblFormHeader.Text = "Detain Licence";
                        
                        break;
                    }
                case enMode.eRelease:
                    {
                        btnSave.Image = Resources.icons8_access_control_64__2_;
                        lblFormHeader.Text = "Release Licence";
                        txtDetainFees.Enabled = false;
                        break;
                    }
            }
        }

        bool _VlidateDetainFeeTxt()
        {
            if (_Mode == enMode.eDetain)
                return clsDVLDSettings.ValidateIfTxtBoxIsNotNumber(txtDetainFees,
                    "Please Enter The Fee", errorProvider1);
            else
                return true;

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

        private void frmDetainLicence_Load(object sender, EventArgs e)
        {
            _RoundControls();
            _ResetObjcts();
            _ShowAppFeesInfo();
            _AlterFormForMode();

            if (stLicenceInfo.IsLiceneSelected)
            {
                _PerformLicenceSearch(stLicenceInfo.Licence.LicenseID);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_VlidateDetainFeeTxt())
                return;

            if (_Save())
            {

                _ = _Mode == enMode.eDetain ?
                    MessageBox.Show("Licence Detained Successfully", "Successed", MessageBoxButtons.OK) :
                    MessageBox.Show("Licence Released Successfully", "Successed", MessageBoxButtons.OK);
                _GoBackToAppsForm();
            }
            else
            {
                _ = _Mode == enMode.eDetain ?
                                   MessageBox.Show("Failed To Detaine Licence", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error) :
                                   MessageBox.Show("Failed To Release Licence", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
