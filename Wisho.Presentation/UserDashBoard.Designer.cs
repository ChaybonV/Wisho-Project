namespace Wisho.Presentation
{
    partial class UserDashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDashBoard));
            lb_welcomeLogin = new Label();
            btn_manageFavorites = new Button();
            btn_manageUserProfile = new Button();
            btn_viewProduucts = new Button();
            pc_LogOut = new PictureBox();
            lb_close = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pc_LogOut).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lb_close).BeginInit();
            SuspendLayout();
            // 
            // lb_welcomeLogin
            // 
            lb_welcomeLogin.AutoSize = true;
            lb_welcomeLogin.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lb_welcomeLogin.ForeColor = Color.FromArgb(32, 88, 138);
            lb_welcomeLogin.Location = new Point(400, 9);
            lb_welcomeLogin.Name = "lb_welcomeLogin";
            lb_welcomeLogin.Size = new Size(294, 46);
            lb_welcomeLogin.TabIndex = 14;
            lb_welcomeLogin.Text = "Welcome User!";
            //
            // lb_userName
            //
            lb_userName = new Label();
            lb_userName.AutoSize = true;
            lb_userName.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lb_userName.ForeColor = Color.FromArgb(32, 88, 138);
            lb_userName.Location = new Point(0, 0);
            lb_userName.Name = "lb_userName";
            lb_userName.Size = new Size(0, 0);
            lb_userName.TabIndex = 15;
            lb_userName.Text = "";
            // 
            // btn_manageFavorites
            // 
            btn_manageFavorites.BackColor = Color.FromArgb(123, 143, 164);
            btn_manageFavorites.FlatAppearance.BorderSize = 0;
            btn_manageFavorites.FlatStyle = FlatStyle.Flat;
            btn_manageFavorites.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btn_manageFavorites.ForeColor = Color.White;
            btn_manageFavorites.Location = new Point(366, 152);
            btn_manageFavorites.Margin = new Padding(3, 2, 3, 2);
            btn_manageFavorites.Name = "btn_manageFavorites";
            btn_manageFavorites.Size = new Size(236, 82);
            btn_manageFavorites.TabIndex = 18;
            btn_manageFavorites.Text = "Manage Favorites";
            btn_manageFavorites.UseVisualStyleBackColor = false;
            btn_manageFavorites.Click += btn_manageFavorites_Click;
            // 
            // btn_manageUserProfile
            // 
            btn_manageUserProfile.BackColor = Color.FromArgb(123, 143, 164);
            btn_manageUserProfile.FlatAppearance.BorderSize = 0;
            btn_manageUserProfile.FlatStyle = FlatStyle.Flat;
            btn_manageUserProfile.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btn_manageUserProfile.ForeColor = Color.White;
            btn_manageUserProfile.Location = new Point(633, 152);
            btn_manageUserProfile.Margin = new Padding(3, 2, 3, 2);
            btn_manageUserProfile.Name = "btn_manageUserProfile";
            btn_manageUserProfile.Size = new Size(236, 82);
            btn_manageUserProfile.TabIndex = 19;
            btn_manageUserProfile.Text = "Manage Profile";
            btn_manageUserProfile.UseVisualStyleBackColor = false;
            btn_manageUserProfile.Click += btn_manageUserProfile_Click;
            // 
            // btn_viewProduucts
            // 
            btn_viewProduucts.BackColor = Color.FromArgb(123, 143, 164);
            btn_viewProduucts.FlatAppearance.BorderSize = 0;
            btn_viewProduucts.FlatStyle = FlatStyle.Flat;
            btn_viewProduucts.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btn_viewProduucts.ForeColor = Color.White;
            btn_viewProduucts.Location = new Point(102, 152);
            btn_viewProduucts.Margin = new Padding(3, 2, 3, 2);
            btn_viewProduucts.Name = "btn_viewProduucts";
            btn_viewProduucts.Size = new Size(236, 82);
            btn_viewProduucts.TabIndex = 21;
            btn_viewProduucts.Text = "View Products";
            btn_viewProduucts.UseVisualStyleBackColor = false;
            btn_viewProduucts.Click += btn_viewProduucts_Click;
            // 
            // pc_LogOut
            // 
            pc_LogOut.Image = (Image)resources.GetObject("pc_LogOut.Image");
            pc_LogOut.Location = new Point(873, 395);
            pc_LogOut.Margin = new Padding(3, 2, 3, 2);
            pc_LogOut.Name = "pc_LogOut";
            pc_LogOut.Size = new Size(109, 46);
            pc_LogOut.SizeMode = PictureBoxSizeMode.Zoom;
            pc_LogOut.TabIndex = 65;
            pc_LogOut.TabStop = false;
            pc_LogOut.Click += pc_LogOut_Click;
            // 
            // lb_close
            // 
            lb_close.Image = Properties.Resources.Close;
            lb_close.Location = new Point(919, 8);
            lb_close.Margin = new Padding(3, 2, 3, 2);
            lb_close.Name = "lb_close";
            lb_close.Size = new Size(34, 31);
            lb_close.SizeMode = PictureBoxSizeMode.Zoom;
            lb_close.TabIndex = 70;
            lb_close.TabStop = false;
            lb_close.Click += lb_close_Click;
            // 
            // UserDashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 236, 230);
            ClientSize = new Size(962, 450);
            ControlBox = false;
            Controls.Add(lb_close);
            Controls.Add(pc_LogOut);
            Controls.Add(btn_viewProduucts);
            Controls.Add(btn_manageUserProfile);
            Controls.Add(btn_manageFavorites);
            Controls.Add(lb_welcomeLogin);
            Controls.Add(lb_userName);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserDashBoard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserDashBoard";
            Load += UserDashBoard_Load;
            ((System.ComponentModel.ISupportInitialize)pc_LogOut).EndInit();
            ((System.ComponentModel.ISupportInitialize)lb_close).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_welcomeLogin;
        private Label lb_userName;
        private Button btn_manageFavorites;
        private Button btn_manageUserProfile;
        private Button btn_viewProduucts;
        private PictureBox pc_LogOut;
        private PictureBox lb_close;
    }
}