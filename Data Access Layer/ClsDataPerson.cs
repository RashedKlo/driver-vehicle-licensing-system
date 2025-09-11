using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
    //INSERT INTO[dbo].[PeopleID]
    //([NationalNo]
    //  ,[FirstName]
    //  ,[SecondName]
    //  ,[ThirdName]NULL
    //  ,[LastName]
    //  ,[DateOfBirth]
    //  ,[Gender]
    //  ,[Address]
    //  ,[Phone]
    //  ,[Email]NULL
    //  ,[NationalityCountryID]
    //  ,[ImagePath])NULL
namespace DataAccess
{

    public class ClsDataPerson
    {
        static public DataTable GetAllPeople()
        {
            DataTable Table = new DataTable();

            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);

            string Query = "Select * From People";

            SqlCommand Command = new SqlCommand(Query, Connection);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    Table.Load(Reader);
                }
                Reader.Close();
            }
            catch (Exception e)
            {

            }
            finally
            {
                Connection.Close();
            }
            return Table;
        }
        static public bool Delete(int ID)
        {
            int ISDeleted = -1;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);

            string Query = "Delete  From People Where PersonID = @ID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ID", ID);
            try
            {
                Connection.Open();
                ISDeleted = Command.ExecuteNonQuery();

            }
            catch (Exception E)
            {
                string a = E.Message;
            }
            finally
            {
                Connection.Close();
            }
            return (ISDeleted > 0);
        }
        static public bool UpdatePerson(int ID, string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth
      , byte Gender, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            int IsUpdated = -1;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);

            string Query = @"Update   People 
                            Set NationalNo=@NationalNo,
                            FirstName=@FirstName,
                            SecondName=@SecondName,
                            ThirdName=@ThirdName,
                            LastName=@LastName,
                            DateOfBirth=@DateOfBirth,
                            Gender=@Gender,
                            Address=@Address,
                            Phone=@Phone,
                            Email=@Email,
                            NationalityCountryID=@NationalityCountryID,
                            ImagePath=@ImagePath
                            Where PersonID =@ID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ID", ID);
            Command.Parameters.AddWithValue("@NationalNo", NationalNo);
            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@SecondName", SecondName);

            if (ThirdName != string.Empty)
                Command.Parameters.AddWithValue("@ThirdName", ThirdName);
            else
                Command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);

            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            Command.Parameters.AddWithValue("@Gender", Gender);
            Command.Parameters.AddWithValue("@Address", Address);
            Command.Parameters.AddWithValue("@Phone", Phone);
            if (Email != string.Empty)
                Command.Parameters.AddWithValue("@Email", Email);

            else
                Command.Parameters.AddWithValue("@Email", System.DBNull.Value);

            Command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            if (ImagePath !=string.Empty)
                Command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                Command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

            try
            {
                Connection.Open();
                IsUpdated = Command.ExecuteNonQuery();

            }
            catch (Exception E)
            {
                string a = E.Message;
            }
            finally
            {
                Connection.Close();
            }
            return (IsUpdated > 0);

        }
        static public bool IsPersonExistByID(int ID)
        {
            bool isExist = false;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);

            string Query = " Select * From People Where PersonID = @ID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("ID", ID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    isExist = true;
                }
                else
                {
                    isExist = false;
                }
                Reader.Close();
            }
            catch (Exception E)
            {
                isExist = false;
            }
            finally
            {
                Connection.Close();
            }
            return isExist;
        }
        static public bool GetPersonByID(int ID, ref string NationalNo, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName,
            ref DateTime DateOfBirth, ref byte Gender, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool IsExist = false;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);

            string Query = " Select * From People Where PersonID = @ID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ID", ID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    IsExist = true;

                    NationalNo = (string)Reader["NationalNo"];
                    FirstName = (string)Reader["FirstName"];
                    SecondName = (string)Reader["SecondName"];
                    if (Reader["ThirdName"] != System.DBNull.Value)
                        ThirdName = (string)Reader["ThirdName"];

                    else
                        ThirdName = string.Empty;
                    LastName = (string)Reader["LastName"];
                    DateOfBirth = (DateTime)Reader["DateOfBirth"];
                    Gender = (byte)Reader["Gendor"];
                    Address = (string)Reader["Address"];
                    Phone = (string)Reader["Phone"];
                    if (Reader["Email"] != System.DBNull.Value)
                        Email = (string)Reader["Email"];
                    else
                        Email = string.Empty;

                    NationalityCountryID = (int)Reader["NationalityCountryID"];
                    if (Reader["ImagePath"] != System.DBNull.Value)
                        ImagePath = (string)Reader["ImagePath"];
                    else
                        ImagePath = string.Empty;

                }
                else
                {
                    IsExist = false;
                }
                Reader.Close();
            }
            catch (Exception e)
            {
                string FIndTheFalse = e.Message;

                IsExist = false;
            }
            finally
            {
                Connection.Close();
            }
            return IsExist;
        }

        static public bool GetPersonByNationalNo(  string NationalNo,ref int ID, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName,
           ref DateTime DateOfBirth, ref byte Gender, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool IsExist = false;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);

            string Query = " Select * From People Where NationalNo = @NationalNo";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@NationalNo", NationalNo);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    IsExist = true;

                    ID = (int)Reader["PersonID"];
                    FirstName = (string)Reader["FirstName"];
                    SecondName = (string)Reader["SecondName"];
                    if (Reader["ThirdName"] != System.DBNull.Value)
                        ThirdName = (string)Reader["ThirdName"];

                    else
                        ThirdName = string.Empty;
                    LastName = (string)Reader["LastName"];
                    DateOfBirth = (DateTime)Reader["DateOfBirth"];
                    Gender = (byte)Reader["Gender"];//
                    Address = (string)Reader["Address"];
                    Phone = (string)Reader["Phone"];
                    if (Reader["Email"] != System.DBNull.Value)
                        Email = (string)Reader["Email"];
                    else
                        Email = string.Empty;

                    NationalityCountryID = (int)Reader["NationalityCountryID"];
                    if (Reader["ImagePath"] != System.DBNull.Value)
                        ImagePath = (string)Reader["ImagePath"];
                    else
                        ImagePath = string.Empty;

                }
                else
                {
                    IsExist = false;
                }
                Reader.Close();
            }
            catch (Exception e)
            {
                string FIndTheFalse = e.Message;

                IsExist = false;
            }
            finally
            {
                Connection.Close();
            }
            return IsExist;
        }

        static public int AddPerson(string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth
            , int Gender, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {

            int ContactID = -1;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);

            string Query = @"INSERT  INTO People(NationalNo,FirstName,SecondName,ThirdName,LastName,DateOfBirth,Gender,Address,Phone,Email,NationalityCountryID,ImagePath)
Values(@NationalNo,@FirstName,@SecondName,@ThirdName,@LastName,@DateOfBirth,@Gender,@Address,@Phone,@Email,@NationalityCountryID,@ImagePath);Select Scope_IDentity();";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@NationalNo", NationalNo);
            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@SecondName", SecondName);
            if (ThirdName != string.Empty)
                Command.Parameters.AddWithValue("@ThirdName", ThirdName);
            else
                Command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);


            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            Command.Parameters.AddWithValue("@Gender", Gender);
            Command.Parameters.AddWithValue("@Address", Address);
            Command.Parameters.AddWithValue("@Phone", Phone);
            if (Email != string.Empty)
                Command.Parameters.AddWithValue("@Email", Email);
            else
                Command.Parameters.AddWithValue("@Email", System.DBNull.Value);




            Command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            if (ImagePath != string.Empty)
                Command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                Command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

            try
            {

                Connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int Inserted))
                {
                    ContactID = Inserted;
                }

            }
            catch (Exception E)
            {
                string a = E.Message;
            }
            finally
            {
                Connection.Close();
            }
            return ContactID;

        }
        static public bool IsPersonExistByNationalNo(string NationalNo)
        {
            bool isExist = false;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);

            string Query = " Select * From People Where NationalNo = @NationalNo";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@NationalNo", NationalNo);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    isExist = true;
                }
                else
                {
                    isExist = false;
                }
                Reader.Close();
            }
            catch (Exception Ee)
            {
                isExist = false;
            }
            finally
            {
                Connection.Close();
            }
            return isExist;
        }

        public static DataTable GetAllPeopleWithCountry()
        {

            DataTable Table = new DataTable();

            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);

            string Query = @"SELECT People.PersonID, People.NationalNo, People.FirstName, People.SecondName, People.ThirdName, People.LastName, People.Gendor, People.DateOfBirth, Countries.CountryName, People.Phone, People.Address,
                   People.Email
FROM            Countries INNER JOIN
                         People ON Countries.CountryID = People.NationalityCountryID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    Table.Load(Reader);
                }
                Reader.Close();
            }
            catch (Exception e)
            {

            }
            finally
            {
                Connection.Close();
            }
            return Table;
        }

    }
}
