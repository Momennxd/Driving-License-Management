using Bunifu.Framework.UI;
using DVLD_PresentationLayer.Applications.Manage_Applications.International_Driving_Licence;
using DVLD_PresentationLayer.Applications.Test_Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Applications.Manage_Applications
{
    public partial class frmManageApplications : Form
    {
        public frmManageApplications()
        {
            InitializeComponent();
        }

        void _RoundControls()
        {
            Control[] controls = { pnlApplications, pnlApplicationsLoader, btnInternationalLicenceApp,
                btnLocalDrivingLicenceApp };
            clsDVLDSettings.RoundControlsByCustomElips(bunifuElipse1, controls);

        }

        void _GoBackToAppsForm()
        {
            frmApplications frmApplications_v = new frmApplications();
            clsDVLDSettings.ShowFormInPanel(pnlApplicationsLoader, frmApplications_v);
        }


        void _ShowInnerForm(BunifuFlatButton btn)
        {

            switch (btn.Name)
            {
                case "btnLocalDrivingLicenceApp":
                    frmLocalDrivingLicenceApp frmLocalDrivingLicenceApp_v = new frmLocalDrivingLicenceApp();
                    clsDVLDSettings.ShowFormInPanel(pnlApplicationsLoader, frmLocalDrivingLicenceApp_v);
                    break;
                case "btnInternationalLicenceApp":
                     frmInternationalDrivingLicence frmInternationalDrivingLicence_v = new frmInternationalDrivingLicence();
                    clsDVLDSettings.ShowFormInPanel(pnlApplicationsLoader, frmInternationalDrivingLicence_v);
                    break;






            }

        }

        private void frmManageApplications_Load(object sender, EventArgs e)
        {
            _RoundControls();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            _GoBackToAppsForm();
        }

        private void btnDrivingLicenceApp_Click(object sender, EventArgs e)
        {
            _ShowInnerForm((BunifuFlatButton)sender);
        }
    }
}
