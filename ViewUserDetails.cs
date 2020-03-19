using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotebookApplication_hymanCorop
{
    public partial class ViewUserDetails : Form
    {
        public ViewUserDetails()
        {
            InitializeComponent();
        }

        private void editUser_btn_Click(object sender, EventArgs e)
        {
            var editUser = new EditUserDetails();
            editUser.ShowDialog();
            //addUser.MdiParent = this;
        }
    }
}
