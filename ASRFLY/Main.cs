using ASRFLY.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ASRFLY.GUI;

namespace ASRFLY
{
    public partial class Main : Form
    {
        private readonly PageManager pageManager; // to Call the fun LoadPage
        public Main()
        {
            InitializeComponent();
            pageManager = new PageManager(this);

            // Load Home Page

            pageManager.LoadPage(GUI.GUI_HOME.HomeUserControl1.Instance());
        }

        #region Events

        private void btn_Home_Click(object sender, EventArgs e)
        {
            pageManager.LoadPage(GUI.GUI_HOME.HomeUserControl1.Instance());
        }
        

        #endregion 
    }
}
