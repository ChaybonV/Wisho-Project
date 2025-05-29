namespace Wisho.Presentation
{
    partial class UserManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManagementForm));
            dvg_users = new DataGridView();
            txt_userName = new TextBox();
            txt_email = new TextBox();
            txt_password = new TextBox();
            txt_address = new TextBox();
            nud_age = new NumericUpDown();
            cb_role = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btn_delete = new Button();
            btn_add = new Button();
            btn_update = new Button();
            checkBox_ShowPass = new CheckBox();
            lb_close = new PictureBox();
            pc_LogOut = new PictureBox();
            ic_back = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dvg_users).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_age).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lb_close).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pc_LogOut).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ic_back).BeginInit();
            SuspendLayout();
            // 
            // dvg_users
            // 
            dvg_users.BackgroundColor = Color.White;
            dvg_users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvg_users.GridColor = Color.LightGray;
            dvg_users.Location = new Point(12, 57);
            dvg_users.Margin = new Padding(3, 2, 3, 2);
            dvg_users.Name = "dvg_users";
            dvg_users.RowHeadersWidth = 51;
            dvg_users.Size = new Size(547, 171);
            dvg_users.TabIndex = 0;
            dvg_users.RowHeaderMouseDoubleClick += dvg_users_RowHeaderMouseDoubleClick;
            // 
            // txt_userName
            // 
            txt_userName.Font = new Font("Segoe UI", 10F);
            txt_userName.Location = new Point(392, 239);
            txt_userName.Margin = new Padding(3, 2, 3, 2);
            txt_userName.Name = "txt_userName";
            txt_userName.Size = new Size(176, 25);
            txt_userName.TabIndex = 2;
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Segoe UI", 10F);
            txt_email.Location = new Point(86, 242);
            txt_email.Margin = new Padding(3, 2, 3, 2);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(176, 25);
            txt_email.TabIndex = 1;
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Segoe UI", 10F);
            txt_password.Location = new Point(392, 281);
            txt_password.Margin = new Padding(3, 2, 3, 2);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(176, 25);
            txt_password.TabIndex = 4;
            txt_password.UseSystemPasswordChar = true;
            // 
            // txt_address
            // 
            txt_address.Font = new Font("Segoe UI", 10F);
            txt_address.Location = new Point(86, 284);
            txt_address.Margin = new Padding(3, 2, 3, 2);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(176, 25);
            txt_address.TabIndex = 3;
            // 
            // nud_age
            // 
            nud_age.Font = new Font("Segoe UI", 10F);
            nud_age.Location = new Point(86, 352);
            nud_age.Margin = new Padding(3, 2, 3, 2);
            nud_age.Name = "nud_age";
            nud_age.Size = new Size(176, 25);
            nud_age.TabIndex = 5;
            // 
            // cb_role
            // 
            cb_role.Font = new Font("Segoe UI", 10F);
            cb_role.FormattingEnabled = true;
            cb_role.Location = new Point(392, 348);
            cb_role.Margin = new Padding(3, 2, 3, 2);
            cb_role.Name = "cb_role";
            cb_role.Size = new Size(176, 25);
            cb_role.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.FromArgb(146, 160, 144);
            label1.Location = new Point(309, 245);
            label1.Name = "label1";
            label1.Size = new Size(77, 19);
            label1.TabIndex = 7;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.FromArgb(146, 160, 144);
            label2.Location = new Point(12, 245);
            label2.Name = "label2";
            label2.Size = new Size(41, 19);
            label2.TabIndex = 8;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.FromArgb(146, 160, 144);
            label3.Location = new Point(309, 287);
            label3.Name = "label3";
            label3.Size = new Size(67, 19);
            label3.TabIndex = 9;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.FromArgb(146, 160, 144);
            label4.Location = new Point(12, 287);
            label4.Name = "label4";
            label4.Size = new Size(58, 19);
            label4.TabIndex = 10;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.FromArgb(146, 160, 144);
            label5.Location = new Point(12, 358);
            label5.Name = "label5";
            label5.Size = new Size(33, 19);
            label5.TabIndex = 11;
            label5.Text = "Age";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.ForeColor = Color.FromArgb(146, 160, 144);
            label6.Location = new Point(309, 354);
            label6.Name = "label6";
            label6.Size = new Size(35, 19);
            label6.TabIndex = 12;
            label6.Text = "Role";
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.FromArgb(229, 27, 27);
            btn_delete.Font = new Font("Segoe UI", 10F);
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(574, 189);
            btn_delete.Margin = new Padding(3, 2, 3, 2);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(111, 39);
            btn_delete.TabIndex = 13;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(123, 143, 164);
            btn_add.Font = new Font("Segoe UI", 10F);
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(574, 57);
            btn_add.Margin = new Padding(3, 2, 3, 2);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(111, 39);
            btn_add.TabIndex = 14;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.FromArgb(123, 143, 164);
            btn_update.Font = new Font("Segoe UI", 10F);
            btn_update.ForeColor = Color.White;
            btn_update.Location = new Point(574, 121);
            btn_update.Margin = new Padding(3, 2, 3, 2);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(111, 39);
            btn_update.TabIndex = 15;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // checkBox_ShowPass
            // 
            checkBox_ShowPass.AutoSize = true;
            checkBox_ShowPass.Font = new Font("Segoe UI", 12F);
            checkBox_ShowPass.ForeColor = Color.FromArgb(146, 160, 144);
            checkBox_ShowPass.Location = new Point(430, 311);
            checkBox_ShowPass.Name = "checkBox_ShowPass";
            checkBox_ShowPass.Size = new Size(138, 25);
            checkBox_ShowPass.TabIndex = 22;
            checkBox_ShowPass.Text = "Show Password";
            checkBox_ShowPass.UseVisualStyleBackColor = true;
            checkBox_ShowPass.CheckedChanged += checkBox_ShowPass_CheckedChanged;
            // 
            // lb_close
            // 
            lb_close.Image = Properties.Resources.Close;
            lb_close.Location = new Point(706, 5);
            lb_close.Margin = new Padding(3, 2, 3, 2);
            lb_close.Name = "lb_close";
            lb_close.Size = new Size(34, 31);
            lb_close.SizeMode = PictureBoxSizeMode.Zoom;
            lb_close.TabIndex = 68;
            lb_close.TabStop = false;
            lb_close.Click += lb_close_Click;
            // 
            // pc_LogOut
            // 
            pc_LogOut.Image = (Image)resources.GetObject("pc_LogOut.Image");
            pc_LogOut.Location = new Point(648, 371);
            pc_LogOut.Margin = new Padding(3, 2, 3, 2);
            pc_LogOut.Name = "pc_LogOut";
            pc_LogOut.Size = new Size(109, 46);
            pc_LogOut.SizeMode = PictureBoxSizeMode.Zoom;
            pc_LogOut.TabIndex = 67;
            pc_LogOut.TabStop = false;
            pc_LogOut.Click += pc_LogOut_Click;
            // 
            // ic_back
            // 
            ic_back.Image = Properties.Resources.iconBack;
            ic_back.Location = new Point(9, 2);
            ic_back.Name = "ic_back";
            ic_back.Size = new Size(44, 50);
            ic_back.SizeMode = PictureBoxSizeMode.Zoom;
            ic_back.TabIndex = 89;
            ic_back.TabStop = false;
            ic_back.Click += ic_back_Click;
            // 
            // UserManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 236, 230);
            ClientSize = new Size(750, 425);
            ControlBox = false;
            Controls.Add(ic_back);
            Controls.Add(lb_close);
            Controls.Add(pc_LogOut);
            Controls.Add(checkBox_ShowPass);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(btn_delete);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cb_role);
            Controls.Add(nud_age);
            Controls.Add(txt_address);
            Controls.Add(txt_password);
            Controls.Add(txt_email);
            Controls.Add(txt_userName);
            Controls.Add(dvg_users);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Management";
            Load += UserManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dvg_users).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_age).EndInit();
            ((System.ComponentModel.ISupportInitialize)lb_close).EndInit();
            ((System.ComponentModel.ISupportInitialize)pc_LogOut).EndInit();
            ((System.ComponentModel.ISupportInitialize)ic_back).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
        private PictureBox profileLinkBtn;
        private PictureBox pb_logOut;
        private Label lb_AdminUserDashboard;
        private DataGridView dgv_userAdmin;
        private Button UserBtn;
        private Button CategoryBtn;
        private Button productBtn;
        private Label lb_Operations;
        private Button btn_Add;
        private Button btn_remove;
        private Button btn_Edit;
        private Label lb_userName;
        private TextBox tb_UserName;
        private TextBox tb_password;
        private Label lb_password;
        private TextBox tb_Email;
        private Label lb_Email;
        private Label lb_age;
        private NumericUpDown tb_numbricAge;
        private TextBox tb_Address;
        private Label lb_Address;
        private Label lb_Role;
        private ComboBox cb_role;
        private Label lb_closeDashBoard;
        private Label lb_RefreshData;
        private DataGridView dvg_users;
        private TextBox txt_userName;
        private TextBox txt_email;
        private TextBox txt_password;
        private TextBox txt_address;
        private NumericUpDown nud_age;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btn_delete;
        private Button btn_add;
        private Button btn_update;
        private CheckBox checkBox_ShowPass;
        private PictureBox lb_close;
        private PictureBox pc_LogOut;
        private PictureBox ic_back;
    }
}