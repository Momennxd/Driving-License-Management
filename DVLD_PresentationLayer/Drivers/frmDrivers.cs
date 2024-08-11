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

namespace DVLD_PresentationLayer.Drivers
{
    public partial class frmDrivers : Form
    {
        public frmDrivers()
        {
            InitializeComponent();
        }

        //Drivers

        void _RoundControls()
        {
            Control[] controls = { dgDrivers, cbSearchFilter, pnlDriversLoader };
            clsDVLDSettings.RoundControlsByCustomElips(bunifuElipse1, controls);

        }

        void _AlterDriversTableColumns(ref DataTable dtDrivers)
        {
            clsDVLDSettings.ChangeColumnNameInDataTable("DriverID", "Driver ID", ref dtDrivers);
            clsDVLDSettings.ChangeColumnNameInDataTable("PersonID", "Person ID", ref dtDrivers);
            clsDVLDSettings.ChangeColumnNameInDataTable("CreatedDate", "Date", ref dtDrivers);



            clsDVLDSettings.AddColumnToDataTable("National No", typeof(string), ref dtDrivers);
            clsDVLDSettings.AddColumnToDataTable("Full Name", typeof(string), ref dtDrivers);
            clsDVLDSettings.AddColumnToDataTable("Active Licences", typeof(int), ref dtDrivers);

        }

        void _AlterDriversTableRows(ref DataTable dtDrivers)
        {
            clsPerson Person = null;
            for (int i = 0; i < dtDrivers.Rows.Count; i++)
            {
                Person = clsPerson.Find(Convert.ToInt16(dtDrivers.Rows[i]["Person ID"]));



                clsDVLDSettings.AddValueToDataTable(i, "Person ID",
                    Person.ID, ref dtDrivers);

                clsDVLDSettings.AddValueToDataTable(i, "National No",
                    Person.NationalNo, ref dtDrivers);

                clsDVLDSettings.AddValueToDataTable(i, "Full Name",
                    clsDVLDSettings.GetPersonFullName(Person), ref dtDrivers);

                clsDVLDSettings.AddValueToDataTable(i, "National No",
                    Person.NationalNo, ref dtDrivers);

                clsDVLDSettings.AddValueToDataTable(i, "Active Licences",
                    clsLicence.GetNumberOfActiveLicensesByPersonID(Person.ID), ref dtDrivers);


            }
        }

        void _DeleteUnWantedColumnsFromDriversTable(ref DataTable dtDrivers)
        {
            dtDrivers.Columns.Remove("CreatedByUserID");

       
        }

        void _ReorderDriversTableColumns(ref DataTable dtDrivers)
        {

            dtDrivers.Columns["Driver ID"].SetOrdinal(0);
            dtDrivers.Columns["Person ID"].SetOrdinal(1);
            dtDrivers.Columns["National No"].SetOrdinal(2);
            dtDrivers.Columns["Full Name"].SetOrdinal(3);
            dtDrivers.Columns["Date"].SetOrdinal(4);
            dtDrivers.Columns["Active Licences"].SetOrdinal(5);

        }

        DataTable _AlterDriversTableToShow(DataTable dtDrivers)
        {
            _AlterDriversTableColumns(ref dtDrivers);
            if (dtDrivers.Rows.Count > 0) _AlterDriversTableRows(ref dtDrivers);
            _DeleteUnWantedColumnsFromDriversTable(ref dtDrivers);
            _ReorderDriversTableColumns(ref dtDrivers);


            return dtDrivers;

        }

        DataTable _FillDriversTableColumnsIfBlank(DataTable dtDrivers)
        {
            return dtDrivers.Rows.Count > 0 ? dtDrivers : clsDriver.GetAllDriversBlankTable();
        }

        void _ShowDataOnDriversList(DataTable dtDrivers)
        {
            clsDVLDSettings.ShowDataOnCustomDataGridView(dgDrivers,
                _AlterDriversTableToShow(_FillDriversTableColumnsIfBlank(dtDrivers)));
        }

        void _PerformSearch()
        {

            if (txtSearchBar.text == "")
            {
                _ShowDataOnDriversList(clsDriver.GetAllDrivers());
                return;
            }


            switch (cbSearchFilter.SelectedIndex)
            {
                case 0:
                    {
                        _ShowDataOnDriversList(clsDriver.GetAllDriversByDriverID(
                            clsDVLDSettings.IsNumber(txtSearchBar.text) ?
                                Convert.ToInt32(txtSearchBar.text) : -1));
                        break;
                    }
                case 1:
                    {
                        _ShowDataOnDriversList(clsDriver.GetAllDriversByPersonID(
                            clsDVLDSettings.IsNumber(txtSearchBar.text) ?
                                Convert.ToInt32(txtSearchBar.text) : -1));
                        break;
                    }
                case 2:
                    {
                        _ShowDataOnDriversList(clsDriver.GetAllDriversColumnNameDataStartsWith(
                            "NationalNo", txtSearchBar.text));
                        break;
                    }
                case 3:
                    {
                        _ShowDataOnDriversList(clsDriver.GetAllDriversByPersonFullNameDataStartsWith(
                         txtSearchBar.text));
                        break;
                    }
               
                

            }
        }

        void _RefreshDriversList()
        {
            _ShowDataOnDriversList(clsDriver.GetAllDrivers());
        }

        void _RefreshForm()
        {           
            clsDVLDSettings.ResetCustomSearchBar(txtSearchBar, lblSearchBar);
            _RefreshDriversList();
            clsDVLDSettings.ShowIndexOnSearchFilter(cbSearchFilter, 0);

        }







        private void frmDrivers_Load(object sender, EventArgs e)
        {
            _RoundControls();
            _ShowDataOnDriversList(clsDriver.GetAllDrivers());
            clsDVLDSettings.ShowIndexOnSearchFilter(cbSearchFilter, 0);
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
    }
}
