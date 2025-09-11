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
    public partial class TakeTest : Form
    {
        int _LocalDrivingLicenseApplicationID;
        int _TestTypeID;
        int _AppointmentID;
        ClsLicenseClasses _LicenseClasses;
        ClsLocalDrivingLicenseApplications _LocalDrivingApplications;
        ClsPerson _Person;
        ClsApplication _Application;
        ClsTestAppointment _Appointment;
        ClsTests _Test;
        public TakeTest(int LocalDrivingLicenseApplicationID,int TestTypeID,int AppointmentID)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            _TestTypeID = TestTypeID;
            _AppointmentID = AppointmentID;
            _LocalDrivingApplications = ClsLocalDrivingLicenseApplications.Find(_LocalDrivingLicenseApplicationID);
            _LicenseClasses = ClsLicenseClasses.FindByID(_LocalDrivingApplications.LicenseClassID);
            _Application = ClsApplication.FindApplicationByID(_LocalDrivingApplications.ApplicationID);
            _Appointment = ClsTestAppointment.FindAppointmentByID(_AppointmentID);
            _Person = ClsPerson.FindByID(_Application.ApplicationPersonID);
            _Test = new ClsTests();
        }
        private string GetFullName()
        {
            return _Person.FirstName + " " + _Person.SecondName + " " + _Person.ThirdName + " " + _Person.LastName;
        }
        private void SetTrials()
        {
            int CountFailedTest = ClsTests.CountFailedTest(_LocalDrivingLicenseApplicationID, _TestTypeID);

            Lb_Trial.Text = CountFailedTest.ToString();
        }
        private void LoadData()
        {
      Lb_DrivingLicenseApplicationID.Text = _LocalDrivingLicenseApplicationID.ToString();
            Lb_ClassName.Text = _LicenseClasses.ClassName;
            Lb_FullName.Text = GetFullName();
            SetTrials();
            Lb_AppointmentDate.Text = _Appointment.AppointmentDate.ToShortDateString();
            Lb_Fees.Text = ClsTestTypes.Find(_TestTypeID).TestTypeFees.ToString();
        }
        private void TakeTest_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //CREATE TABLE[dbo].[Tests]
        //(

        //  [TestID][int] IDENTITY(1,1) NOT NULL,

        // [TestAppointmentID] [int]
        //NOT NULL,

        // [TestResult] [bit]
        //NOT NULL,

        // [Notes] [nvarchar] (500) NULL,
        //[CreatedByUserID]
        //[int]
        //NOT NULL,
        private void SetNotes()
        {
            if (string.IsNullOrEmpty(Txt_Notes.Text))
            {
                _Test.Notes = string.Empty;
            }
            else
            _Test.Notes = Txt_Notes.Text;
        }
        private void SetResult()
        {
            _Test.TestResult = Rb_Pass.Checked;
        }
        private bool SetLockedAppointment()
        {
            _Appointment.IsLocked = true;
            return _Appointment.Save();
        }
        private bool Save()
        {
            _Test.TestAppointmentID = _AppointmentID;
            SetNotes();
            SetResult();
            _Test.CreatedByUserID = ClsSettings.CurrentUser.UserID;
            return SetLockedAppointment() && _Test.Save();
        }
        private void Btn_Save_Click(object sender, EventArgs e)
        {
         if (Save())
            {

                Btn_Save.Enabled = false;
                MessageBox.Show("Save Successfuly", "Check Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

         else
                MessageBox.Show("Save is Failed ", "Check Save", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }
    }
}
