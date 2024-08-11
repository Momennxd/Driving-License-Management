using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsInternationalLicense
    {

        enum Mode { eAddNew = 0, eUpdate = 1 }

        Mode mode = Mode.eAddNew;

        public int InternationalLicenseID { get; set; }

        public int ApplicationID { get; set; }

        public int DriverID { get; set; }

        public int IssuedUsingLocalLicenseID { get; set; }

        public DateTime IssueDate { get; set; }

        public DateTime ExpirationDate { get; set; }

        public bool IsActive { get; set; }

        public int CreatedByUserID { get; set; }

        public clsInternationalLicense()
        {
            InternationalLicenseID = -1;
            ApplicationID = -1;
            DriverID = -1;
            IssuedUsingLocalLicenseID = -1;
            IssueDate = DateTime.Now;
            ExpirationDate = DateTime.Now;
            IsActive = false;
            CreatedByUserID = -1;
            mode = Mode.eAddNew;
        }


        private clsInternationalLicense(int InternationalLicenseID, int ApplicationID, int DriverID,
       int IssuedUsingLocalLicenseID, DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            this.InternationalLicenseID = InternationalLicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.IssuedUsingLocalLicenseID = IssuedUsingLocalLicenseID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.IsActive = IsActive;
            this.CreatedByUserID = CreatedByUserID;
            mode = Mode.eUpdate;
        }


        bool _AddNewInternationalLicense()
        {
            return (clsDVLDDataAccess.AddNewInternationalLicenses(this.ApplicationID, this.DriverID,
          this.IssuedUsingLocalLicenseID, this.IssueDate, this.ExpirationDate, this.IsActive,
          this.CreatedByUserID) > -1);
        }


        bool _UpdateInternationalLicense()
        {
            return (clsDVLDDataAccess.UpdateInternationalLicenseInfo(this.InternationalLicenseID, this.ApplicationID, this.DriverID,
          this.IssuedUsingLocalLicenseID, this.IssueDate, this.ExpirationDate, this.IsActive,
          this.CreatedByUserID));
        }


        public static clsInternationalLicense FindByInternationalLicenseID(int InternationalLicenseID)
        {
            int ApplicationID = -1, DriverID = -1, IssuedUsingLocalLicenseID = -1, CreatedByUserID = -1;
            DateTime IssueDate = DateTime.Now, ExpirationDate = DateTime.Now;
            bool IsActive = false;


            if (clsDVLDDataAccess.GetInternationalLicenseInfoByInternationalLicenseID(InternationalLicenseID, ref ApplicationID, ref DriverID,
       ref IssuedUsingLocalLicenseID, ref IssueDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID))
            {
                return new clsInternationalLicense(InternationalLicenseID, ApplicationID, DriverID,
       IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID);
            }
            else
                return null;
        }

        public static clsInternationalLicense FindByInternationalApplicationID(int ApplicationID)
        {
            int InternationalLicenseID = -1, DriverID = -1, IssuedUsingLocalLicenseID = -1, CreatedByUserID = -1;
            DateTime IssueDate = DateTime.Now, ExpirationDate = DateTime.Now;
            bool IsActive = false;


            if (clsDVLDDataAccess.GetInternationalLicenseInfoByApplicationID(ref InternationalLicenseID, ApplicationID, ref DriverID,
       ref IssuedUsingLocalLicenseID, ref IssueDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID))
            {
                return new clsInternationalLicense(InternationalLicenseID, ApplicationID, DriverID,
       IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID);
            }
            else
                return null;
        }

        public static clsInternationalLicense FindByInternationalDriverID(int DriverID)
        {
            int InternationalLicenseID = -1, ApplicationID = -1, IssuedUsingLocalLicenseID = -1, CreatedByUserID = -1;
            DateTime IssueDate = DateTime.Now, ExpirationDate = DateTime.Now;
            bool IsActive = false;


            if (clsDVLDDataAccess.GetInternationalLicenseInfoByDriverID(ref InternationalLicenseID, ref ApplicationID, DriverID,
       ref IssuedUsingLocalLicenseID, ref IssueDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID))
            {
                return new clsInternationalLicense(InternationalLicenseID, ApplicationID, DriverID,
       IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID);
            }
            else
                return null;
        }

        public static clsInternationalLicense FindByInternationalLocalLicenseID(int IssuedUsingLocalLicenseID)
        {
            int InternationalLicenseID = -1, ApplicationID = -1, DriverID = -1, CreatedByUserID = -1;
            DateTime IssueDate = DateTime.Now, ExpirationDate = DateTime.Now;
            bool IsActive = false;


            if (clsDVLDDataAccess.GetInternationalLicenseInfoByLocalLicenseID(ref InternationalLicenseID, ref ApplicationID, ref DriverID,
       IssuedUsingLocalLicenseID, ref IssueDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID))
            {
                return new clsInternationalLicense(InternationalLicenseID, ApplicationID, DriverID,
       IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID);
            }
            else
                return null;
        }


        public static DataTable GetAllInternationalLicenses()
        {
            DataTable DT = clsDVLDDataAccess.GetAllInternationalLicenses();
            return DT;
        }

        public static DataTable GetAlInternationalLicensesByDriverID(int DriverID)
        {
            DataTable DT = clsDVLDDataAccess.GetAlInternationalLicensesByDriverID(DriverID);
            return DT;
        }

        public static DataTable GetAlInternationalLicensesByInternationalLicenseID(int InternationalLicenseID)
        {
            DataTable DT = clsDVLDDataAccess.GetAlInternationalLicensesByInternationalLicenseID(InternationalLicenseID);
            return DT;
        }

        public static DataTable GetAlInternationalLicensesByInternationalApplicationID(int ApplicationID)
        {
            DataTable DT = clsDVLDDataAccess.GetAlInternationalLicensesByInternationalApplicationID(ApplicationID);
            return DT;
        }

        public static DataTable GetAlInternationalLicensesByLocalLicenseID(int LocalLicenseID)
        {
            DataTable DT = clsDVLDDataAccess.GetAlInternationalLicensesByLocalLicenseID(LocalLicenseID);
            return DT;
        }


        public static DataTable GetAlInternationalLicensesByIsActive(bool IsActive)
        {
            DataTable DT = clsDVLDDataAccess.GetAlInternationalLicensesByIsActive(IsActive);
            return DT;
        }


        public static DataTable GetBlankInternationalLicensesTable()
        {
            DataTable DT = clsDVLDDataAccess.GetAllInternationalLicenses();
            DT.Rows.Clear();
            return DT;
        }

        public static int GetNumberOfInternationalLicenses()
        {
            return clsDVLDDataAccess.GetNumberOfInternationalLicenses();
        }

        public static bool DeleteDetainedInternationalLicense(int InternationalLicenseID)
        {
            return (clsDVLDDataAccess.DeleteDetainedInternationalLicense(InternationalLicenseID));
        }

        public static bool DoesIntLicenceExistByLicence(int LicenseID)
        {
            return (clsDVLDDataAccess.DoesIntLicenceExistByLicence(LicenseID));
        }


        public bool Save()
        {
            switch (mode)
            {
                case Mode.eAddNew:
                    {
                        if (_AddNewInternationalLicense())
                        {
                            mode = Mode.eUpdate;
                            return true;
                        }
                        else
                            return false;

                    }
                case Mode.eUpdate:

                    return _UpdateInternationalLicense();

            }

            return false;
        }

    }
}
