using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
 //   CREATE TABLE[dbo].[Tests]
 //   (

 //  [TestID][int] IDENTITY(1,1) NOT NULL,

 // [TestAppointmentID] [int]
 //   NOT NULL,

 // [TestResult] [bit]
 //   NOT NULL,

 // [Notes] [nvarchar] (500) NULL,
	//[CreatedByUserID]
 //   [int]
 //   NOT NULL,
   public class ClsDataTests
    {

        static public bool DeleteTest(int TestID)
        {
            int ISDeleted = -1;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);

            string Query = "Delete  From Tests Where TestID = @TestID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestID", TestID);
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
        static public bool UpdateTest(int TestID, int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            int IsUpdated = -1;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);

            string Query = @"Update  Tests 
                            Set TestAppointmentID=@TestAppointmentID,
                            TestResult=@TestResult,
                            Notes=@Notes,
                            CreatedByUserID=@CreatedByUserID
                            Where TestID=@TestID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestID", TestID);
            Command.Parameters.AddWithValue("@TestResult", TestResult);
            Command.Parameters.AddWithValue("@Notes", Notes);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            Command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
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

        static public int AddTest(int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {

            int ContactID = -1;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);

            string Query = @"INSERT  INTO Tests(TestAppointmentID,TestResult,Notes,CreatedByUserID)
Values(@TestAppointmentID,@TestResult,@Notes,@CreatedByUserID);Select Scope_IDentity();";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            Command.Parameters.AddWithValue("@TestResult", TestResult);

            if (Notes != string.Empty)
                Command.Parameters.AddWithValue("@Notes", Notes);
            else
                Command.Parameters.AddWithValue("@Notes", System.DBNull.Value);

            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
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
        public static bool GetTestByTestID(int TestID, ref int TestAppointmentID, ref bool TestResult, ref string Notes, ref int CreatedByUserID)
        {

            bool isExist = false;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);

            string Query = @"Select * From Tests Where TestID=@TestID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestID", TestID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    isExist = true;
                    TestAppointmentID = (int)Reader["TestAppointmentID"];
                    TestResult = (bool)Reader["TestResult"];
                    if (Reader["Notes"] != System.DBNull.Value)
                        Notes = (string)Reader["Notes"];
                    else
                        Notes = string.Empty;
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
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
        public static bool GetTestByTestAppointmentID(int TestAppointmentID, ref int TestID, ref bool TestResult, ref string Notes, ref int CreatedByUserID)
        {

            bool isExist = false;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);

            string Query = @"Select * From Tests Where TestAppointmentID=@TestAppointmentID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    isExist = true;
                    TestID = (int)Reader["TestID"];
                    TestResult = (bool)Reader["TestResult"];
                    if (Reader["Notes"] != System.DBNull.Value)
                        Notes = (string)Reader["Notes"];
                    else
                        Notes = string.Empty;

                    CreatedByUserID = (int)Reader["CreatedByUserID"];
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
        public static DataTable GetAllTests()
        {
            DataTable Table = new DataTable();
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);
            string Query = "SELECT * FROM Tests";
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

        public static bool IsPass(int LocalDrivinglicenseID,int TestTypeID)
        {
            bool isfound = false;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);
            string Query = "SELECT        Tests.TestResult FROM LocalDrivingLicenseApplications INNER JOIN TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID INNER JOIN Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID Where LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalID and TestAppointments.TestTypeID = @TestTypeID and Tests.TestResult = 1; ";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestTypeID",TestTypeID);
            Command.Parameters.AddWithValue("@LocalID",LocalDrivinglicenseID);

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
        static public int GetCountFailedTests(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {

            int ContactID = 0;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);

            string Query = @" Select Count(TestResult) From TestAppointments Inner Join LocalDrivingLicenseApplications ON TestAppointments.LocalDrivingLicenseApplicationID=LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID
                                                                           Inner Join Tests ON Tests.TestAppointmentID=TestAppointments.TestAppointmentID 
                                 Where LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID and TestTypeID=@TestTypeID and TestResult=0";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);


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
