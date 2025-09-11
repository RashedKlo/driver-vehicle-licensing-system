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
    public partial class NewInternationalLicenseApplication : Form
    {
        ClsApplication _Application;
        ClsInternationalDrivingLicense _InternationalLicense;
        int _LocalDrivingLicenseID;
        public NewInternationalLicenseApplication()
        {
            InitializeComponent();
            MainDVLD.SendModeToCtrFilterLicense(1);
            ctrFilterLicense1.SendLicenseIDToRenewLicense += SetLocalDrivingLicenseID;
           


        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SetPersonID()
        {
           _Application.ApplicationPersonID = ctrFilterLicense1.ctrLicenseInfo1.GetPersonID();
        }
        private void SetApplicationDate()
        {
            _Application.ApplicationDate = DateTime.Parse(Lb_ApplicationDate.Text);

        }
        private void SetApplicationFees()
        {
            _Application.PaidFees = decimal.Parse(Lb_ApplicationFees.Text);

        }

        private void SetUserID()
        {
            _Application.CreatedByUserID = ClsSettings.CurrentUser.UserID;

        }
        private void SetStatus(byte Status)
        {
            _Application.ApplicationStatus = Status;
        }
        private void SetApplicationType(int TypeID)
        {
            _Application.ApplicationTypeID = TypeID;

        }
        private void SetLastStatusDate()
        {
            _Application.LastStatusDate = DateTime.Parse(Lb_ApplicationDate.Text);
        
        }
        private void SetLocalDrivingLicenseID(int LicenseID, bool isDateActive)
        {
         
                _LocalDrivingLicenseID = ctrFilterLicense1.GetLocalDrivingLicenseID();
        }

        private void LoadData()
        {
            Lb_CreatedBy.Text = ClsSettings.CurrentUser.UserName;
            Lb_ApplicationDate.Text = DateTime.Now.ToShortDateString();
            Lb_ApplicationFees.Text = ClsApplicationTypes.Find(6).ApplicationFees.ToString();
            Lb_IssueDate.Text = DateTime.Now.ToShortDateString();
            Lb_LocalLicenseID.Text  = _LocalDrivingLicenseID.ToString();
            Lb_ExpirationDate.Text = DateTime.Now.AddYears(1).ToShortDateString();
        }
       
        private bool SaveApplicationsData()
        {
            SetPersonID();
            SetApplicationDate();
            SetApplicationFees();
            SetUserID();
            SetStatus(1);
            SetApplicationType(6);
            SetLastStatusDate();
            return _Application.Save();
        }
        //SELECT TOP(1000) [InternationalLicenseID]
        //  ,[ApplicationID]
        //  ,[DriverID]
        //  ,[IssuedUsingLocalLicenseID]
        //  ,[IssueDate]
        //  ,[ExpirationDate]
        //  ,[IsActive]
        //  ,[CreatedByUserID]
        //FROM[DVLD].[dbo].[InternationalLicenses]
        private void SetApplicationID()
        {
            _InternationalLicense.ApplicationID = _Application.ApplicationID;
        }
        private void SetDriverID()
        {
           _InternationalLicense.DriverID = ctrFilterLicense1.ctrLicenseInfo1._License.DriverID;
        }
        private void SetLicenseID()
        {
            _InternationalLicense.IssuedUsingLocalLicenseID = ctrFilterLicense1.ctrLicenseInfo1._License.LicenseID;
        }
        private void SetIssueDate()
        {
            _InternationalLicense.IssueDate = DateTime.Parse(Lb_IssueDate.Text);
        }
        private void SetIsActive(bool IsActive)
        {
            _InternationalLicense.IsActive = IsActive;
        }
        private void SetCreatedByUserID()
        {
            _InternationalLicense.CreatedByUserID = ClsSettings.CurrentUser.UserID;
        }
        private void SetExpiratioinDate()
        {
            _InternationalLicense.ExpirationDate = DateTime.Parse(Lb_ExpirationDate.Text);
        }
        private bool SaveInternationalLicense()
        {
            SetApplicationID();
            SetDriverID();
            SetLicenseID();
            SetIssueDate();
            SetIsActive(true);
            SetCreatedByUserID();
            SetExpiratioinDate();
            return _InternationalLicense.Save() ;
        }
        private void Btn_Save_Click(object sender, EventArgs e)
        {

           if (SaveApplicationsData() &&SaveInternationalLicense())
            {
                MessageBox.Show("Saved Successfuly", "Check Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Lb_InternationalLicenseID.Text = _InternationalLicense.InternationalLicenseID.ToString();
                Lb_ApplicationID.Text = _Application.ApplicationID.ToString();
                Btn_Save.Enabled = false;
                Lb_ShowLicenseInfo.Enabled = true;

            }
           else
                MessageBox.Show("Save is Failed", "Check Save", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void NewInternationalLicenseApplication_Load(object sender, EventArgs e)
        {
            _Application = new ClsApplication();
            _InternationalLicense = new ClsInternationalDrivingLicense();
            LoadData();
        }

        private void ctrFilterLicense1_Load_1(object sender, EventArgs e)
        {

        }
private int GetLocalDrivingLicenseID()
        {
            return int.Parse(Lb_LocalLicenseID.Text);
        }
        private void Lb_ShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowLicenseInfo LicenseInfo = new ShowLicenseInfo(GetLocalDrivingLicenseID());
            LicenseInfo.ShowDialog();
        }

        private void Lb_ShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicenseHirstory history = new LicenseHirstory(GetLocalDrivingLicenseID());
            history.ShowDialog();
        }
    }
}
