using ASRFLY.Code;
using ASRFLY.GUI.GUI_HOME;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASRFLY.GUI.GUI_CATEGORIES
{
    public partial class CategoryUserControl1 : UserControl
    {

        // Variables

        private static CategoryUserControl1 _CategoryUserControl1;


        public CategoryUserControl1()
        {
            InitializeComponent();
        }

        #region Events Operations

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Add_CategoryForm add_CategoryForm = new Add_CategoryForm();

            // Diff between Show & ShowDialog 
            // Show remove Obj
            // ShowDialog make Dispose


            add_CategoryForm.Show();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Message_Collection.ShowEmptyDataMessage();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_Export_Click(object sender, EventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

        }

        private void txt_bx_Search_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        #endregion


        #region Methods 

        // to Solve Singilton Problem 
        public static CategoryUserControl1 Instance()
        {
            return _CategoryUserControl1 ?? (new CategoryUserControl1());
        }

        #endregion
    }
}
