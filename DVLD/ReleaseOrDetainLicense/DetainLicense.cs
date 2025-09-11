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
    public partial class DetainLicense : Form
    {
        int _LicenseID;
        ClsDetainedLicense _DetainedLicense;
        public DetainLicense()
        {
            InitializeComponent();
            MainDVLD.SendModeToCtrFilterLicense(4);
            ctrFilterLicense1.SendLicenseIDToRenewLicense += SetLicenseID;
        }
        private void SetLicenseID(int LicenseID, bool isActive)
        {
            _LicenseID = LicenseID;
            Btn_Save.Enabled = Lb_ShowLicenseInfo.Enabled = isActive;
            if (isActive)
            {
               
                Lb_ShowLicenseHistory.Enabled = true;

                LoadDataRest();
            }
            else
                ClearData();
        }
        private void ClearData()
        {
            Lb_LicenseID.Text = "???";
            Lb_DetainID.Text = "???";
        }
        private void LoadDataRest()
        {
            Lb_LicenseID.Text= _LicenseID.ToString();
        }
        private void LoadData()
        {
            Lb_DetainDate.Text = DateTime.Now.ToShortDateString();
            Lb_CreatedBy.Text = ClsSettings.CurrentUser.UserName;
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //CREATE TABLE[dbo].[DetainedLicenses]
        //  [DetainID][int] IDENTITY(1,1) NOT NULL,
        // [LicenseID] [int]
        //NOT NULL,
        // [DetainDate] [smalldatetime]
        //NOT NULL,
        // [FineFees] [smallmoney]
        //NOT NULL,
        // [CreatedByUserID] [int]
        //NOT NULL,
        // [IsReleased] [bit]
        //NOT NULL,
        // [ReleaseDate] [smalldatetime] NULL,
        //[ReleasedByUserID] [int] NULL,
        //[ReleaseApplicationID] [int] NULL,
        private bool Save()
        {
            if (string.IsNullOrEmpty(Txt_FineFees.Text))
                return false;

             _DetainedLicense = new ClsDetainedLicense();
            _DetainedLicense.LicenseID = _LicenseID;
            _DetainedLicense.DetainDate = DateTime.Now;
            _DetainedLicense.CreatedByUserID = ClsSettings.CurrentUser.UserID;
            _DetainedLicense.IsReleased = false;
            _DetainedLicense.FineFees = decimal.Parse(Txt_FineFees.Text);
           return _DetainedLicense.Save();
        }
        private void Btn_Save_Click(object sender, EventArgs e)
        { 
           if (Save())
            {
                MessageBox.Show("Save Successfuly", "Detained License", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Lb_DetainID.Text = _DetainedLicense.DetainID.ToString();
            }
           else
                MessageBox.Show("Saved is Failed", "Detained License", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void DetainLicense_Load(object sender, EventArgs e)
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
        private void Txt_FineFees_TextChanged(object sender, EventArgs e)
        {
 if (!int.TryParse(Txt_FineFees.Text, out int Result))
                Txt_FineFees.Clear();
        }
    }
}
