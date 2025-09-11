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
using System.IO;
namespace DVLD
{
    public partial class CTRAddOrUpdatePerson : UserControl
    {

        enum enMode { AddNew = 1, Update = 2 }
        private int _PersonID;
        private enMode _Mode;
        private Form _Frm;
        private ClsPerson _Person;
        public CTRAddOrUpdatePerson()
        {
            InitializeComponent();
            ManagePeople.SendToFormAddOrUpdatePerson += DVLD_SendDataToUserControl;

        }
    
        private void DVLD_SendDataToUserControl(object From, int PersonID)
        {
            _PersonID = PersonID;
            _Frm = (AddOrUpdate)From;
            CheckMode(PersonID);
        }
        private void CheckMode(int PersonID)
        {
            if (PersonID != -1)
            {
                _Mode = enMode.Update;
            }
            else
            {
                _Mode = enMode.AddNew;
            }
        }
        private void ChangeTitle(string Name)
        {
            _Frm.Text = Name;
            Lb_Title.Text = Name;
        }
        private void AddMode()
        {
            _Person = new ClsPerson();
            ChangeTitle("Add New Person");
            Lb_ID.Text = "N/A";
        }
        private void LoadData()
        {
            Lb_ID.Text = GetID().ToString();
            Txt_FirstName.Text.Text = GetFirstName();
            Txt_LastName.Text.Text = GetLastName();
            Txt_SecondName.Text.Text = GetSecondName();
            Txt_ThirdName.Text.Text = GetThirdName();
            Txt_Phone.Text.Text = GetPhone();
            Txt_Address.Text.Text = GetAddress();
            Txt_NationalNo.Text.Text = GetNationalNo();
            DTP_BirthDate.Value = GetBirthDate();
            Txt_Email.Text = GetEmail();
            if ((GetGender() == 0))
            {
                Rb_Male.Checked = true;
            }
            else
            {
                Rb_Female.Checked = true;
            }
            Cb_Country.SelectedIndex = Cb_Country.FindString(GetCountry());
            GetPicture();
        }

        private void UpdateMode()
        {
      
            _Person = ClsPerson.FindByID(_PersonID);
            if (_Person != null)
            {
                ChangeTitle("Update Person");

                LoadData();
            }
            else
            {
                MessageBox.Show("Not Found Person");
            }

        }
        private void LoadCountries()
        {
            foreach (DataRow Row in clsCountry.GetAllCountries().Rows)
            {
                Cb_Country.Items.Add(Row["CountryName"]);
            }
            Cb_Country.SelectedIndex = 0;
        }
        private void AddOrUpdateMode()
        {
            LoadCountries();
            DTP_BirthDate.MaxDate = new DateTime(DateTime.Now.Year - 17, 12, 12);
            switch (_Mode)
            {
                case enMode.AddNew:

                    AddMode();
                 
                    break;
                case enMode.Update:
                    UpdateMode();
                    break;
            }
        }
        private void CTRPerson_Load(object sender, EventArgs e)
        {
            AddOrUpdateMode();
        }

        private byte GetGender()
        {
            return _Person.Gender;
        }
        private void SetGender(byte Gender)
        {
            _Person.Gender = Gender;
        }
        public int GetID()
        {
            return _Person.ID;
        }
        private void SetFirstName(string FirstName)
        {
            _Person.FirstName = FirstName;
        }
        private string GetFirstName()
        {
            return _Person.FirstName;
        }
        private void SetSecondName(string SecondName)
        {
            _Person.SecondName = SecondName;
        }
        private string GetSecondName()
        {
            return _Person.SecondName;
        }
        private void SetThirdName(string ThirdName)
        {
            _Person.ThirdName = ThirdName;
        }
        private string GetThirdName()
        {
            return _Person.ThirdName;
        }
        private void SetLastName(string LastName)
        {
            _Person.LastName = LastName;
        }
        private string GetLastName()
        {
            return _Person.LastName;
        }
        private void SetAddress(string Address)
        {
            _Person.Address = Address;
        }
        private string GetAddress()
        {
            return _Person.Address;
        }
        private void SetPhone(string Phone)
        {
            _Person.Phone = Phone;
        }
        private string GetPhone()
        {
            return _Person.Phone;
        }
        private void SetEmail(string Email)
        {
            _Person.Email = Email;
        }
        private string GetEmail()
        {
            return _Person.Email;
        }
        private void SetBirthDate(DateTime BirthDate)
        {
            _Person.DateOfBirth = BirthDate;
        }
        private DateTime GetBirthDate()
        {
            return _Person.DateOfBirth;
        }
        private void SetCountry(string CountryName)
        {
            int CountryID = clsCountry.GetCountryID(CountryName);
            _Person.NationalityCountryID = CountryID;
        }
        private string GetCountry()
        {
            return clsCountry.GetCountryName(_Person.NationalityCountryID);
        }
        private void GetPicture()
        {

            if (_Person.ImagePath != string.Empty)
            {
                Lb_Remove.Visible = true;
                Pb_PersonalImage.Load(_Person.ImagePath);
                Pb_PersonalImage.Tag = "Added";

            }
            else
            {
                Pb_PersonalImage.Tag = "Default";
                ChangeDefaultImage();
            }
            
        }

        private void SetImagePath()
        {
           
            if (!Pb_PersonalImage.Tag.ToString().Equals("Default"))
            {
                if (_Person.ImagePath != string.Empty)
                {
                    File.Delete(_Person.ImagePath);
                }
              
                _Person.ImagePath = PathFile;

            }
            else
            {
                _Person.ImagePath = string.Empty;
            }
        }
        private void SetNationalNo(string NationalNo)
        {

            _Person.NationalNo = NationalNo;

        }
        private string GetNationalNo()
        {
            return _Person.NationalNo;
        }

  

        private bool isEmpty(string Text)
        {
           return string.IsNullOrEmpty(Text);
        }
        private bool isTextsEmpty()
        {
            if (isEmpty(Txt_FirstName.Text.Text))
            {

                return true;
            }
            if (isEmpty(Txt_SecondName.Text.Text))
            {

                return true;
            }
            if (isEmpty(Txt_LastName.Text.Text))
            {

                return true;
            }
            if (isEmpty(Txt_NationalNo.Text.Text))
            {

                return true;
            }
            if (isEmpty(Txt_Address.Text.Text))
            {

                return true;
            }
            if (isEmpty(Txt_Phone.Text.Text))
            {

                return true;
            }
            errorProvider1.Clear();
            return false;
        }
        private bool Save()
        {
            if (isTextsEmpty())
            {
                return false;
            }
            SetFirstName(Txt_FirstName.Text.Text);
            SetSecondName(Txt_SecondName.Text.Text);
            SetThirdName(Txt_ThirdName.Text.Text);
            SetLastName(Txt_LastName.Text.Text);
            SetNationalNo(Txt_NationalNo.Text.Text);

            SetEmail(Txt_Email.Text);

            SetPhone(Txt_Phone.Text.Text);

            SetAddress(Txt_Address.Text.Text);

            SetBirthDate(DTP_BirthDate.Value);
            SetCountry(Cb_Country.Text);

            if (Rb_Female.Checked)
                SetGender(1);
            else
                SetGender(0);
           SetImagePath();
        
                return _Person.Save();
          

        }
    
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (Save())
            {
                MessageBox.Show("Saved Successfuly", "Saved Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Mode = enMode.Update;
                ChangeTitle("Update Person");
                GetID();
              ManagePeople.  SendDataToFormPersonDetails(this,GetID ());
            }
            else
            {
                MessageBox.Show("Failed Saved", "Saved Box", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        string PathFile;
        private void Lb_SetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Pb_PersonalImage.Tag = "Added";
            string FileName = Guid.NewGuid().ToString();
             PathFile = @"F:\repos\MySolution\MySolutionDVLD\DVLD Images People\" + FileName + ".JPG";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
               File.Copy(openFileDialog1.FileName, PathFile);
                Pb_PersonalImage.Load(openFileDialog1.FileName); 
                Lb_Remove.Visible = true;
            }

        }

        private void Lb_Remove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
      
            Pb_PersonalImage.Tag = "Default";
            ChangeDefaultImage();
            Lb_Remove.Visible = false;
        }
        private void ChangeDefaultImage()
        {

            if (Pb_PersonalImage.Tag.ToString().Equals("Default"))
            {
                if (Rb_Male.Checked)
                {
                    Pb_PersonalImage.Image = Properties.Resources.R_Black;
                }
                else
                {
                    Pb_PersonalImage.Image = Properties.Resources.R;

                }
            }
        }
        private void Rb_CheckedChanged(object sender, EventArgs e)
        {
            ChangeDefaultImage();
        }
        private void Txt_NationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (ClsPerson.isNationalNoExist(Txt_NationalNo.Text.Text)&&_Mode!=enMode.Update)
            {
               
              e.Cancel = true;
                errorProvider1.SetError(Txt_NationalNo, "National No is Exist");
            }
            else
            {
                  e.Cancel = false;
                errorProvider1.Clear();
            }
        }

        private void Txt_Email_Validating(object sender, CancelEventArgs e)
        {

            if (!string.IsNullOrEmpty(Txt_Email.Text) && (!Txt_Email.Text.Contains("@gmail.com")))

            {
                errorProvider1.SetError(Txt_Email, "Email is Not Valid");
                e.Cancel = true;

            }
            else
            {
                e.Cancel = false;

                errorProvider1.Clear();
            }
           
        }
    }
}
