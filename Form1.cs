using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreativeArtReach_InventoryManagement
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            ManagePage managePage = new ManagePage();
            managePage.Show();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            FindPage findPage = new FindPage();
            findPage.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewPage viewPage = new ViewPage();
            viewPage.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
