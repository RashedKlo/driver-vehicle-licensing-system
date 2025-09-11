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
    public partial class CTRValidateText : UserControl
    {
        public CTRValidateText()
        {
            InitializeComponent();
        }


        private void Text_TextChanged(object sender, EventArgs e)
        {

            if (Text.Text == string.Empty)
            {
                errorProvider1.SetError(Text, "You Should Fill the Text");

            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void Text_Validating(object sender, CancelEventArgs e)
        {
            if (Text.Text == string.Empty)
            {
                errorProvider1.SetError(Text, "You Should Fill the Text");

            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
