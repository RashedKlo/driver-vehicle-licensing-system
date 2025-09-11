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
    public partial class ReleaseDetainedLicense : Form
    {
        int _LicenseID;
        ClsDetainedLicense _DetainedLicense;
        ClsApplication _NewApplication;
        ClsLicenses _License;
        ClsDrivers _Driver;
        decimal ApplicationFees;
        public ReleaseDetainedLicense()
        {
            InitializeComponent();
            MainDVLD.SendModeToCtrFilterLicense(5);
            ctrFilterLicense1.SendLicenseIDToRenewLicense += SetLicenseID;
        }
        private void SetLicenseID(int LicenseID, bool isActive)
        {
            _LicenseID = LicenseID;
            Btn_Save.Enabled = Lb_ShowLicenseInfo.Enabled = isActive;
            if (isActive)
            {
                Lb_ShowLicenseHistory.Enabled = true;
                _License = ClsLicenses.FindLicenseByID(_LicenseID);
                _Driver = ClsDrivers.FindDirverByDriverID(_License.DriverID);
                _DetainedLicense = ClsDetainedLicense.FindDetainedLicenseByLicenseID(_LicenseID);
                LoadData();
            }
            else
                ClearData();
        }
        private void ClearData()
        {
            Lb_CreatedBy.Text = "???";
             Lb_DetainID.Text = "???";
           Lb_DetainDate.Text = "???";
      Lb_ApplicationFees.Text = "???";
            Lb_LicenseID.Text = "???";
             Lb_FineFees.Text = "???";
            Lb_TotalFees.Text = "???";
        }
        private void LoadData()
        {
             ApplicationFees = ClsApplicationTypes.Find(5).ApplicationFees;
            decimal FineFees = _DetainedLicense.FineFees;
            decimal TotalFees = ApplicationFees + FineFees;
            Lb_CreatedBy.Text = ClsSettings.CurrentUser.UserName;
            Lb_DetainID.Text = _DetainedLicense.DetainID.ToString();
            Lb_DetainDate.Text = _DetainedLicense.DetainDate.ToShortDateString();
            Lb_ApplicationFees.Text = ApplicationFees.ToString();
            Lb_LicenseID.Text = _LicenseID.ToString();
            Lb_FineFees.Text = FineFees.ToString();
           
            Lb_TotalFees.Text = TotalFees .ToString();

        }

        private void ReleaseDetainedLicense_Load(object sender, EventArgs e)
        {
        }
        private void Lb_ShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicenseHirstory history = new LicenseHirstory(_LicenseID);
            history.ShowDialog();

        }

        private void Lb_ShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowLicenseInfo LicenseInfo = new ShowLicenseInfo(_LicenseID);
            LicenseInfo.ShowDialog();
        }
        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool SaveApplicationsData()
        {
            _NewApplication = new ClsApplication();
            _NewApplication.ApplicationPersonID = _Driver.PersonID;
            _NewApplication.ApplicationDate = DateTime.Now;

            _NewApplication.PaidFees = ApplicationFees;
            _NewApplication.CreatedByUserID = ClsSettings.CurrentUser.UserID;
            _NewApplication.ApplicationStatus = 3;
            _NewApplication.ApplicationTypeID = 5;
            _NewApplication.LastStatusDate = DateTime.Now;
            return _NewApplication.Save();
        }
        private bool SaveReleaseDetainedLicense()
        {
            _DetainedLicense.ReleasedByUserID= ClsSettings.CurrentUser.UserID;
            _DetainedLicense.IsReleased = true;
            _DetainedLicense.ReleaseDate = DateTime.Now;
            _DetainedLicense.ReleaseApplicationID = _NewApplication.ApplicationID;
            return _DetainedLicense.Save();
        }
        private bool Save()
        {
            if (SaveApplicationsData())
            {
                if (SaveReleaseDetainedLicense())
                {
                    return true;
                }
            }
            return false;
        }
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (Save())
            {
                MessageBox.Show("Saved Successfuly", "Check Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Lb_ApplicationID.Text = _NewApplication.ApplicationID.ToString();
                Btn_Save.Enabled = false;
              
            }
            else
                MessageBox.Show("Save is Failed", "Check Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
