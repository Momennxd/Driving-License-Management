using DVLD_PresentationLayer.Applications.Manage_Applications.Local_Driving_Licence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_BusinessLayer;


namespace DVLD_PresentationLayer.Dashboard
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        void _RoundControls()
        {
            Control[] controls = { pnlPeopleInfo, pnlDriversInfo, pnlUsersInfo, pnlLicences, ctrlUserDetails1  };
            clsDVLDSettings.RoundControlsByCustomElips(bunifuElipse1, controls);
        }


        void _LoadDataOnForm()
        {
            //People
            clsDVLDSettings.ShowDataOnContolText(lblPeopleNumber, clsPerson.GetNumberOfPeople());
            clsDVLDSettings.ShowDataOnContolText(lblNumOfMales, clsPerson.GetNumberOfPeople(0));
            clsDVLDSettings.ShowDataOnContolText(lblNumOfFemales, clsPerson.GetNumberOfPeople(1));

            //Drivers
            clsDVLDSettings.ShowDataOnContolText(lblNumOfDrivers, clsDriver.GetNumberOfDrivers());
            clsDVLDSettings.ShowDataOnContolText(lblNumOfMaleDrivers, clsDriver.GetNumberOfDrivers(0));
            clsDVLDSettings.ShowDataOnContolText(lblNumOfFemaleDrivers, clsDriver.GetNumberOfDrivers(1));

            //Users
            clsDVLDSettings.ShowDataOnContolText(lblNumOfUsers, clsUser.GetNumberOfUsers());
            clsDVLDSettings.ShowDataOnContolText(lblNumOfActiveUsers, clsUser.GetNumberOfUsers(true));
            clsDVLDSettings.ShowDataOnContolText(lblNumOfInActiveUsers, clsUser.GetNumberOfUsers(false));

            //Licences
            clsDVLDSettings.ShowDataOnContolText(lblNumOfLicences, clsLicence.GetNumberOfLicense());
            clsDVLDSettings.ShowDataOnContolText(lblNumOfActiveLicences, clsLicence.GetNumberOfLicense(true));
            clsDVLDSettings.ShowDataOnContolText(lblNumOfInActiveLicences, clsLicence.GetNumberOfLicense(false));


            ctrlUserDetails1.DispalyUserInfo(clsDVLDSettings.CurrentUser.UserID);

        }

















        private void frmDashboard_Load(object sender, EventArgs e)
        {
            _RoundControls();
            _LoadDataOnForm();
        }
    }
}
