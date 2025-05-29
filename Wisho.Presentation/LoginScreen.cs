using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wisho.BusinessLogic;

namespace Wisho.Presentation
{

    public partial class LoginScreen : Form
    {
        UserService userService;

        public LoginScreen()
        {
            userService = new UserService();
            InitializeComponent();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_UserName.Text = string.Empty;
            tb_Password.Text = string.Empty;
        }

        private void lb_closeLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void lb_SignUp_Click(object sender, EventArgs e)
        {
            SignUpSCreen sinUpSCreen = new SignUpSCreen();
            sinUpSCreen.Show();
            this.Close();
        }

        private void checkBox_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ShowPass.Checked)
                tb_Password.UseSystemPasswordChar = false;
            else
                tb_Password.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                if (userService.authenticateUser(tb_UserName.Text, tb_Password.Text))
                {
                    DataTable User = userService.authenticateUserData(tb_UserName.Text, tb_Password.Text);
                    UserDashBoard userDashboard = new UserDashBoard(User);
                    userDashboard.Show();
                    this.Close();
                }
                else if (userService.authenticateAdmin(tb_UserName.Text, tb_Password.Text))
                {

                    DataTable User = userService.authenticateAdminData(tb_UserName.Text, tb_Password.Text);
                    AdminProfileManagementForm adminProfileManagementForm = new AdminProfileManagementForm(User);
                    AdminDashBoard adminDashboard = new AdminDashBoard(User);
                    adminDashboard.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again.");

                }

            }

        }
        private bool validate()
        {
            if (string.IsNullOrWhiteSpace(tb_UserName.Text))
            {
                MessageBox.Show("Username cannot be empty.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(tb_Password.Text))
            {
                MessageBox.Show("Password cannot be empty.");
                return false;
            }
            return true;
        }

        private void lb_welcomeLogin_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}