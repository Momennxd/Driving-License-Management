using Bunifu.Framework.UI;
using DVLD_BusinessLayer;
using DVLD_PresentationLayer.Applications.Manage_Applications;
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

namespace DVLD_PresentationLayer.Applications.Detain_Licences
{
    public partial class frmManageDetainedLicences : Form
    {
        public frmManageDetainedLicences()
        {
            InitializeComponent();
        }

        struct stLicenceInfo
        {
            public static clsApplication MainApp = null;
            public static clsPerson ApplicantPerson = null;
            public static clsLicence Licence = null;
            public static clsDetainedLicence SelectedDetainedLicence = null;
        }

        class clsDetainedLicenceList
        {
            static void _AlterDetainedLicencesTableColumns(ref DataTable dtDetainedLicences)
            {
                clsDVLDSettings.ChangeColumnNameInDataTable("DetainID", "Detain ID", ref dtDetainedLicences);

                clsDVLDSettings.ChangeColumnNameInDataTable("LicenseID", "License ID", ref dtDetainedLicences);

                clsDVLDSettings.ChangeColumnNameInDataTable("IsReleased", "Is Released", ref dtDetainedLicences);

                clsDVLDSettings.ChangeColumnNameInDataTable("DetainDate", "D.Date", ref dtDetainedLicences);

                clsDVLDSettings.ChangeColumnNameInDataTable("FineFees", "Fine Fees", ref dtDetainedLicences);

                clsDVLDSettings.ChangeColumnNameInDataTable("ReleaseDate", "R.Date", ref dtDetainedLicences);

                clsDVLDSettings.ChangeColumnNameInDataTable("ReleaseApplicationID", "R.App ID", ref dtDetainedLicences);

                clsDVLDSettings.AddColumnToDataTable("N.Number", typeof(string), ref dtDetainedLicences);

                clsDVLDSettings.AddColumnToDataTable("Full Name", typeof(string), ref dtDetainedLicences);


            }

            static void _AlterDetainedlLicencesTableRows(ref DataTable dtDetainedLicences)
            {
                for (int i = 0; i < dtDetainedLicences.Rows.Count; i++)
                {

                    stLicenceInfo.ApplicantPerson = clsPerson.Find(
                        clsApplication.Find(clsLicence.FindByLicenceID(
                                Convert.ToInt16(dtDetainedLicences.Rows[i]["License ID"])).ApplicationID).ApplicantPersonID);

                    clsDVLDSettings.AddValueToDataTable(i, "N.Number", 
                        stLicenceInfo.ApplicantPerson.NationalNo, ref dtDetainedLicences);

                    clsDVLDSettings.AddValueToDataTable(i, "Full Name",
                       clsDVLDSettings.GetPersonFullName(stLicenceInfo.ApplicantPerson), ref dtDetainedLicences);

                }
            }

            static void _DeleteUnWantedColumnsFromDetainedLicencesTable(ref DataTable dtDetainedLicences)
            {
                dtDetainedLicences.Columns.Remove("ReleasedByUserID");

                dtDetainedLicences.Columns.Remove("CreatedByUserID");


            }

            static void _ReorderDetainedLicencesTableColumns(ref DataTable dtDetainedLicences)
            {
                dtDetainedLicences.Columns["Detain ID"].SetOrdinal(0);
                dtDetainedLicences.Columns["License ID"].SetOrdinal(1);
                dtDetainedLicences.Columns["D.Date"].SetOrdinal(2);
                dtDetainedLicences.Columns["Is Released"].SetOrdinal(3);
                dtDetainedLicences.Columns["Fine Fees"].SetOrdinal(4);
                dtDetainedLicences.Columns["R.Date"].SetOrdinal(5);
                dtDetainedLicences.Columns["N.Number"].SetOrdinal(6);
                dtDetainedLicences.Columns["Full Name"].SetOrdinal(7);
                dtDetainedLicences.Columns["R.App ID"].SetOrdinal(8);

            }

            static DataTable _AlterDetainedLicencesTableToShow(DataTable dtDetainedLicences)
            {
                _AlterDetainedLicencesTableColumns(ref dtDetainedLicences);
                if (dtDetainedLicences.Rows.Count > 0) _AlterDetainedlLicencesTableRows(ref dtDetainedLicences);
                _DeleteUnWantedColumnsFromDetainedLicencesTable(ref dtDetainedLicences);
                _ReorderDetainedLicencesTableColumns(ref dtDetainedLicences);


                return dtDetainedLicences;

            }

            static DataTable _FillDetainedLicencesTableColumnsIfBlank(DataTable dtDetainedLicences)
            {
                return dtDetainedLicences.Rows.Count > 0 ? dtDetainedLicences :
                    clsDetainedLicence.GetBlankDetainedLicensesTable();
            }

            public static void ShowDataOnDetainedLicencesList(DataTable dtDetainedLicences, BunifuCustomDataGrid dgDetainedLicences)
            {
                    clsDVLDSettings.ShowDataOnCustomDataGridView(dgDetainedLicences,
                    _AlterDetainedLicencesTableToShow(_FillDetainedLicencesTableColumnsIfBlank(dtDetainedLicences)));
            }

        }

        void _RoundControls()
        {
            Control[] controls = { pnlDetainedLicencesLoader, dgDetainedLicences };
            clsDVLDSettings.RoundControlsByCustomElips(bunifuElipse1, controls);

        }


        void _LoadDataToSelectedDetainedLicence(int DetainedLicenceID)
        {
            stLicenceInfo.SelectedDetainedLicence = clsDetainedLicence.FindByDetainID(DetainedLicenceID);
        }

        void _GoBackToAppsForm()
        {
            frmDetainLicencesServices frmDetainLicencesServices_v = new frmDetainLicencesServices();
            clsDVLDSettings.ShowFormInPanel(pnlDetainedLicencesLoader, frmDetainLicencesServices_v);
        }

        void _DeActivateORActivateReleasedFilterButton(BunifuThinButton2 BTN)
        {
            _ = Convert.ToInt16(BTN.Tag) == 0 ? BTN.Tag = 1 : BTN.Tag = 0;
        }

        bool _IsReleasedFilterButtonActivated(BunifuThinButton2 BTN)
        {
            return Convert.ToInt16(BTN.Tag) == 0 ? false : true;

        }

        void _PerformReleasedFilterButtonStyle(BunifuThinButton2 BTN)
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

        void _DeActivateReleasedFilterButton(BunifuThinButton2 BTN)
        {
            BTN.Tag = 0;
            _PerformReleasedFilterButtonStyle(BTN);
        }

        void _PerformReleasedFilterButtonClick(BunifuThinButton2 BTN)
        {
            _DeActivateORActivateReleasedFilterButton(BTN);

            if (BTN.Name == "btnReleased")
            {
                _DeActivateReleasedFilterButton(btnUnReleased);
                _PerformReleasedFilterButtonStyle(BTN);
                clsDetainedLicenceList.ShowDataOnDetainedLicencesList(_IsReleasedFilterButtonActivated(BTN) ?
                    clsDetainedLicence.GetAlDetainedLicensesByIsReleased(true) :
                    clsDetainedLicence.GetAllDetainedLicenses(), dgDetainedLicences);
            }
            else if (BTN.Name == "btnUnReleased")
            {
                _DeActivateReleasedFilterButton(btnReleased);
                _PerformReleasedFilterButtonStyle(BTN);
                clsDetainedLicenceList.ShowDataOnDetainedLicencesList(_IsReleasedFilterButtonActivated(BTN) ?
                    clsDetainedLicence.GetAlDetainedLicensesByIsReleased(false) :
                    clsDetainedLicence.GetAllDetainedLicenses(), dgDetainedLicences);
            }



        }

        void _PerformSearch()
        {

            if (txtSearchBar.text == "")
            {
                clsDetainedLicenceList.ShowDataOnDetainedLicencesList(
                    clsDetainedLicence.GetAllDetainedLicenses(), dgDetainedLicences);
                return;
            }


            switch (cbSearchFilter.SelectedIndex)
            {
                case 0:
                    {
                        clsDetainedLicenceList.ShowDataOnDetainedLicencesList(
                            clsDetainedLicence.GetAlDetainedLicensesByDetainID(
                            clsDVLDSettings.IsNumber(txtSearchBar.text) ?
                                Convert.ToInt32(txtSearchBar.text) : -1), dgDetainedLicences);
                        break;
                    }
                case 1:
                    {
                        clsDetainedLicenceList.ShowDataOnDetainedLicencesList(
                            clsDetainedLicence.GetAlDetainedLicensesByReleaseApplicationID(
                            clsDVLDSettings.IsNumber(txtSearchBar.text) ?
                                Convert.ToInt32(txtSearchBar.text) : -1), dgDetainedLicences);
                        break;
                    }
                case 2:
                    {
                        clsDetainedLicenceList.ShowDataOnDetainedLicencesList(
                            clsDetainedLicence.GetAlDetainedLicensesByLicenseID(
                            clsDVLDSettings.IsNumber(txtSearchBar.text) ?
                                Convert.ToInt32(txtSearchBar.text) : -1), dgDetainedLicences);
                        break;
                    }



            }
        }

        void _RefreshIntLicencesList()
        {
            clsDetainedLicenceList.ShowDataOnDetainedLicencesList(
                                clsDetainedLicence.GetAllDetainedLicenses(), dgDetainedLicences);
        }

        void _RefreshForm()
        {
            _DeActivateReleasedFilterButton(btnReleased);
            _DeActivateReleasedFilterButton(btnUnReleased);
            clsDVLDSettings.ResetCustomSearchBar(txtSearchBar, lblSearchBar);
            _RefreshIntLicencesList();
            clsDVLDSettings.ShowIndexOnSearchFilter(cbSearchFilter, 0);

        }

        void _ShowReleaseLicenceForm()
        {
            frmDetainAndReleaseLicence frmDetainAndReleaseLicence_v = new frmDetainAndReleaseLicence(2);
            clsDVLDSettings.ShowFormInPanel(pnlDetainedLicencesLoader, frmDetainAndReleaseLicence_v);
        }
        void _ShowDetainLicenceForm()
        {
            frmDetainAndReleaseLicence frmDetainAndReleaseLicence_v = new frmDetainAndReleaseLicence(1);
            clsDVLDSettings.ShowFormInPanel(pnlDetainedLicencesLoader, frmDetainAndReleaseLicence_v);
        }

        void _LoadDataToSelectedLicence(int LicenceID)
        {
            stLicenceInfo.Licence = clsLicence.FindByLicenceID(LicenceID);
        }






        private void frmManageDetainedLicences_Load(object sender, EventArgs e)
        {
            _RoundControls();
            clsDetainedLicenceList.ShowDataOnDetainedLicencesList(
                                clsDetainedLicence.GetAllDetainedLicenses(), dgDetainedLicences);
            clsDVLDSettings.ShowIndexOnSearchFilter(cbSearchFilter, 0);
        }

        private void btnIsReleased_Click(object sender, EventArgs e)
        {
            _PerformReleasedFilterButtonClick((BunifuThinButton2)sender);

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

        private void dgDetainedLicences_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if ((e.Button == MouseButtons.Right) && e.RowIndex >= 0)
            {
                dgDetainedLicences.ClearSelection();
                dgDetainedLicences.Rows[e.RowIndex].Selected = true;
                dgDetainedLicences.CurrentCell = dgDetainedLicences.Rows[e.RowIndex].Cells[e.ColumnIndex];
                _LoadDataToSelectedLicence(Convert.ToInt16(dgDetainedLicences.Rows[e.RowIndex].Cells[1].Value));
                cmsLicenceOperationsList.Show(MousePosition);
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            _GoBackToAppsForm();

        }

        private void btnReleaseLicence_Click(object sender, EventArgs e)
        {
            _ShowReleaseLicenceForm();
        }

        private void btnDetainLicence_Click(object sender, EventArgs e)
        {
            _ShowDetainLicenceForm();
        }

        private void itemRelease_Click(object sender, EventArgs e)
        {
            if (!clsLicence.IsLicenceDetained(stLicenceInfo.Licence.LicenseID))
            {
                MessageBox.Show($"Licence Is Not Detained",
                       "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmDetainAndReleaseLicence frmDetainAndReleaseLicence_v = new frmDetainAndReleaseLicence(2, stLicenceInfo.Licence);
            clsDVLDSettings.ShowFormInPanel(pnlDetainedLicencesLoader, frmDetainAndReleaseLicence_v);
        }
    }
}
