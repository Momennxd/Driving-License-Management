using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsTest
    {

        enum Mode { eAddNew = 0, eUpdate = 1 }

        Mode mode = Mode.eAddNew;

        public int TestID { get; set; }
        public int TestAppointmentID { get; set; }
        public bool TestResult { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserID { get; set; }


        public clsTest()
        {
            TestID = -1;
            TestAppointmentID = -1;
            TestResult = false;
            Notes = "";
            CreatedByUserID = -1;         
            mode = Mode.eAddNew;
        }

        private clsTest(int TestID, int TestAppointmentID, bool TestResult,
            string Notes, int CreatedByUserID)
        {
            this.TestID = TestID;
            this.TestAppointmentID = TestAppointmentID;
            this.TestResult = TestResult;
            this.Notes = Notes;
            this.CreatedByUserID = CreatedByUserID;    
            mode = Mode.eUpdate;

        }

        bool _AddNewTest()
        {
            return (clsDVLDDataAccess.AddNewTest(this.TestAppointmentID, this.TestResult,
           this.Notes, this.CreatedByUserID) > -1);
        }

        bool _UpdateTest()
        {
            return (clsDVLDDataAccess.UpdateTestInfo(this.TestID, this.TestAppointmentID, this.TestResult,
           this.Notes, this.CreatedByUserID));
        }

        public static clsTest Find(int TestID)
        {
            int TestAppointmentID = -1, CreatedByUserID = -1;
            string Notes = "";
            bool TestResult = false;


            if (clsDVLDDataAccess.GetTestInfoByID(TestID, ref TestAppointmentID, ref TestResult,
            ref Notes, ref CreatedByUserID))
            {
                return new clsTest(TestID, TestAppointmentID, TestResult, Notes, CreatedByUserID);
            }
            else
                return null;
        }

        public static DataTable GetAllTests()
        {
            DataTable DT = clsDVLDDataAccess.GetAllTests();
            return DT;
        }

        public static int GetNumberOfTests()
        {
            return clsDVLDDataAccess.GetNumberOfTests();
        }

        public static int GetNumberOfTestsPassedOrFaildByTestLDLAppID(bool IsPassed, int PersonID, int LDLAppID)
        {
            return clsDVLDDataAccess.GetNumberOfTestsPassedOrFaildByTestTypeID(IsPassed, PersonID, LDLAppID);
        }

        public static int GetNumOfPassOrFailTests(int PersonID, int TestTypeID, bool TestResult, int LocalDrivingLicenseApplicationID)
        {
            return clsDVLDDataAccess.GetNumOfPassOrFailTestsByLDLAppID(PersonID, TestTypeID, TestResult, LocalDrivingLicenseApplicationID);
        }


        public static int GetNumberOfTests(int PersonID, int TestTypeID, int LocalDrivingLicenseApplicationID)
        {
            return clsDVLDDataAccess.GetNumOfPassOrFailTestsByLDLAppID(PersonID, TestTypeID, true, LocalDrivingLicenseApplicationID) +
                clsDVLDDataAccess.GetNumOfPassOrFailTestsByLDLAppID(PersonID, TestTypeID, false, LocalDrivingLicenseApplicationID);
        }


        public static bool DeleteTest(int TestID)
        {
            return (clsDVLDDataAccess.DeleteTest(TestID));
        }

        public bool Save()
        {
            switch (mode)
            {
                case Mode.eAddNew:
                    {
                        if (_AddNewTest())
                        {
                            mode = Mode.eUpdate;
                            return true;
                        }
                        else
                            return false;

                    }
                case Mode.eUpdate:

                    return _UpdateTest();

            }

            return false;
        }


    }
}
