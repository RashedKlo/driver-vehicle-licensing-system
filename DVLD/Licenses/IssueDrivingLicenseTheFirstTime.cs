using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessAccess;
namespace DVLD
{
   
    public partial class IssueDrivingLicenseTheFirstTime : Form
    {
        ClsLicenses _License;
        ClsLocalDrivingLicenseApplications _LocalDrivingLicense;
        ClsLicenseClasses _LicenseClass;
        ClsApplication _Application;
        ClsDrivers _Driver;
        public IssueDrivingLicenseTheFirstTime(int LocalDrivingLicenseID,int PassedCount)
        {
            InitializeComponent();
            LocalDrivingLicenseApplications.SendDataToCTRDrivingLicenseApplicationInfo(LocalDrivingLicenseID, PassedCount);
            _LocalDrivingLicense = ClsLocalDrivingLicenseApplications.Find(LocalDrivingLicenseID);
            _LicenseClass = ClsLicenseClasses.FindByID(_LocalDrivingLicense.LicenseClassID);
            _Application = ClsApplication.FindApplicationByID(_LocalDrivingLicense.ApplicationID);
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
       
        private void SetUserID()
        {
            _License.CreatedByUserID = ClsSettings.CurrentUser.UserID;
        }
        private void SetIssueReason(byte IssueReason)
        {
            _License.IssueReason = IssueReason;
        }
        private void SetNotes()
        {
            if (Txt_Notes.Text != string.Empty)
                _License.Notes = Txt_Notes.Text;
            else
                _License.Notes = string.Empty;
        }
        private void SetPaidFees()
        {
            _License.PaidFees = _LicenseClass.ClassFees;
        }
        private void SetExpirationDate()
        {
            int Years = _LicenseClass.DefaultValidityLength;
            _License.ExpirationDate = DateTime.Now.AddYears(Years);
        }
        private void SetIssueDate()
        {
            _License.IssueDate = DateTime.Now;

        }
        private void SetApplicationID()
        {
            _License.ApplicationID = _LocalDrivingLicense.ApplicationID;

        }
        private void SetLicenseClassID()
        {
            _License.LicenseClassID = _LocalDrivingLicense.LicenseClassID;

        }
        private bool SaveDriver()
        {
       
                 _Driver = new ClsDrivers();
                _Driver.PersonID = _Application.ApplicationPersonID;
                _Driver.CreatedByUserID = ClsSettings.CurrentUser.UserID;
                _Driver.CreatedDate = DateTime.Now;
                return _Driver.Save ();
            
           
        }
        private bool SetDriverID()
        {
            if (!ClsDrivers.IsDriverExist(_Application.ApplicationPersonID))
            {
                if (SaveDriver())
                {
                    _License.DriverID = _Driver.DriverID;
                    return true;
                }
                else
                    return false;
            }
            else
            {
                _Driver = ClsDrivers.FindDirverByPersonID(_Application.ApplicationPersonID);
                if(_Driver!=null)
                {
                    _License.DriverID = _Driver.DriverID;
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }
        private bool SetApplicationStatus()
        {
 _Application.ApplicationStatus = 3;
          return   _Application.Save();
        }
        private bool Save()
        {
            _License = new ClsLicenses();
            SetApplicationID();
            SetLicenseClassID();
            SetIssueDate();
            SetExpirationDate();
            SetNotes();
            SetPaidFees();
            SetUserID();
            SetIssueReason(1);
            _License.IsActive = true;
            return SetDriverID() && _License.Save() && SetApplicationStatus ();
           
        }
        private void Btn_Issue_Click(object sender, EventArgs e)
        {
           
            if (Save())
            {
                MessageBox.Show("Saved Successfuly", "Check Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Saved is Failed ", "Check Save", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
