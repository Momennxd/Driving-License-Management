using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccessLayer
{
    public partial class clsDVLDDataAccess
    {

        //LDLApplication Code.

        public static bool GetLDLApplicationInfoByID(int LocalDrivingLicenseApplicationID, ref int ApplicationID, ref int LicenseClassID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDVLDDataSettings.ConnectionString);

            string Query = "SELECT * FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    ApplicationID = (int)Reader["ApplicationID"];
                    LicenseClassID = (int)Reader["LicenseClassID"];

                }

                Reader.Close();

            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }

            return IsFound;


        }

        public static bool GetLDLApplicationInfoByAppID(ref int LocalDrivingLicenseApplicationID, int ApplicationID, ref int LicenseClassID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDVLDDataSettings.ConnectionString);

            string Query = "SELECT * FROM LocalDrivingLicenseApplications WHERE ApplicationID = @ApplicationID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    LocalDrivingLicenseApplicationID = (int)Reader["LocalDrivingLicenseApplicationID"];
                    LicenseClassID = (int)Reader["LicenseClassID"];

                }

                Reader.Close();

            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }

            return IsFound;


        }

        public static int AddNewLDLApplication(int ApplicationID, int LicenseClassID)
        {
            int LocalDrivingLicenseApplicationID = -1;

            SqlConnection connection = new SqlConnection(clsDVLDDataSettings.ConnectionString);

            string Query = @"INSERT INTO LocalDrivingLicenseApplications (ApplicationID, LicenseClassID)
                             VALUES (@ApplicationID, @LicenseClassID)
                              SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);



            try
            {
                connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    LocalDrivingLicenseApplicationID = InsertedID;
                }

            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }


            return LocalDrivingLicenseApplicationID;

        }

        public static bool UpdateLDLApplicationInfo(int LocalDrivingLicenseApplicationID, int ApplicationID, int LicenseClassID)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDVLDDataSettings.ConnectionString);

            string Query = @"UPDATE LocalDrivingLicenseApplications 
                             SET ApplicationID = @ApplicationID,
                                 LicenseClassID = @LicenseClassID
                                 WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";


            SqlCommand Command = new SqlCommand(Query, connection);


            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);


            try
            {
                connection.Open();
                RowsAffected = Command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

            return (RowsAffected > 0);

        }


        public static DataTable GetAllLocalDrivingLicenseApplications()
        {
            DataTable DT = new DataTable();

            SqlConnection connection = new SqlConnection(clsDVLDDataSettings.ConnectionString);

            string Query = @"SELECT * FROM LocalDrivingLicenseApplications";

            SqlCommand Command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                while (Reader.HasRows)
                {
                    DT.Load(Reader);
                }

                Reader.Close();


            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }

            return DT;
        }

        public static DataTable GetAllLocalDrivingeByLDLAppID(int LocalDrivingLicenseApplicationID)
        {
            DataTable DT = new DataTable();

            SqlConnection connection = new SqlConnection(clsDVLDDataSettings.ConnectionString);

            string Query = @"SELECT * FROM LocalDrivingLicenseApplications Where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                while (Reader.HasRows)
                {
                    DT.Load(Reader);
                }

                Reader.Close();


            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }

            return DT;
        }

        public static DataTable GetAllLocalDrivingeByApplicantPersonID(int ApplicantPersonID)
        {
            DataTable DT = new DataTable();

            SqlConnection connection = new SqlConnection(clsDVLDDataSettings.ConnectionString);

            string Query = $@" SELECT  LocalDrivingLicenseApplications.*
                               FROM Applications INNER JOIN
                               LocalDrivingLicenseApplications ON Applications.ApplicationID =
                               LocalDrivingLicenseApplications.ApplicationID
                               where ApplicantPersonID = @ApplicantPersonID ";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                while (Reader.HasRows)
                {
                    DT.Load(Reader);
                }

                Reader.Close();


            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }

            return DT;
        }

        public static bool DoesPersonHaveActiveLicence(int ApplicantPersonID, int LicenseClassID)
        {
            DataTable DT = new DataTable();

            SqlConnection connection = new SqlConnection(clsDVLDDataSettings.ConnectionString);

            string Query = $@" SELECT      found=1 
                               FROM  Licenses INNER JOIN
                               Applications ON Licenses.ApplicationID =
                               Applications.ApplicationID where IsActive = 1 and LicenseClass = @LicenseClassID
                               and ApplicantPersonID = @ApplicantPersonID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);

            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);


            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                while (Reader.HasRows)
                {
                    DT.Load(Reader);
                }

                Reader.Close();


            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }

            return DT.Rows.Count > 0;
        }

        public static bool DoesPersonHaveActiveLDLApp(int ApplicantPersonID, int LicenseClassID)
        {
            DataTable DT = new DataTable();

            SqlConnection connection = new SqlConnection(clsDVLDDataSettings.ConnectionString);

            string Query = $@" SELECT   found=1
                         FROM    Applications INNER JOIN
                         LocalDrivingLicenseApplications ON Applications.ApplicationID =
                         LocalDrivingLicenseApplications.ApplicationID
						 where ApplicantPersonID = @ApplicantPersonID and
                         LicenseClassID = @LicenseClassID 
                         and Applications.ApplicationStatus = 1";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);

            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);


            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                while (Reader.HasRows)
                {
                    DT.Load(Reader);
                }

                Reader.Close();


            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }

            return DT.Rows.Count > 0;
        }


        public static DataTable GetAllLDLApplicationColumnNameDataStartsWith(string ColumnName, string PartialColumnData)
        {
            DataTable DT = new DataTable();

            SqlConnection connection = new SqlConnection(clsDVLDDataSettings.ConnectionString);

            string Query = $@"SELECT LocalDrivingLicenseApplications.*
                FROM  LocalDrivingLicenseApplications INNER JOIN
                Applications ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID INNER JOIN
                People ON Applications.ApplicantPersonID = People.PersonID where  {ColumnName} like '{PartialColumnData}%';";

            SqlCommand Command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                while (Reader.HasRows)
                {
                    DT.Load(Reader);
                }


                Reader.Close();

            }
            catch (Exception ex)
            {
                //
            }
            finally
            {

                connection.Close();

            }

            return DT;
        }

        public static DataTable GetAllLDLApplicationByPersonFullNameDataStartsWith(string PartialFullName)
        {
            DataTable DT = new DataTable();

            SqlConnection connection = new SqlConnection(clsDVLDDataSettings.ConnectionString);

            string Query = $@"SELECT  LocalDrivingLicenseApplications.*
                FROM   LocalDrivingLicenseApplications INNER JOIN
                Applications ON LocalDrivingLicenseApplications.ApplicationID =
                Applications.ApplicationID INNER JOIN
                People ON Applications.ApplicantPersonID = People.PersonID 
			    where People.FirstName + ' ' + SecondName + ' ' + ThirdName + ' ' + LastName like '{PartialFullName}%'";

            SqlCommand Command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                while (Reader.HasRows)
                {
                    DT.Load(Reader);
                }


                Reader.Close();

            }
            catch (Exception ex)
            {
                //
            }
            finally
            {

                connection.Close();

            }

            return DT;
        }


        public static int GetNumberOfLocalDrivingLicenseApplications()
        {
            int NumberOfLocalDrivingLicenseApplications = -1;

            SqlConnection connection = new SqlConnection(clsDVLDDataSettings.ConnectionString);

            string Query = "SELECT Count(*) FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID is not null";

            SqlCommand Command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int AcualNumOfLocalDrivingLicenseApplications))
                {
                    NumberOfLocalDrivingLicenseApplications = AcualNumOfLocalDrivingLicenseApplications;
                }


            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }

            return NumberOfLocalDrivingLicenseApplications;
        }

        public static bool DeleteLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDVLDDataSettings.ConnectionString);

            string Query = "DELETE LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);


            try
            {
                connection.Open();
                RowsAffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }

            return (RowsAffected > 0);
        }

    }
}
