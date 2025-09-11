using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DataAccess
{
    //SELECT TOP(1000) [InternationalLicenseID]
    //  ,[ApplicationID]
    //  ,[DriverID]
    //  ,[IssuedUsingLocalLicenseID]
    //  ,[IssueDate]
    //  ,[ExpirationDate]
    //  ,[IsActive]
    //  ,[CreatedByUserID]
    //FROM[DVLD].[dbo].[InternationalLicenses]
    public class ClsDataInternationalDrivingLicense
    {
        static public int AddInternationalDrivinglicense(int ApplicationID, int DriverID,int IssuedUsingLocalLicenseID, DateTime IssueDate,
            DateTime ExpirationDate,bool IsActive,int CreatedByUserID)
        {

            int ContactID = -1;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);

          string Query= " INSERT INTO[dbo].[InternationalLicenses] ([ApplicationID],[DriverID] , [IssuedUsingLocalLicenseID] ,[IssueDate] ,[ExpirationDate] ,[IsActive] ,[CreatedByUserID]) VALUES (@ApplicationID,  @DriverID, @IssuedUsingLocalLicenseID, @IssueDate,  @ExpirationDate, @IsActive, @CreatedByUserID);Select Scope_IDentity();";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue("@DriverID", DriverID);
            Command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
            Command.Parameters.AddWithValue("@IssueDate", IssueDate);
            Command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            Command.Parameters.AddWithValue("@IsActive", IsActive);
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
        public static DataTable GetAllInternationalLicenses()
        {
            DataTable Table = new DataTable();
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);
            string Query = "SELECT * From InternationalLicenses";
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
        public static bool IsInternationalLicenseExistByApplicatoinID(int ApplicationID)
        {
            bool isfound = false;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);
            string Query = "Select Found=1 From InternationalLicenses Where ApplicationID=@ApplicationID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

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
        public static bool IsInternationalLicenseExistByLicenseID(int IssuedUsingLocalLicenseID)
        {
            bool isfound = false;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);
            string Query = "Select Found=1 From InternationalLicenses Where IssuedUsingLocalLicenseID=@IssuedUsingLocalLicenseID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);

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
        public static bool GetInternationalDrivingLicenseByID(int InternationalLicenseID,ref int ApplicationID,ref  int DriverID, ref int IssuedUsingLocalLicenseID, 
           ref DateTime IssueDate, ref  DateTime ExpirationDate,ref  bool IsActive, ref int CreatedByUserID)
        {

            bool isExist = false;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);

            string Query = @"Select * From InternationalLicenses Where InternationalLicenseID=@InternationalLicenseID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                
                    ApplicationID = (int)Reader["ApplicationID"];
                    DriverID = (int)Reader["DriverID"];
                    IssuedUsingLocalLicenseID = (int)Reader["IssuedUsingLocalLicenseID"];
                    IssueDate = (DateTime)Reader["IssueDate"];
                    ExpirationDate = (DateTime)Reader["ExpirationDate"];
                    IsActive = (bool)Reader["IsActive"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
                    

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
        public static DataTable GetALLInternationalLicensesToPersonID(int PersonID)
        {
            DataTable Table = new DataTable();
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);
            string Query = "SELECT InternationalLicenses.InternationalLicenseID, Applications.ApplicationID, Licenses.LicenseID, InternationalLicenses.IssueDate, InternationalLicenses.ExpirationDate, InternationalLicenses.IsActive FROM InternationalLicenses INNER JOIN  Licenses ON InternationalLicenses.IssuedUsingLocalLicenseID = Licenses.LicenseID INNER JOIN  Applications ON InternationalLicenses.ApplicationID = Applications.ApplicationID INNER JOIN  People ON Applications.ApplicationPersonID = People.PersonID WHERE(People.PersonID = @PersonID);";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
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
