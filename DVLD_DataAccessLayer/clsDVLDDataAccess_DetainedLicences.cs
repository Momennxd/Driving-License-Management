using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccessLayer
{
    public partial class clsDVLDDataAccess
    {

        //Detained Licences

        public static bool GetDetainedLicenceInfoByDetainID(int DetainID, ref int LicenseID, ref DateTime DetainDate,
          ref decimal FineFees, ref int CreatedByUserID, ref bool IsReleased, ref DateTime? ReleaseDate,
          ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDVLDDataSettings.ConnectionString);

            string Query = "SELECT * FROM DetainedLicenses WHERE DetainID = @DetainID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@DetainID", DetainID);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    LicenseID = (int)Reader["LicenseID"];
                    DetainDate = (DateTime)Reader["DetainDate"];
                    FineFees = (decimal)Reader["FineFees"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
                    IsReleased = (bool)Reader["IsReleased"];
                    ReleaseDate = (DateTime)Reader["ReleaseDate"];
                    ReleasedByUserID = (int)Reader["ReleasedByUserID"];
                    ReleaseApplicationID = (int)Reader["ReleaseApplicationID"];
                    

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

        public static bool GetDetainedLicenceInfoByLicenceID(ref int DetainID, int LicenseID, ref DateTime DetainDate,
          ref decimal FineFees, ref int CreatedByUserID, ref bool IsReleased, ref DateTime? ReleaseDate,
          ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDVLDDataSettings.ConnectionString);

            string Query = "SELECT * FROM DetainedLicenses WHERE LicenseID = @LicenseID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    DetainID = (int)Reader["DetainID"];
                    DetainDate = (DateTime)Reader["DetainDate"];
                    FineFees = (decimal)Reader["FineFees"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
                    IsReleased = (bool)Reader["IsReleased"];
                    ReleaseDate = (DateTime)Reader["ReleaseDate"];
                    ReleasedByUserID = (int)Reader["ReleasedByUserID"];
                    ReleaseApplicationID = (int)Reader["ReleaseApplicationID"];


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


        public static bool GetUnReleasedDetainedLicenceInfoByLicenceID(ref int DetainID, int LicenseID, ref DateTime DetainDate,
         ref decimal FineFees, ref int CreatedByUserID, ref bool IsReleased, ref DateTime? ReleaseDate,
         ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDVLDDataSettings.ConnectionString);

            string Query = "SELECT * FROM DetainedLicenses WHERE LicenseID = @LicenseID and IsReleased = 0";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    DetainID = (int)Reader["DetainID"];
                    DetainDate = (DateTime)Reader["DetainDate"];
                    FineFees = (decimal)Reader["FineFees"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
                    IsReleased = (bool)Reader["IsReleased"];
                    ReleaseDate = (DateTime)Reader["ReleaseDate"];
                    ReleasedByUserID = (int)Reader["ReleasedByUserID"];
                    ReleaseApplicationID = (int)Reader["ReleaseApplicationID"];


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

        public static int AddNewDetainLicence(int LicenseID, DateTime DetainDate,
          decimal FineFees, int CreatedByUserID, bool IsReleased, DateTime? ReleaseDate,
          int ReleasedByUserID, int ReleaseApplicationID)
        {
            int DetainID = -1;

            SqlConnection connection = new SqlConnection(clsDVLDDataSettings.ConnectionString);

            string Query = @"INSERT INTO DetainedLicenses (LicenseID, DetainDate,
                             FineFees, CreatedByUserID, IsReleased, ReleaseDate,
                             ReleasedByUserID, ReleaseApplicationID)

                             VALUES (@LicenseID, @DetainDate,
                             @FineFees, @CreatedByUserID, @IsReleased, @ReleaseDate,
                             @ReleasedByUserID, @ReleaseApplicationID)

                              SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@LicenseID", LicenseID);

            Command.Parameters.AddWithValue("@DetainDate", DetainDate);

            Command.Parameters.AddWithValue("@FineFees", FineFees);

            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            Command.Parameters.AddWithValue("@IsReleased", IsReleased);        

            if (ReleaseDate != null)
                Command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
            else
                Command.Parameters.AddWithValue("@ReleaseDate", DBNull.Value);

            if (ReleasedByUserID != -1)
                Command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            else
                Command.Parameters.AddWithValue("@ReleasedByUserID", DBNull.Value);

            if (ReleaseApplicationID != -1)
                Command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
            else
                Command.Parameters.AddWithValue("@ReleaseApplicationID", DBNull.Value);

            try
            {
                connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    DetainID = InsertedID;
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


            return DetainID;

        }

        public static bool UpdateDetainedLicenceInfo(int DetainID, int LicenseID, DateTime DetainDate,
          decimal FineFees, int CreatedByUserID, bool IsReleased, DateTime? ReleaseDate,
          int ReleasedByUserID, int ReleaseApplicationID)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDVLDDataSettings.ConnectionString);

            string Query = @"UPDATE DetainedLicenses 
                             SET LicenseID = @LicenseID,
                                 DetainDate = @DetainDate,
                                 FineFees = @FineFees,
                                 CreatedByUserID = @CreatedByUserID,
                                 IsReleased = @IsReleased,
                                 ReleaseDate = @ReleaseDate,
                                 ReleasedByUserID = @ReleasedByUserID,
                                 ReleaseApplicationID = @ReleaseApplicationID                                                     
                                 WHERE DetainID = @DetainID";


            SqlCommand Command = new SqlCommand(Query, connection);


            Command.Parameters.AddWithValue("@DetainID", DetainID);

            Command.Parameters.AddWithValue("@LicenseID", LicenseID);

            Command.Parameters.AddWithValue("@DetainDate", DetainDate);

            Command.Parameters.AddWithValue("@FineFees", FineFees);

            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            Command.Parameters.AddWithValue("@IsReleased", IsReleased);

            if (ReleaseDate != null)
                Command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
            else
                Command.Parameters.AddWithValue("@ReleaseDate", DBNull.Value);

            if (ReleasedByUserID != -1)
                Command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            else
                Command.Parameters.AddWithValue("@ReleasedByUserID", DBNull.Value);

            if (ReleaseApplicationID != -1)
                Command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
            else
                Command.Parameters.AddWithValue("@ReleaseApplicationID", DBNull.Value);

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

        public static DataTable GetAllDetainedLicenses()
        {
            DataTable DT = new DataTable();

            SqlConnection connection = new SqlConnection(clsDVLDDataSettings.ConnectionString);

            string Query = @"SELECT * FROM DetainedLicenses";

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

        public static DataTable GetAlDetainedLicensesByDetainID(int DetainID)
        {
            DataTable DT = new DataTable();

            SqlConnection connection = new SqlConnection(clsDVLDDataSettings.ConnectionString);

            string Query = @"SELECT * FROM DetainedLicenses Where DetainID = @DetainID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@DetainID", DetainID);

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

        public static DataTable GetAlDetainedLicensesByLicenseID(int LicenseID)
        {
            DataTable DT = new DataTable();

            SqlConnection connection = new SqlConnection(clsDVLDDataSettings.ConnectionString);

            string Query = @"SELECT * FROM DetainedLicenses Where LicenseID = @LicenseID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@LicenseID", LicenseID);

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

        public static DataTable GetAlDetainedLicensesByIsReleased(bool IsReleased)
        {
            DataTable DT = new DataTable();

            SqlConnection connection = new SqlConnection(clsDVLDDataSettings.ConnectionString);

            string Query = @"select * from DetainedLicenses where IsReleased = @IsReleased";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@IsReleased", IsReleased);

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


        public static DataTable GetAlDetainedLicensesByReleaseApplicationID(int ReleaseApplicationID)
        {
            DataTable DT = new DataTable();

            SqlConnection connection = new SqlConnection(clsDVLDDataSettings.ConnectionString);

            string Query = @"SELECT * FROM DetainedLicenses Where ReleaseApplicationID = @ReleaseApplicationID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);

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

        public static int GetNumberOfDetainedLicenses()
        {
            int NumberOfDetainedLicenses = -1;

            SqlConnection connection = new SqlConnection(clsDVLDDataSettings.ConnectionString);

            string Query = "SELECT Count(*) FROM DetainedLicenses WHERE DetainID is not null";

            SqlCommand Command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int AcualNumOfLicenseID))
                {
                    NumberOfDetainedLicenses = AcualNumOfLicenseID;
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

            return NumberOfDetainedLicenses;
        }

        public static bool DeleteDetainedLicenses(int DetainID)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDVLDDataSettings.ConnectionString);

            string Query = "DELETE DetainedLicenses WHERE DetainID = @DetainID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@DetainID", DetainID);


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
