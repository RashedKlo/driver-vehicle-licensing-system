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
    public partial class Drivers : Form
    {
        DataView _View;
        public Drivers()
        {
            InitializeComponent();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void RefreshData()
        {
            Cb_FilterBy.SelectedIndex = 0;
            dataGridView1.DataSource = _View = ClsDrivers.GetAllDrivers().DefaultView;
            Lb_Records.Text = dataGridView1.RowCount.ToString();
        }
        private void Drivers_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void Txt_RowFilter_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_RowFilter.Text))
            {
                _View.RowFilter = "";
                return;
            }
            if (Cb_FilterBy.Text.Equals("PersonID")|| Cb_FilterBy.Text.Equals ("DriverID"))
            {

                if (int.TryParse(Txt_RowFilter.Text, out int Result))
                    _View.RowFilter = $"{Cb_FilterBy.Text}  = {Result}";
                else
                    Txt_RowFilter.Clear();
            }
            else
            {
                _View.RowFilter = $"{Cb_FilterBy.Text} LIKE '{Txt_RowFilter.Text}*' ";
            }
        }

        private void Cb_FilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            Txt_RowFilter.Clear();
            if (Cb_FilterBy.SelectedIndex == 0)
            {
                Txt_RowFilter.Visible = false;
            }
            else
            {
                Txt_RowFilter.Visible = true;
                Txt_RowFilter.Focus();
            }
        }
    }
}
