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
using System.Xml.Serialization;

namespace DVLD_PresentationLayer
{
    public partial class ctrlPersonDetails : UserControl
    {
        public ctrlPersonDetails()
        {
            InitializeComponent();
            _RoundControls();

        }

        void _RoundControls()
        {
            Control[] controls = {pnlPersonID, pnlNationalNo, pnlName, pnlDateOfBirth, pnlGender, pnlAddress,
            pnlPhoneNumber, pnlEmail, pnlNationality, pbPersonPic };

            clsDVLDSettings.RoundControlsByCustomElips(bunifuElipse1, controls);
        }

        clsPerson _Person = new clsPerson();

        void _LoadDataToPerson(int PersonID)
        {
            _Person = clsPerson.Find(PersonID);
        }

        public void DispalyPersonData(int PersonID)
        {
            _LoadDataToPerson(PersonID);

            clsDVLDSettings.ShowDataOnContolText(lblPersonID, _Person.ID);
            clsDVLDSettings.ShowDataOnContolText(lblNationalNo, _Person.NationalNo);
            clsDVLDSettings.ShowDataOnContolText(lblName, clsDVLDSettings.GetPersonFullName(_Person));
            clsDVLDSettings.ShowDataOnContolText(lblDateOfBirth, _Person.DateOfBirth.ToString("dd/MM/yyyy"));
            clsDVLDSettings.ShowDataOnContolText(lblGender, clsDVLDSettings.GetPersonGender(_Person));
            clsDVLDSettings.ShowDataOnContolText(lblAddress, _Person.Address);
            clsDVLDSettings.ShowDataOnContolText(lblPhoneNumber, _Person.Phone);
            clsDVLDSettings.ShowDataOnContolText(lblEmail, _Person.Email);
            clsDVLDSettings.ShowDataOnContolText(lblNationality, clsPerson.GetPersonNationality(_Person));
            clsDVLDSettings.ShowDataOnContolText(lblFirstName, _Person.FirstName);
            clsDVLDSettings.DispalyImageForUser(pbPersonPic, _Person);

        }


    }
}
