using Bunifu.Framework.UI;
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

namespace DVLD_PresentationLayer.Applications.Driving_Licence_Services
{
    public partial class frmNewDrivingLicence : Form
    {
        public frmNewDrivingLicence()
        {
            InitializeComponent();
        }

        void _RoundControls()
        {
            Control[] C = { pnlApplications, pnlApplicationsLoader, btnGoBack, btnInternationalLicenceApp,
            btnLocalDrivingLicenceApp};

            clsDVLDSettings.RoundControlsByCustomElips(bunifuElipse1, C);
        }

        void _ShowInnerForm(BunifuFlatButton btn)
        {

            switch (btn.Name)
            {
                case "btnLocalDrivingLicenceApp":
                    frmAddorUpdateLocalDrivingLicenceApp frmAddorUpdateLocalDrivingLicenceApp_v = new frmAddorUpdateLocalDrivingLicenceApp();
                    clsDVLDSettings.ShowFormInPanel(pnlApplicationsLoader, frmAddorUpdateLocalDrivingLicenceApp_v);
                    break;
                case "btnInternationalLicenceApp":
                    frmAddInternationalLicence frmAddInternationalLicence_v = new frmAddInternationalLicence();
                    clsDVLDSettings.ShowFormInPanel(pnlApplicationsLoader, frmAddInternationalLicence_v);
                    break;






            }

        }

        void _GoBackToLicenceServicesForm()
        {
            frmDrivingLicenceServices frmDrivingLicenceServices_v = new frmDrivingLicenceServices();
            clsDVLDSettings.ShowFormInPanel(pnlApplicationsLoader, frmDrivingLicenceServices_v);
        }


        private void btnGoBack_Click(object sender, EventArgs e)
        {
            _GoBackToLicenceServicesForm();
        }

        private void frmNewDrivingLicence_Load(object sender, EventArgs e)
        {
            _RoundControls();
        }

        private void btnDrivingLicenceAppType_Click(object sender, EventArgs e)
        {
            _ShowInnerForm((BunifuFlatButton)sender);
        }
    }
}
