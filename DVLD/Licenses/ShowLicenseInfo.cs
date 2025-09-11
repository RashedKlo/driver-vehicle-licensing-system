using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ShowLicenseInfo : Form
    {
        int _LicenseID;
       public ShowLicenseInfo(int LicenseID)
        {
            InitializeComponent();
            _LicenseID = LicenseID;
            SendLicenseIDToCTRLicenseInfo(_LicenseID);
        }
        static public Action<int> SendDataToCTRLicenseInfo;
        static  public void SendLicenseIDToCTRLicenseInfo(int LicenseID)
        {
            if (SendDataToCTRLicenseInfo != null)
            {
                Action<int> handler = SendDataToCTRLicenseInfo;
                if (handler != null)
                {
                    SendDataToCTRLicenseInfo(LicenseID);
                }

            }
        }

    }
}
