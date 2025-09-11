using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccess;
namespace BusinessAccess
{
    public class ClsInternationalDrivingLicense
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
        public int InternationalLicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int IssuedUsingLocalLicenseID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }
        private ClsInternationalDrivingLicense(int InternationalLicenseID,int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID, DateTime IssueDate,
            DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            this.InternationalLicenseID = InternationalLicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.IssuedUsingLocalLicenseID = IssuedUsingLocalLicenseID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.IsActive = IsActive;
            this.CreatedByUserID = CreatedByUserID;
        }
        public ClsInternationalDrivingLicense()
        {
            this.InternationalLicenseID = -1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.IssuedUsingLocalLicenseID = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;
            this.IsActive = false;
            this.CreatedByUserID = -1;
        }

        static public ClsInternationalDrivingLicense FindInternationalLicenseByID(int InternationalLicenseID)
        {
        
          int ApplicationID = -1;
          int DriverID = -1;
          int IssuedUsingLocalLicenseID = -1;
         DateTime IssueDate = DateTime.Now;
         DateTime ExpirationDate = DateTime.Now;
          bool IsActive = false;
          int CreatedByUserID = -1;

            if (ClsDataInternationalDrivingLicense.GetInternationalDrivingLicenseByID(InternationalLicenseID, ref ApplicationID, ref DriverID, ref IssuedUsingLocalLicenseID,
           ref IssueDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID))
            {
                return new ClsInternationalDrivingLicense( InternationalLicenseID,   ApplicationID,   DriverID,   IssuedUsingLocalLicenseID,
             IssueDate,   ExpirationDate,   IsActive,   CreatedByUserID);
            }
            else
                return null;
        }
        static public DataTable GetAllInternationalLicenses()
        {
            return ClsDataInternationalDrivingLicense.GetAllInternationalLicenses();
        }
        static public bool IsInternationalLicenseExistByLicenseID(int LicenseID)
        {
            return ClsDataInternationalDrivingLicense.IsInternationalLicenseExistByLicenseID(LicenseID);
        }
        static public bool IsInternationalLicenseExistByApplicationID(int ApplicationID)
        {
            return ClsDataInternationalDrivingLicense.IsInternationalLicenseExistByApplicatoinID(ApplicationID);
        }
       private bool _AddLicense()
        {
            this.InternationalLicenseID = ClsDataInternationalDrivingLicense.AddInternationalDrivinglicense(this.ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate ,ExpirationDate, IsActive, CreatedByUserID);
            return InternationalLicenseID != -1;
        }
        public bool Save()
        {
            return _AddLicense();
        }
        static public DataTable GetAllInternationalLicensesToPersonID(int PersonID)
        {
            return ClsDataInternationalDrivingLicense.GetALLInternationalLicensesToPersonID(PersonID);
        }
    }
}
