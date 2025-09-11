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
    public partial class RenewLicenseApplication : Form
    {
        int _LicenseID;
        ClsLicenses _NewLicense;
        ClsLicenses _OLdLicense;
        ClsApplication _NewApplication;
        ClsApplication _OldApplication;
        public RenewLicenseApplication()
        {
            InitializeComponent();
            MainDVLD.SendModeToCtrFilterLicense(2);
            ctrFilterLicense1.SendLicenseIDToRenewLicense += SetLicenseID;
        }
     
        private void SetLicenseID(int LicenseID,bool isDateActive)
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
   Lb_LicenseFees.Text = "???";
Lb_ExpirationDate.Text = "???";
            Lb_TotalFees.Text = "???";
            Lb_OldLicenseID.Text = "???";
        }
        private void LoadDataRest()
        {   
            Lb_LicenseFees.Text = ClsLicenseClasses.FindByID(_OLdLicense.LicenseClassID).ClassFees.ToString();
            Lb_ExpirationDate.Text = DateTime.Now.AddYears(ClsLicenseClasses.FindByID(_OLdLicense.LicenseClassID).DefaultValidityLength).ToShortDateString();
            decimal Fees = decimal.Parse (Lb_ApplicationFees.Text) + decimal.Parse(Lb_LicenseFees.Text);
          Lb_TotalFees.Text = Fees.ToString();
            Lb_OldLicenseID.Text = ctrFilterLicense1._License.LicenseID.ToString();
          
        }
        private void LoadData()
        {
            Lb_CreatedBy.Text = ClsSettings.CurrentUser.UserName;
            Lb_ApplicationDate.Text = DateTime.Now.ToShortDateString();
            Lb_ApplicationFees.Text = ClsApplicationTypes.Find(2).ApplicationFees.ToString();
            Lb_IssueDate.Text = DateTime.Now.ToShortDateString();
        }
        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RenewLicenseApplication_Load(object sender, EventArgs e)
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
            _NewLicense.Notes = Txt_Notes.Text;
            _NewLicense.PaidFees = _OLdLicense.PaidFees;
           _NewLicense.CreatedByUserID = ClsSettings.CurrentUser.UserID;
            _NewLicense.IssueReason = 2;
            _NewLicense.IsActive = true;
          
            _NewLicense.DriverID = _OLdLicense.DriverID;
        
            return _NewLicense.Save();

        }
     private bool SaveApplicationsData()
        {
            _NewApplication = new ClsApplication();
            _NewApplication.ApplicationPersonID = _OldApplication.ApplicationPersonID;
            _NewApplication.ApplicationDate = DateTime.Now;
            _NewApplication.PaidFees = ClsApplicationTypes.Find(2).ApplicationFees;
            _NewApplication.CreatedByUserID = ClsSettings.CurrentUser.UserID;
            _NewApplication.ApplicationStatus = 3;
            _NewApplication.ApplicationTypeID = 2;
            _NewApplication.LastStatusDate = DateTime.Now;
            return _NewApplication.Save() ;
        }
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (SaveApplicationsData())
                if (SavenewLicenseApplication())
                {
                     
                    _OLdLicense.IsActive = false;
                    _OLdLicense.Save();
                    MessageBox.Show("Saved Successfuly", "Check Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Lb_NewLicenseID.Text = _NewLicense.LicenseID.ToString();
                    Lb_ApplicationID.Text = _NewApplication.ApplicationID.ToString();
                    Btn_Save.Enabled = false;
                    Lb_ShowLicenseInfo.Enabled = true;
                }
                else
                    MessageBox.Show("Save is Failed", "Check Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ctrFilterLicense1_Load(object sender, EventArgs e)
        {

        }
    }

}
