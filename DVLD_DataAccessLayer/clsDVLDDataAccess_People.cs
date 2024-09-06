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

        //People Code

        public static bool GetPersonInfoByID(int PersonID, ref string NationalNo, ref string FirstName,
            ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth,
            ref byte Gender, ref string Address, ref string Phone, ref string Email,
            ref int NationalityCountryID, ref string ImagePath)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDVLDDataSettings.ConnectionString);

            string Query = "SELECT * FROM People WHERE PersonID = @PersonID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    NationalNo = (string)Reader["NationalNo"];
                    FirstName = (string)Reader["FirstName"];
                    SecondName = (string)Reader["SecondName"];
                    ThirdName = (string)Reader["ThirdName"];
                    LastName = (string)Reader["LastName"];
                    DateOfBirth = (DateTime)Reader["DateOfBirth"];
                    Gender = (byte)Reader["Gender"];
                    Address = (string)Reader["Address"];
                    Phone = (string)Reader["Phone"];
                    Email = (string)Reader["Email"];
                    NationalityCountryID = (int)Reader["NationalityCountryID"];

                    if (Reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)Reader["ImagePath"];
                    }




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

        public static bool GetPersonInfoByNationalNum(ref int PersonID, string NationalNo, ref string FirstName,
            ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth,
            ref byte Gender, ref string Address, ref string Phone, ref string Email,
            ref int NationalityCountryID, ref string ImagePath)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDVLDDataSettings.ConnectionString);

            string Query = "SELECT * FROM People WHERE NationalNo = @NationalNo";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    PersonID = (int)Reader["PersonID"];
                    FirstName = (string)Reader["FirstName"];
                    SecondName = (string)Reader["SecondName"];
                    ThirdName = (string)Reader["ThirdName"];
                    LastName = (string)Reader["LastName"];
                    DateOfBirth = (DateTime)Reader["DateOfBirth"];
                    Gender = (byte)Reader["Gender"];
                    Address = (string)Reader["Address"];
                    Phone = (string)Reader["Phone"];
                    Email = (string)Reader["Email"];
                    NationalityCountryID = (int)Reader["NationalityCountryID"];

                    if (Reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)Reader["ImagePath"];
                    }
                    ImagePath = (string)Reader["ImagePath"];




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

        public static int AddNewPerson(string NationalNo, string FirstName,
            string SecondName, string ThirdName, string LastName, DateTime DateOfBirth,
            byte Gender, string Address, string Phone, string Email,
            int NationalityCountryID, string ImagePath)
        {
            int PersonID = -1;

            SqlConnection connection = new SqlConnection(clsDVLDDataSettings.ConnectionString);

            string Query = @"INSERT INTO People (NationalNo, FirstName,
                             SecondName, ThirdName, LastName, DateOfBirth,
                             Gender, Address, Phone, Email,
                             NationalityCountryID, ImagePath)

                             VALUES (@NationalNo, @FirstName,
                             @SecondName, @ThirdName, @LastName, @DateOfBirth,
                             @Gender, @Address, @Phone, @Email,
                             @NationalityCountryID, @ImagePath)

                              SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@NationalNo", NationalNo);


            Command.Parameters.AddWithValue("@FirstName", FirstName);

            Command.Parameters.AddWithValue("@SecondName", SecondName);

            if (ThirdName != null)
                Command.Parameters.AddWithValue("@ThirdName", ThirdName);
            else
                Command.Parameters.AddWithValue("@ThirdName", DBNull.Value);

            Command.Parameters.AddWithValue("@LastName", LastName);


            Command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);

            Command.Parameters.AddWithValue("@Gender", Gender);

            Command.Parameters.AddWithValue("@Address", Address);

            Command.Parameters.AddWithValue("@Phone", Phone);


            if (Email != null)
                Command.Parameters.AddWithValue("@Email", Email);
            else
                Command.Parameters.AddWithValue("@Email", DBNull.Value);

            Command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

            if (ImagePath != null)
                Command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                Command.Parameters.AddWithValue("@ImagePath", DBNull.Value);


            try
            {
                connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    PersonID = InsertedID;
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


            return PersonID;

        }


        public static bool UpdatePersonInfo(int PersonID, string NationalNo, string FirstName,
            string SecondName, string ThirdName, string LastName, DateTime DateOfBirth,
            byte Gender, string Address, string Phone, string Email,
            int NationalityCountryID, string ImagePath)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDVLDDataSettings.ConnectionString);

            string Query = @"UPDATE People 
                             SET NationalNo = @NationalNo,
                                 FirstName = @FirstName,
                                 SecondName = @SecondName,
                                 ThirdName = @ThirdName,
                                 LastName = @LastName,
                                 DateOfBirth = @DateOfBirth,
                                 Gender = @Gender,
                                 Address = @Address,
                                 Phone = @Phone,
                                 Email = @Email,
                                 NationalityCountryID = @NationalityCountryID,
                                 ImagePath = @ImagePath
                                 WHERE PersonID = @PersonID";


            SqlCommand Command = new SqlCommand(Query, connection);


            Command.Parameters.AddWithValue("@PersonID", PersonID);

            Command.Parameters.AddWithValue("@NationalNo", NationalNo);


            Command.Parameters.AddWithValue("@FirstName", FirstName);

            Command.Parameters.AddWithValue("@SecondName", SecondName);

            if (ThirdName != null)
                Command.Parameters.AddWithValue("@ThirdName", ThirdName);
            else
                Command.Parameters.AddWithValue("@ThirdName", DBNull.Value);

            Command.Parameters.AddWithValue("@LastName", LastName);


            Command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);

            Command.Parameters.AddWithValue("@Gender", Gender);

            Command.Parameters.AddWithValue("@Address", Address);

            Command.Parameters.AddWithValue("@Phone", Phone);


            if (Email != null)
                Command.Parameters.AddWithValue("@Email", Email);
            else
                Command.Parameters.AddWithValue("@Email", DBNull.Value);

            Command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

            if (ImagePath != null)
                Command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                Command.Parameters.AddWithValue("@ImagePath", DBNull.Value);

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

        public static DataTable GetAllPeople()
        {
            DataTable DT = new DataTable();

            SqlConnection connection = new SqlConnection(clsDVLDDataSettings.ConnectionString);

            string Query = @"SELECT * FROM People";

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

        public static DataTable GetAllPeopleByGender(int Gender)
        {
            DataTable DT = new DataTable();

            SqlConnection connection = new SqlConnection(clsDVLDDataSettings.ConnectionString);

            string Query = @"SELECT * FROM People Where Gender = @Gender";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@Gender", Gender);

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

        public static DataTable GetAllPeopleByNationalityCountryID(int NationalityCountryID)
        {
            DataTable DT = new DataTable();

            SqlConnection connection = new SqlConnection(clsDVLDDataSettings.ConnectionString);

            string Query = @"SELECT * FROM People Where NationalityCountryID = @NationalityCountryID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

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

        public static DataTable GetAllPeopleByPersonID(int PersonID)
        {
            DataTable DT = new DataTable();

            SqlConnection connection = new SqlConnection(clsDVLDDataSettings.ConnectionString);

            string Query = @"SELECT * FROM People Where PersonID = @PersonID";

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


        public static int GetNumberOfPeople()
        {
            int NumberOfPeople = -1;

            SqlConnection connection = new SqlConnection(clsDVLDDataSettings.ConnectionString);

            string Query = "SELECT Count(*) FROM People WHERE PersonID is not null";

            SqlCommand Command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int AcualNumOfPeople))
                {
                    NumberOfPeople = AcualNumOfPeople;
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

            return NumberOfPeople;
        }

        public static int GetNumberOfPeopleByGender(byte Gender)
        {
            int NumberOfPeople = -1;

            SqlConnection connection = new SqlConnection(clsDVLDDataSettings.ConnectionString);

            string Query = "select count(*) from people where Gender = @Gender";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@Gender", Gender);


            try
            {
                connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int AcualNumOfPeople))
                {
                    NumberOfPeople = AcualNumOfPeople;
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

            return NumberOfPeople;
        }


        public static bool DeletePerson(int LicenseID)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDVLDDataSettings.ConnectionString);

            string Query = "DELETE People WHERE PersonID = @PersonID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@PersonID", LicenseID);


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

        public static bool DoesPersonExist(int LicenseID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDVLDDataSettings.ConnectionString);

            string Query = "SELECT Found=1 FROM People WHERE PersonID = @PersonID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@PersonID", LicenseID);


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

        public static DataTable GetAllPeopleColumnNameDataStartsWith(string ColumnName, string PartialColumnData)
        {
            DataTable DT = new DataTable();

            SqlConnection connection = new SqlConnection(clsDVLDDataSettings.ConnectionString);

            string Query = $"SELECT * FROM People WHERE {ColumnName} LIKE '{PartialColumnData}%'";

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

        public static DataTable GetAllPeopleFullNameStartsWith(string PartialFullName)
        {
            DataTable DT = new DataTable();

            SqlConnection connection = new SqlConnection(clsDVLDDataSettings.ConnectionString);

            string Query = $"select * from People where FirstName + ' ' +  SecondName + ' ' + ThirdName + ' ' + LastName like '{PartialFullName}%'";

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
