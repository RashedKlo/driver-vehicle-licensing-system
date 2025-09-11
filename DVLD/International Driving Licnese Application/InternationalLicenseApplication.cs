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
    public partial class InternationalLicenseApplication : Form
    {
        DataView  _View = ClsInternationalDrivingLicense.GetAllInternationalLicenses().DefaultView;

        public InternationalLicenseApplication()
        {
            InitializeComponent();
        }
      
        private void RefreshData()
        {
            Cb_FilterBy.SelectedIndex = 0;
            dataGridView1.DataSource = _View;
            Lb_Records.Text = dataGridView1.RowCount.ToString();
        }
        private void InternationalLicenseApplication_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void Cb_FilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            Txt_RowFilter.Clear();
            if (Cb_FilterBy.SelectedIndex == 0)
            {
                Chk_IsActive.Visible = Txt_RowFilter.Visible = false;
            }
            else
            {
                if (!Cb_FilterBy.Text.Equals("IsActive"))
                {
                    Chk_IsActive.Visible = false;
                    Txt_RowFilter.Focus();
                }
                else
                {
                    Chk_IsActive.Visible = true;
                }
                Txt_RowFilter.Visible = !Chk_IsActive.Visible;
            }
        }
        private void FilterGender()
        {

            _View.RowFilter = $"{Cb_FilterBy.Text} = {Chk_IsActive.Checked} ";
        }
        private void FilterID(string FilterText)
        {
            
            if (int.TryParse(Txt_RowFilter.Text, out int Result))
                _View.RowFilter = $"{FilterText} = {Result} ";
            else
                Txt_RowFilter.Clear();
        }
        private void Filter()
        {
            if (string.IsNullOrEmpty(Txt_RowFilter.Text))
            {
                _View.RowFilter = "";
                return;
            }
            if (Cb_FilterBy.Text.Contains("ID"))
            {
                if (Cb_FilterBy.Text.Contains("LicenseID"))
                {
                    FilterID("IssuedUsingLocalLicenseID");
                }
                else
                    FilterID(Cb_FilterBy.Text);
            }

         
        }
        private void Txt_RowFilter_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void Btn_AddLicense_Click(object sender, EventArgs e)
        {
            NewInternationalLicenseApplication InternationalLicense = new NewInternationalLicenseApplication();

            InternationalLicense.ShowDialog();
            RefreshData();
        }
        private int GetLocalDrivingLicenseID()
        {
            int LicneseID = int.Parse(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
         int LocalDrivingLicenseID = ClsLicenses.GetLocalDrivingLicenseByLicenseIDandLicenseClassID(LicneseID, 3);
            return LocalDrivingLicenseID;
        }
        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = int.Parse(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());

            ShowLicenseInfo LicenseInfo = new ShowLicenseInfo(LicenseID);
            LicenseInfo.ShowDialog();
        }

        private void showPersonHistoryLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = int.Parse(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());

            LicenseHirstory history = new LicenseHirstory(LicenseID);
            history.ShowDialog();
        }
        private int GetPersonID()
        {
            int ApplicationID = int.Parse(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
            ClsApplication Application = ClsApplication.FindApplicationByID(ApplicationID);
            return Application.ApplicationPersonID;
        }
        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ManagePeople.OpenFormPersonDetails(GetPersonID()) ;
        }

        private void Chk_IsActive_CheckedChanged(object sender, EventArgs e)
        {
            FilterGender();
        }

       
    }
}
