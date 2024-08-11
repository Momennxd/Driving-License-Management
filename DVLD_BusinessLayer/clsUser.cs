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
    public class clsUser
    {
        enum Mode { eAddNew = 0, eUpdate = 1 }

        Mode mode = Mode.eAddNew;

        public int UserID { get; set; }

        public int PersonID { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public bool IsActive { get; set; }


        public clsUser()
        {
            UserID = -1;
            PersonID = -1;
            UserName = "";
            Password = "";
            IsActive = false;         
            mode = Mode.eAddNew;
        }

        private clsUser(int UserID, int PersonID, string UserName, string Password, bool IsActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;
            mode = Mode.eUpdate;
        }

        bool _AddNewUser()
        {
            return (clsDVLDDataAccess.AddNewUser(this.PersonID, this.UserName,
            this.Password, this.IsActive) > -1);
        }

        bool _UpdateUser()
        {
            return (clsDVLDDataAccess.UpdateUserInfo(this.UserID, this.PersonID, this.UserName,
            this.Password, this.IsActive));
        }

        public static clsUser FindByUserID(int UserID)
        {
            bool IsActive = false; int PersonID = -1;
            string UserName = "", Password = "";


            if (clsDVLDDataAccess.GetUserInfoByID(UserID, ref PersonID, ref UserName, ref Password, ref IsActive))
            {
                return new clsUser(UserID, PersonID, UserName, Password, IsActive);
            }
            else
                return null;
        }

        public static clsUser FindByPersonID(int PersonID)
        {
            bool IsActive = false; int UserID = -1;
            string UserName = "", Password = "";


            if (clsDVLDDataAccess.GetUserInfoByPersonID(ref UserID, PersonID, ref UserName, ref Password, ref IsActive))
            {
                return new clsUser(UserID, PersonID, UserName, Password, IsActive);
            }
            else
                return null;
        }

        public static clsUser FindByUserName(string UserName)
        {
            bool IsActive = false; int UserID = -1, PersonID = -1;
            string Password = "";


            if (clsDVLDDataAccess.GetUserInfoByUserName(ref UserID, ref PersonID, UserName, ref Password, ref IsActive))
            {
                return new clsUser(UserID, PersonID, UserName, Password, IsActive);
            }
            else
                return null;
        }


        public static DataTable GetAllUsers()
        {
            DataTable DT = clsDVLDDataAccess.GetAllUsers();
            return DT;
        }

        public static DataTable GetAllUsersByActivity(bool IsActive)
        {
            DataTable DT = clsDVLDDataAccess.GetAllUsersByUserActivity(IsActive);
            return DT;
        }


        public static DataTable GetBlankUsersTable()
        {
            DataTable DT = clsDVLDDataAccess.GetAllUsers();
            DT.Rows.Clear();
            return DT;
        }

        public static DataTable GetAllUsersByUserID(int UserID)
        {
            DataTable DT = clsDVLDDataAccess.GetAllUsersByUserID(UserID);
            return DT;
        }

        public static DataTable GetAllUsersByPersonID(int PersonID)
        {
            DataTable DT = clsDVLDDataAccess.GetAllUsersByPersonID(PersonID);
            return DT;
        }

        public static int GetNumberOfUsers()
        {
            return clsDVLDDataAccess.GetNumberOfUsers();
        }

        public static int GetNumberOfUsers(bool IsActive)
        {
            return clsDVLDDataAccess.GetNumberOfUsersByActive(IsActive);
        }

        public static bool DeleteUser(int UserID)
        {
            return (clsDVLDDataAccess.DeleteUser(UserID));
        }

        public static bool DoesUserExist(int UserID)
        {
            return (clsDVLDDataAccess.DoesUserExist(UserID));
        }

        public static bool IsUserActive(int UserID)
        {
            return (clsDVLDDataAccess.IsUserActive(UserID));
        }

        public static DataTable GetAllUsersColumnNameDataStartsWith(string ColumnName, string PartialColumnData)
        {
            DataTable DT = clsDVLDDataAccess.GetAllUsersColumnNameDataStartsWith(ColumnName, PartialColumnData);
            return DT;
        }

        public bool Save()
        {
            switch (mode)
            {
                case Mode.eAddNew:
                    {
                        if (_AddNewUser())
                        {
                            mode = Mode.eUpdate;
                            return true;
                        }
                        else
                            return false;

                    }
                case Mode.eUpdate:

                    return _UpdateUser();

            }

            return false;
        }



    }
}
