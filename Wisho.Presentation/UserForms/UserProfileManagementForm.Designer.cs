using System.Data;
using System.Windows.Forms;
using Wisho.DataAccess;

namespace Wisho.Presentation.UserForms
{
    partial class UserProfileManagementForm
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfileManagementForm));
            btn_changePassword = new Button();
            lb_checkAge = new Label();
            lb_checkPassword = new Label();
            lb_checkUserName = new Label();
            lb_checkEmail = new Label();
            btn_updateProfile = new Button();
            numberic_Age = new NumericUpDown();
            tb_Address = new TextBox();
            lb_Address = new Label();
            lb_Age = new Label();
            tb_Email = new TextBox();
            lb_email = new Label();
            tb_UserName = new TextBox();
            lb_UserName = new Label();
            lb_welcomeLogin = new Label();
            pc_LogOut = new PictureBox();
            ic_back = new PictureBox();
            pictureBox1 = new PictureBox();
            btn_deleteAccount = new Button();
            ((System.ComponentModel.ISupportInitialize)numberic_Age).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pc_LogOut).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ic_back).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_changePassword
            // 
            btn_changePassword.BackColor = Color.FromArgb(26, 103, 177);
            btn_changePassword.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btn_changePassword.ForeColor = Color.White;
            btn_changePassword.Location = new Point(405, 351);
            btn_changePassword.Name = "btn_changePassword";
            btn_changePassword.Size = new Size(281, 63);
            btn_changePassword.TabIndex = 78;
            btn_changePassword.Text = "Change Password";
            btn_changePassword.UseVisualStyleBackColor = false;
            btn_changePassword.Click += btn_changePassword_Click;
            // 
            // lb_checkAge
            // 
            lb_checkAge.AutoSize = true;
            lb_checkAge.Font = new Font("Segoe UI", 10F);
            lb_checkAge.ForeColor = Color.FromArgb(231, 76, 60);
            lb_checkAge.Location = new Point(603, 258);
            lb_checkAge.Name = "lb_checkAge";
            lb_checkAge.Size = new Size(0, 19);
            lb_checkAge.TabIndex = 77;
            // 
            // lb_checkPassword
            // 
            lb_checkPassword.AutoSize = true;
            lb_checkPassword.Font = new Font("Segoe UI", 10F);
            lb_checkPassword.ForeColor = Color.FromArgb(231, 76, 60);
            lb_checkPassword.Location = new Point(602, 257);
            lb_checkPassword.Name = "lb_checkPassword";
            lb_checkPassword.Size = new Size(0, 19);
            lb_checkPassword.TabIndex = 76;
            // 
            // lb_checkUserName
            // 
            lb_checkUserName.AutoSize = true;
            lb_checkUserName.Font = new Font("Segoe UI", 10F);
            lb_checkUserName.ForeColor = Color.FromArgb(231, 76, 60);
            lb_checkUserName.Location = new Point(602, 125);
            lb_checkUserName.Name = "lb_checkUserName";
            lb_checkUserName.Size = new Size(0, 19);
            lb_checkUserName.TabIndex = 75;
            // 
            // lb_checkEmail
            // 
            lb_checkEmail.AutoSize = true;
            lb_checkEmail.Font = new Font("Segoe UI", 10F);
            lb_checkEmail.ForeColor = Color.FromArgb(231, 76, 60);
            lb_checkEmail.Location = new Point(603, 196);
            lb_checkEmail.Name = "lb_checkEmail";
            lb_checkEmail.Size = new Size(0, 19);
            lb_checkEmail.TabIndex = 74;
            // 
            // btn_updateProfile
            // 
            btn_updateProfile.BackColor = Color.FromArgb(26, 103, 177);
            btn_updateProfile.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btn_updateProfile.ForeColor = Color.White;
            btn_updateProfile.Location = new Point(405, 420);
            btn_updateProfile.Name = "btn_updateProfile";
            btn_updateProfile.Size = new Size(281, 63);
            btn_updateProfile.TabIndex = 73;
            btn_updateProfile.Text = "Update";
            btn_updateProfile.UseVisualStyleBackColor = false;
            btn_updateProfile.Click += btn_updateProfile_Click_1;
            // 
            // numberic_Age
            // 
            numberic_Age.BackColor = Color.FromArgb(236, 240, 241);
            numberic_Age.Font = new Font("Segoe UI", 15F);
            numberic_Age.ForeColor = Color.FromArgb(44, 62, 80);
            numberic_Age.Location = new Point(405, 218);
            numberic_Age.Name = "numberic_Age";
            numberic_Age.Size = new Size(295, 34);
            numberic_Age.TabIndex = 71;
            // 
            // tb_Address
            // 
            tb_Address.BackColor = Color.FromArgb(236, 240, 241);
            tb_Address.Font = new Font("Segoe UI", 15F);
            tb_Address.ForeColor = Color.FromArgb(44, 62, 80);
            tb_Address.Location = new Point(405, 294);
            tb_Address.Name = "tb_Address";
            tb_Address.Size = new Size(295, 34);
            tb_Address.TabIndex = 72;
            // 
            // lb_Address
            // 
            lb_Address.AutoSize = true;
            lb_Address.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lb_Address.ForeColor = Color.FromArgb(146, 160, 144);
            lb_Address.Location = new Point(299, 308);
            lb_Address.Name = "lb_Address";
            lb_Address.Size = new Size(66, 20);
            lb_Address.TabIndex = 70;
            lb_Address.Text = "Address";
            // 
            // lb_Age
            // 
            lb_Age.AutoSize = true;
            lb_Age.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lb_Age.ForeColor = Color.FromArgb(146, 160, 144);
            lb_Age.Location = new Point(299, 233);
            lb_Age.Name = "lb_Age";
            lb_Age.Size = new Size(37, 20);
            lb_Age.TabIndex = 69;
            lb_Age.Text = "Age";
            // 
            // tb_Email
            // 
            tb_Email.BackColor = Color.FromArgb(236, 240, 241);
            tb_Email.Font = new Font("Segoe UI", 15F);
            tb_Email.ForeColor = Color.FromArgb(44, 62, 80);
            tb_Email.Location = new Point(405, 151);
            tb_Email.Name = "tb_Email";
            tb_Email.Size = new Size(294, 34);
            tb_Email.TabIndex = 68;
            // 
            // lb_email
            // 
            lb_email.AutoSize = true;
            lb_email.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lb_email.ForeColor = Color.FromArgb(146, 160, 144);
            lb_email.Location = new Point(298, 165);
            lb_email.Name = "lb_email";
            lb_email.Size = new Size(53, 20);
            lb_email.TabIndex = 67;
            lb_email.Text = "E-mail";
            // 
            // tb_UserName
            // 
            tb_UserName.BackColor = Color.FromArgb(236, 240, 241);
            tb_UserName.Font = new Font("Segoe UI", 15F);
            tb_UserName.ForeColor = Color.FromArgb(44, 62, 80);
            tb_UserName.Location = new Point(405, 78);
            tb_UserName.Name = "tb_UserName";
            tb_UserName.Size = new Size(294, 34);
            tb_UserName.TabIndex = 66;
            // 
            // lb_UserName
            // 
            lb_UserName.AutoSize = true;
            lb_UserName.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lb_UserName.ForeColor = Color.FromArgb(146, 160, 144);
            lb_UserName.Location = new Point(298, 92);
            lb_UserName.Name = "lb_UserName";
            lb_UserName.Size = new Size(83, 20);
            lb_UserName.TabIndex = 65;
            lb_UserName.Text = "UserName";
            // 
            // lb_welcomeLogin
            // 
            lb_welcomeLogin.AutoSize = true;
            lb_welcomeLogin.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lb_welcomeLogin.ForeColor = Color.FromArgb(26, 103, 177);
            lb_welcomeLogin.Location = new Point(298, 11);
            lb_welcomeLogin.Name = "lb_welcomeLogin";
            lb_welcomeLogin.Size = new Size(126, 46);
            lb_welcomeLogin.TabIndex = 64;
            lb_welcomeLogin.Text = "Profile";
            // 
            // pc_LogOut
            // 
            pc_LogOut.Image = (Image)resources.GetObject("pc_LogOut.Image");
            pc_LogOut.Location = new Point(653, 11);
            pc_LogOut.Margin = new Padding(3, 2, 3, 2);
            pc_LogOut.Name = "pc_LogOut";
            pc_LogOut.Size = new Size(68, 46);
            pc_LogOut.SizeMode = PictureBoxSizeMode.Zoom;
            pc_LogOut.TabIndex = 82;
            pc_LogOut.TabStop = false;
            pc_LogOut.Click += pc_LogOut_Click;
            // 
            // ic_back
            // 
            ic_back.Image = Properties.Resources.iconBack;
            ic_back.Location = new Point(12, 11);
            ic_back.Name = "ic_back";
            ic_back.Size = new Size(44, 50);
            ic_back.SizeMode = PictureBoxSizeMode.Zoom;
            ic_back.TabIndex = 81;
            ic_back.TabStop = false;
            ic_back.Click += ic_back_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icProfile;
            pictureBox1.Location = new Point(28, 125);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(223, 186);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 83;
            pictureBox1.TabStop = false;
            // 
            // btn_deleteAccount
            // 
            btn_deleteAccount.BackColor = Color.FromArgb(192, 57, 43);
            btn_deleteAccount.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btn_deleteAccount.ForeColor = Color.White;
            btn_deleteAccount.Location = new Point(405, 489);
            btn_deleteAccount.Name = "btn_deleteAccount";
            btn_deleteAccount.Size = new Size(281, 63);
            btn_deleteAccount.TabIndex = 84;
            btn_deleteAccount.Text = "Delete Account";
            btn_deleteAccount.UseVisualStyleBackColor = false;
            btn_deleteAccount.Click += btn_deleteAccount_Click;
            // 
            // UserProfileManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 236, 230);
            ClientSize = new Size(725, 565);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(pc_LogOut);
            Controls.Add(ic_back);
            Controls.Add(btn_changePassword);
            Controls.Add(lb_checkAge);
            Controls.Add(lb_checkPassword);
            Controls.Add(lb_checkUserName);
            Controls.Add(lb_checkEmail);
            Controls.Add(btn_updateProfile);
            Controls.Add(numberic_Age);
            Controls.Add(tb_Address);
            Controls.Add(lb_Address);
            Controls.Add(lb_Age);
            Controls.Add(tb_Email);
            Controls.Add(lb_email);
            Controls.Add(tb_UserName);
            Controls.Add(lb_UserName);
            Controls.Add(lb_welcomeLogin);
            Controls.Add(btn_deleteAccount);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserProfileManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserProfileManagementForm";
            Load += UserProfileManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)numberic_Age).EndInit();
            ((System.ComponentModel.ISupportInitialize)pc_LogOut).EndInit();
            ((System.ComponentModel.ISupportInitialize)ic_back).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_changePassword;
        private Label lb_checkAge;
        private Label lb_checkPassword;
        private Label lb_checkUserName;
        private Label lb_checkEmail;
        private Button btn_updateProfile;
        private Button btn_deleteAccount;
        private NumericUpDown numberic_Age;
        private TextBox tb_Address;
        private Label lb_Address;
        private Label lb_Age;
        private TextBox tb_Email;
        private Label lb_email;
        private TextBox tb_UserName;
        private Label lb_UserName;
        private Label lb_welcomeLogin;
        private PictureBox pc_LogOut;
        private PictureBox ic_back;
        private PictureBox pictureBox1;
    }
}