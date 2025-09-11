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
    public partial class ManagePeople : Form
    {
        private DataView _View = new DataView(ClsPerson.GetAllPeopleWithCountry());

        public ManagePeople()
        {
            InitializeComponent();
        }
        static public event Action<object, int> SendToFormAddOrUpdatePerson;
        static public event Action<object, int> SendToFormPersonDetails;
       static  public void SendDataToFormAddOrUpdate(object sender, int PersonID)
        {

                if (SendToFormAddOrUpdatePerson != null)
                {
                    Action<object, int> Handler = SendToFormAddOrUpdatePerson;
                    if (Handler != null)
                    {
                        SendToFormAddOrUpdatePerson(sender, PersonID);

                    }
                }
            
        }
     static   public void SendDataToFormPersonDetails(object sender, int PersonID)
        {
          
                if (SendToFormPersonDetails != null)
                {
                    Action<object, int> Handler = SendToFormPersonDetails;
                    if (Handler != null)
                    {
                        SendToFormPersonDetails(sender, PersonID);

                    }
                }

            
        }
        static public  void OpenFormAddOrUpdate( int PersonID)
        {
            AddOrUpdate From = new AddOrUpdate();
            SendDataToFormAddOrUpdate(From, PersonID);
          
            From.ShowDialog();
 

        }
        public static  void OpenFormPersonDetails(int PersonID)
        {
            PersonDetails personDetails = new PersonDetails();
            SendDataToFormPersonDetails(personDetails, PersonID);
            personDetails.ShowDialog();
        }
        private void Pb_AddPerson_Click(object sender, EventArgs e)
        {
            OpenFormAddOrUpdate(-1);
            RefreshData();
        }
        private void AddFilters()
        {
            Cb_FilterBy.SelectedIndex = 0;
            foreach (DataColumn Column in ClsPerson.GetAllPeopleWithCountry().Columns)
            {
                if (Column.ColumnName == "DateOfBirth")
                    continue;
                Cb_FilterBy.Items.Add(Column.ColumnName);
            }

        }

        private void ManagePeople_Load(object sender, EventArgs e)
        {
            AddFilters();
            RefreshData();
        }
       
        private void RefreshData()
        {
              DGV_People.DataSource= _View= ClsPerson.GetAllPeopleWithCountry().DefaultView;
            Lb_Records.Text = _View.Count.ToString();
           
        }

        private void Cb_FlitersBy_SelectedIndexChanged(object sender, EventArgs e)
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
 

        private void ManagePeople_FormClosing(object sender, FormClosingEventArgs e)
        {
            Txt_RowFilter.Visible = false;

        }



        private void Txt_RowFilter_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_RowFilter.Text))
            {
                _View.RowFilter = "";
                return;
            }
            if (Cb_FilterBy.Text.Equals("PersonID") || Cb_FilterBy.Text.Equals("Gender"))
            {

                if (int.TryParse(Txt_RowFilter.Text, out int Result))
                    _View.RowFilter = $"{Cb_FilterBy.Text} = {Result} ";
                else
                    Txt_RowFilter.Clear();
            }
            else
            {
                _View.RowFilter = $"{Cb_FilterBy.Text} LIKE '{Txt_RowFilter.Text}*' ";
            }

        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormAddOrUpdate(-1);
            RefreshData();

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)DGV_People.SelectedCells[0].Value;
            OpenFormAddOrUpdate(PersonID);
            RefreshData();

        }


        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)DGV_People.SelectedCells[0].Value;
           if( ClsPerson.Delete(PersonID))
            {
                MessageBox.Show($"Done {PersonID}  Deleted");
            }
           else
            {
                MessageBox.Show($"Failed Delete {PersonID}");

            }
            RefreshData();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = Convert.ToInt32(DGV_People.SelectedRows[0].Cells[0].Value);
            OpenFormPersonDetails(PersonID);
            RefreshData();
        }
    }
}
