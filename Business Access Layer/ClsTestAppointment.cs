using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;
namespace BusinessAccess
{
    //    USE[DVLD]
    //GO

    //INSERT INTO[dbo].[TestAppointments]
    //    ([TestTypeID]
    //          ,[LocalDrivingLicenseApplicationID]
    //          ,[AppointmentDate]
    //          ,[PaidFees]
    //          ,[CreatedByUserID]
    //          ,[IsLocked])
    //   TestAppointmentID
    //    VALUES
    //          (<TestTypeID, int,>
    //           ,<LocalDrivingLicenseApplicationID, int,>
    //           ,<AppointmentDate, smalldatetime,>
    //           ,<PaidFees, smallmoney,>
    //           ,<CreatedByUserID, int,>
    //           ,<IsLocked, bit,>)
    //GO
    public class ClsTestAppointment
    {
        public int TestAppointmentID { get; set; }
        public int TestTypeID { get; set; }
        public int LocalDrivingLicenseApplicationID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public int RetakeTestApplicationID { get; set; }
        public bool IsLocked { get; set; }

        enum EnMode { Add = 1, Update = 2 };
        EnMode _Mode = EnMode.Update;
        public ClsTestAppointment()
        {
            _Mode = EnMode.Add;
            this.TestAppointmentID = -1;
            this.TestTypeID = -1;
            this.LocalDrivingLicenseApplicationID = -1;
            this.AppointmentDate = DateTime.Now;
            this.PaidFees = 0;
            this.CreatedByUserID = -1;
            this.IsLocked = false;
            this.RetakeTestApplicationID = -1;
        }
        private ClsTestAppointment(int TestAppointmentID, int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, decimal PaidFees, int CreatedByUser, bool IsLocked,int RetakeTestApplicationID)
        {
            this.TestAppointmentID = TestAppointmentID;
            this.TestTypeID = TestTypeID;
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.AppointmentDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUser;
            this.IsLocked = IsLocked;
            this.RetakeTestApplicationID = RetakeTestApplicationID;
            _Mode = EnMode.Update;
        }
        private bool _Add()
        {
            this.TestAppointmentID = ClsDataTestAppointment.AddTestAppointment(TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID);
            return TestAppointmentID != -1;
        }
        private bool _Update()
        {
         return ClsDataTestAppointment.UpdateTestAppointmentByID(TestAppointmentID,TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID);

        }
        public bool Save()
        {
            switch (_Mode)
            {
                case EnMode.Add:
                    {
                        _Mode = EnMode.Update;
                        return _Add();
                    }
                case EnMode.Update: return _Update();
                default: return false;
            }
        }
       static public ClsTestAppointment FindAppointmentByID(int TestAppointmentID)
        {
      
           int TestTypeID = -1;
           int LocalDrivingLicenseApplicationID = -1;
           DateTime AppointmentDate = DateTime.Now;
           decimal PaidFees = 0;
           int CreatedByUserID = -1;
           bool IsLocked = false;
            int RetakeTestApplicationID = -1;
            if (ClsDataTestAppointment.GetAppointmenTestByTestID(TestAppointmentID, ref TestTypeID,ref  LocalDrivingLicenseApplicationID, ref AppointmentDate,ref PaidFees, ref CreatedByUserID, ref IsLocked,ref RetakeTestApplicationID))
            {
                return new ClsTestAppointment(TestAppointmentID, TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID);
            }
            else
                return null;
        }
        static public ClsTestAppointment FindAppointmentByDrivingLicenseIDandLocked(int LocalDrivingLicenseApplicationID,int TestTypeID)
        {

            int TestAppointmentID = -1;
            DateTime AppointmentDate = DateTime.Now;
            decimal PaidFees = 0;
            int CreatedByUserID = -1;
            bool IsLocked = false;
            int RetakeTestApplicationID = -1;
            if (ClsDataTestAppointment.GetAppointmenTestByLocalDrivingID(LocalDrivingLicenseApplicationID,ref TestAppointmentID,  TestTypeID, ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked,ref RetakeTestApplicationID))
            {
                return new ClsTestAppointment(TestAppointmentID, TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID);
            }
            else
                return null;
        }
        static public bool isTestAppointmentByLocalDrivingIDExistandLocked(int LocalDrivingLicenseApplicationID,int TestTypeID,bool isLocked)
        {
            return ClsDataTestAppointment.IsTestAppointmentByLocalDrivingLicenseIDandLocked(LocalDrivingLicenseApplicationID,TestTypeID,isLocked);
        }
        static  public DataTable GetAllAppointments()
        {
            return ClsDataTestAppointment.GetAllTestTypes();
        }
    }
}
