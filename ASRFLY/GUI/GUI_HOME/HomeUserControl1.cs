using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASRFLY.GUI.GUI_HOME
{
    public partial class HomeUserControl1 : UserControl
    {
        private static HomeUserControl1 _HomeUserControl1;
        public HomeUserControl1()
        {
            InitializeComponent();
        }


        // to Solve Singilton Problem 
        public static HomeUserControl1 Instance()
        {
            // if Null 
            return _HomeUserControl1 ?? (new HomeUserControl1());
        }
    }
}
