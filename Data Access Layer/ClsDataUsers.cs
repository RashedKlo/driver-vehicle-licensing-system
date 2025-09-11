using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DataAccess
{
   public class ClsDataUsers
    {
//        USE[DVLD]
//GO

//INSERT INTO[dbo].[Users]
//        ([PersonID]
//          ,[UserName]
//          ,[Password]
//          ,[IsActive])
//    VALUES
//          (<PersonID, int,>
//           ,<UserName, nvarchar(20),>
//           ,<Password, nvarchar(20),>
//           ,<IsActive, bit,>)
//GO

        public static bool GetUserByID(int UserID, ref int PersonID,ref string UserName,ref string Password,ref bool IsActive)
        {
            
            bool isExist = false;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);

            string Query = @"Select * From Users Where UserID=@UserID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    isExist = true;
                    PersonID = (int)Reader["PersonID"];
                    UserName = (string)Reader["UserName"];
                    Password = (string)Reader["Password"];
                    IsActive = (bool)Reader["IsActive"];
                }
                else
                {
                    isExist = false;
                }

                Reader.Close();
            }
            catch (Exception E)
            {
                string e = E.Message;
                isExist = false;
            }
            finally
            {
                Connection.Close();
            }
            return isExist;
        }
        public static bool GetUserByUserName(string UserName,ref int UserID, ref int PersonID, ref string Password, ref bool IsActive)
        {

            bool isExist = false;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);

            string Query = @"Select * From Users Where UserName=@UserName";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserName", UserName);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    isExist = true;
                    PersonID = (int)Reader["PersonID"];
                    UserID = (int)Reader["UserID"];
                    Password = (string)Reader["Password"];
                    IsActive = (bool)Reader["IsActive"];
                }
                else
                {
                    isExist = false;
                }

                Reader.Close();
            }
            catch (Exception E)
            {
                string e = E.Message;
                isExist = false;
            }
            finally
            {
                Connection.Close();
            }
            return isExist;
        }
        public static DataTable GetAllUsers()
        {
            DataTable Table = new DataTable();
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);
            string Query = "SELECT Users.UserID, Users.UserName, People.PersonID,  (FirstName + ' ' + SecondName + Case When +ThirdName is Null then ' ' else ' ' + ThirdName End + ' '+LastName ) as FullName,Users.Password, Users.IsActive FROM  People INNER JOIN Users ON People.PersonID = Users.PersonID";
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
        public static bool IsUserNameExist(string UserName)
        {
            bool isfound = false;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);
            string Query = "Select Found=1 From Users Where UserName=@UserName";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    isfound = true;
                }
                else
                {
                    isfound = false;
                }
                Reader.Close();
            }
            catch (Exception e)
            {
                isfound = false;
            }
            finally
            {
                Connection.Close();
            }
            return isfound;

        }
        public static bool IsPersonIDExist(int PersonID)
        {
            bool isfound = false;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);
            string Query = "Select Found=1 From Users Where PersonID=@PersonID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    isfound = true;
                }
                else
                {
                    isfound = false;
                }
                Reader.Close();
            }
            catch (Exception e)
            {
                isfound = false;
            }
            finally
            {
                Connection.Close();
            }
            return isfound;

        }
        static public bool DeleteUser(int UserID)
        {
            int ISDeleted = -1;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);

            string Query = "Delete  From Users Where UserID = @UserID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);
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
        static public bool UpdateUser(int UserID, int PersonID, string UserName,string Password,bool IsActive)
        {
            int IsUpdated = -1;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);

            string Query = @"Update  Users 
                            Set PersonID=@PersonID,
                            UserName=@UserName,
                            Password=@Password,
                            IsActive=@IsActive
                            Where UserID=@UserID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@Password", Password);
            Command.Parameters.AddWithValue("@IsActive", IsActive);
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
            return (IsUpdated > -1);

        }

        static public int AddUser(int PersonID,string UserName,string Password,bool IsActive)
        {

            int ContactID = -1;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);

            string Query = @"INSERT  INTO USERS(PersonID,UserName,Password,IsActive)
Values(@PersonID,@UserName,@Password,@IsActive);Select Scope_IDentity();";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@Password", Password);
            Command.Parameters.AddWithValue("@IsActive", IsActive);
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


    }
}
