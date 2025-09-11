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
    public partial class LostorDamagedLicense : Form
    {
        int _LicenseID;
        ClsLicenses _NewLicense;
        ClsLicenses _OLdLicense;
        ClsApplication _NewApplication;
        ClsApplication _OldApplication;
        public LostorDamagedLicense()
        {
            InitializeComponent();
            MainDVLD.SendModeToCtrFilterLicense(3);
            ctrFilterLicense1.SendLicenseIDToRenewLicense += SetLicenseID;
        }
        private void SetLicenseID(int LicenseID, bool isDateActive)
        {
            _LicenseID = LicenseID;
            Btn_Save.Enabled = Lb_ShowLicenseInfo.Enabled = isDateActive;
            if (isDateActive)
            {
                _OLdLicense = ClsLicenses.FindLicenseByID(LicenseID);
                _OldApplication = ClsApplication.FindApplicationByID(_OLdLicense.ApplicationID);
                Lb_ShowLicenseHistory.Enabled = true;

                LoadDataRest();
            }
            else
                ClearData();
        }
        private void ClearData()
        {
            Lb_ApplicationFees.Text = "???";
            Lb_ReplaceLicenseID.Text = "???";
            Lb_OldLicenseID.Text = "???";
        }
        private void LoadDataRest()
        {
            Lb_OldLicenseID.Text = ctrFilterLicense1._License.LicenseID.ToString();

        }
        private decimal GetFees()
        {
            decimal Fees = 0;
            if (Rb_Damaged.Checked)
            {
                Fees = ClsApplicationTypes.Find(4).ApplicationFees;
                Lb_Header.Text = "Replacement for Damaged License";
            }
            else
            {                Fees = ClsApplicationTypes.Find(3).ApplicationFees;
            Lb_Header.Text = "Replacement for Lost License"; }
            return Fees;
        }
        private void LoadData()
        {
            Lb_CreatedBy.Text = ClsSettings.CurrentUser.UserName;
            Lb_ApplicationDate.Text = DateTime.Now.ToShortDateString();
            Lb_ApplicationFees.Text = GetFees().ToString ();
    
        }
        private int GetApplicationType()
        {
            if (Rb_Damaged.Checked)
            {
                return 4;
            }
            else return 3;
        }
        private byte GetIssueReason()
        {
            if (Rb_Damaged.Checked)
            {
                return 3;
            }
            else return 4;
        }

        private void LostorDamagedLicense_Load(object sender, EventArgs e)
        {
            LoadData();
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
        private bool SavenewLicenseApplication()
        {
            _NewLicense = new ClsLicenses();
            _NewLicense.ApplicationID = _NewApplication.ApplicationID;
            _NewLicense.LicenseClassID = _OLdLicense.LicenseClassID;
            _NewLicense.IssueDate = DateTime.Now;
            _NewLicense.ExpirationDate = DateTime.Now.AddYears(ClsLicenseClasses.FindByID(_OLdLicense.LicenseClassID).DefaultValidityLength);
            _NewLicense.Notes = _OLdLicense.Notes;
            _NewLicense.PaidFees = _OLdLicense.PaidFees;
            _NewLicense.CreatedByUserID = ClsSettings.CurrentUser.UserID;
         
            _NewLicense.IssueReason = GetIssueReason ();
            _NewLicense.IsActive = true;

            _NewLicense.DriverID = _OLdLicense.DriverID;

            return _NewLicense.Save();

        }
        private bool SaveApplicationsData()
        {
            _NewApplication = new ClsApplication();
            _NewApplication.ApplicationPersonID = _OldApplication.ApplicationPersonID;
            _NewApplication.ApplicationDate = DateTime.Now;
       
            _NewApplication.PaidFees = GetFees ();
            _NewApplication.CreatedByUserID = ClsSettings.CurrentUser.UserID;
            _NewApplication.ApplicationStatus = 3;
            _NewApplication.ApplicationTypeID = GetApplicationType();
            _NewApplication.LastStatusDate = DateTime.Now;
            return _NewApplication.Save();
        }
        private bool Save()
        {
            if (SaveApplicationsData())
            {
                if (SavenewLicenseApplication())
                {

                    _OLdLicense.IsActive = false;
                    return _OLdLicense.Save();
                }
            }
            return false;

        }
        private void Btn_Save_Click(object sender, EventArgs e)
        {
           if (Save())
            {
    MessageBox.Show("Saved Successfuly", "Check Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Lb_ReplaceLicenseID.Text = _NewLicense.LicenseID.ToString();
                    Lb_ApplicationID.Text = _NewApplication.ApplicationID.ToString();
                    Btn_Save.Enabled = false;
                    Lb_ShowLicenseInfo.Enabled = true;
            }
                else
                    MessageBox.Show("Save is Failed", "Check Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Rb_Lost_CheckedChanged(object sender, EventArgs e)
        {
            Lb_ApplicationFees.Text = GetFees().ToString();
           

        }
    }
}
