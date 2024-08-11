using DVLD_BusinessLayer;
using DVLD_PresentationLayer.Applications;
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
    public partial class frmManagApplicationTypes : Form
    {
        public frmManagApplicationTypes()
        {
            InitializeComponent();
        }

        clsApplicationType _SelectedAppType = null;


        void _RoundControls()
        {
            Control[] controls = { dgAppTypes, pnlApplicationTypesLoader };
            clsDVLDSettings.RoundControlsByCustomElips(bunifuElipse1, controls);

        }

        void _ShowAppsForm()
        {
            frmApplications frmApplications_v = new frmApplications();
            clsDVLDSettings.ShowFormInPanel(pnlApplicationTypesLoader, frmApplications_v);
        }

        void _ShowEditAppTypeForm()
        {
            frmEditApplicationType frmEditApplicationType_v = new frmEditApplicationType(_SelectedAppType);
            clsDVLDSettings.ShowFormInPanel(pnlApplicationTypesLoader, frmEditApplicationType_v);
        }


        void _LoadDataToSelectedAppType(int AppTypeID)
        {
            _SelectedAppType = clsApplicationType.Find(AppTypeID);
        }

        void _ShowDataOnAppTypesList(DataTable dtAppTypes)
        {
            dgAppTypes.DataSource = dtAppTypes;
        }

        


        private void frmManagApplicationTypes_Load(object sender, EventArgs e)
        {
            _RoundControls();
            _ShowDataOnAppTypesList(clsApplicationType.GetAllAppTypes());
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            _ShowAppsForm();
        }

        private void dgAppTypes_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if ((e.Button == MouseButtons.Right) && e.RowIndex >= 0)
            {
                dgAppTypes.ClearSelection();
                dgAppTypes.Rows[e.RowIndex].Selected = true;
                dgAppTypes.CurrentCell = dgAppTypes.Rows[e.RowIndex].Cells[e.ColumnIndex];
                _LoadDataToSelectedAppType(Convert.ToInt16(dgAppTypes.Rows[e.RowIndex].Cells[0].Value));
                cmsAppOperationsList.Show(MousePosition);
            }
        }

        private void itemEdit_Click(object sender, EventArgs e)
        {
            _ShowEditAppTypeForm();
        }
    }
}
