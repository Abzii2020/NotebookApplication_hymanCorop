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
    public partial class AddNewUser : Form
    {
        private readonly NotebookAppEntities  notebookAppEntities;
        public AddNewUser()
        {
            InitializeComponent();
            notebookAppEntities = new NotebookAppEntities();
        }

        private void AddNewUser_Load(object sender, EventArgs e)
        {
            //Select position from combo box
            var roles = notebookAppEntities.Roles.ToList();
            accessLevel_cb.DisplayMember = "Position";
            accessLevel_cb.ValueMember = "id";
            accessLevel_cb.DataSource = roles;
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var username = username_tb.Text;
                var employee = employee_tb.Text;
                var password = password_tb.Text;
                var accessLevel = accessLevel_cb.Text;
                var roleId = (int)accessLevel_cb.SelectedValue;
                //var startDate = startDate_dtp.Text;



                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(employee))
                {

                    MessageBox.Show("Missing Information (Username/Password)");

                }
                if(string.IsNullOrWhiteSpace(password_tb.Text) || string.IsNullOrWhiteSpace(accessLevel_cb.Text))
                {

                    MessageBox.Show("Missing Information (Password/Access Level)");

                }
                if(string.IsNullOrWhiteSpace(startDate_dtp.Text))
                {
                    MessageBox.Show("Missing Information (Start Date)");
                }


                var user = new UsersLogin
                {
                    username = username,
                    password = password,
                    active_status = true,
                    employee_name = employee,
                    start_date = startDate_dtp.Value,
                };

                notebookAppEntities.UsersLogins.Add(user);
                notebookAppEntities.SaveChanges();

                var userid = user.id;
                var userRole = new UserRole
                {

                    rolesID = roleId,
                    userID = userid,
                };


                notebookAppEntities.UserRoles.Add(userRole);
                notebookAppEntities.SaveChanges();
                MessageBox.Show("User Added Successfully...");
                Close();

            }

            catch (Exception)
            {

                MessageBox.Show("An Error has Occured...");

            }

        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
