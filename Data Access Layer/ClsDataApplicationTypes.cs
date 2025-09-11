using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DataAccess
{
    //SELECT TOP(1000) [ApplicationTypeID]
    //  ,[ApplicationTypeTitle]
    //  ,[ApplicationFees]
    //FROM[DVLD].[dbo].[ApplicationTypes]

   public class ClsDataApplicationTypes
    {
        public static bool GetApplicationTypeByID(int ApplicationTypeID ,ref string ApplicationTypeTitle,ref decimal ApplicationFees)
        {
            bool isExist = false;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);

            string Query = @"Select * From ApplicationTypes Where ApplicationTypeID=@ApplicationTypeID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    ApplicationTypeTitle = (string)Reader["ApplicationTypeTitle"];
                    ApplicationFees = (decimal)Reader["ApplicationFees"];
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
        public static DataTable GetAllApplicationTypes()
        {
            DataTable Table = new DataTable();
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);
            string Query = "Select * From ApplicationTypes";
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
        static public bool UpdateApplicationType(int ApplicationTypeID,string ApplicationTypeTitle,decimal ApplicationFees)
        {
            int IsUpdated = -1;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);

            string Query = @"Update   ApplicationTypes
                            Set ApplicationTypeTitle=@Title,
                                ApplicationFees=@Fees
                            Where ApplicationTypeID =@ID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ID", ApplicationTypeID);
            Command.Parameters.AddWithValue("@Fees", ApplicationFees);
            Command.Parameters.AddWithValue("@Title", ApplicationTypeTitle);

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
    }
}
