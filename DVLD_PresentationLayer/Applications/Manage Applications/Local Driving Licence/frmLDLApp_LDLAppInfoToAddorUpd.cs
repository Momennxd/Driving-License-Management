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

namespace DVLD_PresentationLayer.Applications.Manage_Applications
{
    public partial class frmLDLApp_LDLAppInfoToAddorUpd : Form
    {
        public frmLDLApp_LDLAppInfoToAddorUpd(int ApplicantPersonID)
        {
            InitializeComponent();
            _ApplicantPersonID = ApplicantPersonID;
            _Mode = enMode.eAddNew;
        }

        public frmLDLApp_LDLAppInfoToAddorUpd(clsLDLApplication LDLApplication)
        {
            InitializeComponent();
            _LDLApplication = LDLApplication;
        }


        enum enMode { eUpdate, eAddNew };

        enMode _Mode = enMode.eUpdate;

        int _ApplicantPersonID = -1;

        clsApplication MainApplicaion = new clsApplication();

        clsApplicationType _CurrentAppType = clsApplicationType.Find(1);

        clsLDLApplication _LDLApplication = new clsLDLApplication();


        void _RoundControls()
        {
            Control[] controls = { pnlLicenceClass, pnlAppDate, pnlAppFees, pnlCreatedBy };
            clsDVLDSettings.RoundControlsByCustomElips(bunifuElipse1, controls);

        }

        void _LoadDataToMainAppObj()
        {
            if (_Mode == enMode.eUpdate) MainApplicaion.ApplicantPersonID =
                    clsApplication.Find(_LDLApplication.ApplicationID).ApplicantPersonID;

            //number 1 is for the local driving type.
            MainApplicaion.ApplicationDate = DateTime.Now;
            MainApplicaion.ApplicationTypeID = 1;
            MainApplicaion.ApplicationStatus = 1;
            MainApplicaion.LastStatusDate = DateTime.Now;
            MainApplicaion.PaidFees = _CurrentAppType.ApplicationFees;
            MainApplicaion.CreatedByUserID = clsDVLDSettings.CurrentUser.UserID;

        }

        void _LoadDataToLDLApplicationObj()
        {
            if (_Mode == enMode.eAddNew) _LDLApplication.ApplicationID = clsApplication.LastAppIDAdded;
            _LDLApplication.LicenseClassID = clsLicenseClass.Find(
                cbLicenceClasses.SelectedItem.ToString()).LicenseClassID;
        }

        bool _SaveMainAppObj()
        {
            return MainApplicaion.Save();
        }

        bool _SaveLDLApplicationObj()
        {
            return _LDLApplication.Save();
        }

        public bool PerformSaving()
        {
            if (!_DoesPersonHaveActiveLicence())
            {
                if (!_DoesPersonHaveActiveLDLApp())
                {
                    _Save();
                    return true;
                }
                else
                {
                    MessageBox.Show("The Selected Person Has An Active LDL Application Already", "Save Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }             
            }
            else
            {
                MessageBox.Show("The Selected Person Has An Active Licence Already", "Save Failed",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            return false;
        }

        bool _Save()
        {
            if (_Mode == enMode.eAddNew) MainApplicaion.ApplicantPersonID = _ApplicantPersonID;

            _LoadDataToMainAppObj();
            _SaveMainAppObj();
            _LoadDataToLDLApplicationObj();
            return _SaveLDLApplicationObj();
        }

        void _LoadAppTypeDataOnForm()
        {
            lblAppDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblAppFees.Text = _CurrentAppType.ApplicationFees.ToString();
            lblCreatedByUserName.Text = clsDVLDSettings.CurrentUser.UserName;
            clsDVLDSettings.ImportDataToComboBox(cbLicenceClasses, clsLicenseClass.GetAllLicenseClasses(), "ClassName");
            clsDVLDSettings.ShowIndexOnSearchFilter(cbLicenceClasses, 0);

        }

        bool _DoesPersonHaveActiveLicence()
        {
            return (clsLDLApplication.DoesPersonHaveActiveLicence(_ApplicantPersonID,
                clsLicenseClass.Find(
                cbLicenceClasses.SelectedItem.ToString()).LicenseClassID));
            
        }

        bool _DoesPersonHaveActiveLDLApp()
        {
            return (clsLDLApplication.DoesPersonHaveActiveLDLApp(_ApplicantPersonID,
                clsLicenseClass.Find(
                cbLicenceClasses.SelectedItem.ToString()).LicenseClassID));

        }

        private void frmLDLApp_LDLAppInfoToAddorUpd_Load(object sender, EventArgs e)
        {
            _LoadAppTypeDataOnForm();
        }

       
    }
}
