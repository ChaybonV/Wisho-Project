namespace Wisho.Presentation
{
    partial class CategoryManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryManagementForm));
            btn_update = new Button();
            btn_add = new Button();
            btn_delete = new Button();
            label1 = new Label();
            txt_categoryName = new TextBox();
            dgv_categories = new DataGridView();
            pc_LogOut = new PictureBox();
            ic_back = new PictureBox();
            lb_close = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgv_categories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pc_LogOut).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ic_back).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lb_close).BeginInit();
            SuspendLayout();
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.FromArgb(123, 143, 164);
            btn_update.Font = new Font("Segoe UI", 10F);
            btn_update.ForeColor = Color.White;
            btn_update.Location = new Point(241, 185);
            btn_update.Margin = new Padding(3, 2, 3, 2);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(104, 48);
            btn_update.TabIndex = 50;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(123, 143, 164);
            btn_add.Font = new Font("Segoe UI", 10F);
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(241, 134);
            btn_add.Margin = new Padding(3, 2, 3, 2);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(104, 47);
            btn_add.TabIndex = 49;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.FromArgb(229, 27, 27);
            btn_delete.Font = new Font("Segoe UI", 10F);
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(241, 237);
            btn_delete.Margin = new Padding(3, 2, 3, 2);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(104, 47);
            btn_delete.TabIndex = 48;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(104, 94);
            label1.Name = "label1";
            label1.Size = new Size(105, 19);
            label1.TabIndex = 45;
            label1.Text = "Category Name";
            // 
            // txt_categoryName
            // 
            txt_categoryName.Font = new Font("Segoe UI", 10F);
            txt_categoryName.Location = new Point(241, 91);
            txt_categoryName.Margin = new Padding(3, 2, 3, 2);
            txt_categoryName.Name = "txt_categoryName";
            txt_categoryName.Size = new Size(161, 25);
            txt_categoryName.TabIndex = 42;
            // 
            // dgv_categories
            // 
            dgv_categories.BackgroundColor = Color.White;
            dgv_categories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_categories.GridColor = Color.LightGray;
            dgv_categories.Location = new Point(491, 91);
            dgv_categories.Margin = new Padding(3, 2, 3, 2);
            dgv_categories.Name = "dgv_categories";
            dgv_categories.RowHeadersWidth = 51;
            dgv_categories.Size = new Size(136, 193);
            dgv_categories.TabIndex = 41;
            dgv_categories.RowHeaderMouseDoubleClick += dgv_categories_RowHeaderMouseDoubleClick;
            // 
            // pc_LogOut
            // 
            pc_LogOut.Image = (Image)resources.GetObject("pc_LogOut.Image");
            pc_LogOut.Location = new Point(770, 348);
            pc_LogOut.Margin = new Padding(3, 2, 3, 2);
            pc_LogOut.Name = "pc_LogOut";
            pc_LogOut.Size = new Size(68, 46);
            pc_LogOut.SizeMode = PictureBoxSizeMode.Zoom;
            pc_LogOut.TabIndex = 89;
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
            ic_back.TabIndex = 88;
            ic_back.TabStop = false;
            ic_back.Click += ic_back_Click;
            // 
            // lb_close
            // 
            lb_close.Image = Properties.Resources.Close;
            lb_close.Location = new Point(805, 11);
            lb_close.Margin = new Padding(3, 2, 3, 2);
            lb_close.Name = "lb_close";
            lb_close.Size = new Size(34, 31);
            lb_close.SizeMode = PictureBoxSizeMode.Zoom;
            lb_close.TabIndex = 90;
            lb_close.TabStop = false;
            lb_close.Click += lb_close_Click;
            // 
            // CategoryManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 236, 230);
            ClientSize = new Size(850, 405);
            ControlBox = false;
            Controls.Add(lb_close);
            Controls.Add(pc_LogOut);
            Controls.Add(ic_back);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(btn_delete);
            Controls.Add(label1);
            Controls.Add(txt_categoryName);
            Controls.Add(dgv_categories);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "CategoryManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CategoryManagementForm";
            Load += CategoryManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_categories).EndInit();
            ((System.ComponentModel.ISupportInitialize)pc_LogOut).EndInit();
            ((System.ComponentModel.ISupportInitialize)ic_back).EndInit();
            ((System.ComponentModel.ISupportInitialize)lb_close).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_update;
        private Button btn_add;
        private Button btn_delete;
        private Label label1;
        private TextBox txt_categoryName;
        private DataGridView dgv_categories;
        private PictureBox pc_LogOut;
        private PictureBox ic_back;
        private PictureBox lb_close;
    }
}