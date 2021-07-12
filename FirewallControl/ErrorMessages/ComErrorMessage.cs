using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirewallControl.ErrorMessages
{
   public static class ComErrorMessage
    {

        public static bool CheckEmptyTextBox(TextBox L, string FieldName)
        {
            if (L.Text == string.Empty)
            {
                MessageBox.Show(FieldName + "not Supplied");
                return true;
            }
            else
            { 
                return false;
            }
        }

    }
}
