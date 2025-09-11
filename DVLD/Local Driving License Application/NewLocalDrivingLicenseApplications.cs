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
    public partial class NewLocalDrivingLicenseApplications : Form
    {
        ClsApplication _Application;
        ClsLocalDrivingLicenseApplications _LocalDrivingLicenseApplications;
        public NewLocalDrivingLicenseApplications()
        {
            InitializeComponent();
        }

        private void Btn_Next_Click(object sender, EventArgs e)
        {
       
            TabPage Page = TBC_PersonDetails.TabPages[1];
            TBC_PersonDetails.SelectedTab = Page;
            Btn_Save.Enabled = true;
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadClasses()
        {
            foreach(DataRow row in ClsLicenseClasses.GetAllLicenseClasses().Rows)
            {
                Cb_LicenseClasses.Items.Add(row["ClassName"]);
            }
        }
        private void LoadData()
        {
            LoadClasses();
            Cb_LicenseClasses.SelectedIndex = 0;
            Lb_CreatedByUser.Text = ClsSettings.CurrentUser.UserName;
            Lb_ApplicationDate.Text = DateTime.Now.ToString();
            Lb_ApplicationFees.Text = ClsApplicationTypes.Find(1).ApplicationFees.ToString();
        }
        private void NewLocalDrivingLicenseApplications_Load(object sender, EventArgs e)
        {
            LoadData();
            _Application = new ClsApplication();
            _LocalDrivingLicenseApplications = new ClsLocalDrivingLicenseApplications();
        }
        private bool SetPersonID()
        {
            int PersonID = -1;
            if (int.TryParse(ctrFindPerson1.ctrPersonDetails1.Lb_PersonID.Text, out int Result))
            {
                PersonID = Result;
                _Application.ApplicationPersonID = PersonID;
                return true;
            }
            else return false;
       }
        private void SetApplicationDate()
        {
            _Application.ApplicationDate = DateTime.Parse(Lb_ApplicationDate.Text);

        }
        private void SetApplicationFees()
        {
            _Application.PaidFees = decimal.Parse(Lb_ApplicationFees.Text);

        }

        private void SetUserID()
        {
            _Application.CreatedByUserID = ClsSettings.CurrentUser.UserID;

        }
        private void SetStatus(byte Status)
        {
            _Application.ApplicationStatus = Status;
        }
        private void SetApplicationType(int TypeID)
        {
            _Application.ApplicationTypeID = TypeID;

        }
        private void SetLastStatusDate()
        {
            _Application.LastStatusDate = DateTime.Parse(Lb_ApplicationDate.Text);

        }
        private bool SaveApplicationsData()
        {
           if (!SetPersonID())
            {
                return false;
            }
            SetApplicationDate();
            SetApplicationFees();
            SetUserID();
            SetStatus(1);
            SetApplicationType(1);
            SetLastStatusDate();
            return _Application.Save();
        }
        private void SetApplicationID()
        {
            _LocalDrivingLicenseApplications.ApplicationID = _Application.ApplicationID;

        }
        private void SetLicenseClassID()
        {
           ClsLicenseClasses Class= ClsLicenseClasses.FindByClassName(Cb_LicenseClasses.Text);
          int LicenseClassID=  Class.LicenseClassID;
            _LocalDrivingLicenseApplications.LicenseClassID = LicenseClassID;
        }
        private bool SaveLocalLicenseApplications()
        {
            SetApplicationID();
            SetLicenseClassID();
            return _LocalDrivingLicenseApplications.Save();
        }
        private string GetNationalNo()
        {
           return (ctrFindPerson1.ctrPersonDetails1.Lb_NationalNo.Text);
            
        }
        private void Btn_Save_Click(object sender, EventArgs e)
        {

            if (ClsLocalDrivingLicenseApplications.IsLocalDrivingLicenseExist(GetNationalNo(),Cb_LicenseClasses.Text))
            {
                MessageBox.Show("LicenseClass is Found ,Choose Another One");
                return;
            }
            if (SaveApplicationsData())
            {
                if (SaveLocalLicenseApplications())
                {

                    MessageBox.Show("Saved Successfuly");
                    Lb_LocalApplicationID.Text = _LocalDrivingLicenseApplications.LocalLicenseApplicationID.ToString();

                }
            }


        }
    }
}
