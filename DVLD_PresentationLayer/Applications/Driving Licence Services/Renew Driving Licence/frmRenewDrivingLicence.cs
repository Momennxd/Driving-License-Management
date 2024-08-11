using DVLD_BusinessLayer;
using DVLD_PresentationLayer.Applications.Manage_Applications.International_Driving_Licence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Applications.Driving_Licence_Services.Renew_Driving_Licence
{
    public partial class frmRenewDrivingLicence : Form
    {
        public frmRenewDrivingLicence()
        {
            InitializeComponent();
        }

        struct stLicenceInfo
        {
            public static clsApplication NewLicenceMainApp = null;
            public static clsPerson ApplicantPerson = null;
            public static clsDriver Driver = null;
            public static clsLicence OldLicence = null;
            public static clsLicence NewLicence = null;
            public static clsLicenseClass LicenceClass = null;
            public static int NewAppType = 2;
            public static byte IssueReason = 2;


        }

        void _RoundControls()
        {
            Control[] controls = { pnlIntLicenceLoader, ctrlLicenceInfo1, txtSearchBar, btnGoBack, 
            pnlAppFees, pnlNewLicenceFees, pnlNewLicenceNotes, pnlTotalFees};
            clsDVLDSettings.RoundControlsByCustomElips(bunifuElipse1, controls);

        }

        void _LoadDataToObjcts()
        {
            stLicenceInfo.Driver = clsDriver.FindByDriverID(stLicenceInfo.OldLicence.DriverID);
            stLicenceInfo.ApplicantPerson = clsPerson.Find(stLicenceInfo.Driver.PersonID);
            stLicenceInfo.LicenceClass = clsLicenseClass.Find(stLicenceInfo.OldLicence.LicenseClass);
        }

        void _GoBackToAppsForm()
        {
            frmDrivingLicenceServices frmDrivingLicenceServices_v = new frmDrivingLicenceServices();
            clsDVLDSettings.ShowFormInPanel(pnlIntLicenceLoader, frmDrivingLicenceServices_v);
        }

        bool _DeActivateOldLicence()
        {
            stLicenceInfo.OldLicence.IsActive = false;
            return stLicenceInfo.OldLicence.Save();
        }

        bool _CreateRenewLicenceMainApp()
        {
            stLicenceInfo.NewLicenceMainApp = new clsApplication();
            stLicenceInfo.NewLicenceMainApp.ApplicantPersonID = stLicenceInfo.ApplicantPerson.ID;
            stLicenceInfo.NewLicenceMainApp.ApplicationDate = DateTime.Now;
            stLicenceInfo.NewLicenceMainApp.ApplicationTypeID = stLicenceInfo.NewAppType;
            stLicenceInfo.NewLicenceMainApp.ApplicationStatus = 3;
            stLicenceInfo.NewLicenceMainApp.LastStatusDate = DateTime.Now;
            stLicenceInfo.NewLicenceMainApp.PaidFees = clsApplicationType.Find(stLicenceInfo.NewAppType).ApplicationFees;
            stLicenceInfo.NewLicenceMainApp.CreatedByUserID = clsDVLDSettings.CurrentUser.UserID;
            return stLicenceInfo.NewLicenceMainApp.Save();

        }

        bool _CreateNewLicencObj()
        {
            stLicenceInfo.NewLicence = new clsLicence();

            stLicenceInfo.NewLicence.ApplicationID = clsApplication.LastAppIDAdded;
            stLicenceInfo.NewLicence.DriverID = stLicenceInfo.Driver.DriverID;
            stLicenceInfo.NewLicence.LicenseClass = stLicenceInfo.LicenceClass.LicenseClassID;
            stLicenceInfo.NewLicence.IssueDate = DateTime.Now;
            stLicenceInfo.NewLicence.ExpirationDate = DateTime.Now.AddYears(stLicenceInfo.LicenceClass.DefaultValidityLength);
            stLicenceInfo.NewLicence.Notes = txtNewLicenceNotes.Text.Trim();
            stLicenceInfo.NewLicence.PaidFees = stLicenceInfo.LicenceClass.ClassFees;
            stLicenceInfo.NewLicence.IsActive = true;
            stLicenceInfo.NewLicence.IssueReason = stLicenceInfo.IssueReason;
            stLicenceInfo.NewLicence.CreatedByUserID = clsDVLDSettings.CurrentUser.UserID;
            return stLicenceInfo.NewLicence.Save();

        }

        bool _SaveNewLicence()
        {
            return _DeActivateOldLicence() && _CreateRenewLicenceMainApp() && _CreateNewLicencObj();
        }

        void _ResetObjcts()
        {
            stLicenceInfo.NewLicenceMainApp = null;
            stLicenceInfo.ApplicantPerson = null;
            stLicenceInfo.Driver = null;
            stLicenceInfo.OldLicence = null;
            stLicenceInfo.NewLicenceMainApp = null;
            stLicenceInfo.LicenceClass = null;
        }

        void _ShowAppFeesInfo()
        {
            lblAppFees.Text = clsApplicationType.Find(stLicenceInfo.NewAppType).ApplicationFees.ToString();
        }

        void _ShowLicenceFeesInfo()
        {
            lblNewLicnceFees.Text = stLicenceInfo.OldLicence.PaidFees.ToString();
            lblTotalFees.Text = (Convert.ToDecimal(lblAppFees.Text) + Convert.ToDecimal(lblNewLicnceFees.Text)).ToString();
        }

        void _LoadDataToOldLicenceObj(dynamic SearchMethod)
        {
            stLicenceInfo.OldLicence = clsLicence.FindByLicenceID(SearchMethod);
        }

        bool _DoesOldLicenceExist(dynamic SearchMethod)
        {
            _LoadDataToOldLicenceObj(SearchMethod);

            if (stLicenceInfo.OldLicence == null)
                return false;
            else
                return true;
        }

        bool _ValidateOldLicence(dynamic SearchMethod)
        {
            if (_DoesOldLicenceExist(SearchMethod))
            {
                if (!stLicenceInfo.OldLicence.IsActive)
                {
                    MessageBox.Show("Licence Is Not Active!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (!clsDVLDSettings.IsDate1GreaterThanDate2(DateTime.Now, stLicenceInfo.OldLicence.ExpirationDate))
                {
                    MessageBox.Show($"Licence Is Not Expired Yet!\nIt Wil Expire on {stLicenceInfo.OldLicence.ExpirationDate.ToString("dd/MM/yyyy")}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                


                ctrlLicenceInfo1.DispalyLicenceData(stLicenceInfo.OldLicence.LicenseID);
                btnSave.Enabled = true;
                pnlNewLicenceNotes.Enabled = true;
                return true;
            }
            else
            {
                MessageBox.Show("Licence Does not Exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        void _PerformOldLicenceSearch(dynamic SearchMethod)
        {
            if (_ValidateOldLicence(SearchMethod))
            {
                _LoadDataToObjcts();
                _ShowLicenceFeesInfo();
            }
        }







        private void btnSearch_Click(object sender, EventArgs e)
        {
            _PerformOldLicenceSearch(clsDVLDSettings.IsNumber(txtSearchBar.text) ?
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

        private void frmRenewDrivingLicence_Load(object sender, EventArgs e)
        {
            _RoundControls();
            _ResetObjcts();
            _ShowAppFeesInfo();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_SaveNewLicence())
            {
                MessageBox.Show("Licence Renewed Successfully", "Successed", MessageBoxButtons.OK);
                _GoBackToAppsForm();
            }
            else
            {
                MessageBox.Show("Failed To Renew Local Licencey", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
