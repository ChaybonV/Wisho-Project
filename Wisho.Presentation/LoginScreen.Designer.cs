using System.Windows.Forms;

namespace Wisho.Presentation
{
    partial class LoginScreen
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
            btn_clear = new Button();
            checkBox_ShowPass = new CheckBox();
            lb_SignUp = new Label();
            lb_messageDonothave = new Label();
            button1 = new Button();
            tb_Password = new TextBox();
            lb_password = new Label();
            tb_UserName = new TextBox();
            lb_Email = new Label();
            lb_welcomeLogin = new Label();
            lb_closeLogin = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.FromArgb(229, 27, 27);
            btn_clear.FlatAppearance.BorderSize = 0;
            btn_clear.FlatStyle = FlatStyle.Flat;
            btn_clear.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn_clear.ForeColor = SystemColors.Window;
            btn_clear.Location = new Point(611, 298);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(147, 55);
            btn_clear.TabIndex = 22;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // checkBox_ShowPass
            // 
            checkBox_ShowPass.AutoSize = true;
            checkBox_ShowPass.Font = new Font("Segoe UI", 12F);
            checkBox_ShowPass.ForeColor = Color.FromArgb(146, 160, 144);
            checkBox_ShowPass.Location = new Point(438, 227);
            checkBox_ShowPass.Name = "checkBox_ShowPass";
            checkBox_ShowPass.Size = new Size(138, 25);
            checkBox_ShowPass.TabIndex = 21;
            checkBox_ShowPass.Text = "Show Password";
            checkBox_ShowPass.UseVisualStyleBackColor = true;
            checkBox_ShowPass.CheckedChanged += checkBox_ShowPass_CheckedChanged;
            // 
            // lb_SignUp
            // 
            lb_SignUp.AutoSize = true;
            lb_SignUp.Cursor = Cursors.Hand;
            lb_SignUp.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_SignUp.ForeColor = Color.FromArgb(59, 119, 149);
            lb_SignUp.Location = new Point(602, 259);
            lb_SignUp.Name = "lb_SignUp";
            lb_SignUp.Size = new Size(66, 21);
            lb_SignUp.TabIndex = 20;
            lb_SignUp.Text = "SignUp";
            lb_SignUp.Click += lb_SignUp_Click;
            // 
            // lb_messageDonothave
            // 
            lb_messageDonothave.AutoSize = true;
            lb_messageDonothave.Font = new Font("Segoe UI", 12F);
            lb_messageDonothave.ForeColor = Color.FromArgb(146, 160, 144);
            lb_messageDonothave.Location = new Point(438, 259);
            lb_messageDonothave.Name = "lb_messageDonothave";
            lb_messageDonothave.Size = new Size(171, 21);
            lb_messageDonothave.TabIndex = 19;
            lb_messageDonothave.Text = "Don't have an account?";
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(438, 298);
            button1.Name = "button1";
            button1.Size = new Size(147, 55);
            button1.TabIndex = 18;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tb_Password
            // 
            tb_Password.BackColor = Color.FromArgb(240, 240, 240);
            tb_Password.BorderStyle = BorderStyle.FixedSingle;
            tb_Password.Font = new Font("Segoe UI", 15F);
            tb_Password.ForeColor = Color.FromArgb(64, 64, 64);
            tb_Password.Location = new Point(438, 190);
            tb_Password.Name = "tb_Password";
            tb_Password.Size = new Size(320, 34);
            tb_Password.TabIndex = 17;
            tb_Password.UseSystemPasswordChar = true;
            // 
            // lb_password
            // 
            lb_password.AutoSize = true;
            lb_password.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_password.ForeColor = Color.FromArgb(146, 160, 144);
            lb_password.Location = new Point(438, 166);
            lb_password.Name = "lb_password";
            lb_password.Size = new Size(82, 21);
            lb_password.TabIndex = 16;
            lb_password.Text = "Password";
            // 
            // tb_UserName
            // 
            tb_UserName.BackColor = Color.FromArgb(240, 240, 240);
            tb_UserName.BorderStyle = BorderStyle.FixedSingle;
            tb_UserName.Font = new Font("Segoe UI", 15F);
            tb_UserName.ForeColor = Color.FromArgb(64, 64, 64);
            tb_UserName.Location = new Point(438, 112);
            tb_UserName.Name = "tb_UserName";
            tb_UserName.Size = new Size(320, 34);
            tb_UserName.TabIndex = 15;
            // 
            // lb_Email
            // 
            lb_Email.AutoSize = true;
            lb_Email.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_Email.ForeColor = Color.FromArgb(146, 160, 144);
            lb_Email.Location = new Point(438, 88);
            lb_Email.Name = "lb_Email";
            lb_Email.Size = new Size(94, 21);
            lb_Email.TabIndex = 14;
            lb_Email.Text = "User Name";
            // 
            // lb_welcomeLogin
            // 
            lb_welcomeLogin.AutoSize = true;
            lb_welcomeLogin.BackColor = Color.Transparent;
            lb_welcomeLogin.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lb_welcomeLogin.ForeColor = Color.FromArgb(59, 119, 149);
            lb_welcomeLogin.Location = new Point(345, 14);
            lb_welcomeLogin.Name = "lb_welcomeLogin";
            lb_welcomeLogin.Size = new Size(178, 46);
            lb_welcomeLogin.TabIndex = 13;
            lb_welcomeLogin.Text = "Welcome!";
            lb_welcomeLogin.Click += lb_welcomeLogin_Click;
            // 
            // lb_closeLogin
            // 
            lb_closeLogin.AutoSize = true;
            lb_closeLogin.Cursor = Cursors.Hand;
            lb_closeLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_closeLogin.ForeColor = Color.FromArgb(52, 152, 219);
            lb_closeLogin.Location = new Point(924, 456);
            lb_closeLogin.Name = "lb_closeLogin";
            lb_closeLogin.Size = new Size(86, 21);
            lb_closeLogin.TabIndex = 23;
            lb_closeLogin.Text = "Close App";
            lb_closeLogin.Click += lb_closeLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.imageLogin2;
            pictureBox1.Location = new Point(10, 92);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(355, 259);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Close;
            pictureBox2.Location = new Point(802, 11);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 236, 230);
            ClientSize = new Size(850, 405);
            ControlBox = false;
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lb_closeLogin);
            Controls.Add(btn_clear);
            Controls.Add(checkBox_ShowPass);
            Controls.Add(lb_SignUp);
            Controls.Add(lb_messageDonothave);
            Controls.Add(button1);
            Controls.Add(tb_Password);
            Controls.Add(lb_password);
            Controls.Add(tb_UserName);
            Controls.Add(lb_Email);
            Controls.Add(lb_welcomeLogin);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "LoginScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private Button btn_clear;
        private CheckBox checkBox_ShowPass;
        private Label lb_SignUp;
        private Label lb_messageDonothave;
        private Button button1;
        private TextBox tb_Password;
        private Label lb_password;
        private TextBox tb_UserName;
        private Label lb_Email;
        private Label lb_welcomeLogin;
        private Label lb_closeLogin;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}