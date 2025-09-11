using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DataAccess
{

  

 


    //SELECT TOP(1000) [LocalDrivingLicenseApplicationID]
    //  ,[ClassName]
    //  ,[NationalNo]
    //  ,[FullName]
    //  ,[ApplicationDate]
    //  ,[PassedTestCount]
    //  ,[Status]
    //FROM[DVLD].[dbo].[LocalDrivingLicenseApplications_View]

    //    USE[DVLD]
    //GO

    //    USE[DVLD]
    //    GO

    //SELECT[ApplicationTypeID]
    //      ,[ApplicationTypeTitle]
    //      ,[ApplicationFees]
    //    FROM[dbo].[ApplicationTypes]

    //    GO




    public class ClsDataApplication
   {
        public static bool GetApplicationByID( int ApplicationID, ref int ApplicationPersonID,ref DateTime ApplicationDate, ref int ApplicationTypeID,ref byte ApplicationStatus,
            ref DateTime LastStatusDate, ref decimal PaidFees,ref int CreatedByUserID)
        {

            bool isExist = false;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);

            string Query = @"Select * From Applications Where ApplicationID=@ID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ID", ApplicationID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    isExist = true;
                    ApplicationPersonID = (int)Reader["ApplicationPersonID"];
                    ApplicationDate = (DateTime)Reader["ApplicationDate"];
                    ApplicationTypeID = (int)Reader["ApplicationTypeID"];
                    ApplicationStatus = (byte)Reader["ApplicationStatus"];
                    LastStatusDate = (DateTime)Reader["LastStatusDate"];
                    PaidFees = (decimal)Reader["PaidFees"];
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
        public static DataTable GetAllApplications()
        {
            DataTable Table = new DataTable();
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);
            string Query = "Select * From Applications";
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
       
        static public bool DeleteApplication(int ApplicatioinID)
        {
            int ISDeleted = -1;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);

            string Query = "Delete  From Applications Where ApplicationID = @ID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ID", ApplicatioinID);
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
        static public bool UpdateApplication(int ApplicationID,int ApplicationPersonID, DateTime ApplicationDate, int ApplicationTypeID, byte ApplicationStatus,
            DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID)
        {
            int IsUpdated = -1;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);

            string Query = @"Update  Applications 
                            Set ApplicationPersonID=@PersonID,
                         ApplicationDate=@Date,
                           ApplicationTypeID=@TypeID,
                            ApplicationStatus=@Status,
                             LastStatusDate=@LastDate,
                              PaidFees=@Fees,
                                CreatedByUserID=@UserID
                            Where ApplicationID=@ApplicationID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue("@PersonID", ApplicationPersonID);
            Command.Parameters.AddWithValue("@Date", ApplicationDate);
            Command.Parameters.AddWithValue("@TypeID", ApplicationTypeID);
            Command.Parameters.AddWithValue("@Status", ApplicationStatus);
            Command.Parameters.AddWithValue("@LastDate", LastStatusDate);
            Command.Parameters.AddWithValue("@Fees", PaidFees);
            Command.Parameters.AddWithValue("@UserID", CreatedByUserID);
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

        static public int AddApplication(int ApplicationPersonID, DateTime ApplicationDate, int ApplicationTypeID, byte ApplicationStatus,
            DateTime LastStatusDate,decimal PaidFees,int CreatedByUserID )
        {

            int ContactID = -1;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);

            string Query = @"INSERT  INTO Applications(ApplicationPersonID,ApplicationDate,ApplicationTypeID,ApplicationStatus,LastStatusDate,PaidFees,CreatedByUserID)
Values(@PersonID,@Date,@TypeID,@Status,@LastDate,@Fees,@UserID);Select Scope_IDentity();";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@PersonID", ApplicationPersonID);
            Command.Parameters.AddWithValue("@Date", ApplicationDate);
            Command.Parameters.AddWithValue("@TypeID", ApplicationTypeID);
            Command.Parameters.AddWithValue("@Status", ApplicationStatus);
            Command.Parameters.AddWithValue("@LastDate", LastStatusDate);
            Command.Parameters.AddWithValue("@Fees", PaidFees);
            Command.Parameters.AddWithValue("@UserID", CreatedByUserID);

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

