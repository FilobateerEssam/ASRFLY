using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASRFLY.Code
{
    public class PageManager
    {
        private readonly Main main;

        //                 Main Form Name
        public PageManager(Main main)
        {
            this.main = main;
        }

        public void LoadPage(UserControl PageuserControl)
        {
            // 1. Load Old Page

            var oldPage = main.panel_Contaner.Controls.OfType<UserControl>().FirstOrDefault();

            // page is already run if Not null

            if (oldPage != null)
            {
                main.panel_Contaner.Controls.Remove(oldPage); // Remove old Page
                oldPage.Dispose(); // to delete from memory
            }

            // 2. Load New Page

            PageuserControl.Dock = DockStyle.Fill;  // to fill page
            main.panel_Contaner.Controls.Add(PageuserControl);


        }


    }
}
