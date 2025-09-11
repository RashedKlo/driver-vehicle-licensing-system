using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DataAccess
{
	//CREATE TABLE[dbo].[DetainedLicenses]
 //  [DetainID][int] IDENTITY(1,1) NOT NULL,
 // [LicenseID] [int]
	//NOT NULL,
 // [DetainDate] [smalldatetime]
	//NOT NULL,
 // [FineFees] [smallmoney]
	//NOT NULL,
 // [CreatedByUserID] [int]
	//NOT NULL,
 // [IsReleased] [bit]
	//NOT NULL,
 // [ReleaseDate] [smalldatetime] NULL,
	//[ReleasedByUserID] [int] NULL,
	//[ReleaseApplicationID] [int] NULL,
   public class ClsDataDetainedLicense
    {

        public static bool GetDetainedLicenseByLicenseID( int LicenseID,ref int DetainID, ref DateTime DetainDate,  ref decimal FineFees,
            ref int CreatedByUserID, ref bool IsReleased, ref DateTime ReleaseDate, ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {

            bool isExist = false;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);

            string Query = @"Select * From DetainedLicenses Where LicenseID=@LicenseID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseID", LicenseID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    isExist = true;
                    DetainID = (int)Reader["DetainID"];
                    DetainDate = (DateTime)Reader["DetainDate"];
                    FineFees  = (decimal)Reader["FineFees"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
                    IsReleased = (bool)Reader["IsReleased"];

                    if (Reader["ReleaseDate"] != System.DBNull.Value)

                        ReleaseDate = (DateTime)Reader["ReleaseDate"];
                    else
                        ReleaseDate = DateTime.MaxValue;

                    if(Reader["ReleasedByUserID"]!=System.DBNull.Value)
                    ReleasedByUserID = (int)Reader["ReleasedByUserID"];
                    else
                        ReleasedByUserID = -1;

                    if (Reader["ReleaseApplicationID"] != System.DBNull.Value)
                        ReleaseApplicationID = (int)Reader["ReleaseApplicationID"];
                    else
                        ReleaseApplicationID = -1;
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
        public static DataTable GetAllDetainedLicense()
        {
            DataTable Table = new DataTable();
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);
            string Query = "Select * From DetainedLicenses_View;"; 
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
        public static bool IsLicenseIsDetained(int LicenseID)
        {
            bool isfound = false;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);
            string Query = "Select Found=1 From DetainedLicenses Where LicenseID=@LicenseID and IsReleased=@IsReleased";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseID", LicenseID);
            Command.Parameters.AddWithValue("@IsReleased", false);

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
        static public bool DeleteDetainLicenseByLicenseID(int LicenseID)
        {
            int ISDeleted = -1;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);

            string Query = "Delete   DetainedLicenses Where LicenseID=@LicenseID";

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
        static public bool DeleteDetainLicenseByDetainID(int DetainID)
        {
            int ISDeleted = -1;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);

            string Query = "Delete   DetainedLicenses Where DetainID=@DetainID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@DetainID", DetainID);
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

        static public bool UpdateDetainedLicense(int DetainID, int LicenseID,DateTime DetainDate,decimal FineFees,
           int CreatedByUserID, bool IsReleased, DateTime ReleaseDate, int ReleasedByUserID,int ReleaseApplicationID)
        {
            int IsUpdated = -1;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);

            string Query = @"Update  DetainedLicenses 
                            Set LicenseID=@LicenseID,
                            DetainDate=@DetainDate,
                            FineFees=@FineFees,
                            CreatedByUserID=@CreatedByUserID,
                             IsReleased=@IsReleased,
                            ReleaseDate=@ReleaseDate,
                            ReleasedByUserID=@ReleasedByUserID,
                            ReleaseApplicationID=@ReleaseApplicationID
                            Where DetainID=@DetainID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@DetainID", DetainID);
            Command.Parameters.AddWithValue("@LicenseID", LicenseID);
            Command.Parameters.AddWithValue("@DetainDate", DetainDate);
            Command.Parameters.AddWithValue("@FineFees", FineFees);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            Command.Parameters.AddWithValue("@IsReleased", IsReleased);

            if(ReleaseDate!=DateTime.MaxValue)
            Command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate) ;
            else
                Command.Parameters.AddWithValue("@ReleaseDate", System.DBNull.Value);

            if(ReleasedByUserID!=-1)
            Command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            else
                Command.Parameters.AddWithValue("@ReleasedByUserID", System.DBNull.Value);

            if(ReleaseApplicationID!=-1)
            Command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
            else
                Command.Parameters.AddWithValue("@ReleaseApplicationID", System.DBNull.Value);

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

        static public int AddDetainedLicense( int LicenseID, DateTime DetainDate, decimal FineFees,
           int CreatedByUserID, bool IsReleased, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {

            int ContactID = -1;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);

            string Query = @"INSERT  INTO DetainedLicenses(  LicenseID, DetainDate,  FineFees,
            CreatedByUserID,  IsReleased,ReleaseDate,  ReleasedByUserID, ReleaseApplicationID)
Values(@LicenseID,@DetainDate,@FineFees,@CreatedByUserID,@IsReleased,@ReleaseDate,@ReleasedByUserID,@ReleaseApplicationID);Select Scope_IDentity();";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@LicenseID", LicenseID);
            Command.Parameters.AddWithValue("@DetainDate", DetainDate);
            Command.Parameters.AddWithValue("@FineFees", FineFees);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            Command.Parameters.AddWithValue("@IsReleased", IsReleased);

            if (ReleaseDate != DateTime.MaxValue)
                Command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
            else
                Command.Parameters.AddWithValue("@ReleaseDate", System.DBNull.Value);

            if (ReleasedByUserID != -1)
                Command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            else
                Command.Parameters.AddWithValue("@ReleasedByUserID", System.DBNull.Value);

            if (ReleaseApplicationID != -1)
                Command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
            else
                Command.Parameters.AddWithValue("@ReleaseApplicationID", System.DBNull.Value);
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
