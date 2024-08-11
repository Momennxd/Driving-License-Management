using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsTestAppointment
    {

        enum Mode { eAddNew = 0, eUpdate = 1 }

        Mode mode = Mode.eAddNew;

        public int TestAppointmentID { get; set; }

        public int TestTypeID { get; set; }

        public int LocalDrivingLicenseApplicationID { get; set; }

        public DateTime AppointmentDate { get; set; }

        public decimal PaidFees { get; set; }

        public int CreatedByUserID { get; set; }

        public bool IsLocked { get; set; }

        public int RetakeTestApplicationID { get; set; }


        public clsTestAppointment()
        {
            TestAppointmentID = -1;
            TestTypeID = -1;
            LocalDrivingLicenseApplicationID = -1;
            AppointmentDate = DateTime.Now;
            PaidFees = 0;
            CreatedByUserID = -1;
            IsLocked = false;
            RetakeTestApplicationID = -1;          

            mode = Mode.eAddNew;
        }

        private clsTestAppointment(int TestAppointmentID, int TestTypeID, int LocalDrivingLicenseApplicationID,
           DateTime AppointmentDate, decimal PaidFees, int CreatedByUserID, bool IsLocked, int RetakeTestApplicationID)
        {
            this.TestAppointmentID = TestAppointmentID;
            this.TestTypeID = TestTypeID;
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.AppointmentDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsLocked = IsLocked;
            this.RetakeTestApplicationID = RetakeTestApplicationID;
            mode = Mode.eUpdate;

        }



        bool _AddNewTestAppointment()
        {
            return (clsDVLDDataAccess.AddNewTestAppointment(this.TestTypeID, this.LocalDrivingLicenseApplicationID,
           this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked, this.RetakeTestApplicationID) > -1);
        }

        bool _UpdatePerson()
        {
            return (clsDVLDDataAccess.UpdateTestAppointmentInfo(this.TestAppointmentID, this.TestTypeID, this.LocalDrivingLicenseApplicationID,
           this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked, this.RetakeTestApplicationID));
        }

        public static clsTestAppointment Find(int TestAppointmentID)
        {
            int TestTypeID = -1, LocalDrivingLicenseApplicationID = -1,
                CreatedByUserID = -1, RetakeTestApplicationID = -1;
            DateTime AppointmentDate = DateTime.Now;
            decimal PaidFee = 0;
            bool IsLocked = false;


            if (clsDVLDDataAccess.GetTestAppointmentInfoByID(TestAppointmentID, ref TestTypeID, ref LocalDrivingLicenseApplicationID,
                      ref AppointmentDate, ref PaidFee, ref CreatedByUserID, ref IsLocked, ref RetakeTestApplicationID))
            {
                return new clsTestAppointment(TestAppointmentID, TestTypeID, LocalDrivingLicenseApplicationID,
                      AppointmentDate, PaidFee, CreatedByUserID, IsLocked, RetakeTestApplicationID);
            }
            else
                return null;
        }

        public static DataTable GetAllTestAppointments()
        {
            DataTable DT = clsDVLDDataAccess.GetAllTestAppointments();
            return DT;
        }

        public static DataTable GetAllBlankTestAppointments()
        {
            DataTable DT = clsDVLDDataAccess.GetAllTestAppointments();
            DT.Rows.Clear();
            return DT;
        }


        public static DataTable GetAllTestAppointmentsByTestTypeID(int TestTypeID, int LDLAppID)
        {
            DataTable DT = clsDVLDDataAccess.GetAllTestAppointmentsByTestTypeID(TestTypeID, LDLAppID);
            return DT;
        }

        public static bool DoesActiveTestAppointmentExist(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            return (clsDVLDDataAccess.DoesActiveTestAppointmentExist(LocalDrivingLicenseApplicationID, TestTypeID));
        }

        public static bool DoesLDLAppHaveAppointment(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            return (clsDVLDDataAccess.DoesLDLAppHaveAppointment(LocalDrivingLicenseApplicationID, TestTypeID));
        }


        public static int GetNumberOfTestAppointments()
        {
            return clsDVLDDataAccess.GetNumberOfTestAppointments();
        }

        public static bool DeleteTestAppointment(int TestAppointmentID)
        {
            return (clsDVLDDataAccess.DeleteTestAppointment(TestAppointmentID));
        }

        public bool Save()
        {
            switch (mode)
            {
                case Mode.eAddNew:
                    {
                        if (_AddNewTestAppointment())
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
