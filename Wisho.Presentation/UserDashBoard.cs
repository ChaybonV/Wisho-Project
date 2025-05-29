using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wisho.BusinessLogic;
using Wisho.Presentation.UserForms;

namespace Wisho.Presentation
{
    public partial class UserDashBoard : Form
    {
        DataTable User;
        public UserDashBoard(DataTable user)
        {
            InitializeComponent();
            User = user;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Close();
        }

        private void btn_viewProduucts_Click(object sender, EventArgs e)
        {
            ViewProductForm viewProductForm = new ViewProductForm(User);
            viewProductForm.Show();
            this.Close();
        }

        private void btn_manageFavorites_Click(object sender, EventArgs e)
        {
            ViewFavoritesForm viewFav = new ViewFavoritesForm(User);
            viewFav.Show();
            this.Close();
        }

        private void btn_manageUserProfile_Click(object sender, EventArgs e)
        {
            UserProfileManagementForm userProfileManagementForm = new UserProfileManagementForm(User);
            userProfileManagementForm.Show();
            this.Close();
        }

        private void UserDashBoard_Load(object sender, EventArgs e)
        {
            lb_welcomeLogin.Text = "Welcome";
            lb_userName.Text = User.Rows[0]["Username"].ToString();
            int centerX = lb_welcomeLogin.Left + lb_welcomeLogin.Width / 2;
            lb_userName.Left = centerX - lb_userName.Width / 2;
            lb_userName.Top = lb_welcomeLogin.Bottom + 5;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoginScreen login = new LoginScreen();
            login.Show();
            this.Close();
        }

        private void pc_LogOut_Click(object sender, EventArgs e)
        {
            LoginScreen login = new LoginScreen();
            login.Show();
            this.Close();
        }

        private void lb_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
