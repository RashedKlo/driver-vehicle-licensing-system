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
    public partial class CTRSechduleTest : UserControl
    {
        int _LocalDrivingLicenseApplicationID;
        int _TestAppointmentID;
        int _TestTypeID;
        ClsLicenseClasses _LicenseClasses;
        ClsLocalDrivingLicenseApplications _LocalDrivingApplications;
        ClsPerson _Person;
        public ClsTestAppointment _Appointment;
        ClsApplication _Application;
        bool _IsFail;
        enum EnMode { Add=1,Update=2};
        EnMode _Mode = EnMode.Update;
        public CTRSechduleTest()
        {
            InitializeComponent();
            LocalDrivingLicenseApplications.SendLocalIDWithAppointmentTestIDWithTypeTestID += VisionTestAppointments_SendLocalDrivingLicenseApplicationID;
       

        }
     
        private void VisionTestAppointments_SendLocalDrivingLicenseApplicationID(int obj,int TestAppointmentID,int TestTypeID)
        {
            _LocalDrivingLicenseApplicationID = obj;
            _LocalDrivingApplications = ClsLocalDrivingLicenseApplications.Find(obj);
           _Application = ClsApplication.FindApplicationByID(_LocalDrivingApplications.ApplicationID);
            _LicenseClasses = ClsLicenseClasses.FindByID(_LocalDrivingApplications.LicenseClassID);
            _Person = ClsPerson.FindByID(_Application.ApplicationPersonID);
            _TestAppointmentID = TestAppointmentID;
            _TestTypeID = TestTypeID;
            CheckMode(TestAppointmentID);
            AddOrUpdate();
        }
        private void SetTrials()
        {
            int CountFailedTest = ClsTests.CountFailedTest(_LocalDrivingLicenseApplicationID, _TestTypeID);

            Lb_Trial.Text = CountFailedTest.ToString();
        }
        private void CheckMode(int TestAppointmentID)
        {
            if(TestAppointmentID!=-1)
            {
                _Mode = EnMode.Update;
            }
            else
            {
                _Mode = EnMode.Add;
            }
        }
        private string GetFullName()
        {
            return _Person.FirstName + " " + _Person.SecondName + " " + _Person.ThirdName + " " + _Person.LastName;
        }
        private void LoadData()
        {

            if (_Appointment!=null&&_Appointment.IsLocked)
            {
              Btn_Save.Enabled=AppointmentDate.Enabled = false;
               
            }
          
      Lb_DrivingLicenseApplicationID.Text = _LocalDrivingLicenseApplicationID.ToString();
            Lb_ClassName.Text = _LicenseClasses.ClassName;
            Lb_FullName.Text = GetFullName();
            SetTrials();
            Lb_Fees.Text = ((int)ClsTestTypes.Find(_TestTypeID).TestTypeFees).ToString();
         
            LoadDataWhenFailed();
        }

        private void LoadDataWhenFailed()
        {
            Gb_RetakeTest.Enabled = _IsFail;
            if (_IsFail)
            {
                Lb_RetakesTestFees.Text = ((int)ClsApplicationTypes.Find(7).ApplicationFees).ToString();


            }
            else
            { Lb_RetakesTestFees.Text = "0";
            }

            int TotalFees = Convert.ToInt32(Lb_Fees.Text) + Convert.ToInt32(Lb_RetakesTestFees.Text);

            Lb_TotalFees.Text = TotalFees.ToString();

        }
        private void AddOrUpdate()
        {
            switch (_Mode)
            {
                case EnMode.Add:
                    _Appointment = new ClsTestAppointment();
                    _IsFail = ClsTestAppointment.isTestAppointmentByLocalDrivingIDExistandLocked(_LocalDrivingLicenseApplicationID, _TestTypeID, true);
                    break;
                case EnMode.Update:
                    _Appointment = ClsTestAppointment.FindAppointmentByID(_TestAppointmentID);
                    _IsFail = _Appointment.RetakeTestApplicationID != -1;
                    break;
            }
            LoadData();
        }
        private void CTRSechduleTest_Load(object sender, EventArgs e)
        {
      
        }
 
        ClsApplication NewApplication = new ClsApplication();

        private void SetPersonID()
        {
            NewApplication.ApplicationPersonID = _Person.ID;
        }
        private void SetApplicationDate()
        {
            NewApplication.ApplicationDate = DateTime.Now;
        }
        private void SetApplicationFees()
        {
            NewApplication.PaidFees = ClsApplicationTypes.Find(7).ApplicationFees;
        }

        private void SetUserID()
        {
            NewApplication.CreatedByUserID = ClsSettings.CurrentUser.UserID;

        }
        private void SetStatus(byte Status)
        {
            NewApplication.ApplicationStatus = Status;
        }
        private void SetApplicationType(int TypeID)
        {
            NewApplication.ApplicationTypeID = TypeID;

        }
        private void SetLastStatusDate()
        {
            NewApplication.LastStatusDate = DateTime.Now;

        }
        private bool SaveApplicationsData()
        {
            SetPersonID();
            SetApplicationDate();
            SetApplicationFees();
            SetUserID();
            SetStatus(1);
            SetApplicationType(7);
            SetLastStatusDate();
            return NewApplication.Save();
        }
     
        private void SetRetakeTestAppointment()
        {
            if (_Mode==EnMode.Add& _IsFail)
            {
                SaveApplicationsData();
                _Appointment.RetakeTestApplicationID = NewApplication.ApplicationID;
                Lb_RetakeTestApplicationID.Text = NewApplication.ApplicationID.ToString();
            }
            else
                _Appointment.RetakeTestApplicationID = -1;

        }
        private bool Save()
        {
            _Appointment.TestTypeID = _TestTypeID;
            _Appointment.LocalDrivingLicenseApplicationID = _LocalDrivingLicenseApplicationID;
            _Appointment.AppointmentDate = AppointmentDate.Value;
            _Appointment.PaidFees = Decimal.Parse(Lb_Fees.Text);
            _Appointment.CreatedByUserID = ClsSettings.CurrentUser.UserID;
            _Appointment.IsLocked = false;
            SetRetakeTestAppointment();
            return _Appointment.Save();
        }
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (Save())
            {
             
                _Mode = EnMode.Update;
                MessageBox.Show("Saved Successfuly", "Check Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Saved is Failed", "Check Save ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
