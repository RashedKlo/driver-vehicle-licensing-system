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
   public  class ClsLocalDrivingLicenseApplications
    {
        public int LocalLicenseApplicationID { get; set; }
        public int ApplicationID { get; set; }
        public int LicenseClassID { get; set; }
        private ClsLocalDrivingLicenseApplications(int LocalLicenseApplicationID, int ApplicationID,int LicenseClassID)
        {
            this.LocalLicenseApplicationID = LocalLicenseApplicationID;
            this.ApplicationID = ApplicationID;
            this.LicenseClassID = LicenseClassID;
        }
        public ClsLocalDrivingLicenseApplications()
        {
            LocalLicenseApplicationID = -1;
            ApplicationID = -1;
            LicenseClassID = -1;
        }
     static public DataTable GetAllLocalDrivingLicenseApplications()
        {
            return ClsDataLocalDrivingLicenseApplication.GetAllLocalDrivingLicenseApplications();
        }
        static public bool IsLocalDrivingLicenseExist(string No,string ClassName)
        {
            return ClsDataLocalDrivingLicenseApplication.IsLocalLicenseApplicationsExist(No, ClassName);
        }
        static public ClsLocalDrivingLicenseApplications Find(int LocalDrivingLicenseApplicationID)
        {
            int AppID = -1;
            int ClassID = -1;
            if (ClsDataLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplications(LocalDrivingLicenseApplicationID, ref AppID, ref ClassID))
            {
                return new ClsLocalDrivingLicenseApplications(LocalDrivingLicenseApplicationID, AppID, ClassID);
            }
            else
                return null;
        }
     private bool _Add()
        {
            this.LocalLicenseApplicationID = ClsDataLocalDrivingLicenseApplication.AddLocalLicenseDrivingApplications(ApplicationID, LicenseClassID);
            return LocalLicenseApplicationID != -1;
        }
        public bool Save()
        {
            return _Add();
        }
        static public DataTable GetAllLocalLicensesToPersonID(int PersonID)
        {
            return ClsDataLocalDrivingLicenseApplication.GetALLLocalLicensesToPersonID(PersonID);

        }
        static public bool DeleteLocalLicens(int LocalDrivingLicenseID)
        {
            return ClsDataLocalDrivingLicenseApplication.Delete(LocalDrivingLicenseID);

        }
    }
}
