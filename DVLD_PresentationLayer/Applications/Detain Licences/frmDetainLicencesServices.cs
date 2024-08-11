using Bunifu.Framework.UI;
using DVLD_PresentationLayer.Applications.Driving_Licence_Services;
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

namespace DVLD_PresentationLayer.Applications.Detain_Licences
{
    public partial class frmDetainLicencesServices : Form
    {
        public frmDetainLicencesServices()
        {
            InitializeComponent();
        }



        void _RoundControls()
        {
            Control[] C = { pnlServices, pnlApplicationsLoader, btnDetainLicence, btnGoBack,
            btnManageDetainedLicences, btnReleaseLicence };

            clsDVLDSettings.RoundControlsByCustomElips(bunifuElipse1, C);
        }

        void _ShowInnerForm(BunifuFlatButton btn)
        {

            switch (btn.Name)
            {
                case "btnManageDetainedLicences":
                    frmManageDetainedLicences frmManageDetainedLicences_v = new frmManageDetainedLicences();
                    clsDVLDSettings.ShowFormInPanel(pnlApplicationsLoader, frmManageDetainedLicences_v);
                    break;
                case "btnDetainLicence":
                    frmDetainAndReleaseLicence frmDetainLicence_v = new frmDetainAndReleaseLicence(1);
                    clsDVLDSettings.ShowFormInPanel(pnlApplicationsLoader, frmDetainLicence_v);
                    break;
                case "btnReleaseLicence":
                    frmDetainAndReleaseLicence frmReleaseLicence_v = new frmDetainAndReleaseLicence(2);
                    clsDVLDSettings.ShowFormInPanel(pnlApplicationsLoader, frmReleaseLicence_v);
                    break;

            }

        }

        private void frmDetainLicencesServices_Load(object sender, EventArgs e)
        {
            _RoundControls();
        }

        private void btnLicenceService_Click(object sender, EventArgs e)
        {
            _ShowInnerForm((BunifuFlatButton)sender);
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            frmApplications frmApplications_v = new frmApplications();
            clsDVLDSettings.ShowFormInPanel(pnlApplicationsLoader, frmApplications_v);

        }
    }
}
