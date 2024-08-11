using Bunifu.Framework.UI;
using DVLD_BusinessLayer;
using DVLD_PresentationLayer.Applications.Manage_Applications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Licences
{
    public partial class frmLicenceHistory : Form
    {
        public frmLicenceHistory(clsPerson Person)
        {
            InitializeComponent();
            stLicenceInfo.ApplicantPerson = Person;
            stLicenceInfo.Driver = clsDriver.FindByPersonID(Person.ID);
        }

        //InternationalLicences

        struct stLicenceInfo
        {
            public static clsInternationalLicense InternationalLicense = null;
            public static clsLDLApplication LDLApp = null;
            public static clsLicenseClass LicenceClass = null;
            public static clsApplication MainApp = null;
            public static clsPerson ApplicantPerson = null;
            public static clsLicence Licence = null;
            public static clsDriver Driver = null;

        }
          
        class clsLocalLicenceList
        {
            static void _AlterLocalLicencesTableColumns(ref DataTable dtLocalLicences)
            {
                clsDVLDSettings.ChangeColumnNameInDataTable("LicenseID", "License ID", ref dtLocalLicences);

                clsDVLDSettings.ChangeColumnNameInDataTable("ApplicationID", "App ID", ref dtLocalLicences);

                clsDVLDSettings.ChangeColumnNameInDataTable("IssueDate", "Issue Date", ref dtLocalLicences);

                clsDVLDSettings.ChangeColumnNameInDataTable("ExpirationDate", "Expiration Date", ref dtLocalLicences);

                clsDVLDSettings.ChangeColumnNameInDataTable("IsActive", "Is Active", ref dtLocalLicences);


                clsDVLDSettings.AddColumnToDataTable("Class Name", typeof(string), ref dtLocalLicences);

            }

            static void _AlterLocalLicencesTableRows(ref DataTable dtLocalLicences)
            {
                for (int i = 0; i < dtLocalLicences.Rows.Count; i++)
                {
                    clsDVLDSettings.AddValueToDataTable(i, "Class Name",
                       clsLicenseClass.Find(Convert.ToInt16(dtLocalLicences.Rows[i]["LicenseClass"])).ClassName,
                        ref dtLocalLicences);

                }
            }

            static void _DeleteUnWantedColumnsFromLocalLicencesTable(ref DataTable dtLocalLicences)
            {
                dtLocalLicences.Columns.Remove("DriverID");

                dtLocalLicences.Columns.Remove("LicenseClass");

                dtLocalLicences.Columns.Remove("Notes");

                dtLocalLicences.Columns.Remove("PaidFees");

                dtLocalLicences.Columns.Remove("IssueReason");

                dtLocalLicences.Columns.Remove("CreatedByUserID");


            }

            static void _ReorderLocalLicencesTableColumns(ref DataTable dtLocalLicences)
            {

                dtLocalLicences.Columns["License ID"].SetOrdinal(0);
                dtLocalLicences.Columns["App ID"].SetOrdinal(1);
                dtLocalLicences.Columns["Class Name"].SetOrdinal(2);
                dtLocalLicences.Columns["Issue Date"].SetOrdinal(3);
                dtLocalLicences.Columns["Expiration Date"].SetOrdinal(4);
                dtLocalLicences.Columns["Is Active"].SetOrdinal(5);

            }

            static DataTable _AlterLocalLicencesTableToShow(DataTable dtLocalLicences)
            {
                _AlterLocalLicencesTableColumns(ref dtLocalLicences);
                if (dtLocalLicences.Rows.Count > 0) _AlterLocalLicencesTableRows(ref dtLocalLicences);
                _DeleteUnWantedColumnsFromLocalLicencesTable(ref dtLocalLicences);
                _ReorderLocalLicencesTableColumns(ref dtLocalLicences);


                return dtLocalLicences;

            }

            static DataTable _FillLocalLicencesTableColumnsIfBlank(DataTable dtLocalLicences)
            {
                return dtLocalLicences.Rows.Count > 0 ? dtLocalLicences : clsLicence.GetBlankLicencesTable();
            }

            public static void ShowDataOnLocalLicencesList(DataTable dtLocalLicences, BunifuCustomDataGrid dgLocalLicences)
            {
                clsDVLDSettings.ShowDataOnCustomDataGridView(dgLocalLicences,
                    _AlterLocalLicencesTableToShow(_FillLocalLicencesTableColumnsIfBlank(dtLocalLicences)));
            }

        }

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
            Control[] controls = { ctrlPersonDetails1, tabCtrlLicencesHistory,
                tabInternational, tabLocal, dgInternationalLicences, dgLocalLicences, btnGoBack };
            clsDVLDSettings.RoundControlsByCustomElips(bunifuElipse1, controls);

        }

        void _LoadDataToPersonCtrl()
        {
            ctrlPersonDetails1.DispalyPersonData(stLicenceInfo.ApplicantPerson.ID);
        }

        void _GoBackToLDLAppForm()
        {
            frmLocalDrivingLicenceApp frmLocalDrivingLicenceApp_v = new frmLocalDrivingLicenceApp();
            clsDVLDSettings.ShowFormInPanel(pnlLicenceLoader, frmLocalDrivingLicenceApp_v);
        }

        void _ShowLocalLiences()
        {
            clsLocalLicenceList.ShowDataOnLocalLicencesList(
               clsLicence.GetAlLicensesByDriverID(stLicenceInfo.Driver.DriverID), dgLocalLicences);
        }

        void _ShowInternationalLiences()
        {
            clsInternationalLicenceList.ShowDataOnInternationalLicencesList(
                clsInternationalLicense.GetAlInternationalLicensesByDriverID(
                    stLicenceInfo.Driver.DriverID), dgInternationalLicences);
        }


        private void frmLicenceHistory_Load(object sender, EventArgs e)
        {
            _RoundControls();
            _LoadDataToPersonCtrl();
            _ShowLocalLiences();
            _ShowInternationalLiences();

        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            _GoBackToLDLAppForm();
        }
    }
}
