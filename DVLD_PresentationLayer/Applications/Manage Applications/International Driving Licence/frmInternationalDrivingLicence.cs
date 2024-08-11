using Bunifu.Framework.UI;
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
    public partial class frmInternationalDrivingLicence : Form
    {
        public frmInternationalDrivingLicence()
        {
            InitializeComponent();
        }


        clsInternationalLicense _SelectedIntLicence = new clsInternationalLicense();

        class clsInternationalLicenceList
        {
            static void _AlterInternationalLicencesTableColumns(ref DataTable dtInternationalLicences)
            {
                clsDVLDSettings.ChangeColumnNameInDataTable("InternationalLicenseID", "InterLicenceID", ref dtInternationalLicences);

                clsDVLDSettings.ChangeColumnNameInDataTable("ApplicationID", "App ID", ref dtInternationalLicences);

                clsDVLDSettings.ChangeColumnNameInDataTable("IssuedUsingLocalLicenseID", "Liecence ID", ref dtInternationalLicences);

                clsDVLDSettings.ChangeColumnNameInDataTable("IssueDate", "Issue Date", ref dtInternationalLicences);

                clsDVLDSettings.ChangeColumnNameInDataTable("ExpirationDate", "Expiration Date", ref dtInternationalLicences);

                clsDVLDSettings.ChangeColumnNameInDataTable("IsActive", "Is Active", ref dtInternationalLicences);

            }

            static void _AlterInternationalLicencesTableRows(ref DataTable dtInternationalLicences)
            {
                //
            }

            static void _DeleteUnWantedColumnsFromInternationalLicencesTable(ref DataTable dtInternationalLicences)
            {
                dtInternationalLicences.Columns.Remove("DriverID");

                dtInternationalLicences.Columns.Remove("CreatedByUserID");


            }

            static void _ReorderInternationalLicencesTableColumns(ref DataTable dtInternationalLicences)
            {

                //

            }

            static DataTable _AlterInternationalLicencesTableToShow(DataTable dtInternationalLicences)
            {
                _AlterInternationalLicencesTableColumns(ref dtInternationalLicences);
                //if (dtInternationalLicences.Rows.Count > 0) _AlterInternationalLicencesTableRows(ref dtInternationalLicences);
                _DeleteUnWantedColumnsFromInternationalLicencesTable(ref dtInternationalLicences);
                _ReorderInternationalLicencesTableColumns(ref dtInternationalLicences);


                return dtInternationalLicences;

            }

            static DataTable _FillInternationalLicencesTableColumnsIfBlank(DataTable dtInternationalLicences)
            {
                return dtInternationalLicences.Rows.Count > 0 ? dtInternationalLicences :
                    clsInternationalLicense.GetBlankInternationalLicensesTable();
            }

            public static void ShowDataOnInternationalLicencesList(DataTable dtInternationalLicences, BunifuCustomDataGrid dgInternationalLicences)
            {
                clsDVLDSettings.ShowDataOnCustomDataGridView(dgInternationalLicences,
                    _AlterInternationalLicencesTableToShow(_FillInternationalLicencesTableColumnsIfBlank(dtInternationalLicences)));
            }

        }

        void _RoundControls()
        {
            Control[] controls = { pnlIntApplicationsLoader, dgIntLicences };
            clsDVLDSettings.RoundControlsByCustomElips(bunifuElipse1, controls);

        }

        void _LoadDataToSelectedIntLicence(int IntLicenceID)
        {
            _SelectedIntLicence = clsInternationalLicense.FindByInternationalLicenseID(IntLicenceID);
        }

        void _GoBackToAppsForm()
        {
            frmManageApplications frmManageApplications_v = new frmManageApplications();
            clsDVLDSettings.ShowFormInPanel(pnlIntApplicationsLoader, frmManageApplications_v);
        }

        void _DeActivateORActivateActiveFilterButton(BunifuThinButton2 BTN)
        {
            _ = Convert.ToInt16(BTN.Tag) == 0 ? BTN.Tag = 1 : BTN.Tag = 0;
        }

        bool _IsActiveFilterButtonActivated(BunifuThinButton2 BTN)
        {
            return Convert.ToInt16(BTN.Tag) == 0 ? false : true;

        }

        void _PerformActiveFilterButtonStyle(BunifuThinButton2 BTN)
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

        void _DeActivateActiveFilterButton(BunifuThinButton2 BTN)
        {
            BTN.Tag = 0;
            _PerformActiveFilterButtonStyle(BTN);
        }

        void _PerformActiveFilterButtonClick(BunifuThinButton2 BTN)
        {
            _DeActivateORActivateActiveFilterButton(BTN);

            if (BTN.Name == "btnActive")
            {
                _DeActivateActiveFilterButton(btnInActive);
                _PerformActiveFilterButtonStyle(BTN);
                clsInternationalLicenceList.ShowDataOnInternationalLicencesList(_IsActiveFilterButtonActivated(BTN) ?
                    clsInternationalLicense.GetAlInternationalLicensesByIsActive(true) :
                    clsInternationalLicense.GetAllInternationalLicenses(), dgIntLicences);
            }
            else if (BTN.Name == "btnInActive")
            {
                _DeActivateActiveFilterButton(btnActive);
                _PerformActiveFilterButtonStyle(BTN);
                clsInternationalLicenceList.ShowDataOnInternationalLicencesList(_IsActiveFilterButtonActivated(BTN) ?
                    clsInternationalLicense.GetAlInternationalLicensesByIsActive(false) :
                    clsInternationalLicense.GetAllInternationalLicenses(), dgIntLicences);
            }



        }

        void _PerformSearch()
        {

            if (txtSearchBar.text == "")
            {
                clsInternationalLicenceList.ShowDataOnInternationalLicencesList(
                    clsInternationalLicense.GetAllInternationalLicenses(),dgIntLicences);
                return;
            }


            switch (cbSearchFilter.SelectedIndex)
            {
                case 0:
                    {
                        clsInternationalLicenceList.ShowDataOnInternationalLicencesList(
                            clsInternationalLicense.GetAlInternationalLicensesByInternationalLicenseID(
                            clsDVLDSettings.IsNumber(txtSearchBar.text) ?
                                Convert.ToInt32(txtSearchBar.text) : -1), dgIntLicences);
                        break;
                    }
                case 1:
                    {
                        clsInternationalLicenceList.ShowDataOnInternationalLicencesList(
                            clsInternationalLicense.GetAlInternationalLicensesByInternationalApplicationID(
                            clsDVLDSettings.IsNumber(txtSearchBar.text) ?
                                Convert.ToInt32(txtSearchBar.text) : -1), dgIntLicences);
                        break;
                    }
                case 2:
                    {
                        clsInternationalLicenceList.ShowDataOnInternationalLicencesList(
                            clsInternationalLicense.GetAlInternationalLicensesByLocalLicenseID(
                            clsDVLDSettings.IsNumber(txtSearchBar.text) ?
                                Convert.ToInt32(txtSearchBar.text) : -1), dgIntLicences);
                        break;
                    }
                case 3:
                    {
                        clsInternationalLicenceList.ShowDataOnInternationalLicencesList(
                            clsInternationalLicense.GetAlInternationalLicensesByDriverID(
                            clsDVLDSettings.IsNumber(txtSearchBar.text) ?
                                Convert.ToInt32(txtSearchBar.text) : -1), dgIntLicences);
                        break;
                    }
               

            }
        }

        void _RefreshIntLicencesList()
        {
            clsInternationalLicenceList.ShowDataOnInternationalLicencesList(
                                clsInternationalLicense.GetAllInternationalLicenses(), dgIntLicences);
        }

        void _RefreshForm()
        {
            _DeActivateActiveFilterButton(btnActive);
            _DeActivateActiveFilterButton(btnInActive);
            clsDVLDSettings.ResetCustomSearchBar(txtSearchBar, lblSearchBar);
            _RefreshIntLicencesList();
            clsDVLDSettings.ShowIndexOnSearchFilter(cbSearchFilter, 0);

        }

        void _ShowintLicenceDetailsForm()
        {
            frmInternationalLicenceDetails frmInternationalLicenceDetails_v =
                new frmInternationalLicenceDetails(_SelectedIntLicence);
            clsDVLDSettings.ShowFormInPanel(pnlIntApplicationsLoader, frmInternationalLicenceDetails_v);
        }

        void _ShowIntLicenceDetailsForm()
        {
            frmAddInternationalLicence frmAddInternationalLicence_v = new frmAddInternationalLicence();
            clsDVLDSettings.ShowFormInPanel(pnlIntApplicationsLoader, frmAddInternationalLicence_v);
        }











        private void frmInternationalDrivingLicence_Load(object sender, EventArgs e)
        {
            _RoundControls();
            clsInternationalLicenceList.ShowDataOnInternationalLicencesList(
                                clsInternationalLicense.GetAllInternationalLicenses(), dgIntLicences);
            clsDVLDSettings.ShowIndexOnSearchFilter(cbSearchFilter, 0);
        }

        private void btnActiveFilter_Click(object sender, EventArgs e)
        {
            _PerformActiveFilterButtonClick((BunifuThinButton2)sender);
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

        private void dgIntLicences_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if ((e.Button == MouseButtons.Right) && e.RowIndex >= 0)
            {
                dgIntLicences.ClearSelection();
                dgIntLicences.Rows[e.RowIndex].Selected = true;
                dgIntLicences.CurrentCell = dgIntLicences.Rows[e.RowIndex].Cells[e.ColumnIndex];
                _LoadDataToSelectedIntLicence(Convert.ToInt16(dgIntLicences.Rows[e.RowIndex].Cells[0].Value));
                cmsIntLicenceOperationsList.Show(MousePosition);
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            _GoBackToAppsForm();
        }

        private void itemShowDetails_Click(object sender, EventArgs e)
        {
            _ShowintLicenceDetailsForm();
        }

        private void btnAddNewIntApp_Click(object sender, EventArgs e)
        {
            _ShowIntLicenceDetailsForm();
        }
    }
}
