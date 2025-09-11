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
    public partial class ChangePassword : Form
    {

        ClsUser _User;
        public ChangePassword(int UserID)
        {
            InitializeComponent();
            _User = ClsUser.Find(UserID);
            ctrUser1.LoadData(_User);
   
        }
       
        private void ChangePassword_Load(object sender, EventArgs e)
        {
    
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txt_Password_Validating(object sender, CancelEventArgs e)
        {
            if (!Txt_Password.Text.Equals(_User.Password))
            {
                errorProvider1.SetError(Txt_Password, "You should Set Correct Password");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        private void SetPassword(string Password)
        {
            _User.Password = Password;
        }
        private bool SavePassword()
        {
            if (Txt_Password.Text == string.Empty)
            {
                return false;
            }
            if (Txt_NewPassword.Text.Text==string.Empty||
                !Txt_NewPassword.Text.Text.Equals(Txt_CheckPassword.Text.Text))
            {
                return false;
            }

            SetPassword(Txt_NewPassword.Text.Text);
            return _User.Save();
        }
        private void ClearTxt()
        {
            Txt_NewPassword.Text.Clear();
            Txt_CheckPassword.Text.Clear();
            Txt_Password.Clear();
        }
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (SavePassword())
            {
                MessageBox.Show("Saved Successfuly", "Check Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTxt();
            }
            else
            {
                MessageBox.Show("Saved is Failed", "Check Save", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
