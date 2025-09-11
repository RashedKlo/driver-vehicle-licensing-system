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
    public partial class CTRUserDetails : UserControl
    {
        private int _UserID;
        private ClsUser _User;
        private enum EnMode { Add = 1, Update = 2 };
        private EnMode _Mode = EnMode.Update;
        public CTRUserDetails()
        {
            InitializeComponent();
            ManageUser.SendDataToUserDetails += ManageUser_SendDataToUserDetails;
        }
        private void ManageUser_SendDataToUserDetails(int PersonID)
        {
            _UserID = PersonID;
            CheckMode();
            AddOrUpdateMode();
        }
        public void UpdateMode()
        {
   _User = ClsUser.Find(_UserID);
                LoadData();
        }
        public void AddMode()
        {
                _User = new ClsUser();

        }
        public void AddOrUpdateMode()
        {
            switch (_Mode)
            {
                case EnMode.Add:
                    {
                        AddMode();
                        break;
                    }
                case EnMode.Update:
                    {
                        UpdateMode();
                        break;
                    }
            }
        }
        private void CheckMode()
        {

            if (_UserID.Equals(-1))
            {

                _Mode = EnMode.Add;

            }
            else
            {


                _Mode = EnMode.Update;


            }

        }
        public  void LoadData()
        {
            Lb_UserID.Text = _UserID.ToString();
            Txt_Password.Text.PasswordChar = '*';
            Txt_CheckPassword.Text = Txt_Password.Text.Text = _User.Password;
            Txt_UserName.Text.Text = _User.UserName;
            Chk_IsActive.Checked = _User.IsActive;
        }

        private void Txt_Password_Enter(object sender, EventArgs e)
        {
            Txt_CheckPassword.Clear();
           

        }

    

        private void Txt_CheckPassword_TextChanged(object sender, EventArgs e)
        {
            if (!Txt_CheckPassword.Text.Equals(Txt_Password.Text.Text))
            {
                errorProvider1.SetError(Txt_CheckPassword, "You should Match Password");
            }
            else
            {

                errorProvider1.Clear();
            }

        }
    }
}
