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
    public partial class FormLoginManageUser : Form
    {
        const string path = @"F:\repos\MySolution\MySolutionDVLD\RemmeberUser.txt";

        public FormLoginManageUser()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool CheckPassword(string Password)
        {
            return (Password.Equals(Txt_Password.Text));
        }

        private bool CheckLogin()
        {
            if (ClsUser.IsUserNameExist(Txt_UserName.Text))
            {
             ClsSettings.  CurrentUser = ClsUser.Find(Txt_UserName.Text);
             
                if (CheckPassword(ClsSettings.CurrentUser.Password) && ClsSettings.CurrentUser.IsActive)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        private void WriteToFile()
        {
            FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            if (Chk_RemmeberMe.Checked)
            {
                streamWriter.WriteLine(Txt_UserName.Text);
                streamWriter.WriteLine(Txt_Password.Text); }
            else
            {
                fileStream.SetLength(0);
            }
            streamWriter.Close();
            fileStream.Close();
        }
        private void Btn_Login_Click(object sender, EventArgs e)
        {
            if (CheckLogin())
            {

                WriteToFile();

                MainDVLD Main = new MainDVLD();
                Main.ShowDialog();

            }
            else
            {
                MessageBox.Show("Wrong UserName/Password", "Page Check", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void Txt_UserName_Click(object sender, EventArgs e)
        {
      
        }

        private string[] ReadFromFile()
        {
            return File.ReadAllLines(path);
        }
        private bool GetUserNameAndPasswordFromFile()
        {
            string[] Contents = ReadFromFile();
            if (Contents.Any())
            {
                Txt_UserName.Text = Contents[0];
                Txt_Password.Text = Contents[1];
                return true;
            }
            else
                return false;
        }
        private void FormLoginManageUser_Load(object sender, EventArgs e)
        {
            Chk_RemmeberMe.Checked = GetUserNameAndPasswordFromFile();

        }

        private void Chk_RemmeberMe_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
