using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsApplicationType
    {
      
        public int ApplicationTypeID { get; set; }

        public string ApplicationTypeTitle { get; set; }

        public decimal ApplicationFees { get; set; }

        private clsApplicationType(int ApplicationTypeID, string ApplicationTypeTitle, decimal ApplicationFees)
        {
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationTypeTitle = ApplicationTypeTitle;
            this.ApplicationFees = ApplicationFees;
        }

        bool _UpdateAppType()
        {
            return (clsDVLDDataAccess.UpdateAppTypeInfo(this.ApplicationTypeID, this.ApplicationTypeTitle, this.ApplicationFees));
        }

        public static clsApplicationType Find(int ApplicationTypeID)
        {
            string ApplicationTypeTitle = "";
            decimal ApplicationFees = 0;



            if (clsDVLDDataAccess.GetAppTypeInfoByID(ApplicationTypeID, ref ApplicationTypeTitle, ref ApplicationFees))
            {
                return new clsApplicationType(ApplicationTypeID, ApplicationTypeTitle, ApplicationFees);
            }
            else
                return null;
        }

        public static DataTable GetAllAppTypes()
        {
            DataTable DT = clsDVLDDataAccess.GetAllAppTypes();
            return DT;
        }

        public bool Save()
        {
            return _UpdateAppType();
        }

    }
}
