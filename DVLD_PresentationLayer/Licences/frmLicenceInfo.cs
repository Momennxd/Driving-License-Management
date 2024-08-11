using Bunifu.Framework;
using DVLD_BusinessLayer;
using DVLD_PresentationLayer.Applications.Manage_Applications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Licences
{
    public partial class frmLicenceInfo : Form
    {
        public frmLicenceInfo(clsLicence Licence)
        {
            InitializeComponent();
            _Licence = Licence;
        }

        clsLicence _Licence = new clsLicence();

        void _RoundControls()
        {
            Control[] controls = { ctrlLicenceInfo1, btnGoBack };
            clsDVLDSettings.RoundControlsByCustomElips(bunifuElipse1, controls);

        }

        void _GoBackToLDLAppsForm()
        {
            frmLocalDrivingLicenceApp frmLocalDrivingLicenceApp_v = new frmLocalDrivingLicenceApp();
            clsDVLDSettings.ShowFormInPanel(pnlLicenceLoader, frmLocalDrivingLicenceApp_v);
        }

        void _ShowLicenceInfo()
        {
            ctrlLicenceInfo1.DispalyLicenceData(_Licence.LicenseID);
        }


        private void btnGoBack_Click(object sender, EventArgs e)
        {
            _GoBackToLDLAppsForm();
        }

        private void frmLicenceInfo_Load(object sender, EventArgs e)
        {
            _ShowLicenceInfo();
        }
    }
}
