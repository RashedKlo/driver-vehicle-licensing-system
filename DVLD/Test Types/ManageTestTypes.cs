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
    public partial class ManageTestTypes : Form
    {
        public ManageTestTypes()
        {
            InitializeComponent();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void RefreshData()
        {
            dataGridView1.DataSource = ClsTestTypes.GetAllTestTypes();
            Lb_Records.Text = dataGridView1.RowCount.ToString();
        }
        private void editApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestTypeID = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString ());
            UpdateTestTypes types = new UpdateTestTypes(TestTypeID);
            types.ShowDialog();
            RefreshData();
        }

        private void ManageTestTypes_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
