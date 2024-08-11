using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsLicenseClass
    {

        enum Mode { eAddNew = 0, eUpdate = 1 }

        Mode mode = Mode.eAddNew;

        public int LicenseClassID { get; set; }

        public string ClassName { get; set; }

        public string ClassDescription { get; set; }

        public byte MinimumAllowedAge { get; set; }

        public byte DefaultValidityLength { get; set; }

        public decimal ClassFees { get; set; }


        public clsLicenseClass()
        {
            LicenseClassID = -1;
            ClassName = "";
            ClassDescription = "";
            MinimumAllowedAge = 18;
            DefaultValidityLength = 0;
            ClassFees = 0;
            mode = Mode.eAddNew;
        }

        private clsLicenseClass(int LicenseClassID, string ClassName, string ClassDescription,
           byte MinimumAllowedAge, byte DefaultValidityLength, decimal ClassFees)
        {
            this.LicenseClassID = LicenseClassID;
            this.ClassName = ClassName;
            this.ClassDescription = ClassDescription;
            this.MinimumAllowedAge = MinimumAllowedAge;
            this.DefaultValidityLength = DefaultValidityLength;
            this.ClassFees = ClassFees;

            mode = Mode.eUpdate;

        }


        bool _AddNewLicenseClass()
        {
            return (clsDVLDDataAccess.AddNewLicenseClasse(this.ClassName, this.ClassDescription,
           this.MinimumAllowedAge, this.DefaultValidityLength, this.ClassFees) > -1);
        }

        bool _UpdateLicenseClass()
        {
            return (clsDVLDDataAccess.UpdateTestInfo(this.LicenseClassID, this.ClassName, this.ClassDescription,
           this.MinimumAllowedAge, this.DefaultValidityLength, this.ClassFees));
        }


        public static clsLicenseClass Find(int LicenseClassID)
        {
            byte MinimumAllowedAge = 0, DefaultValidityLength = 0;
            decimal ClassFees = 0;
            string ClassName = "", ClassDescription = "";


            if (clsDVLDDataAccess.GetLicenseClassInfoByID(LicenseClassID, ref ClassName, ref ClassDescription,
            ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees))
            {
                return new clsLicenseClass(LicenseClassID, ClassName, ClassDescription,
                                          MinimumAllowedAge, DefaultValidityLength, ClassFees);
            }
            else
                return null;
        }

        public static clsLicenseClass Find(string ClassName)
        {
            byte MinimumAllowedAge = 0, DefaultValidityLength = 0;
            decimal ClassFees = 0;
            string ClassDescription = "";
            int LicenseClassID = -1;


            if (clsDVLDDataAccess.GetLicenseClassInfoByClassName(ref LicenseClassID, ClassName, ref ClassDescription,
            ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees))
            {
                return new clsLicenseClass(LicenseClassID, ClassName, ClassDescription,
                                          MinimumAllowedAge, DefaultValidityLength, ClassFees);
            }
            else
                return null;
        }


        public static DataTable GetAllLicenseClasses()
        {
            DataTable DT = clsDVLDDataAccess.GetAllLicenseClasses();
            return DT;
        }


        public static int GetNumberOfLicenseClasses()
        {
            return clsDVLDDataAccess.GetNumberOfLicenseClasses();
        }

        public static bool DeleteLicenseClasse(int LicenseClassID)
        {
            return (clsDVLDDataAccess.DeleteLicenseClasse(LicenseClassID));
        }

        public bool Save()
        {
            switch (mode)
            {
                case Mode.eAddNew:
                    {
                        if (_AddNewLicenseClass())
                        {
                            mode = Mode.eUpdate;
                            return true;
                        }
                        else
                            return false;

                    }
                case Mode.eUpdate:

                    return _UpdateLicenseClass();

            }

            return false;
        }

    }
}
