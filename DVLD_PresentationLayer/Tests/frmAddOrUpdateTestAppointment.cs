using Bunifu.Framework.UI;
using DVLD_BusinessLayer;
using DVLD_PresentationLayer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Tests
{
    public partial class frmAddOrUpdateTestAppointment : Form
    {

        //add new construct
        public frmAddOrUpdateTestAppointment(clsLDLApplication LDLApp, int TestTypeID, bool DoesRetakeTestExist)
        {
            InitializeComponent();
            _ResetTestAppointInfo();
            stTestAppointmentInfo.CurrentLDLApp = LDLApp;
            stTestAppointmentInfo.TestType = TestTypeID;
            _TestType = (enTestType)TestTypeID;
            stTestAppointmentInfo.ApplicantPerson =
                clsPerson.Find(clsApplication.Find(LDLApp.ApplicationID).ApplicantPersonID);
            stTestAppointmentInfo.CurrentTestAppointment = new clsTestAppointment();

            stTestAppointmentInfo.DoesRetakeTestExist = DoesRetakeTestExist;
            _TAMode = enTestAppointmentsModes.eAddNew;
        }

        //update construct
        public frmAddOrUpdateTestAppointment(clsTestAppointment TestAppoi, bool IsLocked = false)
        {
            InitializeComponent();
            _ResetTestAppointInfo();
            stTestAppointmentInfo.CurrentTestAppointment = TestAppoi;

            stTestAppointmentInfo.TestType = TestAppoi.TestTypeID;

            stTestAppointmentInfo.ApplicantPerson = clsPerson.Find(
                clsApplication.Find(clsLDLApplication.FindByLDLAppID(
                    TestAppoi.LocalDrivingLicenseApplicationID).ApplicationID).ApplicantPersonID);

            if (TestAppoi.RetakeTestApplicationID != -1)
            {
                stTestAppointmentInfo.DoesRetakeTestExist = true;
                stTestAppointmentInfo.RetakeTest = clsApplication.Find(TestAppoi.RetakeTestApplicationID);
            }


            _TestType = (enTestType)TestAppoi.TestTypeID;

            stTestAppointmentInfo.CurrentLDLApp = clsLDLApplication.FindByLDLAppID(TestAppoi.LocalDrivingLicenseApplicationID);


            stTestAppointmentInfo.IsLocked = IsLocked;

            if (!IsLocked)           
                _TAMode = enTestAppointmentsModes.eUpdate;
            else
                _TAMode = enTestAppointmentsModes.eLocked;


        }


        struct stTestAppointmentInfo
        {
            public static bool IsLocked = false;
            public static int TestType = -1;
            public static bool DoesRetakeTestExist = false;
            public static clsApplication RetakeTest = null;
            public static clsLDLApplication CurrentLDLApp = null;
            public static clsPerson ApplicantPerson = null;
            public static clsTestAppointment CurrentTestAppointment = null;

        }

        enum enTestAppointmentsModes { eAddNew = 1, eUpdate = 2, eLocked = 3}

        enTestAppointmentsModes _TAMode = enTestAppointmentsModes.eUpdate;

        enum enTestType { eVisionTest = 1, eWrittenTest = 2, eStreetTest = 3 };

        enTestType _TestType = enTestType.eVisionTest;


        void _RoundControls()
        {
            Control[] controls = {pnlApplicantName, pnlClass, pnlDate, pnlFees, btnSave, btnCancel, pnlLDLApplicationID,
            pnlTrials, pnlRetakeAppFees, pnlRetakeAppID, pnlRetakeTestInfo, pnlTestAppointmentLoader, pnlTotalFees
            };
            clsDVLDSettings.RoundControlsByCustomElips(bunifuElipse1, controls);
        }

        void _AlterFormToUpdateMode()
        {
            lblFormHeader.Text = "Update Test Appointment";
        }

        void _AlterFormToLockedMode()
        {
            lblFormHeader.Text = "Show Test Appointment";
            lblIsLocked.Visible = true;
            btnSave.Enabled = false;
            dpDate.Visible = false;
            lblDate.Visible = true;
            lblDate.Text = stTestAppointmentInfo.CurrentTestAppointment.AppointmentDate.ToString("dd/MM/yyyy");
        }

        void _AlterFormToAddNewMode()
        {
            lblFormHeader.Text = "Add Test Appointment";
        }

        void _AlterFormToShowVisionTest()
        {
            pbTestTypePic.Image = Resources.TestTypeVision;
            lblTestTypeName.Text = "Vision Test";
        }

        void _AlterFormToShowWrittenTest()
        {
            pbTestTypePic.Image = Resources.TestTypeWritten;
            lblTestTypeName.Text = "Writting Test";
        }

        void _AlterFormToShowStreetTest()
        {
            pbTestTypePic.Image = Resources.TestTypeStreet;
            lblTestTypeName.Text = "Street Test";
        }

        void _DispalyModeSharedDataOnForm()
        {
            clsDVLDSettings.ShowDataOnContolText(lblLDLApplicationID,
                stTestAppointmentInfo.CurrentLDLApp.LocalDrivingLicenseApplicationID);

            clsDVLDSettings.ShowDataOnContolText(lblClass,
               clsLicenseClass.Find(stTestAppointmentInfo.CurrentLDLApp.LicenseClassID).ClassName);

            clsDVLDSettings.ShowDataOnContolText(lblApplicantName,
               clsDVLDSettings.GetPersonFullName(stTestAppointmentInfo.ApplicantPerson.ID));

            clsDVLDSettings.ShowDataOnContolText(lblTrials, clsTest.GetNumberOfTests(
                stTestAppointmentInfo.ApplicantPerson.ID,
                stTestAppointmentInfo.TestType,
                stTestAppointmentInfo.CurrentLDLApp.LocalDrivingLicenseApplicationID));


            clsDVLDSettings.ShowDataOnContolText(lblFees, clsTestType.Find(stTestAppointmentInfo.TestType).TestTypeFees);

            if (stTestAppointmentInfo.DoesRetakeTestExist)
            {
                if (stTestAppointmentInfo.RetakeTest != null)
                    clsDVLDSettings.ShowDataOnContolText(lblRetakeAppID,
                        stTestAppointmentInfo.RetakeTest.ApplicationID);

                clsDVLDSettings.ShowDataOnContolText(lblRetakeAppFees, clsApplicationType.Find(7).ApplicationFees);
                clsDVLDSettings.ShowDataOnContolText(lblTotalFees,
                  clsApplicationType.Find(7).ApplicationFees + Convert.ToDecimal(lblFees.Text));
            }
            else
            {
                clsDVLDSettings.ShowDataOnContolText(lblTotalFees, lblFees.Text);
            }

            

        }

        void _DispalyDataOnForm()
        {
            _DispalyModeSharedDataOnForm();

            if (_TAMode == enTestAppointmentsModes.eAddNew)
            {
                _AlterFormToAddNewMode();
                clsDVLDSettings.ShowDateOnCustomDatePicker(dpDate, DateTime.Now);
            }
            else if (_TAMode == enTestAppointmentsModes.eUpdate)
            {
                _AlterFormToUpdateMode();
                clsDVLDSettings.ShowDateOnCustomDatePicker(dpDate,
                    stTestAppointmentInfo.CurrentTestAppointment.AppointmentDate);
            }
            else if (_TAMode == enTestAppointmentsModes.eLocked)
            {
                _AlterFormToLockedMode();
                
            }
                
        }

        void DisableOrEnableRetakeTestInfo()
        {
            if (stTestAppointmentInfo.DoesRetakeTestExist)
                pnlRetakeTestInfo.Enabled = true;
            else
                pnlRetakeTestInfo.Enabled = false;

        }

        void _PerformMode()
        {
            _DispalyDataOnForm();
            DisableOrEnableRetakeTestInfo();

            switch (_TestType)
            {
                case enTestType.eVisionTest:
                    {
                        _AlterFormToShowVisionTest();
                        break;
                    }
                case enTestType.eWrittenTest:
                    {
                        _AlterFormToShowWrittenTest();
                        break;
                    }
                case enTestType.eStreetTest:
                    {
                        _AlterFormToShowStreetTest();
                        break;
                    }
            }
        }

        bool _IsDateValid()
        {
            return clsDVLDSettings.ValidateCustomDatePicker(dpDate, DateTime.Now, DateTime.MaxValue,
                "Appointment Can't Be In The Past", errorInfoValidation);
        }

        void _LoadDateToTestAppointObj()
        {
            if (_TAMode == enTestAppointmentsModes.eAddNew)
            {
                stTestAppointmentInfo.CurrentTestAppointment.TestTypeID = stTestAppointmentInfo.TestType;

                stTestAppointmentInfo.CurrentTestAppointment.LocalDrivingLicenseApplicationID =
                    stTestAppointmentInfo.CurrentLDLApp.LocalDrivingLicenseApplicationID;

                stTestAppointmentInfo.CurrentTestAppointment.AppointmentDate = dpDate.Value;

                stTestAppointmentInfo.CurrentTestAppointment.PaidFees =
                    clsTestType.Find(stTestAppointmentInfo.TestType).TestTypeFees;

                stTestAppointmentInfo.CurrentTestAppointment.CreatedByUserID =
                    clsDVLDSettings.CurrentUser.UserID;

                stTestAppointmentInfo.CurrentTestAppointment.IsLocked = false;

                if (stTestAppointmentInfo.RetakeTest != null)
                {
                    stTestAppointmentInfo.CurrentTestAppointment.RetakeTestApplicationID =
                    stTestAppointmentInfo.RetakeTest.ApplicationID;
                }
                else
                {
                    stTestAppointmentInfo.CurrentTestAppointment.RetakeTestApplicationID = -1;
                }
            }
            else if (_TAMode == enTestAppointmentsModes.eUpdate)
            {
                stTestAppointmentInfo.CurrentTestAppointment.AppointmentDate = dpDate.Value;
            }




        }

        bool _CreateRetakeTest()
        {
            clsApplication RetakeApp = new clsApplication();

            RetakeApp.ApplicantPersonID = stTestAppointmentInfo.ApplicantPerson.ID;
            RetakeApp.ApplicationDate = DateTime.Now;
            //7 is for retake test id
            RetakeApp.ApplicationTypeID = 7;
            //3 is for completed
            RetakeApp.ApplicationStatus = 3;

            RetakeApp.ApplicantPersonID = stTestAppointmentInfo.ApplicantPerson.ID;

            RetakeApp.LastStatusDate = DateTime.Now;

            RetakeApp.PaidFees = clsApplicationType.Find(7).ApplicationFees;

            RetakeApp.CreatedByUserID = clsDVLDSettings.CurrentUser.UserID;

            return RetakeApp.Save();


        }

        clsApplication _GetRetakeTestObjIfAny()
        {
            int NumOfFailedTests = clsTest.GetNumOfPassOrFailTests(stTestAppointmentInfo.ApplicantPerson.ID,
                (int)_TestType, false, stTestAppointmentInfo.CurrentLDLApp.LocalDrivingLicenseApplicationID);

            if (NumOfFailedTests > 0)
            {
                _CreateRetakeTest();
                return clsApplication.Find(clsApplication.LastAppIDAdded);
            }
            else
                return null;
        }

        bool _SaveAppointment()
        {
            if (_IsDateValid())
            {
                if (stTestAppointmentInfo.DoesRetakeTestExist) 
                    stTestAppointmentInfo.RetakeTest = _GetRetakeTestObjIfAny();

                _LoadDateToTestAppointObj();
                return stTestAppointmentInfo.CurrentTestAppointment.Save();
            }

            return false;
        }

        void _GoBackToTestAppoinForm()
        {
            frmTestAppointments frmTestAppointments_v = new frmTestAppointments(stTestAppointmentInfo.CurrentLDLApp, stTestAppointmentInfo.TestType);
            clsDVLDSettings.ShowFormInPanel(pnlTestAppointmentLoader, frmTestAppointments_v);
        }

        void _ResetTestAppointInfo()
        {
            stTestAppointmentInfo.IsLocked = false;
            stTestAppointmentInfo.TestType = -1;
            stTestAppointmentInfo.DoesRetakeTestExist = false;
            stTestAppointmentInfo.RetakeTest = null;
            stTestAppointmentInfo.CurrentLDLApp = null;
            stTestAppointmentInfo.ApplicantPerson = null;
            stTestAppointmentInfo.CurrentTestAppointment = null;
        }






        private void frmAddOrUpdateTestAppointment_Load(object sender, EventArgs e)
        {
            _RoundControls();
            _PerformMode();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            _GoBackToTestAppoinForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_SaveAppointment())
            {
                MessageBox.Show("Appointment Saved Successfully", "Successed", MessageBoxButtons.OK);
                _GoBackToTestAppoinForm();
            }
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _GoBackToTestAppoinForm();
        }
    }
}
