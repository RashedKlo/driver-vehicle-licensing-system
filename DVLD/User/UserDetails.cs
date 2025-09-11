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
    public partial class UserDetails : Form
    {
        int _UserID;
        ClsUser _User;

        public UserDetails(int UserID)
        {
            InitializeComponent();
            ChangePassword frm = new ChangePassword(ClsSettings.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrUser1_Load(object sender, EventArgs e)
        {

        }
    }
}
