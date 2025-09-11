using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DataAccess
{
    //SELECT[LicenseClassID]
    //      ,[ClassName]
    //      ,[ClassDescription]
    //      ,[MinimumAllowedAge]
    //      ,[DefaultValidityLength]
    //      ,[ClassFees]
    //    FROM[dbo].[LicenseClasses]

    //    GO

    //        USE[DVLD]
    //GO
    public class ClsDataLicenseClasses
    {
        public static bool GetLicenseClassByID( int LicenseClassID,ref string ClassName, ref string ClassDescription, ref byte MinimumAllowedAge, ref byte DefaultValidityLength, ref decimal ClassFees)
        {

            bool isExist = false;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);

            string Query = @"Select * From LicenseClasses Where LicenseClassID=@LicenseClassID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    ClassName = (string)Reader["ClassName"];
                    ClassDescription = (string)Reader["ClassDescription"];
                    MinimumAllowedAge = (byte)Reader["MinimumAllowedAge"];
                    DefaultValidityLength = (byte)Reader["DefaultValidityLength"];
                    ClassFees = (decimal)Reader["ClassFees"];

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
        public static bool GetLicenseClass(string ClassName,ref int LicenseClassID, ref string ClassDescription, ref byte MinimumAllowedAge, ref byte DefaultValidityLength, ref decimal ClassFees)
        {
  
            bool isExist = false;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);

            string Query = @"Select * From LicenseClasses Where ClassName=@ClassName";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ClassName", ClassName );

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    LicenseClassID = (int)Reader["LicenseClassID"];
                    ClassDescription = (string)Reader["ClassDescription"];
                    MinimumAllowedAge = (byte)Reader["MinimumAllowedAge"];
                    DefaultValidityLength = (byte)Reader["DefaultValidityLength"];
                    ClassFees = (decimal)Reader["ClassFees"];
             
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
        public static DataTable GetAllLicenseClasses()
        {
            DataTable Table = new DataTable();
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);
            string Query = "Select * From LicenseClasses";
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
