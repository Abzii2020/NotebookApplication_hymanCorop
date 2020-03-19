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
    public partial class LoginScreen : Form
    {
        private  readonly NotebookAppEntities _db;

        public LoginScreen()
        {
            InitializeComponent();
            _db = new NotebookAppEntities();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var username = username_tb.Text.Trim();
                var password = password_tb.Text;

                var user = _db.UsersLogins.FirstOrDefault(q => q.username == username && q.password == password);
                if (user == null)
                {
                    MessageBox.Show("Invalid username or password. Please try again");
                }
                else
                {
                    var role = user.UserRoles.FirstOrDefault();
                    var roleshortName = role.Role.shortname;
                    var mainWindow = new MainWindow(this, roleshortName);
                    mainWindow.Show();
                    Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong. Please try again");
                throw;
            }
          
        }

        private void loginClose_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void username_tb_Enter(object sender, EventArgs e)
        {
            username_tb.Text = "";

        }

        private void password_tb_Enter(object sender, EventArgs e)
        {
           password_tb.Text = "";
           
        }

        private void password_tb_Leave(object sender, EventArgs e)
        {
            if (password_tb.Text == "")
            {
                password_tb.Text = "Password";
            }
        }

        private void username_tb_Leave(object sender, EventArgs e)
        {
            if (username_tb.Text == "")
            {
                username_tb.Text = "Username";
            }
        }
    }
}
