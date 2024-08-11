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

namespace DVLD_PresentationLayer.Applications.Manage_Applications.Local_Driving_Licence
{
    public partial class frmLDLAppDetails : Form
    {
        public frmLDLAppDetails(clsLDLApplication LDLApp)
        {
            InitializeComponent();
            _SelectedLDLApplication = LDLApp;
        }

        clsLDLApplication _SelectedLDLApplication = new clsLDLApplication();

        void _RoundControls()
        {
            Control[] controls = { ctrlCurrentApplicationInfo, ctrlCurrentLDLApplicationInfo };
            clsDVLDSettings.RoundControlsByCustomElips(bunifuElipse1, controls);

        }


        private void frmLDLAppDetails_Load(object sender, EventArgs e)
        {
            _RoundControls();
            ctrlCurrentLDLApplicationInfo.DispalyLDLAppData(_SelectedLDLApplication.LocalDrivingLicenseApplicationID);
            ctrlCurrentApplicationInfo.DispalyApplicationData(_SelectedLDLApplication.ApplicationID);
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            frmLocalDrivingLicenceApp frmLocalDrivingLicenceApp_v = new frmLocalDrivingLicenceApp();
            clsDVLDSettings.ShowFormInPanel(pnlLocalApplicationsLoader, frmLocalDrivingLicenceApp_v);
        }
    }
}
