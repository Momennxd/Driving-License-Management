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

namespace DVLD_PresentationLayer.Licences
{
    public partial class ctrlLicenceInfo : UserControl
    {
        public ctrlLicenceInfo()
        {
            InitializeComponent();
            _RoundControls();
        }

        struct stLicenceInfo
        {
            public static clsApplication MainApp = null;
            public static clsPerson ApplicantPerson = null;
            public static clsLicenseClass LicenseClass = null;
            public static clsLicence Licence = null;

        }


        void _RoundControls()
        {
            Control[] controls = {pnlActive, pnlClass, pnlDateOfBirth, pnlDetained, pnlDriverID, pnlExpireDate,
            pnlGender, pnlIssueDate, pnlIssueReason, pnlLicenceID, pnlName, pnlNationalNo, pnlNotes, pbPersonPic };

            clsDVLDSettings.RoundControlsByCustomElips(bunifuElipse1, controls);
        }


        void _LoadDataToMainObjcts(clsLicence licence)
        {
            stLicenceInfo.Licence = licence;
            stLicenceInfo.MainApp = clsApplication.Find(licence.ApplicationID);
            stLicenceInfo.ApplicantPerson = clsPerson.Find(stLicenceInfo.MainApp.ApplicantPersonID);
            stLicenceInfo.LicenseClass = clsLicenseClass.Find(stLicenceInfo.Licence.LicenseClass);
        }


        public void DispalyLicenceData(int LicenceID)
        {
            _LoadDataToMainObjcts(clsLicence.FindByLicenceID(LicenceID));

            clsDVLDSettings.ShowDataOnContolText(lblClass, stLicenceInfo.LicenseClass.ClassName);
            clsDVLDSettings.ShowDataOnContolText(lblNationalNo, stLicenceInfo.ApplicantPerson.NationalNo);
            clsDVLDSettings.ShowDataOnContolText(lblName, clsDVLDSettings.GetPersonFullName(stLicenceInfo.ApplicantPerson));
            clsDVLDSettings.ShowDataOnContolText(lblDateOfBirth, stLicenceInfo.ApplicantPerson.DateOfBirth.ToString("dd/MM/yyyy"));
            clsDVLDSettings.ShowDataOnContolText(lblGender, clsDVLDSettings.GetPersonGender(stLicenceInfo.ApplicantPerson));
            clsDVLDSettings.ShowDataOnContolText(lblLicenceID, stLicenceInfo.Licence.LicenseID);
            clsDVLDSettings.ShowDataOnContolText(lblIssueDate, stLicenceInfo.Licence.IssueDate);
            swtchIsActive.Checked = stLicenceInfo.Licence.IsActive;
            clsDVLDSettings.ShowDataOnContolText(lblIssueReason, clsLicence.GetIssueReasonByNumber(stLicenceInfo.Licence.IssueReason));
            clsDVLDSettings.ShowDataOnContolText(lblDriverID, stLicenceInfo.Licence.DriverID);
            swtchDetained.Checked = clsLicence.IsLicenceDetained(stLicenceInfo.Licence.LicenseID);
            clsDVLDSettings.ShowDataOnContolText(lblExpireDate, stLicenceInfo.Licence.ExpirationDate);
            clsDVLDSettings.ShowDataOnContolText(txtNotes, stLicenceInfo.Licence.Notes);
            clsDVLDSettings.DispalyImageForUser(pbPersonPic, stLicenceInfo.ApplicantPerson);
            clsDVLDSettings.ShowDataOnContolText(lblFirstName, stLicenceInfo.ApplicantPerson.FirstName);




        }

    }
}
