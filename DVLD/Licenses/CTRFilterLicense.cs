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
namespace DVLD.Licenses
{
    public partial class CTRFilterLicense : UserControl
    { 
       public ClsLicenses _License;
        int _Mode;
        public bool IsFound;
        public CTRFilterLicense()
        {
            InitializeComponent(); 
            ManageDetainLicense.SendDataToCTRFilterLicense += ManageDetainLicense_SendDataToCTRFilterLicense;
            MainDVLD.SendModeToCTRFilterLicense += GetMode;
        
        }

        private void ManageDetainLicense_SendDataToCTRFilterLicense(int obj)
        {
            ShowLicenseInfo.SendLicenseIDToCTRLicenseInfo(obj);
            SendID(obj, true);
            groupBox1.Enabled = false;
            Txt_LicenseID.Text = obj.ToString();
        }

        private void GetMode(int Mode)
        {
            _Mode = Mode;
        }
         public Action<int,bool> SendLicenseIDToRenewLicense;
        public void SendID(int LicenseID,bool isDateActive)
        {
            if (SendLicenseIDToRenewLicense != null)
            {
                Action<int,bool> Handler = SendLicenseIDToRenewLicense;
                if (Handler != null)
                {
                    SendLicenseIDToRenewLicense(LicenseID,isDateActive );
                }
            }
        }

   public int GetLocalDrivingLicenseID()
        {
            return ClsLicenses.GetLocalDrivingLicenseByLicenseIDandLicenseClassID(_License.LicenseID, _License.LicenseClassID);
        }
        private bool CheckLicenseIsActive()
        {
            return _License.IsActive;
        }
        private bool CheckLicenseClass()
        {
            return _License.LicenseClassID == 3;
        }
        private int IsExpirationDateNotActive()
        {
            return _License.ExpirationDate.CompareTo(DateTime.Now);
        }
        private bool isInternationalExist()
        {
            return   ClsInternationalDrivingLicense.IsInternationalLicenseExistByLicenseID(_License.LicenseID);
        }
        private void MessageError(string Message)
        {
            MessageBox.Show(Message, "Check License", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private bool RenewLicnesesMode()
        {
            if (IsExpirationDateNotActive()>0||!CheckLicenseIsActive())
            {
                ShowLicenseInfo.SendLicenseIDToCTRLicenseInfo(_License.LicenseID);
                MessageError("Selected License is not yet expiraed , it will expire on :  "+_License.ExpirationDate.ToShortDateString ());
                SendID(_License.LicenseID, false) ;

                return false;
            }
            else
            {
                ShowLicenseInfo.SendLicenseIDToCTRLicenseInfo(_License.LicenseID);
                SendID(_License.LicenseID,true);
                return true;
            }
        }
        private bool NewInternationalLicenseMode()
        {
          
            if (!CheckLicenseClass())
            {
                MessageError("License Class Is Not Valid");
                return false; 
            }

            if (!CheckLicenseIsActive())
            {
                MessageError("License is Not Active");

                return false; ;
            }

            if (isInternationalExist())
            {
                MessageError("International License is Active");
                return false;
            }
            
                ShowLicenseInfo.SendLicenseIDToCTRLicenseInfo(_License.LicenseID);
            SendID(_License.LicenseID,true);
                return true;

        }
        private bool RepalceForLostorDamaged()
        {
            if (IsExpirationDateNotActive() < 0&& !CheckLicenseIsActive())
            {
                ShowLicenseInfo.SendLicenseIDToCTRLicenseInfo(_License.LicenseID);
                MessageError("Selected License is not Valid " );
                SendID(_License.LicenseID, false);

                return false;
            }
            else
            {
                ShowLicenseInfo.SendLicenseIDToCTRLicenseInfo(_License.LicenseID);
                SendID(_License.LicenseID, true);
                return true;
            }
        }
        private bool CheckIsDetainedLicense(int LicenseID)
        {
           return  ClsDetainedLicense.IsLicenseDetained(LicenseID);
        }
        private bool DetainLicense()
        {
            if (IsExpirationDateNotActive() < 0 && !CheckLicenseIsActive())
            {
                ShowLicenseInfo.SendLicenseIDToCTRLicenseInfo(_License.LicenseID);
                MessageError("Selected License is not Valid ");
                SendID(_License.LicenseID, false);

                return false;
            }
            if (CheckIsDetainedLicense(_License.LicenseID))
            {
                ShowLicenseInfo.SendLicenseIDToCTRLicenseInfo(_License.LicenseID);
                MessageError("Selected License is Already Detained");
                SendID(_License.LicenseID, false);

                return false;
            }
            ShowLicenseInfo.SendLicenseIDToCTRLicenseInfo(_License.LicenseID);
                SendID(_License.LicenseID, true);
                return true;
            
        }
        private bool ReleaseDetainedLicense()
        {
            if (IsExpirationDateNotActive() < 0 && !CheckLicenseIsActive())
            {
                ShowLicenseInfo.SendLicenseIDToCTRLicenseInfo(_License.LicenseID);
                MessageError("Selected License is not Valid ");
                SendID(_License.LicenseID, false);

                return false;
            }
            if (!CheckIsDetainedLicense(_License.LicenseID))
            {
                ShowLicenseInfo.SendLicenseIDToCTRLicenseInfo(_License.LicenseID);
                MessageError("Selected License is Not Detained");
                SendID(_License.LicenseID, false);

                return false;
            }
            ShowLicenseInfo.SendLicenseIDToCTRLicenseInfo(_License.LicenseID);
            SendID(_License.LicenseID, true);
            return true;
        }
        private bool CheckMode()
        {
            if (_Mode == 1)
            {
                return NewInternationalLicenseMode();
            }
            else if (_Mode == 2)
            {
                return RenewLicnesesMode();
            }
            else if (_Mode == 3)
            {
                return RepalceForLostorDamaged();
            }
            else if (_Mode == 4)
            {
                return DetainLicense();
            }
            else
                return ReleaseDetainedLicense();
        }
        private void Btn_Search_Click(object sender, EventArgs e)
        {  
             
            if (int.TryParse(Txt_LicenseID.Text, out int result))
            {
            _License= ClsLicenses.FindLicenseByID(result );
               if(_License!=null)
               IsFound= CheckMode();
                
            }
            else
                Txt_LicenseID.Clear();


        }
    }
}
