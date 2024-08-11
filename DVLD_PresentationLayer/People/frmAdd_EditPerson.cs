using Bunifu.Framework.UI;
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
using System.IO;

namespace DVLD_PresentationLayer
{
    public partial class frmAdd_EditPerson : Form
    {
        public frmAdd_EditPerson()
        {
            InitializeComponent();
            _Mode = enMode.eAddNew;
        }

        public frmAdd_EditPerson(clsPerson Person)
        {
            InitializeComponent();
            _Person = Person;
        }

        enum enMode { eUpdate, eAddNew };

        enMode _Mode = enMode.eUpdate;

        clsPerson _Person = new clsPerson();

        void _DispalyPersonData()
        {
            clsDVLDSettings.ShowDataOnContolText(txtNationalNo, _Person.NationalNo);
            clsDVLDSettings.ShowDataOnContolText(txtFirstName, _Person.FirstName);
            clsDVLDSettings.ShowDataOnContolText(txtSecondName, _Person.SecondName);
            clsDVLDSettings.ShowDataOnContolText(txtThirdName, _Person.ThirdName);
            clsDVLDSettings.ShowDataOnContolText(txtLastName, _Person.LastName);
            clsDVLDSettings.ShowDateOnCustomDatePicker(dpDateOfBirth, _Person.DateOfBirth);
            clsDVLDSettings.ShowItemAsSelectedOnComboBoxByName(ref cbGenders, clsDVLDSettings.GetPersonGender(_Person));
            clsDVLDSettings.ShowDataOnContolText(txtAddress, _Person.Address);
            clsDVLDSettings.ShowDataOnContolText(txtPhoneNumber, _Person.Phone);
            clsDVLDSettings.ShowDataOnContolText(txtEmail, _Person.Email);
            clsDVLDSettings.ImportNationalitiesToComboBox(cbNationalities, clsCountry.GetAllCountries());
            clsDVLDSettings.ShowItemAsSelectedOnComboBoxByName(ref cbNationalities, clsPerson.GetPersonNationality(_Person));
            clsDVLDSettings.DispalyImageForUser(pbPersonPic, _Person);
        }

        void _AlterFormToUpdateMode()
        {
            lblFormHeader.Text = "Update Person";
        }

        void _AlterFormToAddNewMode()
        {
            lblFormHeader.Text = "Add Person";
            clsDVLDSettings.ImportNationalitiesToComboBox(cbNationalities, clsCountry.GetAllCountries());
        }

        void _AlterForm(enMode Mode)
        {
            switch (Mode)
            {
                case enMode.eUpdate:
                    {
                        _AlterFormToUpdateMode();
                        break;
                    }
                case enMode.eAddNew:
                    {
                        _AlterFormToAddNewMode();
                        break;
                    }
            }
        }

        void _GoBackToPeopleForm()
        {
            frmPeople frmPeople_v = new frmPeople();
            clsDVLDSettings.ShowFormInPanel(pnlPersonLoader, frmPeople_v);
        }

        void _RoundControls()
        {
            Control[] controls = {pnlNationalNo, pnlFirstName, pnlSecondName, pnlThirdName, pnlLastName
                    , pnlDateOfBirth, pnlGender, pnlAddress,
            pnlPhoneNumber, pnlEmail, pnlNationality, pbPersonPic , pnlPerson, btnGoBack};

            clsDVLDSettings.RoundControlsByCustomElips(bunifuElipse1, controls);
        }

        void _PerformMode()
        {
            switch (_Mode)
            {
                case enMode.eUpdate:
                    {
                        _AlterForm(_Mode);
                        _DispalyPersonData();
                        break;
                    }
                case enMode.eAddNew:
                    {
                        _AlterForm(_Mode);
                        break;
                    }
            
            }
        }

        bool _ValidateInfo()
        {

            return (clsDVLDSettings.ValidateTxtBox(txtFirstName, "", "Please Enter The First Name", errorInfoValidation) &&
                    clsDVLDSettings.ValidateTxtBox(txtSecondName, "", "Please Enter The Second Name", errorInfoValidation) &&
                    clsDVLDSettings.ValidateTxtBox(txtLastName, "", "Please Enter The Last Name", errorInfoValidation) &&
                    clsDVLDSettings.ValidateTxtBox(txtNationalNo, "", "Please Enter The National Number", errorInfoValidation) &&
                    clsDVLDSettings.ValidateTxtBox(txtAddress, "", "Please Enter The Address", errorInfoValidation) &&
                    clsDVLDSettings.ValidateTxtBox(txtPhoneNumber, "", "Please Enter The Phone Number", errorInfoValidation) &&
                    clsDVLDSettings.ValidateIfTxtBoxIsNotNumber(txtPhoneNumber, "Please Enter a Valid Phone Number", errorInfoValidation) &&
                    clsDVLDSettings.ValidateTxtBox(txtEmail, !clsDVLDSettings.IsEmailValid(txtEmail.Text), "Please Enter a Valid Email", errorInfoValidation)) &&
                    clsDVLDSettings.ValidateCustomDatePicker(dpDateOfBirth, clsDVLDSettings.GetBirthDateFor110YearsAgo(), 
                    clsDVLDSettings.GetBirthDateFor18YearsAgo(), "Please Enter a Valid Date over 18 and under 100 years old", errorInfoValidation);

        }

        void _LoadDataFromFrmToPersonObj()
        {
            _Person.NationalNo = txtNationalNo.Text;
            _Person.FirstName = txtFirstName.Text;
            _Person.SecondName = txtSecondName.Text;
            _Person.ThirdName = txtThirdName.Text;
            _Person.LastName = txtLastName.Text;
            _Person.DateOfBirth = dpDateOfBirth.Value;
            _Person.Gender = clsDVLDSettings.GetGenderIndexByName(cbGenders.SelectedItem.ToString());
            _Person.Address = txtAddress.Text;
            _Person.Phone = txtPhoneNumber.Text;
            _Person.Email = txtEmail.Text;
            _Person.NationalityCountryID = clsCountry.Find(cbNationalities.SelectedItem.ToString()).ID;
            
        }

        void _SavePersonImage()
        {          
            if (!string.IsNullOrEmpty(pbPersonPic.ImageLocation))
            {
                Guid GUID = Guid.NewGuid();
                string NewPath = $@"F:\Projects\My Projects With C#\Driving License Management\DVLD Pictures\{GUID.ToString()}.jpg";
                File.Copy(pbPersonPic.ImageLocation, NewPath);
                _Person.ImagePath = NewPath;
            }
            else
            {
                _Person.ImagePath = null;
            }


        }

        void _PerformImageSave()
        {
            if (!string.IsNullOrEmpty(_Person.ImagePath))
            {
                clsDVLDSettings.DeleteOldPersonImageFromSource(_Person);
            }

             _SavePersonImage();    
        }

        void _SavePerson()
        {
            if (_ValidateInfo())
            {
                _LoadDataFromFrmToPersonObj();
                _PerformImageSave();
                _Person.Save();
                _GoBackToPeopleForm();

            }
        }



        private void frmAdd_EditPerson_Load(object sender, EventArgs e)
        {
            _RoundControls();
            _PerformMode();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            _GoBackToPeopleForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _SavePerson();
        }

        private void klblChooseImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ofdPersonImagePicker.ShowDialog() == DialogResult.OK)
            {
                pbPersonPic.ImageLocation = ofdPersonImagePicker.FileName;
            }
        }

        private void klblRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_Mode == enMode.eUpdate)
            {
                clsDVLDSettings.DispalyDefaultImageForUser(pbPersonPic, _Person);
            }
            else if (_Mode == enMode.eAddNew)
            {
                clsDVLDSettings.DispalyDefaultImageForUser(pbPersonPic, clsDVLDSettings.GetGenderIndexByName(cbGenders.SelectedItem.ToString()));
            }


            pbPersonPic.ImageLocation = "";
            ofdPersonImagePicker.FileName = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _GoBackToPeopleForm();
        }

        private void cbGenders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(pbPersonPic.ImageLocation))
            {
                clsDVLDSettings.DispalyDefaultImageForUser(pbPersonPic, clsDVLDSettings.GetGenderIndexByName(cbGenders.SelectedItem.ToString()));
            }
        }
    }
}
