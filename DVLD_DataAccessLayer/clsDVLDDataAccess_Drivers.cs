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

        //Drivers Code

        public static bool GetDriverInfoByDriverID(int DriverID, ref int PersonID, ref int CreatedByUserID,
            ref DateTime CreatedDate)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDVLDDataSettings.ConnectionString);

            string Query = "SELECT * FROM Drivers WHERE DriverID = @DriverID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    PersonID = (int)Reader["PersonID"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
                    CreatedDate = (DateTime)Reader["CreatedDate"];


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

        public static bool GetDriverInfoByPersonID(ref int DriverID, int PersonID, ref int CreatedByUserID,
           ref DateTime CreatedDate)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDVLDDataSettings.ConnectionString);

            string Query = "SELECT * FROM Drivers WHERE PersonID = @PersonID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    DriverID = (int)Reader["DriverID"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
                    CreatedDate = (DateTime)Reader["CreatedDate"];


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

        public static int AddNewDriver(int PersonID, int CreatedByUserID,
           DateTime CreatedDate)
        {
            int DriverID = -1;

            SqlConnection connection = new SqlConnection(clsDVLDDataSettings.ConnectionString);

            string Query = @"INSERT INTO Drivers (PersonID, CreatedByUserID,
                             CreatedDate)

                             VALUES (@PersonID, @CreatedByUserID,
                             @CreatedDate)
                              SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);

            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            Command.Parameters.AddWithValue("@CreatedDate", CreatedDate);


            try
            {
                connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    DriverID = InsertedID;
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


            return DriverID;

        }


        public static bool UpdateDriverInfo(int DriverID, int PersonID, int CreatedByUserID,
           DateTime CreatedDate)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDVLDDataSettings.ConnectionString);

            string Query = @"UPDATE Drivers 
                             SET PersonID = @PersonID,
                                 CreatedByUserID = @CreatedByUserID,
                                 CreatedDate = @CreatedDate                            
                                 WHERE DriverID = @DriverID";


            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@DriverID", DriverID);

            Command.Parameters.AddWithValue("@PersonID", PersonID);

            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            Command.Parameters.AddWithValue("@CreatedDate", CreatedDate);

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


        public static DataTable GetAllDrivers()
        {
            DataTable DT = new DataTable();

            SqlConnection connection = new SqlConnection(clsDVLDDataSettings.ConnectionString);

            string Query = @"SELECT * FROM Drivers";

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

        public static DataTable GetAllDriversByDriverID(int DriverID)
        {
            DataTable DT = new DataTable();

            SqlConnection connection = new SqlConnection(clsDVLDDataSettings.ConnectionString);

            string Query = @"SELECT * FROM Drivers Where DriverID = @DriverID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@DriverID", DriverID);

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

        public static DataTable GetAllDriversByPersonID(int PersonID)
        {
            DataTable DT = new DataTable();

            SqlConnection connection = new SqlConnection(clsDVLDDataSettings.ConnectionString);

            string Query = @"SELECT * FROM Drivers Where PersonID = @PersonID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);

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

        public static int GetNumberOfDrivers()
        {
            int NumberOfDrivers = -1;

            SqlConnection connection = new SqlConnection(clsDVLDDataSettings.ConnectionString);

            string Query = "SELECT Count(*) FROM Drivers WHERE DriverID is not null";

            SqlCommand Command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int AcualNumOfDrivers))
                {
                    NumberOfDrivers = AcualNumOfDrivers;
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

            return NumberOfDrivers;
        }

        public static int GetNumberOfDriversByGender(byte Gender)
        {
            int NumberOfDrivers = -1;

            SqlConnection connection = new SqlConnection(clsDVLDDataSettings.ConnectionString);

            string Query = $@"SELECT        count(*)
                            FROM            Drivers INNER JOIN
                         People ON Drivers.PersonID = People.PersonID where Gender = @Gender";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@Gender", Gender);


            try
            {
                connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int AcualNumOfDrivers))
                {
                    NumberOfDrivers = AcualNumOfDrivers;
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

            return NumberOfDrivers;
        }


        public static bool DoesDriverExist(int DriverID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDVLDDataSettings.ConnectionString);

            string Query = "SELECT Found=1 FROM Drivers WHERE DriverID = @DriverID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@DriverID", DriverID);


            try
            {
                connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null)
                {
                    IsFound = true;
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

            return IsFound;
        }

        public static bool DeleteDriver(int DriverID)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDVLDDataSettings.ConnectionString);

            string Query = "DELETE Drivers WHERE DriverID = @DriverID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@DriverID", DriverID);


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


        public static DataTable GetAllDriversColumnNameDataStartsWith(string ColumnName, string PartialColumnData)
        {
            DataTable DT = new DataTable();

            SqlConnection connection = new SqlConnection(clsDVLDDataSettings.ConnectionString);

            string Query = $@"SELECT        Drivers.*
                              FROM    People INNER JOIN
                              Drivers ON People.PersonID = Drivers.PersonID where
                              {ColumnName} like '{PartialColumnData}%'";

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

        public static DataTable GetAllDriversByPersonFullNameDataStartsWith(string PartialFullName)
        {
            DataTable DT = new DataTable();

            SqlConnection connection = new SqlConnection(clsDVLDDataSettings.ConnectionString);

            string Query = $@"SELECT Drivers.*
                               FROM   Drivers INNER JOIN
                               People ON Drivers.PersonID =
                               People.PersonID where People.FirstName + ' ' +
                               SecondName + ' ' + ThirdName + ' ' + LastName
                               like '{PartialFullName}%'";

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



    }
}
