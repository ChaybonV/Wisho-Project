using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Wisho.BusinessLogic;


namespace Wisho.Presentation
{
    public partial class WelcomeScreen : Form
    {
        UserService _userService;

        public WelcomeScreen()
        {
            InitializeComponent();
            _userService = new UserService();
        }
        private void lb_closeApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Hide();
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            SignUpSCreen sinUpSCreen = new SignUpSCreen();
            sinUpSCreen.Show();
            this.Hide();
        }
    }
}