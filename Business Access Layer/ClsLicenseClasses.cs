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
    public class ClsLicenseClasses
    {
       public int LicenseClassID{get;set;}
      public    string ClassName{get;set;}
   public string ClassDescription{get;set;}
  public   byte MinimumAllowedAge{get;set;}
public byte DefaultValidityLength{get;set;}
        public decimal ClassFees { get; set; }
      
        private ClsLicenseClasses(int LicenseClassID,  string ClassName,  string ClassDescription, byte MinimumAllowedAge, byte DefaultValidityLength,  decimal ClassFees)
        {
            this.LicenseClassID = LicenseClassID;
            this.ClassName = ClassName;
            this.ClassDescription = ClassDescription;
            this.MinimumAllowedAge = MinimumAllowedAge;
            this.DefaultValidityLength = DefaultValidityLength;
            this.ClassFees = ClassFees;
        }

        public static DataTable GetAllLicenseClasses()
        {
            return ClsDataLicenseClasses.GetAllLicenseClasses();
        }
        public static ClsLicenseClasses FindByClassName(string ClassName)
        {
            int ID = -1;
            string Description = string.Empty;
            byte Age = 0;
            byte Length = 0;
            decimal Fees = 0;
            if (ClsDataLicenseClasses.GetLicenseClass( ClassName,ref ID, ref Description, ref Age, ref Length, ref Fees))
            {
                return new ClsLicenseClasses(ID, ClassName, Description, Age, Length, Fees);
            }
            else
                return null;
           
        }
        public static ClsLicenseClasses FindByID(int LicenseClassID)
        {
            string ClassName = string.Empty;
            string Description = string.Empty;
            byte Age = 0;
            byte Length = 0;
            decimal Fees = 0;
            if (ClsDataLicenseClasses.GetLicenseClassByID(LicenseClassID,ref ClassName, ref Description, ref Age, ref Length, ref Fees))
            {
                return new ClsLicenseClasses(LicenseClassID, ClassName, Description, Age, Length, Fees);
            }
            else
                return null;

        }
    }
}
