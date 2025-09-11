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
    public partial class CTRPersonDetails : UserControl
    {
        private int _PersonID ;
        private ClsPerson _Person = new ClsPerson();
        private enum EnMode { Add = 1, Update = 2 };
        private EnMode _Mode = EnMode.Update;
        public CTRPersonDetails()
        {
            InitializeComponent();
            ManagePeople.SendToFormPersonDetails += ManagePeople_SendDataToUserControl;
        }
        private void ManagePeople_SendDataToUserControl(object arg1, int arg2)
        {
            _PersonID = arg2;
          
            CheckMode();
            AddorUpdateMode();
            
        }
        private void AddorUpdateMode()
        {
          if (_Mode == EnMode.Add)
            {
                AddMode();
            }
            else
            {
                UpdateMode();
            }
        }
        private void AddMode()
        {
            _Person = new ClsPerson();
        }
        private void UpdateMode()
        {
            _Person = ClsPerson.FindByID(_PersonID);
            LoadData();
        }
        private void CheckMode()
        {
            if (_PersonID.Equals(-1))
            {
                _Mode = EnMode.Add;
            }
            else
            {
                _Mode = EnMode.Update;
            }
        }
        private string GetName()
        {
            return _Person.FirstName +  " " + _Person.SecondName + " " + _Person.ThirdName + " " + _Person.LastName;
        }
        private string GetGender()
        {
            return (_Person.Gender.Equals(0)) ? "Male" : "Female";
        }
        private string GetCountry()
        {
            return clsCountry.GetCountryName(_Person.NationalityCountryID);
        }
       private void GetPicture()
        {
            if (_Person.ImagePath != string.Empty)
            {
                Pb_PersonalImage.Load(_Person.ImagePath);
            }
            else
            {
                if (GetGender ().Equals("Male"))
                {
                    Pb_PersonalImage.Image = Properties.Resources.R_Black;
                }
                else
                {
                    Pb_PersonalImage.Image = Properties.Resources.R;

                }
            }
        }
        public  void LoadData(int PersonID)
        {
            ClsPerson _Person = ClsPerson.FindByID(PersonID);
            Lb_PersonID.Text = _Person.ID.ToString();
            Lb_Name.Text = GetName();
            Lb_Address.Text = _Person.Address;
            Lb_DateOfBirth.Text = _Person.DateOfBirth.ToShortDateString ();
            Lb_Email.Text = _Person.Email;
            Lb_NationalNo.Text = _Person.NationalNo;
            Lb_Phone.Text = _Person.Phone;
            Lb_Gender.Text = GetGender();
            Lb_Country.Text = GetCountry();
            GetPicture();
        }
        public void LoadData( )
        {
            LoadData(_PersonID);
        }
        private void CTRPersonDetails_Load(object sender, EventArgs e)
        {
        }

        public void IntializeData()
        {
            Lb_Gender.Text = Lb_Name.Text = Lb_NationalNo.Text = Lb_PersonID.Text = Lb_Email.Text = Lb_Phone.Text = Lb_DateOfBirth.Text = Lb_Country.Text = Lb_Address.Text = "[????]";

            Pb_PersonalImage.Image = Properties.Resources.UserName;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddOrUpdate From = new AddOrUpdate();
            
            ManagePeople.SendDataToFormAddOrUpdate( From,_Person.ID);
            From.ShowDialog();
            if (_Mode == EnMode.Update)
            {
                _Person = ClsPerson.FindByID(_PersonID);
                LoadData();
            }
        }
    }
}
