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
    public partial class CTRLicenseInfo : UserControl
    {
        int _LicenseID;
        public ClsLicenses _License;
        ClsPerson _Person;
        ClsLicenseClasses _LicenseClass;
        ClsApplication _Application;
        public CTRLicenseInfo()
        {
            InitializeComponent();
            ShowLicenseInfo.SendDataToCTRLicenseInfo += GetDataFromShowLicenseInfo;
        }

        private void GetDataFromShowLicenseInfo(int LicenseID)
        {
            _LicenseID = LicenseID;

            _License = ClsLicenses.FindLicenseByID(_LicenseID);
            _Application = ClsApplication.FindApplicationByID(_License.ApplicationID);
            _Person = ClsPerson.FindByID(_Application.ApplicationPersonID );
                        LoadData();
        }
        private string GetFullName()
        {
            return _Person.FirstName + " " + _Person.SecondName + " " + _Person.ThirdName + " " + _Person.LastName;
        }
        private string GetClassName()
        {
            _LicenseClass = ClsLicenseClasses.FindByID(_License.LicenseClassID);
            return _LicenseClass.ClassName;
        }
        private string GetGender()
        {
            return (_Person.Gender == 0) ? "Male" : "Female";
        }
        private string GetIssueReason(byte IssueReason)
        {
            //1 - FirstTime, 2 - Renew, 3 - Replacement for Damaged, 4 - Replacement for Lost.
                   switch (IssueReason)
            {
                case 1:return "First Time";
                case 2:return "Renew";
                case 3:return "Replacement for Damaged";
                case 4:return "Replacement for Lost";
                default:return "Error";
            }
        }
        private string GetActiveLicense(bool isActive)
        {
            return (isActive) ? "Yes" : "No";
        }
        public int GetPersonID()
        {
            return _Person.ID;
        }
        private void GetImage()
        {
            if (!string.IsNullOrEmpty(_Person.ImagePath))
            {
                Pb_PersonalImage.Load(_Person.ImagePath);
            }
            else
            {
                ChangeDefaultImage();
            }
        }
        private void ChangeDefaultImage()
        {

            
                if (_Person.Gender==0)
                {
                    Pb_PersonalImage.Image = Properties.Resources.R_Black;
                }
                else
                {
                    Pb_PersonalImage.Image = Properties.Resources.R;

                }
            
        }
      
        private void LoadData()
        {
           Lb_Class.Text = GetClassName();
            Lb_Name.Text = GetFullName();
            Lb_LicenseID.Text = _License.LicenseID.ToString();
            Lb_NationalNo.Text = _Person.NationalNo;
            Lb_Gender.Text = GetGender();
            Lb_IssueDate.Text = _License.IssueDate.ToShortDateString();
            Lb_IssueReason.Text = GetIssueReason(_License.IssueReason);
            Lb_Notes.Text = _License.Notes;
            Lb_IsActive.Text = GetActiveLicense(_License.IsActive);
            Lb_DateOfBirth.Text = _Person.DateOfBirth.ToShortDateString();
            Lb_DriverID.Text = _License.DriverID.ToString();
            Lb_ExpirationDate.Text = _License.ExpirationDate.ToShortDateString();
            GetImage();

            Lb_IsDetained.Text = ClsDetainedLicense.IsLicenseDetained(_License.LicenseID) ? "Yes" : "No";
        }
        private void CTRLicenseInfo_Load(object sender, EventArgs e)
        {
           
        }
    }
}
