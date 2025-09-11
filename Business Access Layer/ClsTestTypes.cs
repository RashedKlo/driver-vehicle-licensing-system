using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;
namespace BusinessAccess
{
    public class ClsTestTypes
    {
        public int TestTypeID { get; set; }
        public string TestTypeTitle { get; set; }
        public string TestTypeDescription { get; set; }
        public decimal TestTypeFees { get; set; }
        private ClsTestTypes(int TestTypeID, string TestTypeTitle, string TestTypeDescription, decimal TestTypeFees)
        {
            this.TestTypeID = TestTypeID;
            this.TestTypeTitle = TestTypeTitle;
            this.TestTypeDescription = TestTypeDescription;
            this.TestTypeFees = TestTypeFees;
        }
       public bool Save()
        {
            return ClsDataTestTypes.UpdateApplicationType(TestTypeID, TestTypeTitle, TestTypeDescription, TestTypeFees);
        }
        static public DataTable GetAllTestTypes()
        {
            return ClsDataTestTypes.GetAllTestTypes();
        }
        static public ClsTestTypes Find(int ID)
        {
            string Title = string.Empty;
        string   Description = string.Empty;
            decimal Fees = 0;
            if (ClsDataTestTypes.GetTestTypeByID(ID, ref Title, ref Description, ref Fees))
            {
                return new ClsTestTypes(ID, Title, Description, Fees);
            }
            else
                return null;
        }

    }
}
