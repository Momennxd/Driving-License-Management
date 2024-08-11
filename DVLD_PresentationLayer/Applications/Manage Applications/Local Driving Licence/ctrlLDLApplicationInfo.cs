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
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_PresentationLayer.Applications.Manage_Applications.Local_Driving_Licence
{
    public partial class ctrlLDLApplicationInfo : UserControl
    {
        public ctrlLDLApplicationInfo()
        {
            InitializeComponent();
            _RoundControls();
        }


        void _RoundControls()
        {
            Control[] controls = {pnlAppliedForLicence, pnlLDLApplicationID, pnlMainApplicationID,
                pnlPassedTests };
            clsDVLDSettings.RoundControlsByCustomElips(bunifuElipse1, controls);
        }

        clsLDLApplication _LDLApplication = new clsLDLApplication();

        void _LoadDataToLDLApp(int LDLAppID)
        {
            _LDLApplication = clsLDLApplication.FindByLDLAppID(LDLAppID);
        }


        public void DispalyLDLAppData(int LDLApplicationID)
        {
            _LoadDataToLDLApp(LDLApplicationID);

            clsDVLDSettings.ShowDataOnContolText(lblLDLApplicationID, _LDLApplication.LocalDrivingLicenseApplicationID);

            clsDVLDSettings.ShowDataOnContolText(lblMainApplicationID, _LDLApplication.ApplicationID);

            clsDVLDSettings.ShowDataOnContolText(lblPassedTests, clsTest.GetNumberOfTestsPassedOrFaildByTestLDLAppID(true,
                clsPerson.Find(clsApplication.Find(_LDLApplication.ApplicationID).ApplicantPersonID).ID, LDLApplicationID));

            clsDVLDSettings.ShowDataOnContolText(lblAppliedForLicence, clsLicenseClass.Find(_LDLApplication.LicenseClassID).ClassName);


        }


    }
}
