using DVLD_BusinessLayer;
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

namespace DVLD_PresentationLayer.Tests
{
    public partial class frmTakeTest : Form
    {
        public frmTakeTest(clsTestAppointment CurrentTestAppointment)
        {
            InitializeComponent();
            stTestAppointmentInfo.CurrentTestAppointment = CurrentTestAppointment;
            
            stTestAppointmentInfo.CurrentLDLApp = clsLDLApplication.FindByLDLAppID(
                stTestAppointmentInfo.CurrentTestAppointment.LocalDrivingLicenseApplicationID);

            stTestAppointmentInfo.ApplicantPerson = clsPerson.Find(clsApplication.Find(
                    stTestAppointmentInfo.CurrentLDLApp.ApplicationID).ApplicantPersonID);

            stTestAppointmentInfo.TestType = CurrentTestAppointment.TestTypeID;
        }

        struct stTestAppointmentInfo
        {
            public static clsLDLApplication CurrentLDLApp = null;
            public static clsPerson ApplicantPerson = null;
            public static clsTestAppointment CurrentTestAppointment = null;
            public static int TestType = -1;
            public static clsTest Test = new clsTest();

        }

        enum enTestType { eVisionTest = 1, eWrittenTest = 2, eStreetTest = 3 };

        enTestType _TestType = enTestType.eVisionTest;


        void _RoundControls()
        {
            Control[] controls = {pnlApplicantName, pnlClass, pnlDate, pnlFees, btnSave, btnCancel, pnlLDLApplicationID,
            pnlTrials, pnlTestAppointmentLoader, pnlNotes, pnlPassFail};
            clsDVLDSettings.RoundControlsByCustomElips(bunifuElipse1, controls);
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

        void _DispalyDataOnForm()
        {
            clsDVLDSettings.ShowDataOnContolText(lblLDLApplicationID,
                stTestAppointmentInfo.CurrentLDLApp.LocalDrivingLicenseApplicationID);

            clsDVLDSettings.ShowDataOnContolText(lblClass,
               clsLicenseClass.Find(stTestAppointmentInfo.CurrentLDLApp.LicenseClassID).ClassName);

            clsDVLDSettings.ShowDataOnContolText(lblApplicantName,
               clsDVLDSettings.GetPersonFullName(stTestAppointmentInfo.ApplicantPerson.ID));

            clsDVLDSettings.ShowDataOnContolText(lblTrials, clsTest.GetNumOfPassOrFailTests(
                stTestAppointmentInfo.ApplicantPerson.ID,
                stTestAppointmentInfo.TestType, false,
                stTestAppointmentInfo.CurrentLDLApp.LocalDrivingLicenseApplicationID));


            clsDVLDSettings.ShowDataOnContolText(lblFees,
                clsTestType.Find(stTestAppointmentInfo.TestType).TestTypeFees);


            clsDVLDSettings.ShowDataOnContolText(lblDate,
                stTestAppointmentInfo.CurrentTestAppointment.AppointmentDate.ToString("dd/MM/yyyy"));




        }

       

        void _LoadDataToTestAndTestAppoiObj()
        {
            stTestAppointmentInfo.Test.TestAppointmentID =
                stTestAppointmentInfo.CurrentTestAppointment.TestAppointmentID;

            stTestAppointmentInfo.Test.TestResult = rbPass.Checked;

            stTestAppointmentInfo.Test.Notes = txtNotes.Text;

            stTestAppointmentInfo.Test.CreatedByUserID = clsDVLDSettings.CurrentUser.UserID;

            stTestAppointmentInfo.CurrentTestAppointment.IsLocked = true;

        }

        void _PerformMode()
        {
            _DispalyDataOnForm();

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

        bool _SaveTestAndTestAppoi()
        {
            //Reseting the obj
            stTestAppointmentInfo.Test = new clsTest();

            _LoadDataToTestAndTestAppoiObj();
            return stTestAppointmentInfo.Test.Save()
                && stTestAppointmentInfo.CurrentTestAppointment.Save();
            
        }

        void _GoBackToTestAppoinForm()
        {
            frmTestAppointments frmTestAppointments_v = new frmTestAppointments(stTestAppointmentInfo.CurrentLDLApp, stTestAppointmentInfo.TestType);
            clsDVLDSettings.ShowFormInPanel(pnlTestAppointmentLoader, frmTestAppointments_v);
        }








        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            _RoundControls();
            _PerformMode();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            _GoBackToTestAppoinForm();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _GoBackToTestAppoinForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_SaveTestAndTestAppoi())
            {
                MessageBox.Show("Test Has Been Taken Successfully", "Successed", MessageBoxButtons.OK);
                _GoBackToTestAppoinForm();
            }
            else
            {
                MessageBox.Show("Test Save Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
