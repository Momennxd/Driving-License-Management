using DVLD_BusinessLayer;
using DVLD_PresentationLayer.Applications.Manage_Applications;
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
    public partial class frmTestAppointments : Form
    {
        public frmTestAppointments(clsLDLApplication SelectedLDLApp, int TestTypeID)
        {
            InitializeComponent();
            _SelectedLDLApplication = SelectedLDLApp;
            _ApplicantPerson = clsPerson.Find(
               clsApplication.Find(SelectedLDLApp.ApplicationID).ApplicantPersonID);
            _TestType = (enTestType)TestTypeID;
        }

        enum enTestType { eVisionTest = 1, eWrittenTest = 2, eStreetTest = 3 };

        enTestType _TestType = enTestType.eVisionTest;

        clsLDLApplication _SelectedLDLApplication = new clsLDLApplication();

        clsPerson _ApplicantPerson = new clsPerson();

        clsTestAppointment _SelectedTestAppointment = new clsTestAppointment();

        //TestAppointments

        void _RoundControls()
        {
            Control[] controls = { pnlTestAppointmentsLoader, dgTestAppointments,
                ctrlCurrentApplicationInfo, ctrlCurrentLDLApplicationInfo, pbTestTypePic, btnGoBack };
            clsDVLDSettings.RoundControlsByCustomElips(bunifuElipse1, controls);

        }

        void _AlterFormToShowVisionTest()
       {
            pbTestTypePic.Image = Resources.TestTypeVision;
            lblTestTypeName.Text = "Vision Test";
            lblFormHeader.Text = "Vision Test Appointments";
       }

        void _AlterFormToShowWrittenTest()
        {
            pbTestTypePic.Image = Resources.TestTypeWritten;
            lblTestTypeName.Text = "Writting Test";
            lblFormHeader.Text = "Writting Test Appointments";
        }

        void _AlterFormToShowStreetTest()
        {
            pbTestTypePic.Image = Resources.TestTypeStreet;
            lblTestTypeName.Text = "Street Test";
            lblFormHeader.Text = "Street Test Appointments";
        }

        void _LoadDataToApp()
        {
            ctrlCurrentApplicationInfo.DispalyApplicationData(_SelectedLDLApplication.ApplicationID);
            ctrlCurrentLDLApplicationInfo.DispalyLDLAppData(_SelectedLDLApplication.LocalDrivingLicenseApplicationID);
        }

        void _GoBackToAppsForm()
        {
            frmLocalDrivingLicenceApp frmLocalDrivingLicenceApp_v = new frmLocalDrivingLicenceApp();
            clsDVLDSettings.ShowFormInPanel(pnlTestAppointmentsLoader, frmLocalDrivingLicenceApp_v);
        }

        DataTable _FillTestAppointmentsTableColumnsIfBlank(DataTable dtTestAppointments)
        {
            return dtTestAppointments.Rows.Count > 0 ? dtTestAppointments : clsTestAppointment.GetAllBlankTestAppointments();
        }

        void _AlterTestAppointmentsTableColumns(ref DataTable dtTestAppointments)
        {
            clsDVLDSettings.ChangeColumnNameInDataTable("TestAppointmentID", "TestAppointment ID", ref dtTestAppointments);
            clsDVLDSettings.ChangeColumnNameInDataTable("AppointmentDate", "Appointment Date", ref dtTestAppointments);
            clsDVLDSettings.ChangeColumnNameInDataTable("PaidFees", "Paid Fees", ref dtTestAppointments);
            clsDVLDSettings.ChangeColumnNameInDataTable("IsLocked", "Is Locked", ref dtTestAppointments);



        }

        void _DeleteUnWantedColumnsFromTestAppointmentsTable(ref DataTable dtTestAppointments)
        {
            dtTestAppointments.Columns.Remove("TestTypeID");

            dtTestAppointments.Columns.Remove("LocalDrivingLicenseApplicationID");

            dtTestAppointments.Columns.Remove("CreatedByUserID");

            dtTestAppointments.Columns.Remove("RetakeTestApplicationID");

        }

        DataTable _AlterTestAppointmentsTableToShow(DataTable dtTestAppointments)
        {
            _AlterTestAppointmentsTableColumns(ref dtTestAppointments);
            _DeleteUnWantedColumnsFromTestAppointmentsTable(ref dtTestAppointments);
            return dtTestAppointments;

        }

        void _ShowAlteredDataOnLDLAppsList(DataTable dtTestAppointments)
        {
            clsDVLDSettings.ShowDataOnCustomDataGridView(dgTestAppointments,
                _AlterTestAppointmentsTableToShow(_FillTestAppointmentsTableColumnsIfBlank(dtTestAppointments)));

        }

        void _PerformMode()
        {
            _LoadDataToApp();

            switch (_TestType)
            {
                case enTestType.eVisionTest:
                    {
                        _AlterFormToShowVisionTest();
                        _ShowAlteredDataOnLDLAppsList(clsTestAppointment.GetAllTestAppointmentsByTestTypeID(1, _SelectedLDLApplication.LocalDrivingLicenseApplicationID));
                        break;
                    }
                case enTestType.eWrittenTest:
                    {
                        _AlterFormToShowWrittenTest();
                        _ShowAlteredDataOnLDLAppsList(clsTestAppointment.GetAllTestAppointmentsByTestTypeID(2, _SelectedLDLApplication.LocalDrivingLicenseApplicationID));
                        break;
                    }
                case enTestType.eStreetTest:
                    {
                        _AlterFormToShowStreetTest();
                        _ShowAlteredDataOnLDLAppsList(clsTestAppointment.GetAllTestAppointmentsByTestTypeID(3, _SelectedLDLApplication.LocalDrivingLicenseApplicationID));
                        break;
                    }
            }
        }

        bool _DoesActiveAppointmentExist()
        {
            return clsTestAppointment.DoesActiveTestAppointmentExist(
                _SelectedLDLApplication.LocalDrivingLicenseApplicationID, (int)_TestType);
        }

        //
        bool _CreateRetakeTest()
        {
            clsApplication RetakeApp = new clsApplication();

            RetakeApp.ApplicantPersonID = _ApplicantPerson.ID;
            RetakeApp.ApplicationDate = DateTime.Now;
            //7 is for retake test id
            RetakeApp.ApplicationTypeID = 7;
            //3 is for completed
            RetakeApp.ApplicationStatus = 3;

            RetakeApp.ApplicantPersonID = _ApplicantPerson.ID;

            RetakeApp.LastStatusDate = DateTime.Now;

            RetakeApp.PaidFees = clsApplicationType.Find(7).ApplicationFees;

            RetakeApp.CreatedByUserID = clsDVLDSettings.CurrentUser.UserID;

            return RetakeApp.Save();


        }

        clsApplication _GetRetakeTestObjIfAny()
        {
            int NumOfFailedTests = clsTest.GetNumOfPassOrFailTests(_ApplicantPerson.ID,
                (int)_TestType, false, _SelectedLDLApplication.LocalDrivingLicenseApplicationID);

            if (NumOfFailedTests > 0)
            {
                _CreateRetakeTest();
                return clsApplication.Find(clsApplication.LastAppIDAdded);
            }
            else
                return null;
        }

        //

        void _ShowAddNewTestAppointmentForm()
        {
            int NumOfFailedTests = clsTest.GetNumOfPassOrFailTests(_ApplicantPerson.ID,
               (int)_TestType, false, _SelectedLDLApplication.LocalDrivingLicenseApplicationID);


            frmAddOrUpdateTestAppointment frmAddOrUpdateTestAppointment_v =
                new frmAddOrUpdateTestAppointment(_SelectedLDLApplication, (int)_TestType, NumOfFailedTests > 0);
            clsDVLDSettings.ShowFormInPanel(pnlTestAppointmentsLoader, frmAddOrUpdateTestAppointment_v);
        }

        void _ShowUpdateTestAppointmentForm()
        {
            frmAddOrUpdateTestAppointment frmAddOrUpdateTestAppointment_v =
                new frmAddOrUpdateTestAppointment(_SelectedTestAppointment, _SelectedTestAppointment.IsLocked);
            clsDVLDSettings.ShowFormInPanel(pnlTestAppointmentsLoader, frmAddOrUpdateTestAppointment_v);
        }

        void _ShowTakeTestForm()
        {
            frmTakeTest frmTakeTest_v =
                new frmTakeTest(_SelectedTestAppointment);
            clsDVLDSettings.ShowFormInPanel(pnlTestAppointmentsLoader, frmTakeTest_v);
        }


        void _LoadDataToSelectedTestAppoin(int TestAppointID)
        {
            _SelectedTestAppointment = clsTestAppointment.Find(TestAppointID);

           
        }

        bool _DidPersonPassTestCurrentTest()
        {
            return (clsTest.GetNumOfPassOrFailTests(_ApplicantPerson.ID, (int)_TestType, true,
                _SelectedLDLApplication.LocalDrivingLicenseApplicationID) > 0);
        }




        private void frmTestAppointments_Load(object sender, EventArgs e)
        {
            _RoundControls();
            _PerformMode();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            _GoBackToAppsForm();
        }

        private void btnAddNewTestAppointment_Click(object sender, EventArgs e)
        {
            if (_DoesActiveAppointmentExist())
            {
                MessageBox.Show("Failed, There is already an active appointment",
                    "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (_DidPersonPassTestCurrentTest())
                {
                    MessageBox.Show("Failed, Person Already Passed This Test",
                    "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    _ShowAddNewTestAppointmentForm();


            }
        }

        private void dgTestAppointments_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if ((e.Button == MouseButtons.Right) && e.RowIndex >= 0)
            {
                dgTestAppointments.ClearSelection();
                dgTestAppointments.Rows[e.RowIndex].Selected = true;
                dgTestAppointments.CurrentCell = dgTestAppointments.Rows[e.RowIndex].Cells[e.ColumnIndex];
                _LoadDataToSelectedTestAppoin(Convert.ToInt16(dgTestAppointments.Rows[e.RowIndex].Cells[0].Value));
                cmsTestAppointmentsOpList.Show(MousePosition);
            }
        }

        private void itemEdit_Click(object sender, EventArgs e)
        {
            _ShowUpdateTestAppointmentForm();
        }

       
        private void itemTakeTest_Click_1(object sender, EventArgs e)
        {

            if (_SelectedTestAppointment.IsLocked)
            {
                MessageBox.Show("Failed, There appointment has been already taken",
                    "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                _ShowTakeTestForm();


        }
    }
}
