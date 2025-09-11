using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccess;
namespace BusinessAccess
{
   public class clsCountry
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }
        public clsCountry()
        {
            CountryName = string.Empty;
            CountryID = -1;
        }
        private clsCountry(int CountryID, string CountryName)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;
        }
        public static clsCountry FindByID(int CountryID)
        {
            string CountryName = "";
            if(ClsDataCountry.GetCountryByID(CountryID,ref CountryName))
            {
                return new clsCountry(CountryID, CountryName);
            }
            else
            {
                return null;
            }
        }
        public static DataTable GetAllCountries()
        {
            return ClsDataCountry.GetAllCountries();
        }
        public static bool isCountryExist(string CountryName)
        {
            return ClsDataCountry.IsCountryExistByCountryName(CountryName);
        }
        public static bool isCountryExist(int CountryID)
        {
            return ClsDataCountry.IsCountryExistByCountryID(CountryID);
        }
        public static string GetCountryName(int CountryID)
        {
            string CountryName = "Not Found";
            return (ClsDataCountry.GetCountryName(CountryID, ref CountryName) ? CountryName : CountryName);
        }
        public static int GetCountryID(string CountryName)
        {
            int CountryID = -1;
            return (ClsDataCountry.GetCountryID(CountryName, ref CountryID) ? CountryID : CountryID);
        }
    }
}
