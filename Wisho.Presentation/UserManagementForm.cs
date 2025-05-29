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
    public partial class UserManagementForm : Form
    {
        DataTable User;
        UserService userService;
        public UserManagementForm(DataTable user)
        {
            userService = new UserService();
            InitializeComponent();
            User = user;
        }

        private void UserManagementForm_Load(object sender, EventArgs e)
        {
            loadDataOnGridView();
            cb_role.Items.Add("Admin");
            cb_role.Items.Add("User");
            cb_role.SelectedIndex = 0;
            btn_add.Show();
            btn_update.Hide();
            btn_delete.Hide();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            AdminDashBoard adminDashBoard = new AdminDashBoard(User);
            adminDashBoard.Show();
            this.Close();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (validateInputs())
            {
                int rowsAffected = userService.addUser(
                    txt_userName.Text,
                    txt_password.Text,
                    txt_email.Text,
                    (int)nud_age.Value,
                    txt_address.Text,
                    cb_role.SelectedItem.ToString() // Ensure role is converted to string
                );

                if (rowsAffected > 0)
                {
                    MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearInputs();
                    loadDataOnGridView();
                }
                else
                {
                    MessageBox.Show("Failed to add user. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool validateInputs()
        {
            if (string.IsNullOrWhiteSpace(txt_userName.Text))
            {
                MessageBox.Show("Username cannot be empty.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_email.Text))
            {
                MessageBox.Show("Email cannot be empty.");
                return false;
            }

            if (!IsValidEmail(txt_email.Text))
            {
                MessageBox.Show("Invalid email format.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_password.Text))
            {
                MessageBox.Show("Password cannot be empty.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_address.Text))
            {
                MessageBox.Show("Address cannot be empty.");
                return false;
            }

            if (nud_age.Value <= 0)
            {
                MessageBox.Show("Please enter a valid age.");
                return false;
            }

            if (cb_role.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a role.");
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void clearInputs()
        {
            txt_userName.Text = string.Empty;
            txt_email.Text = string.Empty;
            txt_password.Text = string.Empty;
            txt_address.Text = string.Empty;
            nud_age.Value = 0; 
            cb_role.SelectedIndex = -1; 
        }
        int id;
        private void loadDataOnGridView()
        {
            DataRow userRow = User.Rows[0];
            id = Convert.ToInt32(userRow["UserId"]);

            dvg_users.DataSource = userService.getAllUsers(id);

            if (dvg_users.Columns.Contains("UserID"))
                dvg_users.Columns["UserID"].Visible = false;

            if (dvg_users.Columns.Contains("UserName"))
                dvg_users.Columns["UserName"].HeaderText = "Username";

            if (dvg_users.Columns.Contains("Email"))
                dvg_users.Columns["Email"].HeaderText = "Email";

            if (dvg_users.Columns.Contains("Password"))
                dvg_users.Columns["Password"].HeaderText = "Password";

            if (dvg_users.Columns.Contains("Age"))
                dvg_users.Columns["Age"].HeaderText = "Age";

            if (dvg_users.Columns.Contains("Address"))
                dvg_users.Columns["Address"].HeaderText = "Address";

            if (dvg_users.Columns.Contains("Role"))
                dvg_users.Columns["Role"].HeaderText = "Role";

            dvg_users.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvg_users.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvg_users.MultiSelect = false;
            dvg_users.RowTemplate.Height = 30;
            dvg_users.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            btn_add.Show();
            btn_delete.Hide();
            btn_update.Hide();
        }

        private void dvg_users_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btn_add.Hide();
                btn_delete.Show();
                btn_update.Show();
                DataGridViewRow row = dvg_users.Rows[e.RowIndex];

                txt_userName.Text = row.Cells["UserName"].Value?.ToString();
                txt_password.Text = row.Cells["Password"].Value?.ToString();
                txt_email.Text = row.Cells["Email"].Value?.ToString();
                nud_age.Value = row.Cells["Age"].Value != null ? Convert.ToInt32(row.Cells["Age"].Value) : 0;
                txt_address.Text = row.Cells["Address"].Value?.ToString();

                string selectedRole = row.Cells["Role"].Value?.ToString();
                if (cb_role.Items.Contains(selectedRole))
                {
                    cb_role.SelectedItem = selectedRole;
                }
            }
        }

        private void checkBox_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ShowPass.Checked)
                txt_password.UseSystemPasswordChar = false;
            else
                txt_password.UseSystemPasswordChar = true;
        }

        int userId;
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (validateInputs())
            {
                if (dvg_users.SelectedRows.Count > 0)
                {
                    userId = Convert.ToInt32(dvg_users.SelectedRows[0].Cells["UserID"].Value);

                    int rowsAffected = userService.updateUser(
                        userId,
                        txt_userName.Text,
                        txt_password.Text,
                        txt_email.Text,
                        (int)nud_age.Value,
                        txt_address.Text,
                        cb_role.SelectedItem.ToString()
                    );

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearInputs();
                        loadDataOnGridView();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update user. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a user to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dvg_users.SelectedRows.Count > 0)
            {
                userId = Convert.ToInt32(dvg_users.SelectedRows[0].Cells["UserID"].Value);

                var confirmation = MessageBox.Show("Are you sure you want to delete this user?","Confirm Deletion",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (confirmation == DialogResult.Yes)
                {
                    int rowsAffected = userService.deleteUser(userId);
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearInputs();
                        loadDataOnGridView();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete user. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a user to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pc_LogOut_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Close();
        }

        private void lb_close_Click(object sender, EventArgs e)
        {
            AdminDashBoard adminDashBoard = new AdminDashBoard(User);
            adminDashBoard.Show();
            this.Close();
        }

        private void ic_back_Click(object sender, EventArgs e)
        {
            AdminDashBoard adminDashBoard = new AdminDashBoard(User);
            adminDashBoard.Show();
            this.Close();
        }
    }
}