using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;
namespace BusinessAccess
{
	//CREATE TABLE[dbo].[Tests]
	//(

	//  [TestID][int] IDENTITY(1,1) NOT NULL,

	// [TestAppointmentID] [int]
	//NOT NULL,

	// [TestResult] [bit]
	//NOT NULL,

	// [Notes] [nvarchar] (500) NULL,
	//[CreatedByUserID]
	//[int]
	//NOT NULL,
	public class ClsTests
    {
public int TestID { get; set; }
		public int TestAppointmentID { get; set; }
		public bool TestResult { get; set; }
		public string Notes { get; set; }
		public int CreatedByUserID { get; set; }
		enum EnMode { Add = 1, Update = 2 };
		EnMode _Mode = EnMode.Update;
		private ClsTests(int TestID, int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
			this.TestAppointmentID = TestAppointmentID;
			this.TestID = TestID;
			this.TestResult = TestResult;
			this.Notes = Notes;
			this.CreatedByUserID = CreatedByUserID;
			_Mode = EnMode.Update;
        }
		public ClsTests()
        {
			this.TestAppointmentID = -1;
			this.TestID = -1;
			this.TestResult = false;
			this.Notes = string.Empty;
			this.CreatedByUserID = -1;
			_Mode = EnMode.Add;
		}
		private bool _AddTest()
        {
			this.TestID = ClsDataTests.AddTest(this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUserID);
			return TestID != -1;
        }
		private bool _UpdateTest()
        {
			return ClsDataTests.UpdateTest(this.TestID, this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUserID);
        }
		public bool Save()
		{
			switch (_Mode)
			{
				case EnMode.Add:
					{
						_Mode = EnMode.Update;
						return _AddTest();
					}
				case EnMode.Update:
					return _UpdateTest();
				default:
					return false;
			}
		}
		static public ClsTests FindByTestID(int TestID)
        {

			int _TestAppointmentID = -1;
			bool _TestResult = false;
			string _Notes = string.Empty;
			int _CreatedByUserID = -1;
			if (ClsDataTests.GetTestByTestID(TestID, ref _TestAppointmentID, ref _TestResult,ref _Notes, ref _CreatedByUserID))
            {
				return new ClsTests(TestID, _TestAppointmentID, _TestResult, _Notes, _CreatedByUserID);
            }
			else
            {
				return null;
            }
		}
		static public ClsTests FindByTestAppointmentID(int TestAppointmentID)
		{

			int TestID = -1;
			bool _TestResult = false;
			string _Notes = string.Empty;
			int _CreatedByUserID = -1;
			if (ClsDataTests.GetTestByTestAppointmentID(TestAppointmentID,ref TestID, ref _TestResult, ref _Notes, ref _CreatedByUserID))
			{
				return new ClsTests(TestID, TestAppointmentID, _TestResult, _Notes, _CreatedByUserID);
			}
			else
			{
				return null;
			}
		}
		public bool Delete()
        {
			return ClsDataTests.DeleteTest(this.TestID);
        }
		static public DataTable GetAllTests()
        {
			return ClsDataTests.GetAllTests();
        }
		static public bool IsPass(int LocalDrivingLicenseID,int TestTypeID)
        {
			return ClsDataTests.IsPass(LocalDrivingLicenseID, TestTypeID);
        }

		static public int CountFailedTest(int LocalDrivingLicenseID, int TestTypeID)
        {
			return ClsDataTests.GetCountFailedTests(LocalDrivingLicenseID, TestTypeID);
        }
    }
}
