using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;
namespace BusinessAccess
{
   public class ClsDrivers
    {
        //    SELECT TOP(1000) [DriverID]
        //      ,[PersonID]
        //      ,[CreatedByUserID]
        //      ,[CreatedDate]
        //    FROM[DVLD].[dbo].[Drivers]
        public int DriverID { get; set; }
        public int PersonID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedDate { get; set; }
      
        public ClsDrivers()
        {
            DriverID = -1;
            PersonID = -1;
            CreatedByUserID = -1;
            CreatedDate = DateTime.MaxValue;
        }
        private ClsDrivers(int DriverID,int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            this.DriverID = DriverID;
            this.PersonID = PersonID;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedDate = CreatedDate;
        }
        private bool _AddDriver()
        {
            this.DriverID = ClsDataDriver.AddDriver( PersonID, CreatedByUserID, CreatedDate);
            return DriverID != -1;

        }
        public bool Save()
        {
            return _AddDriver();
        }

        static public ClsDrivers FindDirverByPersonID(int PerID)
        {
            int DrivID = -1;
            int UserID = -1;
            DateTime Time = DateTime.Now;
            if (ClsDataDriver.GetDriverByID(PerID,ref  DrivID, ref UserID,ref  Time))
            {
                return new ClsDrivers(DrivID,PerID, UserID, Time);
            }
            else
                return null;
        }
        static public ClsDrivers FindDirverByDriverID(int DrivID)
        {
            int PerID = -1;
            int UserID = -1;
            DateTime Time = DateTime.Now;
            if (ClsDataDriver.GetDriverByDriverID( DrivID,ref PerID, ref UserID, ref Time))
            {
                return new ClsDrivers(DrivID, PerID, UserID, Time);
            }
            else
                return null;
        }
        static public DataTable GetAllDrivers()
        {
            return ClsDataDriver.GetAllDrivers();
        }
        static public bool IsDriverExist(int PersonID)
        {
            return ClsDataDriver.IsDriverExist(PersonID);
        }
    }
}
