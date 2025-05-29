namespace Wisho.Presentation.UserForms
{
    partial class ViewFavoritesForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewFavoritesForm));
            btn_deleteFav = new Button();
            btn_sendFavByMail = new Button();
            panel_favorites = new Panel();
            pc_LogOut = new PictureBox();
            ic_back = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pc_LogOut).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ic_back).BeginInit();
            SuspendLayout();
            // 
            // btn_deleteFav
            // 
            btn_deleteFav.BackColor = Color.Red;
            btn_deleteFav.Font = new Font("Segoe UI", 10F);
            btn_deleteFav.ForeColor = Color.White;
            btn_deleteFav.Location = new Point(91, 134);
            btn_deleteFav.Name = "btn_deleteFav";
            btn_deleteFav.Size = new Size(158, 59);
            btn_deleteFav.TabIndex = 0;
            btn_deleteFav.Text = "Delete From Favorites";
            btn_deleteFav.UseVisualStyleBackColor = false;
            btn_deleteFav.Visible = false;
            btn_deleteFav.Click += btn_deleteFav_Click;
            // 
            // btn_sendFavByMail
            // 
            btn_sendFavByMail.BackColor = Color.SteelBlue;
            btn_sendFavByMail.Font = new Font("Segoe UI", 10F);
            btn_sendFavByMail.ForeColor = Color.White;
            btn_sendFavByMail.Location = new Point(91, 235);
            btn_sendFavByMail.Name = "btn_sendFavByMail";
            btn_sendFavByMail.Size = new Size(158, 59);
            btn_sendFavByMail.TabIndex = 1;
            btn_sendFavByMail.Text = "Send by Email";
            btn_sendFavByMail.UseVisualStyleBackColor = false;
            btn_sendFavByMail.Click += btn_sendFavByMail_Click;
            // 
            // panel_favorites
            // 
            panel_favorites.AutoScroll = true;
            panel_favorites.BackColor = Color.White;
            panel_favorites.Location = new Point(388, 134);
            panel_favorites.Name = "panel_favorites";
            panel_favorites.Size = new Size(400, 160);
            panel_favorites.TabIndex = 2;
            // 
            // pc_LogOut
            // 
            pc_LogOut.Image = (Image)resources.GetObject("pc_LogOut.Image");
            pc_LogOut.Location = new Point(754, 8);
            pc_LogOut.Name = "pc_LogOut";
            pc_LogOut.Size = new Size(109, 46);
            pc_LogOut.SizeMode = PictureBoxSizeMode.Zoom;
            pc_LogOut.TabIndex = 3;
            pc_LogOut.TabStop = false;
            pc_LogOut.Click += pc_LogOut_Click;
            // 
            // ic_back
            // 
            ic_back.Image = Properties.Resources.iconBack;
            ic_back.Location = new Point(12, 8);
            ic_back.Name = "ic_back";
            ic_back.Size = new Size(44, 50);
            ic_back.SizeMode = PictureBoxSizeMode.Zoom;
            ic_back.TabIndex = 4;
            ic_back.TabStop = false;
            ic_back.Click += ic_back_Click;
            // 
            // ViewFavoritesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 236, 230);
            ClientSize = new Size(850, 405);
            ControlBox = false;
            Controls.Add(btn_deleteFav);
            Controls.Add(btn_sendFavByMail);
            Controls.Add(panel_favorites);
            Controls.Add(pc_LogOut);
            Controls.Add(ic_back);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ViewFavoritesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewFavoritesForm";
            Load += ViewFavoritesForm_Load;
            ((System.ComponentModel.ISupportInitialize)pc_LogOut).EndInit();
            ((System.ComponentModel.ISupportInitialize)ic_back).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_deleteFav;
        private Button btn_sendFavByMail;
        private Panel panel_favorites;
        private PictureBox pc_LogOut;
        private PictureBox ic_back;
    }
}