using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DataAccess
{


    //SELECT TOP(1000) [TestAppointmentID]
    //  ,[TestTypeID]
    //  ,[LocalDrivingLicenseApplicationID]
    //  ,[AppointmentDate]
    //  ,[PaidFees]
    //  ,[CreatedByUserID]
    //  ,[IsLocked]
    //  ,[RetakeTestApplicationID]
    //FROM[DVLD].[dbo].[TestAppointments]

    public  class ClsDataTestAppointment
    {
        public static bool GetAppointmenTestByTestID (int TestAppointmentID, ref int TestTypeID, ref int LocalDrivingLicenseApplicationID, ref DateTime AppointmentDate,ref decimal PaidFees,ref int CreatedByUserID,ref bool IsLocked,ref int RetakeTestApplicationID)
        {

            bool isExist = false;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);

            string Query = @"Select * From TestAppointments Where TestAppointmentID=@TestAppointmentID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    isExist = true;
                    TestTypeID = (int)Reader["TestTypeID"];
                    LocalDrivingLicenseApplicationID = (int)Reader["LocalDrivingLicenseApplicationID"];

                    AppointmentDate = (DateTime)Reader["AppointmentDate"];
                    PaidFees = (decimal)Reader["PaidFees"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];

                    IsLocked = (bool)Reader["IsLocked"];

                    if (Reader["RetakeTestApplicationID"] !=System.DBNull.Value)
                        RetakeTestApplicationID = (int)Reader["RetakeTestApplicationID"];
                    else
                        RetakeTestApplicationID = -1;
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
        static public bool UpdateTestAppointmentByID(int TestAppointmentID,  int TestTypeID,  int LocalDrivingLicenseApplicationID,  DateTime AppointmentDate,  decimal PaidFees,  int CreatedByUserID,  bool IsLocked,int RetakeTestApplicationID)
        {
            int IsUpdated = -1;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);

            string Query = @"Update  TestAppointments 
                            Set 
                            TestTypeID=@TestTypeID,
                            LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID,
                             AppointmentDate=@AppointmentDate,
                             PaidFees=@PaidFees,
                             CreatedByUserID=@CreatedByUserID,
                             IsLocked=@IsLocked,
                             RetakeTestApplicationID=@RetakeTestApplicationID
                            Where TestAppointmentID=@TestAppointmentID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            Command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            Command.Parameters.AddWithValue("@PaidFees", PaidFees);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID); 
            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID); 
            Command.Parameters.AddWithValue("@IsLocked", IsLocked);

            if(RetakeTestApplicationID!=-1)
            Command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);
            else
                Command.Parameters.AddWithValue("@RetakeTestApplicationID", System.DBNull.Value);

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

        static public int AddTestAppointment(int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, decimal PaidFees, int CreatedByUserID, bool IsLocked,int RetakeTestApplicationID)
        {

            int ContactID = -1;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);

            string Query = @"INSERT  INTO TestAppointments(TestTypeID,LocalDrivingLicenseApplicationID,AppointmentDate,PaidFees,CreatedByUserID,IsLocked,RetakeTestApplicationID)
Values(@TestTypeID,@LocalDrivingLicenseApplicationID,@AppointmentDate,@PaidFees,@CreatedByUserID,@IsLocked,@RetakeTestApplicationID);Select Scope_IDentity();";

            SqlCommand Command = new SqlCommand(Query, Connection);
 Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            Command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            Command.Parameters.AddWithValue("@PaidFees", PaidFees);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            Command.Parameters.AddWithValue("@IsLocked", IsLocked);

            if (RetakeTestApplicationID != -1)
                Command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);
            else
                Command.Parameters.AddWithValue("@RetakeTestApplicationID", System.DBNull.Value);

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

        public static DataTable GetAllTestTypes()
        {
            DataTable Table = new DataTable();
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);
            string Query = "Select *   From TestAppointments";
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
        public static bool GetAppointmenTestByLocalDrivingID( int LocalDrivingLicenseApplicationID, ref int TestAppointmentID,  int TestTypeID, ref DateTime AppointmentDate, ref decimal PaidFees, ref int CreatedByUserID, ref bool IsLocked,ref int RetakeTestApplicationID)
        {

            bool isExist = false;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);

            string Query = @"Select * From TestAppointments Where LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID and IsLocked=@IsLocked and TestTypeID=@TestTypeID ";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            Command.Parameters.AddWithValue("@IsLocked", true);
            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);


            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    isExist = true;
                    TestTypeID = (int)Reader["TestTypeID"];
                    TestAppointmentID = (int)Reader["TestAppointmentID"];

                    AppointmentDate = (DateTime)Reader["AppointmentDate"];
                    PaidFees = (decimal)Reader["PaidFees"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
                    IsLocked = (bool)Reader["IsLocked"];

                    if (Reader["RetakeTestApplicationID"] != null)
                        RetakeTestApplicationID = (int)Reader["RetakeTestApplicationID"];
                    else
                        RetakeTestApplicationID = -1;
                }
                else
                    isExist = false;
              

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
        public static bool IsTestAppointmentByLocalDrivingLicenseIDandLocked(int LocalDrivingLicenseApplicationID,int TestTypeID,bool IsLocked)
        {
            bool isfound = false;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);
            string Query = "Select Found=1 From TestAppointments Where LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID and IsLocked=@IsLocked and TestTypeID=@TestTypeID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            Command.Parameters.AddWithValue("@IsLocked", IsLocked);
            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

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
    }
}
