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
    public partial class LicenseHirstory : Form
    {
        int _LicenseID;
        ClsLicenses _License;
        ClsApplication _Application;
        public LicenseHirstory(int LicenseID)
        {
            InitializeComponent();
            _LicenseID = LicenseID;
            _License = ClsLicenses.FindLicenseByID(LicenseID);
            _Application = ClsApplication.FindApplicationByID(_License.ApplicationID);
            ManagePeople.SendDataToFormPersonDetails(this,_Application.ApplicationPersonID);
            RefreshLocalLicense();
            RefreshInternationalLicense();
        }
        private void RefreshLocalLicense()
        {
            DGV_LocalLicenses.DataSource = ClsLocalDrivingLicenseApplications.GetAllLocalLicensesToPersonID(_Application.ApplicationPersonID);
            Lb_LocalRecords.Text = DGV_LocalLicenses.Rows.Count.ToString();

        }
        private void RefreshInternationalLicense()
        {
            DGV_InternationalLicenses.DataSource = ClsInternationalDrivingLicense.GetAllInternationalLicensesToPersonID(_Application.ApplicationPersonID);
            Lb_InternationalRecords.Text = DGV_InternationalLicenses.Rows.Count.ToString();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = int.Parse(DGV_LocalLicenses.SelectedRows[0].Cells[0].Value.ToString());
            ShowLicenseInfo LicenseInfo = new ShowLicenseInfo(LicenseID);
            LicenseInfo.ShowDialog();
        }
    }
}
