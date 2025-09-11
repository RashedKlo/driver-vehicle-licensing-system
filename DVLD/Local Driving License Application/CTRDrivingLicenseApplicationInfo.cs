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
    public partial class CTRDrivingLicenseApplicationInfo : UserControl
    {
        int _LocalDrivingLicenseApplicationID;
        ClsApplication _Application;
        ClsLicenseClasses _LicenseClasses;
        ClsLocalDrivingLicenseApplications _LocalDrivingApplications;
        ClsPerson _Person;
        ClsApplicationTypes _ApplicationType;
        ClsUser _User;

        int _PassedCount;
        public CTRDrivingLicenseApplicationInfo()
        {
            InitializeComponent();
            LocalDrivingLicenseApplications.SendLocalDrivingLicenseApplicationID += VisionTestAppointments_SendLocalDrivingLicenseApplicationID;
        }

        private void VisionTestAppointments_SendLocalDrivingLicenseApplicationID(int obj,int PassedCount)
        {
            _LocalDrivingLicenseApplicationID = obj;
            _LocalDrivingApplications = ClsLocalDrivingLicenseApplications.Find(obj);
            _Application = ClsApplication.FindApplicationByID(_LocalDrivingApplications.ApplicationID);
            _LicenseClasses = ClsLicenseClasses.FindByID(_LocalDrivingApplications.LicenseClassID);
            _ApplicationType = ClsApplicationTypes.Find(_Application.ApplicationTypeID);
            _Person = ClsPerson.FindByID(_Application.ApplicationPersonID);
            _User = ClsUser.Find(_Application.CreatedByUserID);
            _PassedCount = PassedCount;
            LoadData();
        }
        private string GetFullName()
        {
            return _Person.FirstName + " " + _Person.SecondName + " " + _Person.ThirdName + " " + _Person.LastName;
        }
        private string GetStatus(byte Status)
        {
            switch (Status)
            {
                case 1:return "New";
                case 2:return "Cancelled";
                case 3:return "Completed";
                default:return "Error";
            }
        }
        public void SetPassedTest(int PassedCount)
        {
            _PassedCount += PassedCount;
            Lb_PassedTest.Text = _PassedCount.ToString();
            Lb_PassedTest.Text += "/3";
        }
        private void LoadData()
        {
            Lb_DrivingLicenseApplicationID.Text = _LocalDrivingLicenseApplicationID.ToString();
            Lb_ClassName.Text = _LicenseClasses.ClassName;
            Lb_ApplicationID.Text = _Application.ApplicationID.ToString();
            Lb_Status.Text = GetStatus(_Application.ApplicationStatus);
            Lb_Fees.Text = _ApplicationType.ApplicationFees.ToString();
            Lb_TypeService.Text = _ApplicationType.ApplicationTypeTitle;
            Lb_Date.Text = _Application.ApplicationDate.ToShortDateString();
            Lb_User.Text = _User.UserName;
            Lb_StatusDate.Text = _Application.LastStatusDate.ToShortDateString();
            Lb_FullName.Text = GetFullName();
            SetPassedTest(0);

        }
        private void CTRDrivingLicenseApplicationInfo_Load(object sender, EventArgs e)
        {
        }

        private void Lb_PersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ManagePeople.OpenFormPersonDetails(_Application.ApplicationPersonID);
        }
    }
}
