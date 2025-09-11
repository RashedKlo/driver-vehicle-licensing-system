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
    public partial class LocalDrivingLicenseApplications : Form
    {
        DataView _View;
        static public event Action<int, int> SendLocalDrivingLicenseApplicationID;
        static public void SendDataToCTRDrivingLicenseApplicationInfo(int LocalDrivingID, int PassedCount)
        {
            if (SendLocalDrivingLicenseApplicationID != null)
            {
                Action<int, int> Handler = SendLocalDrivingLicenseApplicationID;
                if (Handler != null)
                {
                    SendLocalDrivingLicenseApplicationID(LocalDrivingID, PassedCount);
                }
            }
        }
        static public event Action<int, int, int> SendLocalIDWithAppointmentTestIDWithTypeTestID;
        static public void SendLocalIDWithAppointmentTestToCTRSechduleTest(int LocalDrivingID, int TestAppointmentID, int TestTypeID)
        {
            if (SendLocalIDWithAppointmentTestIDWithTypeTestID != null)
            {
                Action<int, int, int> Handler = SendLocalIDWithAppointmentTestIDWithTypeTestID;
                if (Handler != null)
                {
                    SendLocalIDWithAppointmentTestIDWithTypeTestID(LocalDrivingID, TestAppointmentID, TestTypeID);
                }
            }
        }
        public LocalDrivingLicenseApplications()
        {
            InitializeComponent();
        }
        private void RefreshData()
        {  
            Cb_FilterBy.SelectedIndex = 0;
            dataGridView1.DataSource = _View = ClsLocalDrivingLicenseApplications.GetAllLocalDrivingLicenseApplications().DefaultView ;
            Lb_Records.Text = dataGridView1.RowCount.ToString();
        }
        private void LocalDrivingLicenseApplications_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
        private void Btn_AddLicense_Click(object sender, EventArgs e)
        {
         
            NewLocalDrivingLicenseApplications Frm = new NewLocalDrivingLicenseApplications();
            Frm.ShowDialog();
            RefreshData();
        }
        private int GetLocalDrivingLicenseID()
        {
            int LocalDrivingLicenseID = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            return LocalDrivingLicenseID;
        }
        private bool SetStatus(byte Status)
        {
            ClsLocalDrivingLicenseApplications L_D_App = ClsLocalDrivingLicenseApplications.Find(GetLocalDrivingLicenseID());
            ClsApplication App = ClsApplication.FindApplicationByID(L_D_App.ApplicationID);
            App.ApplicationStatus = Status;
            return App.Save();

        }
        private void CancelAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Want To Cancel ", "Check Cancel", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (SetStatus(2))
                {
                    MessageBox.Show(" Done !", "Check Cancel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(" Not Done !", "Check Cancel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            RefreshData();
        }
        private void Cb_FilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            Txt_RowFilter.Clear();
            if (Cb_FilterBy.SelectedIndex == 0)
            {
                Txt_RowFilter.Visible = false;
            }
            else
            {
                Txt_RowFilter.Visible = true;
                Txt_RowFilter.Focus();
            }
        }
        private void Txt_RowFilter_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_RowFilter.Text))
            {
                _View.RowFilter = "";
                return;
            }
            if ( Cb_FilterBy.Text.Equals("ID"))
            {

                if (int.TryParse(Txt_RowFilter.Text, out int Result))
                    _View.RowFilter = $"{Cb_FilterBy.Text} = {Result} ";
                else
                    Txt_RowFilter.Clear();
            }
            else
            {
                _View.RowFilter = $"{Cb_FilterBy.Text} LIKE '{Txt_RowFilter.Text}*' ";
            }
        }
        private void Clear()
        {
            
            VisionTest.Enabled = false;
            WrittenTest.Enabled = false;
            StreetTest.Enabled = false;
      

        }
        private void OpenTest()
        {
            Clear();
            
            switch (GetPassedTestCount())
            {
                case 0:
                    {
                VisionTest.Enabled = true;
                        break;
                    }
                case 1:
                    {
                WrittenTest.Enabled = true;
                        break;
                    }
                case 2:
                    {
                StreetTest.Enabled = true;
                        break;
                    }
                 
            }
        }
        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenTest();
        }
        private void CMS_ManagePeople_Opening(object sender, CancelEventArgs e)
        {
            int PassedCount = GetPassedTestCount();
            string Status = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            issuingDrivingLicenseFirstTimeToolStripMenuItem.Enabled = PassedCount==3 && Status.Equals("New");
            SechduleTestToolStripMenuItem.Enabled = PassedCount != 3;
            showLicenseToolStripMenuItem.Enabled = Status.Equals("Completed");
            EditApplicationToolStripMenuItem.Enabled = DeleteToolStripMenuItem.Enabled = CancelAppToolStripMenuItem.Enabled = !showLicenseToolStripMenuItem.Enabled;
        }

        private void VisionTest_Click(object sender, EventArgs e)
        {
          
            VisionTestAppointments appointments = new VisionTestAppointments(GetLocalDrivingLicenseID(), GetPassedTestCount());
            appointments.ShowDialog();
            RefreshData();
        }

        private void WrittenTest_Click_1(object sender, EventArgs e)
        {
            WrittenTestAppointment appointments = new WrittenTestAppointment(GetLocalDrivingLicenseID(), GetPassedTestCount());
            appointments.ShowDialog();
            RefreshData(); 
        }

        private void StreetTest_Click_1(object sender, EventArgs e)
        {
            StreetTestAppointment appointments = new StreetTestAppointment(GetLocalDrivingLicenseID(),GetPassedTestCount());
            appointments.ShowDialog();
            RefreshData();
        }

        private void issuingDrivingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueDrivingLicenseTheFirstTime Issue = new IssueDrivingLicenseTheFirstTime(GetLocalDrivingLicenseID(), GetPassedTestCount());
            Issue.ShowDialog();
            RefreshData();
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClsLocalDrivingLicenseApplications L_D_App = ClsLocalDrivingLicenseApplications.Find(GetLocalDrivingLicenseID());
            int LicenseID = ClsLicenses.FindLicenseByApplicationID(L_D_App.ApplicationID).LicenseID;
            ShowLicenseInfo LicenseInfo = new ShowLicenseInfo(LicenseID);
            LicenseInfo.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClsLocalDrivingLicenseApplications L_D_App = ClsLocalDrivingLicenseApplications.Find(GetLocalDrivingLicenseID());
            int LicenseID = ClsLicenses.FindLicenseByApplicationID(L_D_App.ApplicationID).LicenseID;
            LicenseHirstory history = new LicenseHirstory(LicenseID);
            history.ShowDialog();
        }
        private int GetPassedTestCount()
        {
            int PassedCount = int.Parse(dataGridView1.SelectedRows[0].Cells[5].Value.ToString());
            return PassedCount;

        }
        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationDetails Details = new ApplicationDetails();
            SendDataToCTRDrivingLicenseApplicationInfo(GetLocalDrivingLicenseID(), GetPassedTestCount());
            Details.ShowDialog();
        }

        private void EditApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {

  
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
          if(  MessageBox.Show ("Are You Sure To Delete","Delete License",MessageBoxButtons.OK,MessageBoxIcon.Question)==DialogResult.OK)
            {
if(ClsLocalDrivingLicenseApplications.DeleteLocalLicens(GetLocalDrivingLicenseID()))
                {
                    MessageBox.Show("Deleted Successfuly");
                }
else
                    MessageBox.Show("Delete is Failed");

                RefreshData();
            }


        }
    }
}
