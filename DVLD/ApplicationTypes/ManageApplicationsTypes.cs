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
    public partial class ManageApplicationsTypes : Form
    {
        public ManageApplicationsTypes()
        {
            InitializeComponent();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            Update_Applications_Type update_Applications_Type = new Update_Applications_Type(ID);
            update_Applications_Type.ShowDialog();
            RefreshData();
        }
        private void RefreshData()
        {
            dataGridView1.DataSource = ClsApplicationTypes.GetAllApplicationTypes();
            Lb_Records.Text = dataGridView1.RowCount.ToString();

        }
        private void ManageApplicationsTypes_Load(object sender, EventArgs e)
        {
            RefreshData();           
        }
    }
}
