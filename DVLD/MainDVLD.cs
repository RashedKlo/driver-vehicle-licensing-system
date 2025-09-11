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
    public partial class MainDVLD : Form
    {
        public MainDVLD()
        {
            InitializeComponent();
        }

       static public Action<int> SendModeToCTRFilterLicense;
       static public void SendModeToCtrFilterLicense(int Mode)
        {
            if(SendModeToCTRFilterLicense!=null)
            {
                Action<int> Handler = SendModeToCTRFilterLicense;
                if (Handler != null)
                {
                    SendModeToCTRFilterLicense(Mode);
                }
            }
        }
        private void DVLD_Load(object sender, EventArgs e)
        {
        }


        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void Btn_People_Click(object sender, EventArgs e)
        { 
            ManagePeople From = new ManagePeople();
            From.ShowDialog();

        }

        private void Btn_Users_Click(object sender, EventArgs e)
        {
            ManageUser From = new ManageUser();
            From.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_AccountSettings_Click(object sender, EventArgs e)
        {
            Point point = new Point(696, 80);

            CM_AccountSettings.Show(point);

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = ClsSettings.CurrentUser.UserID;
            ChangePassword Frm = new ChangePassword(UserID);
            Frm.ShowDialog();
        }

        private void changeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = ClsSettings.CurrentUser.UserID;

            UserDetails Details = new UserDetails(UserID);
            Details.ShowDialog();
        }

        private void Btn_Applications_Click(object sender, EventArgs e)
        {
            Point point = new Point(0,80);
           
           
            CM_Applications.Show(point);
        }

        private void manageApplicationsTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageApplicationsTypes manageApplications = new ManageApplicationsTypes();
            manageApplications.ShowDialog();
        }

        private void mangeTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageTestTypes manageTestTypes = new ManageTestTypes();
            manageTestTypes.ShowDialog();
        }

        private void loaclDrivingLiscenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocalDrivingLicenseApplications frm = new LocalDrivingLicenseApplications();
            frm.ShowDialog();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewLocalDrivingLicenseApplications Frm = new NewLocalDrivingLicenseApplications();
            Frm.ShowDialog();
        }

        private void Btn_Drivers_Click(object sender, EventArgs e)
        {
            Drivers Frm = new Drivers();
            Frm.ShowDialog();
        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewInternationalLicenseApplication Frm = new NewInternationalLicenseApplication();
            Frm.ShowDialog();
        }

        private void internationalLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InternationalLicenseApplication frm = new InternationalLicenseApplication();
            frm.ShowDialog();
        }

        private void newDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RenewLicenseApplication Renew = new RenewLicenseApplication();
            Renew.ShowDialog();
        }

        private void replacementForLostOrDamagedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LostorDamagedLicense frm = new LostorDamagedLicense();
            frm.ShowDialog();
        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DetainLicense frm = new DetainLicense();
            frm.ShowDialog();
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReleaseDetainedLicense frm = new ReleaseDetainedLicense();
            frm.ShowDialog();
        }

        private void manageDetainedLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageDetainLicense Frm = new ManageDetainLicense();
            Frm.ShowDialog();
        }

        private void releaseDetainedDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReleaseDetainedLicense Frm = new ReleaseDetainedLicense();
            Frm.ShowDialog();
        }

        private void reTakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocalDrivingLicenseApplications Frm = new LocalDrivingLicenseApplications();
            Frm.ShowDialog();
        }
    }
}
