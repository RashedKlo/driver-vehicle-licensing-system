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
    public partial class AddOrUpdateUser : Form
    {
        private int _UserID;
      private enum EnMode { Add=1,Update=2};
     private   EnMode _Mode = EnMode.Update;
       private ClsUser _User;
        public AddOrUpdateUser(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
             CheckMode(_UserID);
        }
        private void CheckMode(int UserID)
        {
            if (UserID.Equals(-1))
            {
                _Mode = EnMode.Add;
            }
            else
            {
                _Mode = EnMode.Update;
            }
        }
        private void ChangeTitle(string Title)
        {
            this.Text = Title;
            Lb_Title.Text = Title;
        }
        private void AddMode()
        { 
            _User = new ClsUser();
            ChangeTitle("Add User");
          ctrFindPerson1.Gb_Filter.Enabled = true;
               

        }

        private void UpdateMode()
        {
            _User = ClsUser.Find(_UserID);
            ChangeTitle("Update User");
         ctrFindPerson1.  Gb_Filter.Enabled = false;
        
            

        }
        private void AddOrUpdateMode()
        {
            switch (_Mode)
            {
                case EnMode.Add:
                    {
                        AddMode();
                        ManagePeople.SendDataToFormPersonDetails(this, -1);

                        break;
                    }
                case EnMode.Update:
                    {
                          UpdateMode();  
                        ManagePeople.SendDataToFormPersonDetails(this, _User.PersonID);

                    
                        break;
                    }
            }
        }
        private void AddOrUpdateUser_Load(object sender, EventArgs e)
        {
            AddOrUpdateMode();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrPersonDetails1_Load(object sender, EventArgs e)
        {

        }

      
        private void FindPerson_Click(object sender, EventArgs e)
        {
           
        }

        private void Btn_Next_Click(object sender, EventArgs e)
        {
            int PersonID = int.Parse(ctrFindPerson1.ctrPersonDetails1.Lb_PersonID.Text);
           
            if (ClsUser.IsPersonIDExist( PersonID))
            {
                MessageBox.Show("Person is Used or Not Found , PLease Choose Another One", "Check Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            TabPage Page= TBC_PersonDetails.TabPages[1];
            TBC_PersonDetails.SelectedTab = Page;
            Btn_Save.Enabled = true;
        }

        private void Btn_Previous_Click(object sender, EventArgs e)
        {
            TabPage Page = TBC_PersonDetails.TabPages[0];
            TBC_PersonDetails.SelectedTab = Page;
        }

        private void Cb_FindBy_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
      
        private bool Save()
        {


            if (!string.IsNullOrEmpty(ctrFindPerson1.ctrPersonDetails1.Lb_PersonID.Text))
            {
                if (int.TryParse(ctrFindPerson1.ctrPersonDetails1.Lb_PersonID.Text, out int result))
                {
                    _User.PersonID = result;
                }
                else
                {
                    return false;
                }
            }
            else
                return false;
            if (!string.IsNullOrEmpty(ctrUserDetails1.Txt_UserName.Text.Text))
                _User.UserName = ctrUserDetails1.Txt_UserName.Text.Text;
            else
                return false;

            if (!string.IsNullOrEmpty(ctrUserDetails1.Txt_UserName.Text.Text))
                _User.Password = ctrUserDetails1.Txt_Password.Text.Text;
            else
                return false;
            _User.IsActive = ctrUserDetails1.Chk_IsActive.Checked;
            return _User.Save();
          
        }
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (Save())
            {
                MessageBox.Show("Saved Successfuly", "Check Save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                _Mode = EnMode.Update;
                ctrUserDetails1.Lb_UserID.Text = _User.UserID.ToString();
                _UserID = _User.UserID;
                UpdateMode();
            }
        }
       
        private void Btn_AddPerson_Click(object sender, EventArgs e)
        {
        }

        private void Txt_FindBy_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
