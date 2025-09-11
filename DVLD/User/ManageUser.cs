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
    public partial class ManageUser : Form
    {
        DataView _View = ClsUser.GetAllUser().DefaultView;
        static public Action<int> SendDataToUserDetails;
       static public void SendIDToUserDetails(int PersonID)
        {
            if (SendDataToUserDetails != null)
            {
                Action< int> Handler = SendDataToUserDetails;
                if (Handler != null)
                {
                    SendDataToUserDetails(PersonID);

                }
            }
        }

        public ManageUser()
        {
            InitializeComponent();
        }

        private void ManageUser_Load(object sender, EventArgs e)
        {
            Cb_FilterBy.SelectedIndex = 0;
            RefreshData();
        }
        private void RefreshData()
        {
            dataGridView1.DataSource = _View = ClsUser.GetAllUser().DefaultView;
            Lb_Records.Text = _View.Count.ToString();

        }
        private void Cb_FilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cb_FilterBy.Text.Equals("None"))
            {
                Txt_RowFilter.Visible = false;
                Cb_IsActive.Visible = false;
                return;
            }

            if (Cb_FilterBy.Text.Equals("IsActive"))
            {
                Cb_IsActive.SelectedIndex = 0;
                Cb_IsActive.Visible = true;
                Txt_RowFilter.Visible = false;
            }
            else
            {
                Txt_RowFilter.Clear();
                Cb_IsActive.Visible = false;
                Txt_RowFilter.Visible = true;
            }
            _View.RowFilter = "";
        }

        private void Txt_RowFilter_TextChanged(object sender, EventArgs e)
        {
            if (Cb_FilterBy.Text.Equals("PersonID") || Cb_FilterBy.Text.Equals("UserID"))
            {
                if (int.TryParse(Txt_RowFilter.Text, out int Result))
                {
                    _View.RowFilter = $"{Cb_FilterBy.Text}={Result}";
                }
                else
                {
                    Txt_RowFilter.Clear();
                    _View.RowFilter = "";
                }

            }
            else
            {
                _View.RowFilter = $"{Cb_FilterBy.Text} LIKE '{Txt_RowFilter.Text}*' ";

            }
        }

        private void Cb_IsActive_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (!Cb_IsActive.Text.Equals("None"))
            {
                _View.RowFilter = $"{Cb_FilterBy.Text}= {Cb_IsActive.Text} ";
            }
        }
        private void Pb_AddUser_Click(object sender, EventArgs e)
        {
            OpenFormAddorUpdateUser(-1);

        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormAddorUpdateUser(-1);
        }
        private void OpenFormAddorUpdateUser(int UserID)
        {

            AddOrUpdateUser add = new AddOrUpdateUser(UserID);
            SendDataToUserDetails(UserID);

            add.ShowDialog();
            RefreshData();
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            OpenFormAddorUpdateUser(UserID);

        }
        private void ErrorMessageWhenFailedDelete(int UserID)
        {
            MessageBox.Show("Delete is Failed " + UserID, "Check Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void DeleteUser(int UserID)
        {
            if (ClsUser.Delete(UserID))
            {
                MessageBox.Show("Deleted Successfuly" + UserID, "Check Delete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                ErrorMessageWhenFailedDelete(UserID);
            }
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            if (MessageBox.Show("Are you Sure To Delete " + UserID, "Check Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                DeleteUser(UserID);
            else
                ErrorMessageWhenFailedDelete(UserID);

            RefreshData();
    
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

            ChangePassword Frm = new ChangePassword(UserID);
            Frm.ShowDialog();
            RefreshData();

        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

            UserDetails Details = new UserDetails(UserID);
            Details.ShowDialog();
          
        }
    }
    }

