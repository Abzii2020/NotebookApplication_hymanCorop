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
    public partial class MainWindow : Form
    {
        private LoginScreen _login;
        public string _roleName;
        public UsersLogin _user;

        public MainWindow(LoginScreen login, string roleShortName)
        {
            InitializeComponent();
            _login = login;
            _roleName = roleShortName;
        }

        public MainWindow(LoginScreen login, UsersLogin user)
        {
            InitializeComponent();
            _login = login;
            _user = user;
            _roleName = user.UserRoles.FirstOrDefault().Role.shortname;
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var OpenForms = Application.OpenForms.Cast<Form>();
            var isOpen = OpenForms.Any(q => q.Name == "AddNewUser");
            if (!isOpen)
            {
                var addUser = new AddNewUser();
                addUser.MdiParent = this.MdiParent; //adduser is the child of a child form (main menu)
                addUser.Show();
            }
        }

        private void editUserDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var OpenForms = Application.OpenForms.Cast<Form>();
            var isOpen = OpenForms.Any(q => q.Name == "EditUserDetails");
            if (!isOpen)
            {
                var editUser = new EditUserDetails();
                editUser.MdiParent = this.MdiParent;
                editUser.Show();
            }
        }

        private void viewUserDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var OpenForms = Application.OpenForms.Cast<Form>();
            var isOpen = OpenForms.Any(q => q.Name == "ViewUserDetails");
            if (!isOpen)
            {
                var viewUsers = new ViewUserDetails();
                viewUsers.MdiParent = this.MdiParent;
                viewUsers.Show();
            }
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var OpenForms = Application.OpenForms.Cast<Form>();
            var isOpen = OpenForms.Any(q => q.Name == "DeleteUser");
            if (!isOpen)
            {
                var deleteUser = new DeleteUser();
                deleteUser.MdiParent = this.MdiParent;
                deleteUser.Show();
            }
        }

        private void activeUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var OpenForms = Application.OpenForms.Cast<Form>();
            var isOpen = OpenForms.Any(q => q.Name == "ViewActiveUsers");
            if (!isOpen)
            {
                var activeUsers = new ViewActiveUsers();
                activeUsers.MdiParent = this.MdiParent;
                activeUsers.Show();
            }
        }

        private void deactivedUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var OpenForms = Application.OpenForms.Cast<Form>();
            var isOpen = OpenForms.Any(q => q.Name == "ViewDeactiveUsers");
            if (!isOpen)
            {
                var deactiveUsers = new ViewDeactiveUsers();
                deactiveUsers.MdiParent = this.MdiParent;
                deactiveUsers.Show();
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            if (_user.password == Utils.DefaultHashPassword())
            {
                var resetPassword = new ResetPassword();
                resetPassword.ShowDialog();
            }

            var username = _user.username;
            tsilLoginText.Text = $"Logged In As: {username}";

            if (_roleName != "A1")
            {
                manageAccessToolStripMenuItem.Visible = false;
            }
        }

        private void resetPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var OpenForms = Application.OpenForms.Cast<Form>();
            var isOpen = OpenForms.Any(q => q.Name == "ResetPassword");
            if (!isOpen)
            {
                var resetUser = new ResetPassword();
                resetUser.MdiParent = this.MdiParent; //resetUseruser is the child of a child form (main menu)
                resetUser.Show();
            }
        }

        private void deleteUserToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var OpenForms = Application.OpenForms.Cast<Form>();
            var isOpen = OpenForms.Any(q => q.Name == "DeleteUser");
            if (!isOpen)
            {
                var deleteUser = new DeleteUser();
                deleteUser.MdiParent = this.MdiParent;
                deleteUser.Show();
            }
        }

        private void manageAccessToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
