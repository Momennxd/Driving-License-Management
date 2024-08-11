using DVLD_DataAccessLayer;
using System;
using System.Data;

namespace DVLD_BusinessLayer
{
    public class clsDriver
    {

        enum Mode { eAddNew = 0, eUpdate = 1 }

        Mode mode = Mode.eAddNew;

        public int DriverID { get; set; }

        public int PersonID { get; set; }

        public int CreatedByUserID { get; set; }

        public DateTime CreatedDate { get; set; }


        public clsDriver()
        {
            DriverID = -1;
            PersonID = -1;
            CreatedByUserID = -1;
            CreatedDate = DateTime.Now;           
            mode = Mode.eAddNew;
        }

        private clsDriver(int DriverID, int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            this.DriverID = DriverID;
            this.PersonID = PersonID;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedDate = CreatedDate;

            mode = Mode.eUpdate;

        }

        bool _AddNewDriver()
        {
            return (clsDVLDDataAccess.AddNewDriver(this.PersonID,
           this.CreatedByUserID, this.CreatedDate) > -1);
        }

        bool _UpdateDriver()
        {
            return (clsDVLDDataAccess.UpdateDriverInfo(this.DriverID, this.PersonID,
           this.CreatedByUserID, this.CreatedDate));
        }


        public static clsDriver FindByDriverID(int DriverID)
        {
            int PersonID = -1, CreatedByUserID = -1;
            DateTime CreatedDate = DateTime.Now;

            if (clsDVLDDataAccess.GetDriverInfoByDriverID(DriverID,
                ref PersonID, ref CreatedByUserID, ref CreatedDate))
            {
                return new clsDriver(DriverID, PersonID, CreatedByUserID, CreatedDate);
            }
            else
                return null;
        }

        public static clsDriver FindByPersonID(int PersonID)
        {
            int DriverID = -1, CreatedByUserID = -1;
            DateTime CreatedDate = DateTime.Now;

            if (clsDVLDDataAccess.GetDriverInfoByPersonID(ref DriverID,
                PersonID, ref CreatedByUserID, ref CreatedDate))
            {
                return new clsDriver(DriverID, PersonID, CreatedByUserID, CreatedDate);
            }
            else
                return null;
        }

        public static DataTable GetAllDrivers()
        {
            DataTable DT = clsDVLDDataAccess.GetAllDrivers();
            return DT;
        }

        public static DataTable GetAllDriversByDriverID(int DriverID)
        {
            DataTable DT = clsDVLDDataAccess.GetAllDriversByDriverID(DriverID);
            return DT;
        }

        public static DataTable GetAllDriversByPersonID(int PersonID)
        {
            DataTable DT = clsDVLDDataAccess.GetAllDriversByPersonID(PersonID);
            return DT;
        }

        public static DataTable GetAllDriversBlankTable()
        {
            DataTable DT = clsDVLDDataAccess.GetAllDrivers();
            DT.Rows.Clear();
            return DT;
        }

        public static DataTable GetAllDriversColumnNameDataStartsWith(string ColumnName, string PartialColumnData)
        {
            DataTable DT = clsDVLDDataAccess.GetAllDriversColumnNameDataStartsWith(ColumnName, PartialColumnData);
            return DT;
        }

        public static DataTable GetAllDriversByPersonFullNameDataStartsWith(string PartialFullName)
        {
            DataTable DT = clsDVLDDataAccess.GetAllDriversByPersonFullNameDataStartsWith(PartialFullName);
            return DT;
        }

        public static int GetNumberOfDrivers()
        {
            return clsDVLDDataAccess.GetNumberOfDrivers();
        }

        public static int GetNumberOfDrivers(byte Gender)
        {
            return clsDVLDDataAccess.GetNumberOfDriversByGender(Gender);
        }


        public static bool DoesDriverExist(int DriverID)
        {
            return (clsDVLDDataAccess.DoesDriverExist(DriverID));
        }

        public static bool DeleteDriver(int DriverID)
        {
            return (clsDVLDDataAccess.DeleteDriver(DriverID));
        }


        public bool Save()
        {
            switch (mode)
            {
                case Mode.eAddNew:
                    {
                        if (_AddNewDriver())
                        {
                            mode = Mode.eUpdate;
                            return true;
                        }
                        else
                            return false;

                    }
                case Mode.eUpdate:

                    return _UpdateDriver();

            }

            return false;
        }


    }
}
