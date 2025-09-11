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
    public partial class VisionTestAppointments : Form
    {
        int _LocalDrivingLicenseID;
        DataView _View;
        const int _TypeID = 1;

       
        public VisionTestAppointments(int LocalDrivingLicenseID,int PassedCount)
        {
            InitializeComponent();
            _LocalDrivingLicenseID = LocalDrivingLicenseID;
         LocalDrivingLicenseApplications.SendDataToCTRDrivingLicenseApplicationInfo(LocalDrivingLicenseID,PassedCount);
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      private void OpenSechduleTest(int AppointmentID)
        {
            SechduleTest Test = new SechduleTest();
            LocalDrivingLicenseApplications.SendLocalIDWithAppointmentTestToCTRSechduleTest(_LocalDrivingLicenseID, AppointmentID,_TypeID);
            Test.ShowDialog();
            RefreshData();
        }
       
         public DataTable SetDataTableTestAppointment(DataTable From)
        {
           
            DataTable To =GetDataTable(); ;

            foreach(DataRow Row in From.Rows)
            {
                int ID = (int)Row["TestAppointmentID"];
             DateTime Date = (DateTime)Row["AppointmentDate"];
                    decimal Fee = (Decimal)Row["PaidFees"]; 
                bool isLocked=(bool)Row["IsLocked"];

                To.Rows.Add(ID, Date, Fee, isLocked);
            }
            return To;
        }
         public  DataTable GetDataTable()
        {
            DataTable NewTable=new DataTable ();
            NewTable.Columns.Add("Appointment ID",typeof (int));
            NewTable.Columns.Add("Appointment Date",typeof(DateTime ));
            NewTable.Columns.Add("Paid Fees",typeof(decimal ));
            NewTable.Columns.Add("Is Locked", typeof(bool));
            return NewTable;
        }
        private void RefreshData()
        {
            _View = ClsTestAppointment.GetAllAppointments().DefaultView;
          
            _View.RowFilter = $"LocalDrivingLicenseApplicationID = {_LocalDrivingLicenseID} and TestTypeID = {_TypeID}";
  if(_View.Count!=0)
            dataGridView1.DataSource = SetDataTableTestAppointment(_View.ToTable ());

        }
        private bool IsPass()
        {
            return ClsTests.IsPass(_LocalDrivingLicenseID, _TypeID);

        }
        private void Btn_AddLicense_Click(object sender, EventArgs e)
        {
            if(ClsTestAppointment.isTestAppointmentByLocalDrivingIDExistandLocked(_LocalDrivingLicenseID,_TypeID,false))
            {
                MessageBox.Show("there is Already Active Appointment", "Check Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(ClsTestAppointment.isTestAppointmentByLocalDrivingIDExistandLocked(_LocalDrivingLicenseID,_TypeID,true))

            {
                if (IsPass())
                {
                    MessageBox.Show("Person is Passed the Test", "Check Test", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    OpenSechduleTest(-1);
                    if (IsPass())
                    {
                        ctrDrivingLicenseApplicationInfo1.SetPassedTest(1);
                    }
                }
                return;
            }
            OpenSechduleTest(-1);
         
        }  

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestAppointmentID = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            OpenSechduleTest(TestAppointmentID);
        }


        private void VisionTestAppointments_Load(object sender, EventArgs e)
        {
                  RefreshData();
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestAppointmentID = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            TakeTest Take = new TakeTest(_LocalDrivingLicenseID, _TypeID,TestAppointmentID);
            Take.ShowDialog();
            if (IsPass())
            {
                ctrDrivingLicenseApplicationInfo1.SetPassedTest(1);
            }
            RefreshData();

        }
    }
}
