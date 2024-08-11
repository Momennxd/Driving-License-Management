using Bunifu.Framework.UI;
using DVLD_BusinessLayer;
using DVLD_PresentationLayer.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_PresentationLayer
{
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        clsUser _SelectedUser = new clsUser();

        void _RoundControls()
        {
            Control[] controls = { dgUsers, cbSearchFilter, pnlUsersLoader };
            clsDVLDSettings.RoundControlsByCustomElips(bunifuElipse1, controls);

        }

        void _LoadDataToSelectedUser(int UserID)
        {
            _SelectedUser = clsUser.FindByUserID(UserID);
        }

        void _AlterUsersTableColumns(ref DataTable dtUsers)
        {
            clsDVLDSettings.ChangeColumnNameInDataTable("UserName", "User Name", ref dtUsers);
            clsDVLDSettings.AddColumnToDataTable("Full Name", typeof(string), ref dtUsers);

        }

        void _AlterUsersTableRows(ref DataTable dtUsers)
        {
            for (int i = 0; i < dtUsers.Rows.Count; i++)
            {          
                clsDVLDSettings.AddValueToDataTable(i, "Full Name",
                    clsDVLDSettings.GetPersonFullName(clsPerson.Find(Convert.ToInt16(dtUsers.Rows[i][1]))),
                    ref dtUsers);

            }
        }

        void _DeleteUnWantedColumnsFromUsersTable(ref DataTable dtUsers)
        {
            dtUsers.Columns.Remove("Password");          
        }

        void _ReorderUsersTableColumns(ref DataTable dtUsers)
        {

            dtUsers.Columns["UserID"].SetOrdinal(0);
            dtUsers.Columns["PersonID"].SetOrdinal(1);
            dtUsers.Columns["Full Name"].SetOrdinal(2);
            dtUsers.Columns["User Name"].SetOrdinal(3);
            dtUsers.Columns["IsActive"].SetOrdinal(4);
            
        }

        DataTable _AlterUsersTableToShow(DataTable dtUsers)
        {
            _AlterUsersTableColumns(ref dtUsers);
            if (dtUsers.Rows.Count > 0) _AlterUsersTableRows(ref dtUsers);
            _DeleteUnWantedColumnsFromUsersTable(ref dtUsers);
            _ReorderUsersTableColumns(ref dtUsers);


            return dtUsers;

        }

        DataTable _FillUsersTableColumnsIfBlank(DataTable dtUsers)
        {
            return dtUsers.Rows.Count > 0 ? dtUsers : clsUser.GetBlankUsersTable();
        }

        void _ShowDataOnUsersList(DataTable dtUsers)
        {
            clsDVLDSettings.ShowDataOnCustomDataGridView(dgUsers,
                _AlterUsersTableToShow(_FillUsersTableColumnsIfBlank(dtUsers)));
        }

        void _DeActivateORActivateIsActiveFilterButton(BunifuThinButton2 BTN)
        {
            _ = Convert.ToInt16(BTN.Tag) == 0 ? BTN.Tag = 1 : BTN.Tag = 0;
        }

        bool _IsActiveFilterButtonActivated(BunifuThinButton2 BTN)
        {
            return Convert.ToInt16(BTN.Tag) == 0 ? false : true;

        }

        void _PerformIsActiveFilterButtonStyle(BunifuThinButton2 BTN)
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

        void _DeActivateIsActiveFilterButton(BunifuThinButton2 BTN)
        {
            BTN.Tag = 0;
            _PerformIsActiveFilterButtonStyle(BTN);
        }

        void _PerformIsActiveFilterButtonClick(BunifuThinButton2 BTN)
        {
            _DeActivateORActivateIsActiveFilterButton(BTN);

            if (BTN.Name == "btnActive")
            {
                _DeActivateIsActiveFilterButton(btnInActive);
                _PerformIsActiveFilterButtonStyle(BTN);
                _ShowDataOnUsersList(_IsActiveFilterButtonActivated(BTN) ?
                    clsUser.GetAllUsersByActivity(true) : clsUser.GetAllUsers());
            }
            else if (BTN.Name == "btnInActive")
            {
                _DeActivateIsActiveFilterButton(btnActive);
                _PerformIsActiveFilterButtonStyle(BTN);
                _ShowDataOnUsersList(_IsActiveFilterButtonActivated(BTN) ?
                    clsUser.GetAllUsersByActivity(false) : clsUser.GetAllUsers());
            }



        }

        void _PerformSearch()
        {

            if (txtSearchBar.text == "")
            {
                _ShowDataOnUsersList(clsUser.GetAllUsers());
                return;
            }


            switch (cbSearchFilter.SelectedIndex)
            {
                case 0:
                    {
                        _ShowDataOnUsersList(clsUser.GetAllUsersByUserID(
                            clsDVLDSettings.IsNumber(txtSearchBar.text) ?
                                Convert.ToInt32(txtSearchBar.text) : -1));
                        break;
                    }
                case 1:
                    {
                        _ShowDataOnUsersList(clsUser.GetAllUsersByPersonID(
                            clsDVLDSettings.IsNumber(txtSearchBar.text) ?
                                Convert.ToInt32(txtSearchBar.text) : -1));
                        break;
                    }
                case 2:
                    {
                        _ShowDataOnUsersList(clsUser.GetAllUsersColumnNameDataStartsWith(
                            "UserName", txtSearchBar.text));
                        break;
                    }
               
            }
        }

        void _RefreshUsersList()
        {
            _ShowDataOnUsersList(clsUser.GetAllUsers());
        }

        void _RefreshForm()
        {
            _DeActivateIsActiveFilterButton(btnActive);
            _DeActivateIsActiveFilterButton(btnInActive);
            clsDVLDSettings.ResetCustomSearchBar(txtSearchBar, lblSearchBar);
            _RefreshUsersList();
            clsDVLDSettings.ShowIndexOnSearchFilter(cbSearchFilter, 0);

        }

        void _ShowUserDetailsForm()
        {
            frmUserDetails frmUserDetails_v = new frmUserDetails(_SelectedUser);
            clsDVLDSettings.ShowFormInPanel(pnlUsersLoader, frmUserDetails_v);

        }



        private void frmUsers_Load(object sender, EventArgs e)
        {
            _RoundControls();
            _ShowDataOnUsersList(clsUser.GetAllUsers());
            clsDVLDSettings.ShowIndexOnSearchFilter(cbSearchFilter, 2);
        }

        private void btnActivity_Click(object sender, EventArgs e)
        {
            _PerformIsActiveFilterButtonClick((BunifuThinButton2)sender);

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

        private void dgUsers_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if ((e.Button == MouseButtons.Right) && e.RowIndex >= 0)
            {
                dgUsers.ClearSelection();
                dgUsers.Rows[e.RowIndex].Selected = true;
                dgUsers.CurrentCell = dgUsers.Rows[e.RowIndex].Cells[e.ColumnIndex];
                _LoadDataToSelectedUser(Convert.ToInt16(dgUsers.Rows[e.RowIndex].Cells[0].Value));
                cmsUsersOperationsList.Show(MousePosition);
            }
        }

        private void itemDelete_Click(object sender, EventArgs e)
        {
            //Tep Code.

            if (!clsUser.DeleteUser(_SelectedUser.UserID))
                MessageBox.Show("Error");



            _RefreshUsersList();
        }

        private void itemShowDetails_Click(object sender, EventArgs e)
        {
            _ShowUserDetailsForm();
        }

        private void dgUsers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _LoadDataToSelectedUser(Convert.ToInt16(dgUsers.Rows[e.RowIndex].Cells[0].Value));
            _ShowUserDetailsForm();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            frmAddorUpdateUser frmAdd_UpdateUser_v = new frmAddorUpdateUser();
            clsDVLDSettings.ShowFormInPanel(pnlUsersLoader, frmAdd_UpdateUser_v);
        }

        private void itemEdit_Click(object sender, EventArgs e)
        {
            frmAddorUpdateUser frmAdd_UpdateUser_v = new frmAddorUpdateUser(_SelectedUser);
            clsDVLDSettings.ShowFormInPanel(pnlUsersLoader, frmAdd_UpdateUser_v);
        }

        private void itemChangePassword_Click(object sender, EventArgs e)
        {
            frmChangeUserPassword frmChangeUserPassword_v = new frmChangeUserPassword(_SelectedUser);
            clsDVLDSettings.ShowFormInPanel(pnlUsersLoader, frmChangeUserPassword_v);
        }
    }
}
