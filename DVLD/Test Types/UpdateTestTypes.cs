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
    public partial class UpdateTestTypes : Form
    {
        int _TestID;
        ClsTestTypes _TestType;
        public UpdateTestTypes(int TestID)
        {
            InitializeComponent();
            _TestID = TestID;
            _TestType = ClsTestTypes.Find(TestID);
        }
        private void LoadData()
        {
            Txt_Description.Text = _TestType.TestTypeDescription;
            Txt_Title.Text = _TestType.TestTypeTitle;
            Txt_Fees.Text = _TestType.TestTypeFees.ToString();
            Lb_ID.Text = _TestType.TestTypeID.ToString();
        }
        private void UpdateTestTypes_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private bool isEmptyTxts()
        {
            return (string.IsNullOrEmpty(Txt_Title.Text)) ? true : (string.IsNullOrEmpty(Txt_Description.Text)) ? true : (string.IsNullOrEmpty(Txt_Fees.Text)) ? true : false;

                   }
        private void SetTitle(string Title)
        {
            _TestType.TestTypeTitle = Title;
        }
        private void SetDescription(string Description)
        {
            _TestType.TestTypeDescription = Description;
        }
        private bool SetFees(string Fees)
        {
            if (decimal.TryParse(Fees, out decimal Result))
            {
                _TestType.TestTypeFees = Result;
                return true;
            }
            else
                return false;

        }
        private bool Save()
        {
            if (isEmptyTxts())
            {
                return false;
            }
            SetTitle(Txt_Title.Text);
            SetDescription(Txt_Description.Text);
           if (!SetFees(Txt_Fees.Text))
            {
                return false;
            }
            return _TestType.Save();

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

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
