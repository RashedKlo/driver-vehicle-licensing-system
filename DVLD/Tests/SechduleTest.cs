using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class SechduleTest : Form
    {
        public SechduleTest()
        {
            InitializeComponent();
        }
        private void ChangeTitle(string Title)
        {
            Lb_Title.Text = Title;
        }
        private void ChangeTitleMessage(string message)
        {
            Lb_TitleMessage.Text = message;
        }
       private void LoadData()
        {
            if (ctrSechduleTest1._Appointment.IsLocked)
            {
                ChangeTitle("Sechdule Retake Test");
                ChangeTitleMessage("Person Took this Appointment, Appointment is Locked");
            }
            else
            {
                if (ctrSechduleTest1._Appointment.RetakeTestApplicationID!=-1)
                {
                    ChangeTitle("Sechdule Retake Test");
                }
                else
                    ChangeTitle("Sechdule Test");

                ChangeTitleMessage("");
            }
        }
        private void SechduleTest_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void ctrSechduleTest1_Load(object sender, EventArgs e)
        {

        }
    }
}
