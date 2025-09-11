using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;
namespace BusinessAccess
{
    public class ClsApplication
    {
        public int ApplicationID { get; set; }
        public int ApplicationPersonID { get; set; }
        public DateTime ApplicationDate { get; set; }
        public int ApplicationTypeID { get; set; }
        public byte ApplicationStatus { get; set; }
        public DateTime LastStatusDate { get; set; }
        public int CreatedByUserID { get; set; }
        public decimal PaidFees { get; set; }
        enum EnMode { Add=1,Update=2}
        EnMode _Mode = EnMode.Update;
        public static DataTable GetAllApplications()
        {
            return ClsDataApplication.GetAllApplications();
        }
        public bool Delete(int Application)
        {
            return ClsDataApplication.DeleteApplication(Application);
        }
        private ClsApplication(int ApplicationID, int ApplicationPersonID, DateTime ApplicationDate, int ApplicationTypeID, byte ApplicationStatus,
            DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID)
        {
            this.ApplicationID = ApplicationID;
      this.ApplicationPersonID = ApplicationPersonID;
        this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationDate = ApplicationDate;
        this.ApplicationStatus = ApplicationStatus;
           this.LastStatusDate = LastStatusDate;
          this.CreatedByUserID = CreatedByUserID;
                 this.PaidFees = PaidFees;
            _Mode = EnMode.Update;
        }
        public ClsApplication()
        {
            this.ApplicationID = -1;
            this.ApplicationPersonID = -1;
            this.ApplicationTypeID = -1;
            this.ApplicationStatus = 0;
            this.LastStatusDate = DateTime.Now;
            this.CreatedByUserID = -1;
            this.PaidFees = 0;
            this.ApplicationDate = DateTime.Now;
            _Mode = EnMode.Add;
        }
        private bool _Add()
        {
            this.ApplicationID = ClsDataApplication.AddApplication(ApplicationPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus,
              LastStatusDate, PaidFees, CreatedByUserID);
            return this.ApplicationID != -1;
        }
        private bool _Update()
        {
            return ClsDataApplication.UpdateApplication( ApplicationID,  ApplicationPersonID,  ApplicationDate,  ApplicationTypeID,  ApplicationStatus,
             LastStatusDate,  PaidFees,  CreatedByUserID);
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case EnMode.Add:
                    {
                        return _Add();
                    }
                case EnMode.Update:
                    {
                        return _Update();
                    }
                default:
                    return false;
                
            }

        }
        static public ClsApplication FindApplicationByID(int ID)
        {
          int PersonID = -1;
        int TypeID = -1;
        byte Status = 0;
            DateTime LastDate = DateTime.Now;
         int UserID = -1;
       decimal Fees = 0;
          DateTime Date = DateTime.Now;
            if (ClsDataApplication.GetApplicationByID( ID, ref PersonID, ref Date, ref TypeID, ref Status, ref LastDate, ref Fees, ref UserID))
            {
                return new ClsApplication(ID, PersonID, Date, TypeID, Status, LastDate, Fees, UserID);
            }
            else
                return null;
        }

        }
    
}
