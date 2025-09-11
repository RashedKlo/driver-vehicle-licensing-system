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
    public partial class ManageDetainLicense : Form
    {
        DataView _View;

        public ManageDetainLicense()
        {
            InitializeComponent();
        }
        static public event Action<int> SendDataToCTRFilterLicense;
        static public void SendLicenseIDToCTRFilterLicense(int LicenseID)
        {
            if (SendDataToCTRFilterLicense != null)
            {
                Action<int> Handler = SendDataToCTRFilterLicense;
                if (Handler != null)
                {
                    SendDataToCTRFilterLicense(LicenseID);
                }
            }
        }
        private void Cb_FilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            Txt_RowFilter.Clear();
            if (Cb_FilterBy.SelectedIndex == 0)
            {
                Chk_IsReleased.Visible = Txt_RowFilter.Visible = false;
            }
            else
            {
                if (!Cb_FilterBy.Text.Equals("IsReleased"))
                {
                    Chk_IsReleased.Visible = false;
                    Txt_RowFilter.Focus();
                }
                else
                {
                    Chk_IsReleased.Visible = true;
                }
                Txt_RowFilter.Visible = !Chk_IsReleased.Visible;
            }
        }
        private void RefreshData()
        {
            Cb_FilterBy.SelectedIndex = 0;
            dataGridView1.DataSource = _View = ClsDetainedLicense.GetAllDetainedLicenses().DefaultView;
            Lb_Records.Text = dataGridView1.RowCount.ToString();
        }

        private void Txt_RowFilter_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_RowFilter.Text))
            {
                _View.RowFilter = "";
                return;
            }
            if (Cb_FilterBy.Text.Contains ("ID"))
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
        private void FilterReleaseLicense()
        {

            _View.RowFilter = $"{Cb_FilterBy.Text} = {Chk_IsReleased.Checked} ";
        }
        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageDetainLicense_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = int.Parse(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());

            ShowLicenseInfo LicenseInfo = new ShowLicenseInfo(LicenseID);
            LicenseInfo.ShowDialog();
            RefreshData();

        }

        private void showPersonHistoryLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = int.Parse(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());

            LicenseHirstory history = new LicenseHirstory(LicenseID);
            history.ShowDialog();
            RefreshData();

        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = int.Parse(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());

            ReleaseDetainedLicense Frm = new ReleaseDetainedLicense();
            SendLicenseIDToCTRFilterLicense(LicenseID);
            Frm.ShowDialog();
            RefreshData();

        }

        private void Btn_Detain_Click(object sender, EventArgs e)
        {
            DetainLicense Frm = new DetainLicense();
            Frm.ShowDialog();
            RefreshData();

        }

        private void Btn_Release_Click(object sender, EventArgs e)
        {
            ReleaseDetainedLicense Frm = new ReleaseDetainedLicense();
            Frm.ShowDialog();
            RefreshData();
        }
        private int GetPersonID()
        {
            string NationalNo = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
          int ID=  ClsPerson.FindByNationalNo(NationalNo).ID;
            return ID;
        }
        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ManagePeople.OpenFormPersonDetails(GetPersonID());
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            bool isReleased = bool.Parse (dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
            releaseDetainedLicenseToolStripMenuItem.Enabled = !isReleased;

        }

        private void Chk_IsActive_CheckedChanged(object sender, EventArgs e)
        {
            FilterReleaseLicense();
        }
    }
    }
