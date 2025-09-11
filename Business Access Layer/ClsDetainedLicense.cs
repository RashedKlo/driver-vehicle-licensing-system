using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccess;
namespace BusinessAccess
{
    public class ClsDetainedLicense
    {
        public int DetainID { get; set; }
        public int LicenseID { get; set; }
        public DateTime DetainDate { get; set; }
             public decimal FineFees{get;set;}
                 public int CreatedByUserID{get;set;}
                   public  bool IsReleased{get;set;}
                public DateTime ReleaseDate{get;set;}
               public int ReleasedByUserID{get;set;}
            public int ReleaseApplicationID { get; set; }
        enum EnMode { Add=1,Update=2}
        EnMode _Mode = EnMode.Update;


        public ClsDetainedLicense()
        {
            this.DetainID = -1;
            this.LicenseID = -1;
            this.DetainDate = DateTime.MaxValue;
            this.FineFees = 0;
            this.CreatedByUserID = -1;
            this.IsReleased = false;
            this.ReleaseDate = DateTime.MaxValue;
            this.ReleasedByUserID = -1;
            this.ReleaseApplicationID = -1;
            _Mode = EnMode.Add;
        }
        private ClsDetainedLicense(int DetainID, int LicenseID, DateTime DetainDate, decimal FineFees,
           int CreatedByUserID, bool IsReleased, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            this.DetainID = DetainID;
            this.LicenseID = LicenseID;
            this.DetainDate = DetainDate;
            this.FineFees = FineFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsReleased = IsReleased;
            this.ReleaseDate = ReleaseDate;
            this.ReleasedByUserID = ReleasedByUserID;
            this.ReleaseApplicationID = ReleaseApplicationID;
            _Mode = EnMode.Update;

        }

        private bool _AddDetainedLicense()
        {
            this.DetainID = ClsDataDetainedLicense.AddDetainedLicense(LicenseID, DetainDate, FineFees,
            CreatedByUserID, IsReleased,ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            return DetainID != -1;

        }
        private bool _UpdateDetainedLicense()
        {
           return ClsDataDetainedLicense.UpdateDetainedLicense(DetainID,LicenseID, DetainDate, FineFees,
            CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case EnMode.Add:
                    {
                        _Mode = EnMode.Update;
                        return _AddDetainedLicense();
                    }
                case EnMode.Update:
                    {
                        return _UpdateDetainedLicense();
                    }
                default:
                    return false;
            }
        }
        static public ClsDetainedLicense FindDetainedLicenseByLicenseID(int LicenseID)
        {
            int DetainID = -1;
           DateTime DetainDate = DateTime.MaxValue;
          decimal FineFees = 0;
           int CreatedByUserID = -1;
           bool IsReleased = false;
           DateTime ReleaseDate = DateTime.MaxValue;
           int ReleasedByUserID = -1;
           int ReleaseApplicationID = -1;
            if (ClsDataDetainedLicense.GetDetainedLicenseByLicenseID(LicenseID, ref DetainID, ref DetainDate, ref FineFees,
            ref CreatedByUserID, ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID))
            {
                return new ClsDetainedLicense(DetainID, LicenseID, DetainDate, FineFees,
            CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            }
            else
                return null;
        }
        static public DataTable GetAllDetainedLicenses()
        {
            return ClsDataDetainedLicense.GetAllDetainedLicense();
        }
        static public bool DeleteByLicenseID(int LicenseID)
        {
            return ClsDataDetainedLicense.DeleteDetainLicenseByLicenseID(LicenseID);
        }
        static public bool DeleteByDetainID(int DetainID)
        {
            return ClsDataDetainedLicense.DeleteDetainLicenseByLicenseID(DetainID);
        }
        static public bool IsLicenseDetained(int LicenseID)
        {
            return ClsDataDetainedLicense.IsLicenseIsDetained(LicenseID);
        }
    }
}
