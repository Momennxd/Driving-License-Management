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
using System.IO;
using Bunifu.Framework.UI;
using System.Xml.Serialization;
using System.Security.Policy;
using System.Runtime.Remoting.Messaging;

namespace DVLD_PresentationLayer
{
    public partial class frmPeople : Form
    {
        public frmPeople()
        {
            InitializeComponent();
        }

        clsPerson _SelectedPerson = new clsPerson();

        void _RoundControls()
        {
            Control[] controls = { dgPeople, cbSearchFilter, pnlPeopleLoader };
            clsDVLDSettings.RoundControlsByCustomElips(bunifuElipse1, controls);

        }

        void _LoadDataToSelectedPerson(int PersonID)
        {
            _SelectedPerson = clsPerson.Find(PersonID);
        }

        void _AlterPeopleTableColumns(ref DataTable dtPeople)
        {
            clsDVLDSettings.ChangeColumnNameInDataTable("NationalNo", "National Num", ref dtPeople);
            clsDVLDSettings.ChangeColumnNameInDataTable("FirstName", "First Name", ref dtPeople);
            clsDVLDSettings.ChangeColumnNameInDataTable("SecondName", "Second Name", ref dtPeople);
            clsDVLDSettings.ChangeColumnNameInDataTable("ThirdName", "Third Name", ref dtPeople);
            clsDVLDSettings.ChangeColumnNameInDataTable("LastName", "Last Name", ref dtPeople);
            clsDVLDSettings.ChangeColumnNameInDataTable("DateOfBirth", "Date Of Birth", ref dtPeople);
            clsDVLDSettings.ChangeColumnNameInDataTable("Gender", "GenderIndex", ref dtPeople);
            clsDVLDSettings.ChangeColumnNameInDataTable("PersonID", "Person ID", ref dtPeople);

            clsDVLDSettings.AddColumnToDataTable("Gender", typeof(string), ref dtPeople);
            clsDVLDSettings.AddColumnToDataTable("Nationality", typeof(string), ref dtPeople);

        }

        void _AlterPeopleTableRows(ref DataTable dtPeople)
        {
            for (int i = 0; i < dtPeople.Rows.Count; i++)
            {

                if (Convert.ToInt16(dtPeople.Rows[i]["GenderIndex"]) == 0)
                    clsDVLDSettings.AddValueToDataTable(i, "Gender", "Male", ref dtPeople);

                else if (Convert.ToInt16(dtPeople.Rows[i]["GenderIndex"]) == 1)
                    clsDVLDSettings.AddValueToDataTable(i, "Gender", "Female", ref dtPeople);

                else
                    clsDVLDSettings.AddValueToDataTable(i, "Gender", "Other", ref dtPeople);


                clsDVLDSettings.AddValueToDataTable(i, "Nationality",
                    clsCountry.Find(Convert.ToInt16(dtPeople.Rows[i]["NationalityCountryID"])).CountryName,
                    ref dtPeople);

            }
        }

        void _DeleteUnWantedColumnsFromPeopleTable(ref DataTable dtPeople)
        {
            dtPeople.Columns.Remove("NationalityCountryID");

            dtPeople.Columns.Remove("GenderIndex");

            dtPeople.Columns.Remove("ImagePath");

            dtPeople.Columns.Remove("Date Of Birth");


            dtPeople.Columns.Remove("Address");

            dtPeople.Columns.Remove("Email");

            dtPeople.Columns.Remove("Phone");



        }

        void _ReorderPeopleTableColumns(ref DataTable dtPeople)
        {

            dtPeople.Columns["Person ID"].SetOrdinal(0);
            dtPeople.Columns["National Num"].SetOrdinal(1);
            dtPeople.Columns["First Name"].SetOrdinal(2);
            dtPeople.Columns["Second Name"].SetOrdinal(3);
            dtPeople.Columns["Third Name"].SetOrdinal(4);
            dtPeople.Columns["Last Name"].SetOrdinal(5);
            dtPeople.Columns["Gender"].SetOrdinal(6);
            //dtPeople.Columns["Date Of Birth"].SetOrdinal(7);
            dtPeople.Columns["Nationality"].SetOrdinal(7);

            // dtPeople.Columns["Phone"].SetOrdinal(8);
            //dtPeople.Columns["Email"].SetOrdinal(9);

        }

        DataTable _AlterPeopleTableToShow(DataTable dtPeople)
        {
            _AlterPeopleTableColumns(ref dtPeople);
            if (dtPeople.Rows.Count > 0) _AlterPeopleTableRows(ref dtPeople);
            _DeleteUnWantedColumnsFromPeopleTable(ref dtPeople);
            _ReorderPeopleTableColumns(ref dtPeople);
            
           
            return dtPeople;

        }

        void _ShowDataOnPeopleList(DataTable dtPeople)
        {
            clsDVLDSettings.ShowDataOnCustomDataGridView(dgPeople,
                _AlterPeopleTableToShow(_FillPeopleTableColumnsIfBlank(dtPeople)));
        }

        void _DeActivateORActivateGenderFilterButton(BunifuThinButton2 BTN)
        {
            _ = Convert.ToInt16(BTN.Tag) == 0 ? BTN.Tag = 1 : BTN.Tag = 0;
        }

        bool _IsGenderFilterButtonActivated(BunifuThinButton2 BTN)
        {
            return Convert.ToInt16(BTN.Tag) == 0 ? false : true;

        }

        void _PerformGenderFilterButtonStyle(BunifuThinButton2 BTN)
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

        void _DeActivateGenderFilterButton(BunifuThinButton2 BTN)
        {
            BTN.Tag = 0;
            _PerformGenderFilterButtonStyle(BTN);
        }

        void _PerformGenderFilterButtonClick(BunifuThinButton2 BTN)
        {
            _DeActivateORActivateGenderFilterButton(BTN);

            if (BTN.Name == "btnMales")
            {
                _DeActivateGenderFilterButton(btnFemales);
                _PerformGenderFilterButtonStyle(BTN);
                _ShowDataOnPeopleList(_IsGenderFilterButtonActivated(BTN) ?
                    clsPerson.GetAllPeopleByGender(0) : clsPerson.GetAllPeople());
            }
            else if (BTN.Name == "btnFemales")
            {
                _DeActivateGenderFilterButton(btnMales);
                _PerformGenderFilterButtonStyle(BTN);
                _ShowDataOnPeopleList(_IsGenderFilterButtonActivated(BTN) ?
                    clsPerson.GetAllPeopleByGender(1) : clsPerson.GetAllPeople());
            }



        }

        DataTable _FillPeopleTableColumnsIfBlank(DataTable dtPeople)
        {
            return dtPeople.Rows.Count > 0 ? dtPeople : clsPerson.GetBlankPeopleTable();
        }

        void _PerformSearch()
        {

            if (txtSearchBar.text == "")
            {
                _ShowDataOnPeopleList(clsPerson.GetAllPeople());
                return;
            }


            switch (cbSearchFilter.SelectedIndex)
            {
                case 0:
                    {
                        _ShowDataOnPeopleList(clsPerson.GetAllPeopleByPersonID(
                            clsDVLDSettings.IsNumber(txtSearchBar.text) ?
                                Convert.ToInt32(txtSearchBar.text) : -1));
                        break;
                    }
                case 1:
                    {
                        _ShowDataOnPeopleList(clsPerson.GetAllPeopleColumnNameDataStartsWith(
                            "NationalNo", txtSearchBar.text));
                        break;
                    }
                case 2:
                    {
                        _ShowDataOnPeopleList(clsPerson.GetAllPeopleColumnNameDataStartsWith(
                            "FirstName", txtSearchBar.text));
                        break;
                    }
                case 3:
                    {
                        _ShowDataOnPeopleList(clsPerson.GetAllPeopleColumnNameDataStartsWith(
                            "SecondName", txtSearchBar.text));
                        break;
                    }
                case 4:
                    {
                        _ShowDataOnPeopleList(clsPerson.GetAllPeopleColumnNameDataStartsWith(
                            "ThirdName", txtSearchBar.text));
                        break;
                    }
                case 5:
                    {
                        _ShowDataOnPeopleList(clsPerson.GetAllPeopleColumnNameDataStartsWith(
                            "LastName", txtSearchBar.text));
                        break;
                    }
              
            }
        }
         
        void _RefreshPeopleList()
        {
            _ShowDataOnPeopleList(clsPerson.GetAllPeople());
        }

        void _RefreshForm()
        {
            _DeActivateGenderFilterButton(btnMales);
            _DeActivateGenderFilterButton(btnFemales);
            clsDVLDSettings.ResetCustomSearchBar(txtSearchBar, lblSearchBar);
            _RefreshPeopleList();
            clsDVLDSettings.ShowIndexOnSearchFilter(cbSearchFilter, 0);

        }

        void _ShowPersonDetailsForm()
        {
            frmPersonDetails frmPersonDetails_v = new frmPersonDetails(_SelectedPerson);
            clsDVLDSettings.ShowFormInPanel(pnlPeopleLoader, frmPersonDetails_v);
        }


        private void frmPeople_Load(object sender, EventArgs e)
        {
            _RoundControls();
            _ShowDataOnPeopleList(clsPerson.GetAllPeople());
            clsDVLDSettings.ShowIndexOnSearchFilter(cbSearchFilter, 2);
        }

        private void btnGenderFilter_Click(object sender, EventArgs e)
        {
            _PerformGenderFilterButtonClick((BunifuThinButton2)sender);
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

        private void dgPeople_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if ((e.Button == MouseButtons.Right) && e.RowIndex >= 0)
            {
                dgPeople.ClearSelection();
                dgPeople.Rows[e.RowIndex].Selected = true;
                dgPeople.CurrentCell = dgPeople.Rows[e.RowIndex].Cells[e.ColumnIndex];
                _LoadDataToSelectedPerson(Convert.ToInt16(dgPeople.Rows[e.RowIndex].Cells[0].Value));
                cmsPeopleOperationsList.Show(MousePosition);
            }
        }

        private void itemDelete_Click(object sender, EventArgs e)
        {

            //Tep Code.

            if (!clsPerson.DeletePerson(_SelectedPerson.ID))
                MessageBox.Show("Error");
               
            

            _RefreshPeopleList();
        }

        private void itemShowDetails_Click(object sender, EventArgs e)
        {
            _ShowPersonDetailsForm();
        }

        private void dgPeople_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _LoadDataToSelectedPerson(Convert.ToInt16(dgPeople.Rows[e.RowIndex].Cells[0].Value));
            _ShowPersonDetailsForm();
        }

        private void itemEdit_Click(object sender, EventArgs e)
        {
            frmAdd_EditPerson frmAdd_EditPerson_v = new frmAdd_EditPerson(_SelectedPerson);
            clsDVLDSettings.ShowFormInPanel(pnlPeopleLoader, frmAdd_EditPerson_v);
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAdd_EditPerson frmAdd_EditPerson_v = new frmAdd_EditPerson();
            clsDVLDSettings.ShowFormInPanel(pnlPeopleLoader, frmAdd_EditPerson_v);
        }
    }
}
