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
    public partial class Update_Applications_Type : Form
    {
        int _ApplicationTypeID;
         ClsApplicationTypes _ApplicationType;
        public Update_Applications_Type( int ID)
        {
            InitializeComponent();
            _ApplicationTypeID = ID;
            _ApplicationType = ClsApplicationTypes.Find(ID);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (Save())
            {
                MessageBox.Show("Saved Successfuly", "Check Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Save is Failed ", "Check Save", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void SetFees(decimal Fees)
        {
            _ApplicationType.ApplicationFees = Fees;
        }
        private void SetTitle(string Title)
        {
            _ApplicationType.ApplicationTypeTitle = Title;
        }
        private bool Save()
        {
         
            if (string.IsNullOrEmpty(Txt_Fees.Text.Text))
            {
                return false;
            }
            if (string.IsNullOrEmpty(Txt_Title.Text))
            {
                return false;
            }
            if (!decimal.TryParse(Txt_Fees.Text.Text,out decimal Result))
            {
                return false;
            }
            SetTitle(Txt_Title.Text);
          
            SetFees(Result );
            return _ApplicationType.Save();


        }
        private void LoadData()
        {
           Txt_Title.Text = _ApplicationType.ApplicationTypeTitle;
            Txt_Fees.Text.Text = _ApplicationType.ApplicationFees.ToString();
            Lb_ID.Text = _ApplicationTypeID.ToString();
            
        }
        private void Update_Applications_Type_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
