using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsTestType
    {

        public int TestTypeID { get; set; }

        public string TestTypeTitle { get; set; }

        public string TestTypeDescription { get; set; }

        public decimal TestTypeFees { get; set; }

        private clsTestType(int TestTypeID, string TestTypeTitle, string TestTypeDescription, decimal TestTypeFees)
        {
            this.TestTypeID = TestTypeID;
            this.TestTypeTitle = TestTypeTitle;
            this.TestTypeDescription = TestTypeDescription;
            this.TestTypeFees = TestTypeFees;

        }

        bool _UpdateTestType()
        {
            return (clsDVLDDataAccess.UpdateTestTypeInfo(this.TestTypeID, this.TestTypeTitle, this.TestTypeDescription, this.TestTypeFees));
        }

        public static clsTestType Find(int TestTypeID)
        {
            string TestTypeTitle = "", TestTypeDescription = "";
            decimal TestTypeFees = 0;



            if (clsDVLDDataAccess.GetTestTypeInfoByID(TestTypeID, ref TestTypeTitle, ref TestTypeDescription, ref TestTypeFees))
            {
                return new clsTestType(TestTypeID, TestTypeTitle, TestTypeDescription, TestTypeFees);
            }
            else
                return null;
        }

        public static DataTable GetAllTestTypes()
        {
            DataTable DT = clsDVLDDataAccess.GetAllTestTypes();
            return DT;
        }

        public bool Save()
        {
            return _UpdateTestType();
        }
    }
}
