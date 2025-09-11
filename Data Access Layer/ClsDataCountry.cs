using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DataAccess
{
   public class ClsDataCountry
    {

      public  static bool GetCountryByID(int CountryID, ref string CountryName)
        {
            bool isExist = false;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);

            string Query = @"Select * From Countries Where CountryID=@CountryID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@CountryID", CountryID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    isExist = true;
                    CountryName =(string) Reader["CountryName"];
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
        public static DataTable GetAllCountries()
        {
            DataTable Table = new DataTable();
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);
            string Query = "Select * From Countries";
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
     public   static bool IsCountryExistByCountryID(int CountryID)
        {
            bool isfound = false;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);
            string Query = "Select Found=1 From Countries Where CountryID=@CountryID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@CountryID", CountryID);

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
      public  static bool IsCountryExistByCountryName(string CountryName)
        {
            bool isfound = false;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);
            string Query = "Select Found=1 From Countries Where CountryName=@CountryName";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@CountryName", CountryName);

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
        public static bool GetCountryName(int CountryID, ref string CountryName)
        {
            bool isExist = false;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);

            string Query = @"Select CountryName From Countries Where CountryID=@CountryID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@CountryID", CountryID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    isExist = true;
                    CountryName = (string)Reader["CountryName"];
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

        public static bool GetCountryID(string CountryName,ref int CountryID)
        {
            bool isExist = false;
            SqlConnection Connection = new SqlConnection(ClsDataConnection.Connection);

            string Query = @"Select CountryID From Countries Where CountryName=@CountryName";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@CountryName", CountryName);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    isExist = true;
                    CountryID = (int)Reader["CountryID"];
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
