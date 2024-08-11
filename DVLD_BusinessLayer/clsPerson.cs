using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DVLD_DataAccessLayer.clsDVLDDataAccess;

namespace DVLD_BusinessLayer
{
    public class clsPerson
    {

        enum Mode { eAddNew = 0, eUpdate = 1 }

        Mode mode = Mode.eAddNew;

        public int ID { get; set; }

        public string NationalNo { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string ThirdName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public byte Gender { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public int NationalityCountryID { get; set; }

        public string ImagePath { get; set; }


        public clsPerson()
        {
            ID = -1;
            NationalNo = "";
            FirstName = "";
            SecondName = "";
            ThirdName = "";
            LastName = "";
            DateOfBirth = new DateTime(2005, 10, 9);
            Gender = 0;
            Address = "";
            Phone = "";
            Email = "";
            NationalityCountryID = -1;
            ImagePath = "";

            mode = Mode.eAddNew;
        }

        private clsPerson(int ID, string NationalNo, string FirstName,
            string SecondName, string ThirdName, string LastName, DateTime DateOfBirth,
            byte Gender, string Address, string Phone, string Email,
            int NationalityCountryID, string ImagePath)
        {
            this.ID = ID;
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gender;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityCountryID = NationalityCountryID;
            this.ImagePath = ImagePath;
            mode = Mode.eUpdate;
        }



        bool _AddNewPerson()
        {
            return (clsDVLDDataAccess.AddNewPerson(this.NationalNo, this.FirstName,
            this.SecondName, this.ThirdName, this.LastName, this.DateOfBirth,
            this.Gender, this.Address, this.Phone, this.Email,
            this.NationalityCountryID, this.ImagePath) > -1);
        }

        bool _UpdatePerson()
        {
            return (clsDVLDDataAccess.UpdatePersonInfo(this.ID, this.NationalNo, this.FirstName,
            this.SecondName, this.ThirdName, this.LastName, this.DateOfBirth,
            this.Gender, this.Address, this.Phone, this.Email,
            this.NationalityCountryID, this.ImagePath));
        }

        public static clsPerson Find(int PersonID)
        {
            byte Gender = 0; int NationalityCountryID = -1;
            string NationalNo = "", FirstName = "", SecondName = "", ThirdName = "", LastName = "", Address = "",
                 Phone = "", Email = "", ImagePath = "";
            DateTime DateOfBirth = new DateTime(2005, 10, 9);


            if (clsDVLDDataAccess.GetPersonInfoByID(PersonID, ref NationalNo, ref FirstName,
            ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth,
            ref Gender, ref Address, ref Phone, ref Email,
            ref NationalityCountryID, ref ImagePath))
            {
                return new clsPerson(PersonID, NationalNo, FirstName,
                SecondName, ThirdName, LastName, DateOfBirth,
                Gender, Address, Phone, Email,
                NationalityCountryID, ImagePath);
            }
            else
                return null;
        }

        public static clsPerson Find(string NationalNo)
        {
            int ID = -1,  NationalityCountryID = -1; byte Gender = 0;
            string FirstName = "", SecondName = "", ThirdName = "", LastName = "", Address = "",
                 Phone = "", Email = "", ImagePath = "";
            DateTime DateOfBirth = new DateTime(2005, 10, 9);


            if (clsDVLDDataAccess.GetPersonInfoByNationalNum(ref ID, NationalNo, ref FirstName,
            ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth,
            ref Gender, ref Address, ref Phone, ref Email,
            ref NationalityCountryID, ref ImagePath))
            {
                return new clsPerson(ID, NationalNo, FirstName,
                SecondName, ThirdName, LastName, DateOfBirth,
                Gender, Address, Phone, Email,
                NationalityCountryID, ImagePath);
            }
            else
                return null;
        }

        public static string GetPersonNationality(clsPerson Person)
        {
            return clsCountry.Find(Person.NationalityCountryID).CountryName;
        }

        public static DataTable GetAllPeople()
        {
            DataTable DT = clsDVLDDataAccess.GetAllPeople();
            return DT;
        }

        public static DataTable GetBlankPeopleTable()
        {
            DataTable DT = clsDVLDDataAccess.GetAllPeople();
            DT.Rows.Clear();
            return DT;
        }


        public static DataTable GetAllPeopleByGender(byte Gender)
        {
            DataTable DT = clsDVLDDataAccess.GetAllPeopleByGender(Gender);
            return DT;
        }

        public static DataTable GetAllPeopleByNationalityCountryID(int NationalityCountryID)
        {
            DataTable DT = clsDVLDDataAccess.GetAllPeopleByNationalityCountryID(NationalityCountryID);
            return DT;
        }

        public static DataTable GetAllPeopleByPersonID(int PersonID)
        {
            DataTable DT = clsDVLDDataAccess.GetAllPeopleByPersonID(PersonID);
            return DT;
        }


        public static int GetNumberOfPeople()
        {
            return clsDVLDDataAccess.GetNumberOfPeople();
        }

        public static int GetNumberOfPeople(byte Gender)
        {
            return clsDVLDDataAccess.GetNumberOfPeopleByGender(Gender);
        }


        public static bool DeletePerson(int PersonID)
        {
            return (clsDVLDDataAccess.DeletePerson(PersonID));
        }

        public static bool DoesPersonExist(int PersonID)
        {
            return (clsDVLDDataAccess.DoesPersonExist(PersonID));
        }

        public static DataTable GetAllPeopleColumnNameDataStartsWith(string ColumnName, string PartialColumnData)
        {
            DataTable DT = clsDVLDDataAccess.GetAllPeopleColumnNameDataStartsWith(ColumnName, PartialColumnData);
            return DT;
        }

        public static DataTable GetAllPeopleFullNameStartsWith(string PartialFullName)
        {
            DataTable DT = clsDVLDDataAccess.GetAllPeopleFullNameStartsWith(PartialFullName);
            return DT;
        }

        public bool Save()
        {
            switch (mode)
            {
                case Mode.eAddNew:
                    {
                        if (_AddNewPerson())
                        {
                            mode = Mode.eUpdate;
                            return true;
                        }
                        else
                            return false;

                    }
                case Mode.eUpdate:

                    return _UpdatePerson();

            }

            return false;
        }


    }
}
