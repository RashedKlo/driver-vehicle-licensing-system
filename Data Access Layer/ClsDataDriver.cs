using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DataAccess
{
//    SELECT TOP(1000) [DriverID]
//      ,[PersonID]
//      ,[CreatedByUserID]
//      ,[CreatedDate]
//    FROM[DVLD].[dbo].[Drivers]
    public class ClsDataDriver
    {

        static public int AddDriver( int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {

            int ContactID = -1;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);

            string Query = @"INSERT  INTO Drivers(PersonID,CreatedByUserID,CreatedDate)
Values(@PersonID,@CreatedByUserID,@CreatedDate);Select Scope_IDentity();";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            Command.Parameters.AddWithValue("@CreatedDate", CreatedDate);
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
        public static DataTable GetAllDrivers()
        {
            DataTable Table = new DataTable();
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);
            string Query = "SELECT * From Drivers_View";
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
        public static bool IsDriverExist(int PersonID)
        {
            bool isfound = false;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);
            string Query = "Select Found=1 From Drivers Where PersonID=@PersonID";

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
        public static bool GetDriverByID( int PersonID,ref int DriverID, ref int CreatedByUserID,ref  DateTime CreatedDate)
        {

            bool isExist = false;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);

            string Query = @"Select * From Drivers Where PersonID=@PersonID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    DriverID = (int)Reader["DriverID"];
                    PersonID = (int)Reader["PersonID"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
                    CreatedDate = (DateTime)Reader["CreatedDate"];

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
                string e = E.Message;
                isExist = false;
            }
            finally
            {
                Connection.Close();
            }
            return isExist;
        }
        public static bool GetDriverByDriverID(int DriverID, ref int PersonID, ref int CreatedByUserID, ref DateTime CreatedDate)
        {

            bool isExist = false;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);

            string Query = @"Select * From Drivers Where DriverID=@DriverID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    DriverID = (int)Reader["DriverID"];
                    PersonID = (int)Reader["PersonID"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
                    CreatedDate = (DateTime)Reader["CreatedDate"];

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
                string e = E.Message;
                isExist = false;
            }
            finally
            {
                Connection.Close();
            }
            return isExist;
        }

    }
}
