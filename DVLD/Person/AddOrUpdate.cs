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
    public partial class AddOrUpdate : Form
    {
        public AddOrUpdate()
        {
            InitializeComponent();
        }
    
        public int GetID()
        {
            return ctrAddOrUpdatePerson1.GetID();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ctrPerson1_Load(object sender, EventArgs e)
        {

        }
      
        private void Btn_Close_Click(object sender, EventArgs e)
        {
          
            this.Close();
        }

        private void ctrAddOrUpdatePerson1_Load(object sender, EventArgs e)
        {

        }
    }
}
