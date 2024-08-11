using Bunifu.Framework.UI;
using DVLD_PresentationLayer.Applications.Driving_Licence_Services.Renew_Driving_Licence;
using DVLD_PresentationLayer.Applications.Driving_Licence_Services.Replace_licence_for_lost_or_damaged;
using DVLD_PresentationLayer.Applications.Manage_Applications;
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

namespace DVLD_PresentationLayer.Applications.Driving_Licence_Services
{
    public partial class frmDrivingLicenceServices : Form
    {
        public frmDrivingLicenceServices()
        {
            InitializeComponent();
        }

        void _RoundControls()
        {
            Control[] C = { pnlApplications, pnlApplicationsLoader, btnGoBack, btnLicenceRemplacement,
            btnNewDrivingLicences, btnRnewDrivingLicence };

            clsDVLDSettings.RoundControlsByCustomElips(bunifuElipse1, C);
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
                case "btnNewDrivingLicences":
                    frmNewDrivingLicence frmNewDrivingLicence_v = new frmNewDrivingLicence();
                    clsDVLDSettings.ShowFormInPanel(pnlApplicationsLoader, frmNewDrivingLicence_v);
                    break;
                case "btnRnewDrivingLicence":
                    frmRenewDrivingLicence frmRenewDrivingLicence_v = new frmRenewDrivingLicence();
                    clsDVLDSettings.ShowFormInPanel(pnlApplicationsLoader, frmRenewDrivingLicence_v);
                    break;
                case "btnLicenceRemplacement":
                    frmReplaceLicence frmReplaceLicence_v = new frmReplaceLicence();
                    clsDVLDSettings.ShowFormInPanel(pnlApplicationsLoader, frmReplaceLicence_v);
                    break;





            }

        }

        private void frmDrivingLicenceServices_Load(object sender, EventArgs e)
        {
            _RoundControls();
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            _ShowInnerForm((BunifuFlatButton)sender);
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            _GoBackToAppsForm();
        }
    }
}
