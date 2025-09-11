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
	//CREATE TABLE[dbo].[Licenses]
	//   [LicenseID][int] IDENTITY(1,1) 
	//  [ApplicationID] [int]
	//  [DriverID] [int]
	//  [LicenseClass] [int]
	//  [IssueDate] [datetime]
	//  [ExpirationDate] [datetime]
	//  [Notes] [nvarchar] (500) NULL,
	//[PaidFees]
	//[IsActive] [bit]
	//[IssueReason] [tinyint]
	//[CreatedByUserID] [int]
	public class ClsLicenses
	{
		public int LicenseID { get; set; }
		public int ApplicationID { get; set; }
		public int DriverID { get; set; }
		public int LicenseClassID { get; set; }
		public DateTime IssueDate { get; set; }
		public DateTime ExpirationDate { get; set; }

		public string Notes { get; set; }
		public decimal PaidFees { get; set; }
		public bool IsActive { get; set; }
        public byte IssueReason { get; set; }
		public int CreatedByUserID { get; set; }
	enum EnMode { Add=1,Update=2}
		EnMode _Mode = EnMode.Update;
		public ClsLicenses()
        {
			LicenseID = -1;
			ApplicationID = -1;
			DriverID = -1;
			LicenseClassID = -1;
			IssueDate = DateTime.Now;
			ExpirationDate = DateTime.Now;
			Notes = string.Empty;
			PaidFees = 0;
			IsActive = false;
			IssueReason = 0;
			CreatedByUserID = -1;
			_Mode = EnMode.Add;
        }
		private ClsLicenses(int LicenseID,int ApplicationID, int DriverID, int LicenseClassID, DateTime IssueDate, DateTime ExpirationDate, string Notes, decimal PaidFees, bool IsActive, byte IssueReason, int CreatedByUserID)
        {
			this.LicenseID = LicenseID;
			this.ApplicationID = ApplicationID;
			this.DriverID = DriverID;
			this.LicenseClassID = LicenseClassID;
			this.IssueDate = IssueDate;
			this.ExpirationDate = ExpirationDate;
			this.Notes = Notes;
			this.PaidFees = PaidFees;
			this.IsActive = IsActive;
			this.IssueReason = IssueReason;
			this.CreatedByUserID = CreatedByUserID;
			_Mode = EnMode.Update;

		}
private bool _AddLicense()
        {
			this.LicenseID = ClsDataLicenses.AddLicense(ApplicationID, DriverID, LicenseClassID, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID);
			return LicenseID != -1;
        }
		private bool _UpdateLicense()
        {
			return ClsDataLicenses.UpdateLicense(LicenseID,ApplicationID, DriverID, LicenseClassID, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID);
		}
		public  bool Save()
        {
            switch (_Mode)
            {
                case EnMode.Add:
					_Mode = EnMode.Update;
					return _AddLicense();
                case EnMode.Update:
					return _UpdateLicense();
				default:
					return false;
            }
        }
		static public ClsLicenses FindLicenseByID(int LicenseID)
        {

			int ApplicationID = -1;
			int DriverID = -1;
			int LicenseClassID = -1;
			DateTime IssueDate = DateTime.Now;
			DateTime ExpirationDate = DateTime.Now;
			string Notes = string.Empty;
			decimal PaidFees = 0;
			bool IsActive = false;
			byte IssueReason = 0;
			int CreatedByUserID = -1;
			if (ClsDataLicenses.GetLicenseByID(LicenseID,ref ApplicationID,ref DriverID,ref LicenseClassID,ref IssueDate,ref ExpirationDate,ref Notes,ref PaidFees,ref IsActive ,ref IssueReason,ref CreatedByUserID))
            {
				
				return new ClsLicenses(LicenseID,ApplicationID, DriverID, LicenseClassID, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID); ;
            }
			else
            {
				return null;
            }
        }
		static public ClsLicenses FindLicenseByApplicationID(int ApplicationID)
		{

			int LicenseID = -1;
			int DriverID = -1;
			int LicenseClassID = -1;
			DateTime IssueDate = DateTime.Now;
			DateTime ExpirationDate = DateTime.Now;
			string Notes = string.Empty;
			decimal PaidFees = 0;
			bool IsActive = false;
			byte IssueReason = 0;
			int CreatedByUserID = -1;
			if (ClsDataLicenses.GetLicenseByApplication( ApplicationID,ref LicenseID, ref DriverID, ref LicenseClassID, ref IssueDate, ref ExpirationDate, ref Notes, ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID))
			{

				return new ClsLicenses(LicenseID,ApplicationID, DriverID, LicenseClassID, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID); ;
			}
			else
			{
				return null;
			}
		}
		static public bool DeleteLicense(int LicenseID)
        {
			return ClsDataLicenses.Deletelicense(LicenseID);
        }
		static public bool IsLicenseIDExist(int LicenseID,int LicenseClassID)
        {
			return ClsDataLicenses.IsLicenseIDExist(LicenseID, LicenseClassID);
        }
		static public int GetLocalDrivingLicenseByLicenseIDandLicenseClassID(int LicenseID, int LicenseClassID)
        {
			return (ClsDataLicenses.GetLocalDrivingLicenseIDByLicenseIDWithLicenseClassID(LicenseID, LicenseClassID));
        }
    }
}
