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
    public partial class CTRFindPerson : UserControl
    {
        public CTRFindPerson()
        {
            InitializeComponent();
        }
        private int GetIDFromFilterPersonID()
        {
            return (int.TryParse(Txt_FindBy.Text, out int result) && ClsPerson.isPersonExist(result)) ? result : -1;
        }

        private int GetIDFromFilterNationlNo()
        {
            int PersonID = -1;
            if (ClsPerson.isNationalNoExist(Txt_FindBy.Text))
            {
                PersonID = ClsPerson.FindByNationalNo(Txt_FindBy.Text).ID;
            }
            return PersonID;
        }
        public int GetPersonID()
        {
            int PersonID = -1;
            if (Cb_FindBy.Text.Equals("PersonID"))
            {
                PersonID = GetIDFromFilterPersonID();

            }
            else if (Cb_FindBy.Text.Equals("NationalNo"))
            {
                PersonID = GetIDFromFilterNationlNo();

            }
            return PersonID;
        }
        private void Btn_FindPerson_Click(object sender, EventArgs e)
        {
            int PersonID = GetPersonID();
            if (PersonID == -1)
            {
                ctrPersonDetails1.IntializeData();
                MessageBox.Show("Person Not Found", "Find Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                ManagePeople.SendDataToFormPersonDetails(this, PersonID);
        }

        private void Btn_AddPerson_Click(object sender, EventArgs e)
        {
            ManagePeople.OpenFormAddOrUpdate(-1);

        }

        private void Cb_FindBy_SelectedIndexChanged(object sender, EventArgs e)
        {

            Txt_FindBy.Clear();
        }

        private void Txt_FindBy_TextChanged(object sender, EventArgs e)
        {

        }

        private void CTRFindPerson_Load(object sender, EventArgs e)
        {
            Cb_FindBy.SelectedIndex = 0;

        }
    }
}
