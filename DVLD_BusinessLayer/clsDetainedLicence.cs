using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_BusinessLayer
{
    public class clsDetainedLicence
    {


        enum Mode { eAddNew = 0, eUpdate = 1 }

        Mode mode = Mode.eAddNew;

        public int DetainID { get; set; }

        public int LicenseID { get; set; }

        public DateTime DetainDate { get; set; }

        public decimal FineFees { get; set; }

        public int CreatedByUserID { get; set; }

        public bool IsReleased { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public int ReleasedByUserID { get; set; }

        public int ReleaseApplicationID { get; set; }


        public clsDetainedLicence()
        {
            DetainID = -1;
            LicenseID = -1;
            DetainDate = DateTime.Now;
            FineFees = 0;
            CreatedByUserID = -1;
            IsReleased = false;
            ReleaseDate = null;
            ReleasedByUserID = -1;
            ReleaseApplicationID = -1;         
            mode = Mode.eAddNew;
        }

        private clsDetainedLicence(int DetainID, int LicenseID, DateTime DetainDate,
          decimal FineFees, int CreatedByUserID, bool IsReleased, DateTime? ReleaseDate,
          int ReleasedByUserID, int ReleaseApplicationID)
        {
            this.DetainID = DetainID;
            this.LicenseID = LicenseID;
            this.DetainDate = DetainDate;
            this.FineFees = FineFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsReleased = IsReleased;
            this.ReleaseDate = ReleaseDate;
            this.ReleasedByUserID = ReleasedByUserID;
            this.ReleaseApplicationID = ReleaseApplicationID;
            mode = Mode.eUpdate;
        }


        bool _AddNewDetainLicence()
        {
            return (clsDVLDDataAccess.AddNewDetainLicence(this.LicenseID, this.DetainDate,
          this.FineFees, this.CreatedByUserID, this.IsReleased, this.ReleaseDate,
          this.ReleasedByUserID, this.ReleaseApplicationID) > -1);
        }


        bool _UpdateDetainLicence()
        {
            return (clsDVLDDataAccess.UpdateDetainedLicenceInfo(this.DetainID, this.LicenseID, this.DetainDate,
          this.FineFees, this.CreatedByUserID, this.IsReleased, this.ReleaseDate,
          this.ReleasedByUserID, this.ReleaseApplicationID));
        }


        public static clsDetainedLicence FindByDetainID(int DetainID)
        {
            int LicenseID = -1, CreatedByUserID = -1, ReleasedByUserID = -1, ReleaseApplicationID = -1;
            DateTime DetainDate = DateTime.Now; DateTime? ReleaseDate = null;
            decimal FineFees = 0; bool IsReleased = false;


            if (clsDVLDDataAccess.GetDetainedLicenceInfoByDetainID(DetainID, ref LicenseID, ref DetainDate,
          ref FineFees, ref CreatedByUserID, ref IsReleased, ref ReleaseDate,
          ref ReleasedByUserID, ref ReleaseApplicationID))
            {
                return new clsDetainedLicence(DetainID, LicenseID, DetainDate,
          FineFees, CreatedByUserID, IsReleased, ReleaseDate,
          ReleasedByUserID, ReleaseApplicationID);
            }
            else
                return null;
        }

        public static clsDetainedLicence FindByLicenseID(int LicenseID)
        {
            int DetainID = -1, CreatedByUserID = -1, ReleasedByUserID = -1, ReleaseApplicationID = -1;
            DateTime DetainDate = DateTime.Now; DateTime? ReleaseDate = null;
            decimal FineFees = 0; bool IsReleased = false;


            if (clsDVLDDataAccess.GetDetainedLicenceInfoByLicenceID(ref DetainID, LicenseID, ref DetainDate,
          ref FineFees, ref CreatedByUserID, ref IsReleased, ref ReleaseDate,
          ref ReleasedByUserID, ref ReleaseApplicationID))
            {
                return new clsDetainedLicence(DetainID, LicenseID, DetainDate,
          FineFees, CreatedByUserID, IsReleased, ReleaseDate,
          ReleasedByUserID, ReleaseApplicationID);
            }
            else
                return null;
        }

        public static clsDetainedLicence FindUnReleasedByLicenseID(int LicenseID)
        {
            int DetainID = -1, CreatedByUserID = -1, ReleasedByUserID = -1, ReleaseApplicationID = -1;
            DateTime DetainDate = DateTime.Now; DateTime? ReleaseDate = null;
            decimal FineFees = 0; bool IsReleased = false;


            if (clsDVLDDataAccess.GetUnReleasedDetainedLicenceInfoByLicenceID(ref DetainID, LicenseID, ref DetainDate,
          ref FineFees, ref CreatedByUserID, ref IsReleased, ref ReleaseDate,
          ref ReleasedByUserID, ref ReleaseApplicationID))
            {
                return new clsDetainedLicence(DetainID, LicenseID, DetainDate,
          FineFees, CreatedByUserID, IsReleased, ReleaseDate,
          ReleasedByUserID, ReleaseApplicationID);
            }
            else
                return null;
        }


        public static DataTable GetAllDetainedLicenses()
        {
            DataTable DT = clsDVLDDataAccess.GetAllDetainedLicenses();
            return DT;
        }


        public static DataTable GetBlankDetainedLicensesTable()
        {
            DataTable DT = clsDVLDDataAccess.GetAllDetainedLicenses();
            DT.Rows.Clear();
            return DT;
        }


        public static DataTable GetAlDetainedLicensesByLicenseID(int LicenseID)
        {
            DataTable DT = clsDVLDDataAccess.GetAlDetainedLicensesByLicenseID(LicenseID);
            return DT;
        }

        public static DataTable GetAlDetainedLicensesByDetainID(int DetainID)
        {
            DataTable DT = clsDVLDDataAccess.GetAlDetainedLicensesByDetainID(DetainID);
            return DT;
        }

        public static DataTable GetAlDetainedLicensesByReleaseApplicationID(int ReleaseApplicationID)
        {
            DataTable DT = clsDVLDDataAccess.GetAlDetainedLicensesByReleaseApplicationID(ReleaseApplicationID);
            return DT;
        }

        public static DataTable GetAlDetainedLicensesByIsReleased(bool IsReleased)
        {
            DataTable DT = clsDVLDDataAccess.GetAlDetainedLicensesByIsReleased(IsReleased);
            return DT;
        }


        public static int GetNumberOfDetainedLicenses()
        {
            return clsDVLDDataAccess.GetNumberOfDetainedLicenses();
        }

        public static bool DeleteDetainedLicenses(int DetainID)
        {
            return (clsDVLDDataAccess.DeleteDetainedLicenses(DetainID));
        }

        public bool Save()
        {
            switch (mode)
            {
                case Mode.eAddNew:
                    {
                        if (_AddNewDetainLicence())
                        {
                            mode = Mode.eUpdate;
                            return true;
                        }
                        else
                            return false;

                    }
                case Mode.eUpdate:

                    return _UpdateDetainLicence();

            }

            return false;
        }


    }
}
