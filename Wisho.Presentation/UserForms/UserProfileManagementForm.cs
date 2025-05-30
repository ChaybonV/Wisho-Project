using System;
using System.Data;
using Wisho.BusinessLogic;
using System.Drawing;
using System.Windows.Forms;


namespace Wisho.Presentation.UserForms
{
    public partial class UserProfileManagementForm : Form
    {
        UserService userService;
        DataTable User;
        public UserProfileManagementForm(DataTable user)
        {
            userService = new UserService();
            User = user;
            InitializeComponent();
        }
        int id;

        private void btn_back_Click(object sender, EventArgs e)
        {
            UserDashBoard userDashBoard = new UserDashBoard(User);
            userDashBoard.Show();
            this.Close();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Close();
        }

        private void UserProfileManagementForm_Load(object sender, EventArgs e)
        {
            if (User != null && User.Rows.Count > 0)
            {
                DataRow userRow = User.Rows[0];
                id = Convert.ToInt32(userRow["UserId"]);
                tb_Email.Text = userRow["Email"].ToString();
                tb_UserName.Text = userRow["Username"].ToString();
                tb_Address.Text = userRow["Address"].ToString();
                numberic_Age.Value = Convert.ToInt32(userRow["Age"]);
            }
            else
            {
                MessageBox.Show("User data is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        string userName;
        string email;
        string address;
        int age;

        private void btn_updateProfile_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_UserName.Text) ||
                string.IsNullOrWhiteSpace(tb_Email.Text) ||
                string.IsNullOrWhiteSpace(tb_Address.Text) ||
                numberic_Age.Value <= 0)
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            userName = tb_UserName.Text.Trim();
            email = tb_Email.Text.Trim();
            address = tb_Address.Text.Trim();
            age = (int)numberic_Age.Value;
            int rowsAffected = userService.updateUserProfile(id, userName, email, age, address);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                User = userService.authenticateUserData(userName, email);
            }
            else
            {
                MessageBox.Show("Failed to update profile. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_deleteAccount_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to delete your account?","Confirm Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                int result = userService.deleteUser(id);
                if (result > 0)
                {
                    MessageBox.Show("Your account has been deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoginScreen loginScreen = new LoginScreen();
                    loginScreen.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to delete account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btn_changePassword_Click(object sender, EventArgs e)
        {
            UserChangePasswordForm userChangePasswordForm = new UserChangePasswordForm(User);
            userChangePasswordForm.Show();
            this.Close();
        }

        private void pc_LogOut_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Close();
        }

        private void ic_back_Click(object sender, EventArgs e)
        {
            UserDashBoard userDashBoard = new UserDashBoard(User);
            userDashBoard.Show();
            this.Close();
        }
    }
}