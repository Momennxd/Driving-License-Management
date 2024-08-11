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
    public partial class ctrlInternationalLicence : UserControl
    {
        public ctrlInternationalLicence()
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
            public static clsInternationalLicense InternationalLicence = null;

        }

        void _RoundControls()
        {
            Control[] controls = {pnlActive, pnlClass, pnlDateOfBirth, pnlDriverID, pnlExpireDate,
            pnlGender, pnlIssueDate, pnlLicenceID, pnlName, pnlNationalNo, pbPersonPic };

            clsDVLDSettings.RoundControlsByCustomElips(bunifuElipse1, controls);
        }

        void _LoadDataToMainObjcts(int InternationalLicenceID)
        {
            stLicenceInfo.InternationalLicence =
                clsInternationalLicense.FindByInternationalLicenseID(InternationalLicenceID);
            stLicenceInfo.Licence = clsLicence.FindByLicenceID(stLicenceInfo.InternationalLicence.IssuedUsingLocalLicenseID);
            stLicenceInfo.MainApp = clsApplication.Find(stLicenceInfo.Licence.ApplicationID);
            stLicenceInfo.ApplicantPerson = clsPerson.Find(stLicenceInfo.MainApp.ApplicantPersonID);
            stLicenceInfo.LicenseClass = clsLicenseClass.Find(stLicenceInfo.Licence.LicenseClass);
        }


        public void DispalyLicenceData(int InternationalLicenceID)
        {
            _LoadDataToMainObjcts(InternationalLicenceID);

            clsDVLDSettings.ShowDataOnContolText(lblClass, stLicenceInfo.LicenseClass.ClassName);
            clsDVLDSettings.ShowDataOnContolText(lblNationalNo, stLicenceInfo.ApplicantPerson.NationalNo);
            clsDVLDSettings.ShowDataOnContolText(lblName, clsDVLDSettings.GetPersonFullName(stLicenceInfo.ApplicantPerson));
            clsDVLDSettings.ShowDataOnContolText(lblDateOfBirth, stLicenceInfo.ApplicantPerson.DateOfBirth.ToString("dd/MM/yyyy"));
            clsDVLDSettings.ShowDataOnContolText(lblGender, clsDVLDSettings.GetPersonGender(stLicenceInfo.ApplicantPerson));
            clsDVLDSettings.ShowDataOnContolText(lblLicenceID, stLicenceInfo.Licence.LicenseID);
            clsDVLDSettings.ShowDataOnContolText(lblIssueDate, stLicenceInfo.InternationalLicence.IssueDate);
            swtchIsActive.Checked = stLicenceInfo.InternationalLicence.IsActive;
            clsDVLDSettings.ShowDataOnContolText(lblDriverID, stLicenceInfo.Licence.DriverID);
            clsDVLDSettings.ShowDataOnContolText(lblExpireDate, stLicenceInfo.InternationalLicence.ExpirationDate);
            clsDVLDSettings.DispalyImageForUser(pbPersonPic, stLicenceInfo.ApplicantPerson);
            clsDVLDSettings.ShowDataOnContolText(lblFirstName, stLicenceInfo.ApplicantPerson.FirstName);




        }





    }
}
