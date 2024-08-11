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

namespace DVLD_PresentationLayer.Applications.Test_Types
{
    public partial class frmManageTestTypes : Form
    {
        public frmManageTestTypes()
        {
            InitializeComponent();
        }

        clsTestType _SelectedTestType = null;

        void _RoundControls()
        {
            Control[] controls = { dgTests, pnlTestTypesLoader };
            clsDVLDSettings.RoundControlsByCustomElips(bunifuElipse1, controls);

        }

        void _ShowAppsForm()
        {
            frmApplications frmApplications_v = new frmApplications();
            clsDVLDSettings.ShowFormInPanel(pnlTestTypesLoader, frmApplications_v);
        }

        void _LoadDataToSelectedTestType(int TestTypeID)
        {
            _SelectedTestType = clsTestType.Find(TestTypeID);
        }

        void _ShowDataOnAppTypesList(DataTable dtTestTypes)
        {
            dgTests.DataSource = dtTestTypes;
        }

        void _ShowEditTestTypeForm()
        {
            frmEditTestType frmEditTestType_v = new frmEditTestType(_SelectedTestType);
            clsDVLDSettings.ShowFormInPanel(pnlTestTypesLoader, frmEditTestType_v);
        }




        private void frmManageTestTypes_Load(object sender, EventArgs e)
        {
            _RoundControls();
            _ShowDataOnAppTypesList(clsTestType.GetAllTestTypes());
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            _ShowAppsForm();
        }

        private void dgTests_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if ((e.Button == MouseButtons.Right) && e.RowIndex >= 0)
            {
                dgTests.ClearSelection();
                dgTests.Rows[e.RowIndex].Selected = true;
                dgTests.CurrentCell = dgTests.Rows[e.RowIndex].Cells[e.ColumnIndex];
                _LoadDataToSelectedTestType(Convert.ToInt16(dgTests.Rows[e.RowIndex].Cells[0].Value));
                cmsTestOperationsList.Show(MousePosition);
            }
        }

        private void itemEdit_Click(object sender, EventArgs e)
        {
            _ShowEditTestTypeForm();
        }
    }
}
