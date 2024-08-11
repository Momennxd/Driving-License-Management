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

namespace DVLD_PresentationLayer.Applications.Driving_Licence_Services.Replace_licence_for_lost_or_damaged
{
    public partial class frmReplaceLicence : Form
    {
        public frmReplaceLicence()
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
            public static int NewAppType = -1;
            public static byte IssueReason = 0;


        }

        void _RoundControls()
        {
            Control[] controls = { pnlIntLicenceLoader, ctrlLicenceInfo1, txtSearchBar, btnGoBack,
            pnlAppFees, pnlNewLicenceFees, pnlTotalFees};
            clsDVLDSettings.RoundControlsByCustomElips(bunifuElipse1, controls);

        }

        void _LoadDataToObjcts()
        {
            stLicenceInfo.Driver = clsDriver.FindByDriverID(stLicenceInfo.OldLicence.DriverID);
            stLicenceInfo.ApplicantPerson = clsPerson.Find(stLicenceInfo.Driver.PersonID);
            stLicenceInfo.LicenceClass = clsLicenseClass.Find(stLicenceInfo.OldLicence.LicenseClass);
            //3 is for lost type 4 is for damaged licence :
            stLicenceInfo.NewAppType = rbLost.Checked ? 3 : 4;
            stLicenceInfo.IssueReason = Convert.ToByte(rbLost.Checked ? 4 : 3);
        }

        void _GoBackToServicesForm()
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
            stLicenceInfo.NewLicence.IssueDate = stLicenceInfo.OldLicence.IssueDate;
            stLicenceInfo.NewLicence.ExpirationDate = stLicenceInfo.OldLicence.ExpirationDate;
            stLicenceInfo.NewLicence.Notes = stLicenceInfo.OldLicence.Notes;
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
            stLicenceInfo.NewAppType = -1;
            stLicenceInfo.IssueReason = 0;
        }

        void _ShowAppFeesInfo()
        {
            lblAppFees.Text = clsApplicationType.Find(rbLost.Checked ? 3 : 4).ApplicationFees.ToString();
        }

        void _ShowLicenceFeesInfo()
        {
            lblNewLicnceFees.Text = stLicenceInfo.OldLicence != null ?
                stLicenceInfo.OldLicence.PaidFees.ToString() : 0.ToString();
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
                else if (clsDVLDSettings.IsDate1GreaterThanDate2(DateTime.Now, stLicenceInfo.OldLicence.ExpirationDate))
                {
                    MessageBox.Show("Licence Is  Expired Yet!",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }



                ctrlLicenceInfo1.DispalyLicenceData(stLicenceInfo.OldLicence.LicenseID);
                btnSave.Enabled = true;
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

        void _RefreshFeesInfo()
        {
            _ShowAppFeesInfo();
            _ShowLicenceFeesInfo();
        }








        private void btnSearch_Click(object sender, EventArgs e)
        {
            _PerformOldLicenceSearch(clsDVLDSettings.IsNumber(txtSearchBar.text) ?
              Convert.ToInt32(txtSearchBar.text) : -1);
            _RefreshFeesInfo();
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
            _GoBackToServicesForm();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _GoBackToServicesForm();

        }

        private void frmReplaceLicence_Load(object sender, EventArgs e)
        {
            _RoundControls();
            _ResetObjcts();
            _RefreshFeesInfo();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_SaveNewLicence())
            {
                MessageBox.Show("Licence Replaced Successfully", "Successed", MessageBoxButtons.OK);
                _GoBackToServicesForm();
            }
            else
            {
                MessageBox.Show("Failed To Replace Local Licencey", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void rbReplacementType_CheckedChanged(object sender, EventArgs e)
        {
            _RefreshFeesInfo();
        }
    }
}
