namespace Wisho.Presentation.UserForms
{
    partial class UserChangePasswordForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserChangePasswordForm));
            btn_updateProfile = new Button();
            cb_confirmPassword = new CheckBox();
            txt_confirmPassword = new TextBox();
            label2 = new Label();
            cb_oldPassword = new CheckBox();
            txt_newPassword = new TextBox();
            label1 = new Label();
            cb_newPassword = new CheckBox();
            txt_oldPassword = new TextBox();
            lb_password = new Label();
            lb_welcomeLogin = new Label();
            pictureBox1 = new PictureBox();
            pc_LogOut = new PictureBox();
            ic_back = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pc_LogOut).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ic_back).BeginInit();
            SuspendLayout();
            // 
            // btn_updateProfile
            // 
            btn_updateProfile.BackColor = Color.FromArgb(26, 103, 177);
            btn_updateProfile.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btn_updateProfile.ForeColor = Color.White;
            btn_updateProfile.Location = new Point(395, 362);
            btn_updateProfile.Name = "btn_updateProfile";
            btn_updateProfile.Size = new Size(174, 63);
            btn_updateProfile.TabIndex = 78;
            btn_updateProfile.Text = "Update";
            btn_updateProfile.UseVisualStyleBackColor = false;
            btn_updateProfile.Click += btn_updateProfile_Click;
            // 
            // cb_confirmPassword
            // 
            cb_confirmPassword.AutoSize = true;
            cb_confirmPassword.Font = new Font("Segoe UI", 12F);
            cb_confirmPassword.ForeColor = Color.FromArgb(146, 160, 144);
            cb_confirmPassword.Location = new Point(506, 303);
            cb_confirmPassword.Name = "cb_confirmPassword";
            cb_confirmPassword.Size = new Size(199, 25);
            cb_confirmPassword.TabIndex = 75;
            cb_confirmPassword.Text = "Show Confirm Password";
            cb_confirmPassword.UseVisualStyleBackColor = true;
            cb_confirmPassword.CheckedChanged += cb_confirmPassword_CheckedChanged;
            // 
            // txt_confirmPassword
            // 
            txt_confirmPassword.BackColor = Color.FromArgb(240, 240, 240);
            txt_confirmPassword.BorderStyle = BorderStyle.FixedSingle;
            txt_confirmPassword.Font = new Font("Segoe UI", 14F);
            txt_confirmPassword.ForeColor = Color.FromArgb(64, 64, 64);
            txt_confirmPassword.Location = new Point(414, 265);
            txt_confirmPassword.Name = "txt_confirmPassword";
            txt_confirmPassword.Size = new Size(286, 32);
            txt_confirmPassword.TabIndex = 74;
            txt_confirmPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(146, 160, 144);
            label2.Location = new Point(260, 276);
            label2.Name = "label2";
            label2.Size = new Size(148, 21);
            label2.TabIndex = 73;
            label2.Text = "Confirm Password";
            // 
            // cb_oldPassword
            // 
            cb_oldPassword.AutoSize = true;
            cb_oldPassword.Font = new Font("Segoe UI", 12F);
            cb_oldPassword.ForeColor = Color.FromArgb(146, 160, 144);
            cb_oldPassword.Location = new Point(538, 135);
            cb_oldPassword.Name = "cb_oldPassword";
            cb_oldPassword.Size = new Size(168, 25);
            cb_oldPassword.TabIndex = 72;
            cb_oldPassword.Text = "Show old Password ";
            cb_oldPassword.UseVisualStyleBackColor = true;
            cb_oldPassword.CheckedChanged += cb_oldPassword_CheckedChanged;
            // 
            // txt_newPassword
            // 
            txt_newPassword.BackColor = Color.FromArgb(240, 240, 240);
            txt_newPassword.BorderStyle = BorderStyle.FixedSingle;
            txt_newPassword.Font = new Font("Segoe UI", 14F);
            txt_newPassword.ForeColor = Color.FromArgb(64, 64, 64);
            txt_newPassword.Location = new Point(414, 178);
            txt_newPassword.Name = "txt_newPassword";
            txt_newPassword.Size = new Size(286, 32);
            txt_newPassword.TabIndex = 71;
            txt_newPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(146, 160, 144);
            label1.Location = new Point(260, 114);
            label1.Name = "label1";
            label1.Size = new Size(113, 21);
            label1.TabIndex = 70;
            label1.Text = "Old Password";
            // 
            // cb_newPassword
            // 
            cb_newPassword.AutoSize = true;
            cb_newPassword.Font = new Font("Segoe UI", 12F);
            cb_newPassword.ForeColor = Color.FromArgb(146, 160, 144);
            cb_newPassword.Location = new Point(530, 216);
            cb_newPassword.Name = "cb_newPassword";
            cb_newPassword.Size = new Size(174, 25);
            cb_newPassword.TabIndex = 69;
            cb_newPassword.Text = "Show New Password";
            cb_newPassword.UseVisualStyleBackColor = true;
            cb_newPassword.CheckedChanged += cb_newPassword_CheckedChanged;
            // 
            // txt_oldPassword
            // 
            txt_oldPassword.BackColor = Color.FromArgb(240, 240, 240);
            txt_oldPassword.BorderStyle = BorderStyle.FixedSingle;
            txt_oldPassword.Font = new Font("Segoe UI", 14F);
            txt_oldPassword.ForeColor = Color.FromArgb(64, 64, 64);
            txt_oldPassword.Location = new Point(414, 100);
            txt_oldPassword.Name = "txt_oldPassword";
            txt_oldPassword.Size = new Size(286, 32);
            txt_oldPassword.TabIndex = 68;
            txt_oldPassword.UseSystemPasswordChar = true;
            // 
            // lb_password
            // 
            lb_password.AutoSize = true;
            lb_password.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_password.ForeColor = Color.FromArgb(146, 160, 144);
            lb_password.Location = new Point(260, 192);
            lb_password.Name = "lb_password";
            lb_password.Size = new Size(121, 21);
            lb_password.TabIndex = 67;
            lb_password.Text = "New Password";
            // 
            // lb_welcomeLogin
            // 
            lb_welcomeLogin.AutoSize = true;
            lb_welcomeLogin.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lb_welcomeLogin.ForeColor = Color.FromArgb(26, 103, 177);
            lb_welcomeLogin.Location = new Point(210, 12);
            lb_welcomeLogin.Name = "lb_welcomeLogin";
            lb_welcomeLogin.Size = new Size(299, 46);
            lb_welcomeLogin.TabIndex = 66;
            lb_welcomeLogin.Text = "Change Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icProfile;
            pictureBox1.Location = new Point(12, 111);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(223, 186);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 84;
            pictureBox1.TabStop = false;
            // 
            // pc_LogOut
            // 
            pc_LogOut.Image = (Image)resources.GetObject("pc_LogOut.Image");
            pc_LogOut.Location = new Point(663, 12);
            pc_LogOut.Margin = new Padding(3, 2, 3, 2);
            pc_LogOut.Name = "pc_LogOut";
            pc_LogOut.Size = new Size(68, 46);
            pc_LogOut.SizeMode = PictureBoxSizeMode.Zoom;
            pc_LogOut.TabIndex = 86;
            pc_LogOut.TabStop = false;
            pc_LogOut.Click += pc_LogOut_Click;
            // 
            // ic_back
            // 
            ic_back.Image = Properties.Resources.iconBack;
            ic_back.Location = new Point(7, 13);
            ic_back.Name = "ic_back";
            ic_back.Size = new Size(44, 50);
            ic_back.SizeMode = PictureBoxSizeMode.Zoom;
            ic_back.TabIndex = 85;
            ic_back.TabStop = false;
            ic_back.Click += ic_back_Click;
            // 
            // UserChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 236, 230);
            ClientSize = new Size(735, 450);
            ControlBox = false;
            Controls.Add(pc_LogOut);
            Controls.Add(ic_back);
            Controls.Add(pictureBox1);
            Controls.Add(btn_updateProfile);
            Controls.Add(cb_confirmPassword);
            Controls.Add(txt_confirmPassword);
            Controls.Add(label2);
            Controls.Add(cb_oldPassword);
            Controls.Add(txt_newPassword);
            Controls.Add(label1);
            Controls.Add(cb_newPassword);
            Controls.Add(txt_oldPassword);
            Controls.Add(lb_password);
            Controls.Add(lb_welcomeLogin);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserChangePasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserChangePasswordForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pc_LogOut).EndInit();
            ((System.ComponentModel.ISupportInitialize)ic_back).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_updateProfile;
        private CheckBox cb_confirmPassword;
        private TextBox txt_confirmPassword;
        private Label label2;
        private CheckBox cb_oldPassword;
        private TextBox txt_newPassword;
        private Label label1;
        private CheckBox cb_newPassword;
        private TextBox txt_oldPassword;
        private Label lb_password;
        private Label lb_welcomeLogin;
        private PictureBox pictureBox1;
        private PictureBox pc_LogOut;
        private PictureBox ic_back;
    }
}