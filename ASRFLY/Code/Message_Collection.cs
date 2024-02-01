using ASRFLY.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASRFLY.Code
{
    public static class Message_Collection
    {
        // Message
        
        public static void ShowEmptyDataMessage()
        {
            MessageBox.Show(Resources.EmptyMessageText,Resources.EmptyMessageCaption ,
               MessageBoxButtons.OK , MessageBoxIcon.Information );
        }

        // dialog
    }
}
