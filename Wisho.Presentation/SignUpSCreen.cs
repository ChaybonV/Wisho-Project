using System;
using System.Text.RegularExpressions;
using Wisho.BusinessLogic;
using System.Net;
using System.Net.Mail;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace Wisho.Presentation
{
    public partial class SignUpSCreen : Form
    {
        UserService _userService;

        public SignUpSCreen()
        {
            InitializeComponent();
            _userService = new UserService();
        }

        private void checkBox_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ShowPass.Checked)
                tb_Password.UseSystemPasswordChar = false;
            else
                tb_Password.UseSystemPasswordChar = true;
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            tb_UserName.Text = string.Empty;
            tb_Email.Text = string.Empty;
            tb_Password.Text = string.Empty;
            numberic_Age.Value = 0;
            tb_Address.Text = string.Empty;
        }

        private void lb_closeSignUp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void SendConfirmationEmail(string toEmail, string username)
        {
            try
            {
                string fromEmail = "chaybon2006@gmail.com";
                string fromPassword = "wkzp ldto szcb grbu";

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(fromEmail);
                mail.To.Add(toEmail);
                mail.Subject = "Confirmation of your account";
                mail.Body = $"Hello {username},\n\nyour account has been successfully created!\n\nKing regards,\nChaybon Verlooy - Owner Wisho";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential(fromEmail, fromPassword);
                smtp.EnableSsl = true;
                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error by sending mail: " + ex.Message);
            }
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            if (validateInputs())
            {
                try
                {
                    int rowAffetcted = _userService.addUser(tb_UserName.Text, tb_Password.Text, tb_Email.Text, (int)numberic_Age.Value, tb_Address.Text);
                    if (rowAffetcted > 0)
                    {
                        SendConfirmationEmail(tb_Email.Text, tb_UserName.Text);
                        MessageBox.Show("SignUp Succes, you have received a confirmation email.", "Suceess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoginScreen loginScreen = new LoginScreen();
                        loginScreen.Show();
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private bool validateInputs()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(tb_UserName.Text))
            {
                MessageBox.Show("Username is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }

            if (!Regex.IsMatch(tb_Email.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Invalid email format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }

            if (tb_Password.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }

            if (numberic_Age.Value < 18)
            {
                MessageBox.Show("You must be at least 18 years old to sign up.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(tb_Address.Text))
            {
                MessageBox.Show("Address is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }

            return isValid;
        }

        private void lb_LoginHere_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Close();
        }

        private void numberic_Age_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lb_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}