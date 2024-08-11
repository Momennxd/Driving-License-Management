using Bunifu.Framework.UI;
using DVLD_PresentationLayer.Applications.Detain_Licences;
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

namespace DVLD_PresentationLayer.Applications
{
    public partial class frmApplications : Form
    {
        public frmApplications()
        {
            InitializeComponent();
        }


        void _RoundControls()
        {
            Control[] C = { pnlApplications, pnlApplicationsLoader, btnDetainLicences, btnDrivingLicencesServices,
            btnManageApplications, btnManageApplicationTypes, btnManageTestTypes };

            clsDVLDSettings.RoundControlsByCustomElips(bunifuElipse1, C);
        }

        void _ShowInnerForm(BunifuFlatButton btn)
        {

            switch (btn.Name)
            {
                case "btnManageApplicationTypes":
                    frmManagApplicationTypes frmManagApplicationTypes_v = new frmManagApplicationTypes();
                    clsDVLDSettings.ShowFormInPanel(pnlApplicationsLoader, frmManagApplicationTypes_v);
                    break;

                case "btnManageTestTypes":
                    frmManageTestTypes frmManageTestTypes_v = new frmManageTestTypes();
                    clsDVLDSettings.ShowFormInPanel(pnlApplicationsLoader, frmManageTestTypes_v);
                    break;

                case "btnManageApplications":
                    frmManageApplications frmManageApplications_v = new frmManageApplications();
                    clsDVLDSettings.ShowFormInPanel(pnlApplicationsLoader, frmManageApplications_v);
                    break;

                case "btnDrivingLicencesServices":
                    frmDrivingLicenceServices frmDrivingLicenceServices_v = new frmDrivingLicenceServices();
                    clsDVLDSettings.ShowFormInPanel(pnlApplicationsLoader, frmDrivingLicenceServices_v);
                    break;
                case "btnDetainLicences":
                     frmDetainLicencesServices frmDetainLicencesServices_v = new frmDetainLicencesServices();
                    clsDVLDSettings.ShowFormInPanel(pnlApplicationsLoader, frmDetainLicencesServices_v);
                    break;





            }

        }









        private void frmApplications_Load(object sender, EventArgs e)
        {
            _RoundControls();
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            _ShowInnerForm((BunifuFlatButton)sender);
        }
    }
}
