using Bunifu.Framework.UI;
using DVLD_BusinessLayer;
using DVLD_PresentationLayer.Applications.Manage_Applications.Local_Driving_Licence;
using DVLD_PresentationLayer.Licences;
using DVLD_PresentationLayer.Tests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Applications.Manage_Applications
{
    public partial class frmLocalDrivingLicenceApp : Form
    {
        public frmLocalDrivingLicenceApp()
        {
            InitializeComponent();
        }

        //LDLApps

        clsLDLApplication _SelectedLDLApplication = new clsLDLApplication();

        void _RoundControls()
        {
            Control[] controls = { pnlLocalApplicationsLoader, dgLocalLicenceApps };
            clsDVLDSettings.RoundControlsByCustomElips(bunifuElipse1, controls);

        }

        void _LoadDataToSelectedLDLApp(int LDLAppID)
        {
            _SelectedLDLApplication = clsLDLApplication.FindByLDLAppID(LDLAppID);
        }

        void _GoBackToAppsForm()
        {
            frmManageApplications frmManageApplications_v = new frmManageApplications();
            clsDVLDSettings.ShowFormInPanel(pnlLocalApplicationsLoader, frmManageApplications_v);
        }

        DataTable _FillLDLAppsTableColumnsIfBlank(DataTable dtLDLApps)
        {
            return dtLDLApps.Rows.Count > 0 ? dtLDLApps : clsLDLApplication.GetAllLocalDrivingLicenseApplicationsBlankTable();
        }

        void _AlterLDLAppsTableColumns(ref DataTable dtLDLApps)
        {
            clsDVLDSettings.ChangeColumnNameInDataTable("LocalDrivingLicenseApplicationID", "App ID", ref dtLDLApps);
            

            clsDVLDSettings.AddColumnToDataTable("Driving Class", typeof(string), ref dtLDLApps);
            clsDVLDSettings.AddColumnToDataTable("National No", typeof(string), ref dtLDLApps);
            clsDVLDSettings.AddColumnToDataTable("Full Name", typeof(string), ref dtLDLApps);
            clsDVLDSettings.AddColumnToDataTable("App Date", typeof(DateTime), ref dtLDLApps);
            clsDVLDSettings.AddColumnToDataTable("Passed Tests", typeof(int), ref dtLDLApps);
            clsDVLDSettings.AddColumnToDataTable("Status", typeof(string), ref dtLDLApps);

        }

        void _AlterLDLAppsTableRows(ref DataTable dtLDLApps)
        {

            clsPerson ApplicantPerson;
            clsApplication MainApplication;
            clsLDLApplication LDLApp;

            for (int i = 0; i < dtLDLApps.Rows.Count; i++)
            {

                ApplicantPerson = clsPerson.Find(clsApplication.Find(Convert.ToInt16(dtLDLApps.Rows[i]["ApplicationID"])).ApplicantPersonID);

                MainApplication = clsApplication.Find(Convert.ToInt16(dtLDLApps.Rows[i]["ApplicationID"]));

                LDLApp = clsLDLApplication.FindByLDLAppID(Convert.ToInt16(dtLDLApps.Rows[i]["App ID"]));

                clsDVLDSettings.AddValueToDataTable(i, "Driving Class", 
                    clsLicenseClass.Find(Convert.ToInt16(dtLDLApps.Rows[i]["LicenseClassID"])).ClassName, ref dtLDLApps);

                clsDVLDSettings.AddValueToDataTable(i, "National No",
                    ApplicantPerson.NationalNo, ref dtLDLApps);

                clsDVLDSettings.AddValueToDataTable(i, "Full Name",
                    clsDVLDSettings.GetPersonFullName(ApplicantPerson), ref dtLDLApps);

                clsDVLDSettings.AddValueToDataTable(i, "App Date",
                    MainApplication.ApplicationDate, ref dtLDLApps);

                clsDVLDSettings.AddValueToDataTable(i, "Passed Tests",
                    clsTest.GetNumberOfTestsPassedOrFaildByTestLDLAppID(true, ApplicantPerson.ID,
                    LDLApp.LocalDrivingLicenseApplicationID), ref dtLDLApps);

                clsDVLDSettings.AddValueToDataTable(i, "Status",
                   clsApplication.GetApplicationStatus(MainApplication), ref dtLDLApps);



            }
        }

        void _DeleteUnWantedColumnsFromLDLAppsTable(ref DataTable dtLDLApps)
        {
            dtLDLApps.Columns.Remove("ApplicationID");

            dtLDLApps.Columns.Remove("LicenseClassID");

        }

        void _ReorderLDLAppsTableColumns(ref DataTable dtLDLApps)
        {

           // dtPeople.Columns["Person ID"].SetOrdinal(0);
         

        }

        DataTable _AlterLDLAppsTableToShow(DataTable dtLDLApps)
        {
            _AlterLDLAppsTableColumns(ref dtLDLApps);
            if (dtLDLApps.Rows.Count > 0) _AlterLDLAppsTableRows(ref dtLDLApps);
            _DeleteUnWantedColumnsFromLDLAppsTable(ref dtLDLApps);
            _ReorderLDLAppsTableColumns(ref dtLDLApps);
            return dtLDLApps;

        }

        void _ShowAlteredDataOnLDLAppsList(DataTable dtLDLApps)
        {
            clsDVLDSettings.ShowDataOnCustomDataGridView(dgLocalLicenceApps,
                _AlterLDLAppsTableToShow(_FillLDLAppsTableColumnsIfBlank(dtLDLApps)));
            
        }

        void _DeActivateORActivateStatusFilterButton(BunifuThinButton2 BTN)
        {
            _ = Convert.ToInt16(BTN.Tag) == 0 ? BTN.Tag = 1 : BTN.Tag = 0;
        }

        bool _IsStatusFilterButtonActivated(BunifuThinButton2 BTN)
        {
            return Convert.ToInt16(BTN.Tag) == 0 ? false : true;

        }

        void _PerformStatusFilterButtonStyle(BunifuThinButton2 BTN)
        {
            if (Convert.ToInt16(BTN.Tag) == 1)
            {
                clsDVLDSettings.StyleBunifuThinButtonIDLE(BTN, Color.FromArgb(208, 224, 247),
                Color.FromArgb(87, 144, 227), Color.FromArgb(87, 144, 227));
            }
            else
            {
                clsDVLDSettings.StyleBunifuThinButtonIDLE(BTN, Color.White,
                Color.FromArgb(77, 77, 77), Color.FromArgb(200, 200, 206));
            }


        }

        void _DeActivateStatusFilterButton(BunifuThinButton2 BTN)
        {
            BTN.Tag = 0;
            _PerformStatusFilterButtonStyle(BTN);
        }

        void _PerformStatusFilterButtonClick(BunifuThinButton2 BTN)
        {
            _DeActivateORActivateStatusFilterButton(BTN);

            if (BTN.Name == "btnCompleted")
            {
                _DeActivateStatusFilterButton(btnCancelled);
                _DeActivateStatusFilterButton(btnNew);

                _PerformStatusFilterButtonStyle(BTN);
                _ShowAlteredDataOnLDLAppsList(_IsStatusFilterButtonActivated(BTN) ?
                    clsLDLApplication.GetAllLDLAppsColumnNameDataStartsWith("ApplicationStatus", "3") :
                    clsLDLApplication.GetAllLocalDrivingLicenseApplications());
            }
            else if (BTN.Name == "btnCancelled")
            {
                _DeActivateStatusFilterButton(btnCompleted);
                _DeActivateStatusFilterButton(btnNew);

                _PerformStatusFilterButtonStyle(BTN);
                _ShowAlteredDataOnLDLAppsList(_IsStatusFilterButtonActivated(BTN) ?
                    clsLDLApplication.GetAllLDLAppsColumnNameDataStartsWith("ApplicationStatus", "2") :
                    clsLDLApplication.GetAllLocalDrivingLicenseApplications());
            }
            else if (BTN.Name == "btnNew")
            {
                _DeActivateStatusFilterButton(btnCancelled);
                _DeActivateStatusFilterButton(btnCompleted);

                _PerformStatusFilterButtonStyle(BTN);
                _ShowAlteredDataOnLDLAppsList(_IsStatusFilterButtonActivated(BTN) ?
                    clsLDLApplication.GetAllLDLAppsColumnNameDataStartsWith("ApplicationStatus", "1") :
                    clsLDLApplication.GetAllLocalDrivingLicenseApplications());
            }



        }

        void _PerformSearch()
        {

            if (txtSearchBar.text == "")
            {
                _ShowAlteredDataOnLDLAppsList(clsLDLApplication.GetAllLocalDrivingLicenseApplications());
                return;
            }


            switch (cbSearchFilter.SelectedIndex)
            {
                case 0:
                    {
                        _ShowAlteredDataOnLDLAppsList(clsLDLApplication.GetAllLDLAppsByLDLAppID(
                            clsDVLDSettings.IsNumber(txtSearchBar.text) ?
                                Convert.ToInt32(txtSearchBar.text) : -1));
                        break;
                    }
                case 1:
                    {
                        _ShowAlteredDataOnLDLAppsList(clsLDLApplication.GetAllLDLAppsColumnNameDataStartsWith(
                            "NationalNo", txtSearchBar.text));
                        break;
                    }
                case 2:
                    {
                        _ShowAlteredDataOnLDLAppsList(
                            clsLDLApplication.GetAllLDLApplicationByPersonFullNameDataStartsWith(
                           txtSearchBar.text));
                        break;
                    }
                

            }
        }

        void _RefreshLDLAppsList()
        {
            _ShowAlteredDataOnLDLAppsList(clsLDLApplication.GetAllLocalDrivingLicenseApplications());
        }

        void _RefreshForm()
        {
            _DeActivateStatusFilterButton(btnCompleted);
            _DeActivateStatusFilterButton(btnNew);
            _DeActivateStatusFilterButton(btnCancelled);
            clsDVLDSettings.ResetCustomSearchBar(txtSearchBar, lblSearchBar);
            _RefreshLDLAppsList();
            clsDVLDSettings.ShowIndexOnSearchFilter(cbSearchFilter, 0);

        }

        void _ShowLDLAppDetailsForm()
        {
            frmLDLAppDetails frmLDLAppDetails_v = new frmLDLAppDetails(_SelectedLDLApplication);
            clsDVLDSettings.ShowFormInPanel(pnlLocalApplicationsLoader, frmLDLAppDetails_v);
        }

        void _ShowUpdateLDLAppForm()
        {
            frmAddorUpdateLocalDrivingLicenceApp frmAddorUpdateLocalDrivingLicenceApp_v = new frmAddorUpdateLocalDrivingLicenceApp(_SelectedLDLApplication);
            clsDVLDSettings.ShowFormInPanel(pnlLocalApplicationsLoader, frmAddorUpdateLocalDrivingLicenceApp_v);
        }


        void _ShowIssueLicenceForm()
        {
            frmIssueDLFirstTime frmIssueDLFirstTime_v = new frmIssueDLFirstTime(_SelectedLDLApplication);
            clsDVLDSettings.ShowFormInPanel(pnlLocalApplicationsLoader, frmIssueDLFirstTime_v);
        }

        void _ShowLicenceInfoForm()
        {
            frmLicenceInfo frmLicenceInfo_v =
                new frmLicenceInfo(clsLicence.FindByApplicationID(_SelectedLDLApplication.ApplicationID));
            clsDVLDSettings.ShowFormInPanel(pnlLocalApplicationsLoader, frmLicenceInfo_v);
        }

        void _ShowLicenceHistoryForm()
        {
            frmLicenceHistory frmLicenceHistory_v =
                new frmLicenceHistory(clsPerson.Find(clsApplication.Find(
                    _SelectedLDLApplication.ApplicationID).ApplicantPersonID));

            clsDVLDSettings.ShowFormInPanel(pnlLocalApplicationsLoader, frmLicenceHistory_v);
        }


        bool _CanPersonTakeTest(clsLDLApplication CurrentLDLApp, int TestTypeID)
        {
            clsApplication MainApp = clsApplication.Find(CurrentLDLApp.ApplicationID);

            if (TestTypeID == 1)
            {
                return !(clsTest.GetNumOfPassOrFailTests
                    (MainApp.ApplicantPersonID, TestTypeID, true, CurrentLDLApp.LocalDrivingLicenseApplicationID) > 0);
            }
            else
            {
                if ((clsTest.GetNumOfPassOrFailTests
                    (MainApp.ApplicantPersonID, TestTypeID, true, CurrentLDLApp.LocalDrivingLicenseApplicationID) > 0) == false &&
                    (clsTest.GetNumOfPassOrFailTests
                    (MainApp.ApplicantPersonID, TestTypeID - 1, true, CurrentLDLApp.LocalDrivingLicenseApplicationID) > 0))
                {
                    return true;
                }
            }

            return false;

        }

        void _AlterAppOperationListToShow()
        {
            clsApplication MainApp = clsApplication.Find(_SelectedLDLApplication.ApplicationID);

            cmsLDLAppOperationsList.Items["itemCancelApplication"].Enabled = MainApp.ApplicationStatus != 2;

            cmsLDLAppOperationsList.Items["toolScheduleTest"].Enabled =
                MainApp.ApplicationStatus == 1;

            cmsLDLAppOperationsList.Items["itemCancelApplication"].Enabled =
                MainApp.ApplicationStatus == 1;

            cmsLDLAppOperationsList.Items["itemShowLicence"].Enabled =
                clsLicence.FindByApplicationID(_SelectedLDLApplication.ApplicationID) != null;

            cmsLDLAppOperationsList.Items["itemShowPersonLicencesHistory"].Enabled =
               cmsLDLAppOperationsList.Items["itemShowLicence"].Enabled;


            cmsLDLAppOperationsList.Items["itemIssueDrivingLicence"].Enabled =
                (clsLicence.GetNumberOfActiveLicenses(clsApplication.Find(
                _SelectedLDLApplication.ApplicationID).ApplicantPersonID,
                true, _SelectedLDLApplication.LicenseClassID) == 0 &&
                clsTest.GetNumberOfTestsPassedOrFaildByTestLDLAppID(true, MainApp.ApplicantPersonID,
                _SelectedLDLApplication.LocalDrivingLicenseApplicationID) == 3);


        }





        private void btnGoBack_Click(object sender, EventArgs e)
        {
            _GoBackToAppsForm();
        }

        private void frmLocalDrivingLicenceApp_Load(object sender, EventArgs e)
        {
            _RoundControls();
            _ShowAlteredDataOnLDLAppsList(clsLDLApplication.GetAllLocalDrivingLicenseApplications());
            clsDVLDSettings.ShowIndexOnSearchFilter(cbSearchFilter, 0);
        }

        private void btnStatusFilter_Click(object sender, EventArgs e)
        {
            _PerformStatusFilterButtonClick((BunifuThinButton2)sender);
        }

        private void txtSearchBar_OnTextChange(object sender, EventArgs e)
        {
            lblSearchBar.Text = "";
            _PerformSearch();
        }

        private void btnClearSearchBar_Click(object sender, EventArgs e)
        {
            _RefreshForm();

        }

        private void btnAddNewLDLApp_Click(object sender, EventArgs e)
        {
            frmAddorUpdateLocalDrivingLicenceApp frmAddorUpdateLocalDrivingLicenceApp_v = new frmAddorUpdateLocalDrivingLicenceApp();
            clsDVLDSettings.ShowFormInPanel(pnlLocalApplicationsLoader, frmAddorUpdateLocalDrivingLicenceApp_v);

        }

        private void dgLocalLicenceApps_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if ((e.Button == MouseButtons.Right) && e.RowIndex >= 0)
            {
                dgLocalLicenceApps.ClearSelection();
                dgLocalLicenceApps.Rows[e.RowIndex].Selected = true;
                dgLocalLicenceApps.CurrentCell = dgLocalLicenceApps.Rows[e.RowIndex].Cells[e.ColumnIndex];
                _LoadDataToSelectedLDLApp(Convert.ToInt16(dgLocalLicenceApps.Rows[e.RowIndex].Cells[0].Value));
                _AlterAppOperationListToShow();
                cmsLDLAppOperationsList.Show(MousePosition);
            }
        }

        private void itemCancelApplication_Click(object sender, EventArgs e)
        {
            clsLDLApplication.ChangeLDLAppStatus(_SelectedLDLApplication, 2);
            _RefreshLDLAppsList();
        }

        private void itemShowDetails_Click(object sender, EventArgs e)
        {
            _ShowLDLAppDetailsForm();
        }

        private void dgLocalLicenceApps_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _LoadDataToSelectedLDLApp(Convert.ToInt16(dgLocalLicenceApps.Rows[e.RowIndex].Cells[0].Value));
            _ShowLDLAppDetailsForm();
        }

        private void itemDelete_Click(object sender, EventArgs e)
        {
            if (clsLDLApplication.DeleteLocalDrivingLicenseApplication(_SelectedLDLApplication.LocalDrivingLicenseApplicationID))
            {
                _RefreshLDLAppsList();
            }
            else
                MessageBox.Show("Cant Delete This Application Due to Assosiated Data", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

        }

        private void subItemScheduleTestType_Click(object sender, EventArgs e)
        {
            if (_CanPersonTakeTest(_SelectedLDLApplication, Convert.ToInt32(((ToolStripMenuItem)sender).Tag)))
            {
                frmTestAppointments frmTestAppointments = new frmTestAppointments(_SelectedLDLApplication,
                    Convert.ToInt32(((ToolStripMenuItem)sender).Tag));
                clsDVLDSettings.ShowFormInPanel(pnlLocalApplicationsLoader, frmTestAppointments);
            }
            else
            {
                MessageBox.Show("You Cant Take This Test\nTake Previous Tests First", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void itemIssueDrivingLicence_Click(object sender, EventArgs e)
        {
            _ShowIssueLicenceForm();
        }

        private void itemShowLicence_Click(object sender, EventArgs e)
        {
            _ShowLicenceInfoForm();
        }

        private void itemShowPersonLicencesHistory_Click(object sender, EventArgs e)
        {
            _ShowLicenceHistoryForm();
        }

        private void itemEdit_Click(object sender, EventArgs e)
        {
            _ShowUpdateLDLAppForm();
        }
    }
}
