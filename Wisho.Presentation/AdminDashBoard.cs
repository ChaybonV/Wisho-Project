using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Wisho.BusinessLogic;


namespace Wisho.Presentation
{
    public partial class AdminDashBoard : Form
    {
        DataTable UserData;
        public AdminDashBoard(DataTable user)
        {
            UserData = user;
            InitializeComponent();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Close();
        }

        private void btn_manageUsers_Click(object sender, EventArgs e)
        {
            UserManagementForm userManagementForm = new UserManagementForm(UserData);
            userManagementForm.Show();
            this.Close();
        }

        private void btn_manageProducts_Click(object sender, EventArgs e)
        {
            ProductManagementForm productManagementForm = new ProductManagementForm(UserData);
            productManagementForm.Show();
            this.Close();
        }

        private void btn_manageCategories_Click(object sender, EventArgs e)
        {
            CategoryManagementForm categoryManagementForm = new CategoryManagementForm(UserData);
            categoryManagementForm.Show();
            this.Close();
        }

        private void btn_adminProfile_Click(object sender, EventArgs e)
        {
            AdminProfileManagementForm adminProfile = new AdminProfileManagementForm(UserData);
            adminProfile.Show();
            this.Close();
        }

        private void AdminDashBoard_Load(object sender, EventArgs e)
        {
            lb_welcomeLogin.Text = "Welcome";
            lb_userName.Text = UserData.Rows[0]["Username"].ToString();
            int centerX = lb_welcomeLogin.Left + lb_welcomeLogin.Width / 2;
            lb_userName.Left = centerX - lb_userName.Width / 2;
            lb_userName.Top = lb_welcomeLogin.Bottom + 5;
        }

        private void lb_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pc_LogOut_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Close();
        }

        private void lb_welcomeLogin_Click(object sender, EventArgs e)
        {

        }
    }
}