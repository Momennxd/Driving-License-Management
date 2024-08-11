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
    public partial class frmEditTestType : Form
    {
        public frmEditTestType(clsTestType TestType)
        {
            InitializeComponent();
            _SelectedTestType = TestType;
        }

        clsTestType _SelectedTestType = null;

        void _RoundControls()
        {
            Control[] controls = { pnlTestLoader, pnlTestTypeInfo, pnlFees, pnlTitle, pnlDescription, btnCancel, btnSave };
            clsDVLDSettings.RoundControlsByCustomElips(bunifuElipse1, controls);

        }

        void _GoBackToTestTypesForm()
        {
            frmManageTestTypes frmManageTestTypes_v = new frmManageTestTypes();
            clsDVLDSettings.ShowFormInPanel(pnlTestLoader, frmManageTestTypes_v);
        }

        void _DispalyTestTypeInfoOnForm()
        {
            txtTitle.Text = _SelectedTestType.TestTypeTitle;
            txtDescription.Text = _SelectedTestType.TestTypeDescription;
            txtFees.Text = _SelectedTestType.TestTypeFees.ToString();
        }

        void _LoadDataFromFormToTestTypeObj()
        {
            _SelectedTestType.TestTypeTitle = txtTitle.Text;
            _SelectedTestType.TestTypeDescription = txtDescription.Text;
            _SelectedTestType.TestTypeFees = Convert.ToDecimal(txtFees.Text);
        }

        bool _ValidateInfo()
        {
            return (clsDVLDSettings.ValidateTxtBox(txtTitle, "", "Please Enter A Title", errorInfoValidation) &&
                clsDVLDSettings.ValidateTxtBox(txtDescription, "", "Please Enter A Description", errorInfoValidation) &&
                clsDVLDSettings.ValidateTxtBox(txtFees, "", "Please Enter A Title", errorInfoValidation) &&
                clsDVLDSettings.ValidateIfTxtBoxIsNotNumber(txtFees, "Please Enter A Valid Fee", errorInfoValidation));
        }

        bool _SaveTestType()
        {
            if (_ValidateInfo())
            {
                _LoadDataFromFormToTestTypeObj();
                _SelectedTestType.Save();
                return true;
            }

            return false;
        }





        private void btnSave_Click(object sender, EventArgs e)
        {
            _SaveTestType();
            _GoBackToTestTypesForm();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _GoBackToTestTypesForm();

        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            _GoBackToTestTypesForm();

        }

        private void frmEditTestType_Load(object sender, EventArgs e)
        {
            _RoundControls();
            _DispalyTestTypeInfoOnForm();
        }
    }
}
