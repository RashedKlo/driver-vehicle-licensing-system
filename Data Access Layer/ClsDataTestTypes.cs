using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DataAccess
{
  public  class ClsDataTestTypes
    {
      //  SELECT TOP(1000) [TestTypeID]
      //,[TestTypeTitle]
      //,[TestTypeDescription]
      //,[TestTypeFees]
      //  FROM[DVLD].[dbo].[TestTypes]
        public static bool GetTestTypeByID(int TestTypeID, ref string TestTypeTitle,ref string TestTypeDescription, ref decimal TestTypeFees)
        {
            bool isExist = false;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);

            string Query = @"Select * From TestTypes where TestTypeID=@TestTypeID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    TestTypeTitle = (string)Reader["TestTypeTitle"];
                    TestTypeDescription = (string)Reader["TestTypeDescription"];
                    TestTypeFees = (decimal)Reader["TestTypeFees"];
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
        public static DataTable GetAllTestTypes()
        {
            DataTable Table = new DataTable();
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);
            string Query = "Select * From TestTypes";
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
        static public bool UpdateApplicationType(int TestTypeID, string TestTypeTitle,string TestTypeDescription, decimal TestTypeFees)
        {
            int IsUpdated = -1;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);

            string Query = @"Update   TestTypes
                            Set TestTypeTitle=@Title,
                            TestTypeDescription=@Description,
                                TestTypeFees=@Fees
                            Where TestTypeID =@ID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ID", TestTypeID);
            Command.Parameters.AddWithValue("@Fees", TestTypeFees);
            Command.Parameters.AddWithValue("@Title", TestTypeTitle);
            Command.Parameters.AddWithValue("@Description", TestTypeDescription);

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

