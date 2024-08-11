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
    public class clsLicence
    {

        enum Mode { eAddNew = 0, eUpdate = 1 }

        Mode mode = Mode.eAddNew;

        public int LicenseID { get; set; }

        public int ApplicationID { get; set; }

        public int DriverID { get; set; }

        public int LicenseClass { get; set; }

        public DateTime IssueDate { get; set; }

        public DateTime ExpirationDate { get; set; }

        public string Notes { get; set; }

        public decimal PaidFees { get; set; }

        public bool IsActive { get; set; }

        public byte IssueReason { get; set; }

        public int CreatedByUserID { get; set; }

        public clsLicence()
        {
            LicenseID = -1;
            ApplicationID = -1;
            DriverID = -1;
            LicenseClass = -1;
            IssueDate = DateTime.Now;
            ExpirationDate = DateTime.Now;
            Notes = "";
            PaidFees = 0;
            IsActive = false;
            IssueReason = 0;
            CreatedByUserID = -1;
            mode = Mode.eAddNew;
        }


        private clsLicence(int LicenseID, int ApplicationID, int DriverID,
            int LicenseClass, DateTime IssueDate, DateTime ExpirationDate, string Notes,
            decimal PaidFees, bool IsActive, byte IssueReason, int CreatedByUserID)
        {
            this.LicenseID = LicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.LicenseClass = LicenseClass;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.Notes = Notes;
            this.PaidFees = PaidFees;
            this.IsActive = IsActive;
            this.IssueReason = IssueReason;
            this.CreatedByUserID = CreatedByUserID;
            mode = Mode.eUpdate;
        }

        bool _AddNewLicence()
        {
            return (clsDVLDDataAccess.AddNewLicence(this.ApplicationID, this.DriverID,
            this.LicenseClass, this.IssueDate, this.ExpirationDate, this.Notes,
            this.PaidFees, this.IsActive, this.IssueReason, this.CreatedByUserID) > -1);
        }

        bool _UpdateLicence()
        {
            return (clsDVLDDataAccess.UpdateLicenceInfo(this.LicenseID, this.ApplicationID, this.DriverID,
            this.LicenseClass, this.IssueDate, this.ExpirationDate, this.Notes,
            this.PaidFees, this.IsActive, this.IssueReason, this.CreatedByUserID));
        }


        public static clsLicence FindByLicenceID(int LicenseID)
        {
            int ApplicationID = -1; int DriverID = -1, LicenseClass = -1, CreatedByUserID = -1;
            string Notes = "";
            DateTime IssueDate = DateTime.Now, ExpirationDate = DateTime.Now;
            decimal PaidFees = 0;
            bool IsActive = false;
            byte IssueReason = 0;


            if (clsDVLDDataAccess.GetLicenceInfoByLicenceID(LicenseID, ref ApplicationID, ref DriverID,
           ref LicenseClass, ref IssueDate, ref ExpirationDate, ref Notes,
           ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID)) 
            {
                return new clsLicence(LicenseID, ApplicationID, DriverID,
            LicenseClass, IssueDate, ExpirationDate, Notes,
            PaidFees, IsActive, IssueReason, CreatedByUserID);
            }
            else
                return null;
        }

        public static clsLicence FindUnDetainedByLicenceID(int LicenseID)
        {
            int ApplicationID = -1; int DriverID = -1, LicenseClass = -1, CreatedByUserID = -1;
            string Notes = "";
            DateTime IssueDate = DateTime.Now, ExpirationDate = DateTime.Now;
            decimal PaidFees = 0;
            bool IsActive = false;
            byte IssueReason = 0;


            if (clsDVLDDataAccess.GetUnDetainedLicenceInfoByLicenceID(LicenseID, ref ApplicationID, ref DriverID,
           ref LicenseClass, ref IssueDate, ref ExpirationDate, ref Notes,
           ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID))
            {
                return new clsLicence(LicenseID, ApplicationID, DriverID,
            LicenseClass, IssueDate, ExpirationDate, Notes,
            PaidFees, IsActive, IssueReason, CreatedByUserID);
            }
            else
                return null;
        }


        public static clsLicence FindByApplicationID(int ApplicationID)
        {
            int LicenseID = -1; int DriverID = -1, LicenseClass = -1, CreatedByUserID = -1;
            string Notes = "";
            DateTime IssueDate = DateTime.Now, ExpirationDate = DateTime.Now;
            decimal PaidFees = 0;
            bool IsActive = false;
            byte IssueReason = 0;


            if (clsDVLDDataAccess.GetLicenceInfoByApplicationID(ref LicenseID, ApplicationID, ref DriverID,
           ref LicenseClass, ref IssueDate, ref ExpirationDate, ref Notes,
           ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID))
            {
                return new clsLicence(LicenseID, ApplicationID, DriverID,
            LicenseClass, IssueDate, ExpirationDate, Notes,
            PaidFees, IsActive, IssueReason, CreatedByUserID);
            }
            else
                return null;
        }

        public static DataTable GetAllLicences()
        {
            DataTable DT = clsDVLDDataAccess.GetAllLicenses();
            return DT;
        }

        public static DataTable GetBlankLicencesTable()
        {
            DataTable DT = clsDVLDDataAccess.GetAllLicenses();
            DT.Rows.Clear();
            return DT;
        }


        public static DataTable GetAlLicensesByApplicationID(int ApplicationID)
        {
            DataTable DT = clsDVLDDataAccess.GetAlLicensesByApplicationID(ApplicationID);
            return DT;
        }

        public static DataTable GetAlLicensesByDriverID(int DriverID)
        {
            DataTable DT = clsDVLDDataAccess.GetAlLicensesByDriverID(DriverID);
            return DT;
        }

        public static int GetNumberOfLicense()
        {
            return clsDVLDDataAccess.GetNumberOfLicenses();
        }

        public static int GetNumberOfLicense(bool IsActive)
        {
            return clsDVLDDataAccess.GetNumberOfLicensesByActive(IsActive);
        }


        public static int GetNumberOfActiveLicensesByPersonID(int PersonID)
        {
            return clsDVLDDataAccess.GetNumberOfActiveLicensesByPersonID(PersonID);
        }

        public static int GetNumberOfActiveLicenses(int PersonID, bool IsActive, int LicenceClassID)
        {
            return clsDVLDDataAccess.GetNumberOfActiveLicenses(IsActive, PersonID, LicenceClassID); ;
        }

        public static string GetIssueReasonByNumber(int IssueReasonNum)
        {
            switch (IssueReasonNum)
            {
                case 1:
                    return "First Time";
                case 2:
                    return "Renew";
                case 3:
                    return "Replacement for Damaged";
                case 4:
                    return "Replacement for Lost";
                default:
                    return "";

            }
        }

        public static bool IsLicenceDetained(int LicenceID)
        {
            return clsDVLDDataAccess.IsLicenceDetained(LicenceID);
        }

        public static bool DeleteLicense(int LicenseID)
        {
            return (clsDVLDDataAccess.DeleteLicense(LicenseID));
        }

        public static bool DoesLicenseExist(int LicenseID)
        {
            return (clsDVLDDataAccess.DoesLicenseExist(LicenseID));
        }

        public bool Save()
        {
            switch (mode)
            {
                case Mode.eAddNew:
                    {
                        if (_AddNewLicence())
                        {
                            mode = Mode.eUpdate;
                            return true;
                        }
                        else
                            return false;

                    }
                case Mode.eUpdate:

                    return _UpdateLicence();

            }

            return false;
        }


    }
}
