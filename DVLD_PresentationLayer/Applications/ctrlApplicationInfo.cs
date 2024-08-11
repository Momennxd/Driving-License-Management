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
    public partial class ctrlApplicationInfo : UserControl
    {
        public ctrlApplicationInfo()
        {
            InitializeComponent();
            _RoundControls();
        }

        void _RoundControls()
        {
            Control[] controls = {pnlApplicationID, pnlCreatedBy, pnlDate, pnlFees, pnlStatus, pnlStatusDate,
            pnlType, pnlApplicant};

            clsDVLDSettings.RoundControlsByCustomElips(bunifuElipse1, controls);
        }

        clsApplication _Application = new clsApplication();

        void _LoadDataToApp(int AppID)
        {
            _Application = clsApplication.Find(AppID);
        }

        public void DispalyApplicationData(int ApplicationID)
        {
            _LoadDataToApp(ApplicationID);

            clsDVLDSettings.ShowDataOnContolText(lblApplicationID, _Application.ApplicationID);
            clsDVLDSettings.ShowDataOnContolText(lblStatus, clsApplication.GetApplicationStatus(_Application));
            clsDVLDSettings.ShowDataOnContolText(lblFees, _Application.PaidFees);
            clsDVLDSettings.ShowDataOnContolText(lblCreatedBy, clsDVLDSettings.CurrentUser.UserName);
            clsDVLDSettings.ShowDataOnContolText(lblType, clsApplicationType.Find(_Application.ApplicationTypeID).ApplicationTypeTitle);
            clsDVLDSettings.ShowDataOnContolText(lblApplicant, clsDVLDSettings.GetPersonFullName(clsPerson.Find(_Application.ApplicantPersonID)));
            clsDVLDSettings.ShowDataOnContolText(lblDate, _Application.ApplicationDate.ToString("dd/MM/yyyy"));
            clsDVLDSettings.ShowDataOnContolText(lblStatusDate, _Application.LastStatusDate.ToString("dd/MM/yyyy"));




        }

    }
}
