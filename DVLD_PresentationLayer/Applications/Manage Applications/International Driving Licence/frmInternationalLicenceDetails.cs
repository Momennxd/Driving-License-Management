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
    public partial class frmInternationalLicenceDetails : Form
    {
        public frmInternationalLicenceDetails(clsInternationalLicense IntLicence)
        {
            InitializeComponent();
            _SelectedIntLicence = IntLicence;
        }

        clsInternationalLicense _SelectedIntLicence = new clsInternationalLicense();

        void _RoundControls()
        {
            Control[] controls = { pnlIntLicenceLoader, ctrlInternationalLicence1, btnGoBack };
            clsDVLDSettings.RoundControlsByCustomElips(bunifuElipse1, controls);

        }

        void _GoBackToAppsForm()
        {
            frmInternationalDrivingLicence frmInternationalDrivingLicence_v = new frmInternationalDrivingLicence();
            clsDVLDSettings.ShowFormInPanel(pnlIntLicenceLoader, frmInternationalDrivingLicence_v);
        }


        private void frmInternationalLicenceDetails_Load(object sender, EventArgs e)
        {
            _RoundControls();
            ctrlInternationalLicence1.DispalyLicenceData(_SelectedIntLicence.InternationalLicenseID);
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            _GoBackToAppsForm();
        }
    }
}
