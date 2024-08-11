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

namespace DVLD_PresentationLayer.Applications
{
    public partial class frmEditApplicationType : Form
    {
        public frmEditApplicationType(clsApplicationType AppType)
        {
            InitializeComponent();
            _SelectedAppType = AppType;

        }

        clsApplicationType _SelectedAppType = null;

        void _RoundControls()
        {
            Control[] controls = { pnlApplicationLoader, pnlAppTypeInfo, pnlFees, pnlTitle, btnCancel, btnSave };
            clsDVLDSettings.RoundControlsByCustomElips(bunifuElipse1, controls);

        }

        void _DispalyAppTypeInfoOnForm()
        {
            txtTitle.Text = _SelectedAppType.ApplicationTypeTitle;
            txtFees.Text = _SelectedAppType.ApplicationFees.ToString();
        }

        void _LoadDataFromFormToAppTypeObj()
        {
            _SelectedAppType.ApplicationTypeTitle = txtTitle.Text;
            _SelectedAppType.ApplicationFees = Convert.ToDecimal(txtFees.Text);
        }

        bool _ValidateInfo()
        {
            return (clsDVLDSettings.ValidateTxtBox(txtTitle, "", "Please Enter A Title", errorInfoValidation) &&
                clsDVLDSettings.ValidateTxtBox(txtFees, "", "Please Enter A Title", errorInfoValidation) &&
                clsDVLDSettings.ValidateIfTxtBoxIsNotNumber(txtFees, "Please Enter A Valid Fee", errorInfoValidation));
        }

        bool _SaveAppType()
        {
            if (_ValidateInfo())
            {
                _LoadDataFromFormToAppTypeObj();
                _SelectedAppType.Save();
                return true;
            }

            return false;
        }

        void _GoBackToAppTypesForm()
        {
            frmManagApplicationTypes frmManagApplicationTypes_v = new frmManagApplicationTypes();
            clsDVLDSettings.ShowFormInPanel(pnlApplicationLoader, frmManagApplicationTypes_v);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _SaveAppType();
            _GoBackToAppTypesForm();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _GoBackToAppTypesForm();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            _GoBackToAppTypesForm();
        }

        private void frmEditApplicationType_Load(object sender, EventArgs e)
        {
            _RoundControls();
            _DispalyAppTypeInfoOnForm();
        }
    }
}
