using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsLDLApplication
    {

        enum Mode { eAddNew = 0, eUpdate = 1 }

        Mode mode = Mode.eAddNew;

        public int LocalDrivingLicenseApplicationID { get; set; }

        public int ApplicationID { get; set; }

        public int LicenseClassID { get; set; }


        public clsLDLApplication()
        {
            LocalDrivingLicenseApplicationID = -1;
            ApplicationID = -1;
            LicenseClassID = -1;
            
            mode = Mode.eAddNew;
        }


        private clsLDLApplication(int LocalDrivingLicenseApplicationID, int ApplicationID, int LicenseClassID)
        {
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.ApplicationID = ApplicationID;
            this.LicenseClassID = LicenseClassID;         
            mode = Mode.eUpdate;

        }


        bool _AddNewLDLApplication()
        {
            return (clsDVLDDataAccess.AddNewLDLApplication(this.ApplicationID,
           this.LicenseClassID) > -1);
        }

        bool _UpdateLDLApplication()
        {
            return (clsDVLDDataAccess.UpdateLDLApplicationInfo(this.LocalDrivingLicenseApplicationID, this.ApplicationID,
           this.LicenseClassID));
        }


        public static clsLDLApplication FindByLDLAppID(int LocalDrivingLicenseApplicationID)
        {
            int ApplicationID = -1, LicenseClassID = -1;

            if (clsDVLDDataAccess.GetLDLApplicationInfoByID(LocalDrivingLicenseApplicationID,
                ref ApplicationID, ref LicenseClassID))
            {
                return new clsLDLApplication(LocalDrivingLicenseApplicationID, ApplicationID, LicenseClassID);
            }
            else
                return null;
        }

        public static clsLDLApplication FindByMainAppID(int ApplicationID)
        {
            int LocalDrivingLicenseApplicationID = -1, LicenseClassID = -1;

            if (clsDVLDDataAccess.GetLDLApplicationInfoByAppID(ref LocalDrivingLicenseApplicationID,
                 ApplicationID, ref LicenseClassID))
            {
                return new clsLDLApplication(LocalDrivingLicenseApplicationID, ApplicationID, LicenseClassID);
            }
            else
                return null;
        }

        public static DataTable GetAllLocalDrivingLicenseApplications()
        {
            DataTable DT = clsDVLDDataAccess.GetAllLocalDrivingLicenseApplications();
            return DT;
        }

        public static DataTable GetAllLDLAppsByLDLAppID(int LDLAppID)
        {
            DataTable DT = clsDVLDDataAccess.GetAllLocalDrivingeByLDLAppID(LDLAppID);
            return DT;
        }


        public static DataTable GetAllLocalDrivingLicenseApplicationsBlankTable()
        {
            DataTable DT = clsDVLDDataAccess.GetAllLocalDrivingLicenseApplications();
            DT.Rows.Clear();
            return DT;
        }

        public static DataTable GetAllLDLAppsColumnNameDataStartsWith(string ColumnName, string PartialColumnData)
        {
            DataTable DT = clsDVLDDataAccess.GetAllLDLApplicationColumnNameDataStartsWith(ColumnName, PartialColumnData);
            return DT;
        }

        public static DataTable GetAllLDLApplicationByPersonFullNameDataStartsWith(string PartialFullName)
        {
            DataTable DT = clsDVLDDataAccess.GetAllLDLApplicationByPersonFullNameDataStartsWith(PartialFullName);
            return DT;
        }

        public static DataTable GetAllLDLApplicationByPersonID(int PersonID)
        {
            DataTable DT = clsDVLDDataAccess.GetAllLocalDrivingeByApplicantPersonID(PersonID);
            return DT;
        }


        public static void ChangeLDLAppStatus(clsLDLApplication LDLApp, byte Status)
        {
            clsApplication MainApp = clsApplication.Find(LDLApp.ApplicationID);
            MainApp.ApplicationStatus = Status;
            MainApp.Save();
        }


        public static int GetNumberOfLocalDrivingLicenseApplications()
        {
            return clsDVLDDataAccess.GetNumberOfLocalDrivingLicenseApplications();
        }

        public static bool DeleteLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID)
        {
            return (clsDVLDDataAccess.DeleteLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID));
        }

        public static bool DoesPersonHaveActiveLicence(int ApplicatntPersonID, int LicenseClassID)
        {
            return (clsDVLDDataAccess.DoesPersonHaveActiveLicence(ApplicatntPersonID, LicenseClassID));
        }

        public static bool DoesPersonHaveActiveLDLApp(int ApplicatntPersonID, int LicenseClassID)
        {
            return (clsDVLDDataAccess.DoesPersonHaveActiveLDLApp(ApplicatntPersonID, LicenseClassID));
        }

        public bool Save()
        {
            switch (mode)
            {
                case Mode.eAddNew:
                    {
                        if (_AddNewLDLApplication())
                        {
                            mode = Mode.eUpdate;
                            return true;
                        }
                        else
                            return false;

                    }
                case Mode.eUpdate:

                    return _UpdateLDLApplication();

            }

            return false;
        }


    }
}
