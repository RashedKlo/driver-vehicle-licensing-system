using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{

    //CREATE TABLE[dbo].[Licenses]
    //   [LicenseID][int] IDENTITY(1,1) 
    //  [ApplicationID] [int]
    //  [DriverID] [int]
    //  [LicenseClass] [int]
    //  [IssueDate] [datetime]
    //  [ExpirationDate] [datetime]
    //  [Notes] [nvarchar] (500) NULL,
    //[PaidFees]
    //[IsActive] [bit]
    //[IssueReason] [tinyint]
    //[CreatedByUserID] [int]



    public class ClsDataLicenses
    {
        static public bool Deletelicense(int LicenseID)
        {
            int ISDeleted = -1;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);

            string Query = "Delete  From Licenses Where LicenseID = @LicenseID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseID", LicenseID);
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
        static public bool UpdateLicense(int LicenseID, int ApplicationID, int DriverID,int LicenseClassID, DateTime IssueDate, DateTime ExpirationDate,string Notes,decimal PaidFees,bool IsActive,byte IssueReason,int CreatedByUserID)
        {
            int IsUpdated = -1;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);

            string Query = @"Update  Licenses 
                            Set 
                            ApplicationID=@ApplicationID,
                              DriverID=@DriverID,
                            LicenseClassID=@LicenseClassID,
                            IssueDate=@IssueDate,
                             ExpirationDate=@ExpirationDate,
                                Notes=@Notes,
                                 PaidFees=@PaidFees,
                                  IsActive=@IsActive,
                                   IssueReason=@IssueReason,
                                    CreatedByUserID=@CreatedByUserID
                            Where LicenseID=@LicenseID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseID", LicenseID);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue("@DriverID", DriverID);
            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            Command.Parameters.AddWithValue("@IssueDate", IssueDate);
            Command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);

            if (Notes!=string.Empty)
            Command.Parameters.AddWithValue("@Notes", Notes);
            else
                Command.Parameters.AddWithValue("@Notes", System.DBNull.Value);

            Command.Parameters.AddWithValue("@PaidFees", PaidFees);
            Command.Parameters.AddWithValue("@IsActive", IsActive);
            Command.Parameters.AddWithValue("@IssueReason", IssueReason);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

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

        static public int AddLicense( int ApplicationID, int DriverID, int LicenseClassID, DateTime IssueDate, DateTime ExpirationDate, string Notes, decimal PaidFees, bool IsActive, byte IssueReason, int CreatedByUserID)
        {

            int ContactID = -1;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);

            string Query = @"INSERT  INTO Licenses( ApplicationID, DriverID, LicenseClassID,  IssueDate,  ExpirationDate,  Notes,  PaidFees,  IsActive,  IssueReason,  CreatedByUserID)

Values( @ApplicationID, @DriverID, @LicenseClassID, @IssueDate, @ExpirationDate, @Notes, @PaidFees, @IsActive, @IssueReason, @CreatedByUserID);
Select Scope_IDentity();";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue("@DriverID", DriverID);
            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            Command.Parameters.AddWithValue("@IssueDate", IssueDate);
            Command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);

            if (Notes != string.Empty)
                Command.Parameters.AddWithValue("@Notes", Notes);
            else
                Command.Parameters.AddWithValue("@Notes", System.DBNull.Value);

            Command.Parameters.AddWithValue("@PaidFees", PaidFees);
            Command.Parameters.AddWithValue("@IsActive", IsActive);
            Command.Parameters.AddWithValue("@IssueReason", IssueReason);
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

        public static bool GetLicenseByID(int LicenseID,ref int ApplicationID,ref int DriverID,ref int LicenseClassID,ref DateTime IssueDate,ref DateTime ExpirationDate,ref string Notes,ref decimal PaidFees,ref bool IsActive,ref byte IssueReason,ref int CreatedByUserID)
        {

            bool isExist = false;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);

            string Query = @"Select * From Licenses Where LicenseID=@LicenseID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseID", LicenseID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    isExist = true;
                    LicenseID = (int)Reader["LicenseID"];
                    ApplicationID = (int)Reader["ApplicationID"];
                    DriverID = (int)Reader["DriverID"];
                    LicenseClassID = (int)Reader["LicenseClassID"];
                    IssueDate = (DateTime)Reader["IssueDate"];
                    ExpirationDate = (DateTime)Reader["ExpirationDate"];

                    if (Reader["Notes"] != System.DBNull.Value)
                    Notes = (string)Reader["Notes"];
                    else
                        Notes =string.Empty;


                    PaidFees = (decimal)Reader["PaidFees"];
                    IsActive = (bool)Reader["IsActive"];
                    IssueReason = (byte)Reader["IssueReason"];
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
        public static bool GetLicenseByApplication( int ApplicationID,ref int LicenseID, ref int DriverID, ref int LicenseClassID, ref DateTime IssueDate, ref DateTime ExpirationDate, ref string Notes, ref decimal PaidFees, ref bool IsActive, ref byte IssueReason, ref int CreatedByUserID)
        {

            bool isExist = false;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);

            string Query = @"Select * From Licenses Where ApplicationID=@ApplicationID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    isExist = true;
                    LicenseID = (int)Reader["LicenseID"];
                    ApplicationID = (int)Reader["ApplicationID"];
                    DriverID = (int)Reader["DriverID"];
                    LicenseClassID = (int)Reader["LicenseClassID"];
                    IssueDate = (DateTime)Reader["IssueDate"];
                    ExpirationDate = (DateTime)Reader["ExpirationDate"];

                    if (Reader["Notes"] != System.DBNull.Value)
                        Notes = (string)Reader["Notes"];
                    else
                        Notes = string.Empty;


                    PaidFees = (decimal)Reader["PaidFees"];
                    IsActive = (bool)Reader["IsActive"];
                    IssueReason = (byte)Reader["IssueReason"];
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
         public static bool IsLicenseIDExist(int LicenseID,int LicenseClassID)
        {

            bool isfound = false;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);
            string Query = "Select Found=1 From Licenses Where LicenseID=@LicenseID and LicenseClassID=@LicenseClassID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseID", LicenseID);
            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

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
        public static int GetLocalDrivingLicenseIDByLicenseIDWithLicenseClassID(int LicenseID, int LicenseClassID)
        {
            int ContactID = -1;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);

            string Query = @"SELECT LocalDrivingLicenseApplicationID FROM Licenses INNER JOIN Applications ON Licenses.ApplicationID = Applications.ApplicationID INNER JOIN LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID WHERE LicenseID =@LicenseID AND Licenses.LicenseClassID =@LicenseClassID ";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseID", LicenseID);
            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
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
                string e = E.Message;
            }
            finally
            {
                Connection.Close();
            }
            return ContactID;
        }

    }
}
