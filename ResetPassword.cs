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
    public partial class ResetPassword : Form
    {
        private readonly NotebookAppEntities notebookAppEntities;
        private UsersLogin _user;

        public ResetPassword()//UsersLogin user)
        {
            InitializeComponent();
            notebookAppEntities = new NotebookAppEntities();
            //_user = user;
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            try
            { 
                var password = newPassword_tb.Text;
                var confirmPassword = confirmPassword_tb.Text;
                var user = notebookAppEntities.UsersLogins.FirstOrDefault(q => q.username == _user.username);
                    //UsersLogin.FirstOrDefault(q => q.id == _user.id);

                if (password != confirmPassword)
                {

                    MessageBox.Show("Passwords do not match. Please try again!");

                }
                _user.password = Utils.HashPassword(password);

                notebookAppEntities.SaveChanges();

                MessageBox.Show("Password Reset Successful...");
                Close();

            }
            catch (Exception)
            {

                MessageBox.Show("An Error Has Occured.Please Try Again...");

            }
        }

        private void ResetPassword_Load(object sender, EventArgs e)
        {
            var users = notebookAppEntities.UsersLogins.ToList();
            username_cb.DisplayMember = "Username";
            username_cb.ValueMember = "id";
            username_cb.DataSource = users;
        }
    }
}
