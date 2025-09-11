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
    public partial class CTRUser : UserControl
    {
        
        
        public CTRUser()
        {
            InitializeComponent();
        
        }
        


        public  void LoadData(ClsUser _User)
        {
            ctrPersonDetails1.LoadData(_User.UserID);
            Lb_UserID.Text = _User.UserID.ToString();
            Lb_UserName.Text = _User.UserName;
            Lb_IsActive.Text = (_User.IsActive) ? "True" : "False";
        }
    }
}
