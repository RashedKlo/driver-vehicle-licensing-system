using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;
namespace BusinessAccess
{
 public   class ClsApplicationTypes
    {
        public int ApplicationTypeID { get; set; }
        public string ApplicationTypeTitle { get; set; }
        public decimal ApplicationFees { get; set; }

        private ClsApplicationTypes(int ID,string Title,decimal Fees)
        {
            ApplicationFees = Fees;
            ApplicationTypeID = ID;
            ApplicationTypeTitle = Title;
        }
public static DataTable GetAllApplicationTypes()
        {
            return ClsDataApplicationTypes.GetAllApplicationTypes();
        }
        public bool Save()
        {
            return ClsDataApplicationTypes.UpdateApplicationType(ApplicationTypeID, ApplicationTypeTitle, ApplicationFees);
        }
        public static ClsApplicationTypes Find(int ApplicationTypeID)
        {
            string Title = string.Empty;
            decimal Fees = 0;

            if (ClsDataApplicationTypes.GetApplicationTypeByID(ApplicationTypeID, ref Title, ref Fees))
            {
                return new ClsApplicationTypes(ApplicationTypeID, Title, Fees);
            }
            else
                return null;
        }
    }

}
