namespace Wisho.Presentation
{
    partial class ProductManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductManagementForm));
            btn_update = new Button();
            btn_add = new Button();
            btn_delete = new Button();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            lblFav3 = new Label();
            lblFav2 = new Label();
            lblFav1 = new Label();
            lblTop3Title = new Label();
            cb_category = new ComboBox();
            nud_price = new NumericUpDown();
            txt_productName = new TextBox();
            dvg_products = new DataGridView();
            lb_close = new PictureBox();
            pc_LogOut = new PictureBox();
            ic_back = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)nud_price).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvg_products).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lb_close).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pc_LogOut).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ic_back).BeginInit();
            SuspendLayout();
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.FromArgb(123, 143, 164);
            btn_update.Font = new Font("Segoe UI", 10F);
            btn_update.ForeColor = Color.White;
            btn_update.Location = new Point(529, 255);
            btn_update.Margin = new Padding(3, 2, 3, 2);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(119, 55);
            btn_update.TabIndex = 38;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(123, 143, 164);
            btn_add.Font = new Font("Segoe UI", 10F);
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(393, 255);
            btn_add.Margin = new Padding(3, 2, 3, 2);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(119, 55);
            btn_add.TabIndex = 37;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.FromArgb(229, 27, 27);
            btn_delete.Font = new Font("Segoe UI", 10F);
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(663, 255);
            btn_delete.Margin = new Padding(3, 2, 3, 2);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(119, 55);
            btn_delete.TabIndex = 36;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(13, 158);
            label6.Name = "label6";
            label6.Size = new Size(65, 19);
            label6.TabIndex = 35;
            label6.Text = "Category";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(13, 123);
            label5.Name = "label5";
            label5.Size = new Size(38, 19);
            label5.TabIndex = 34;
            label5.Text = "Price";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(10, 80);
            label1.Name = "label1";
            label1.Size = new Size(97, 19);
            label1.TabIndex = 30;
            label1.Text = "Product Name";
            // 
            // lblFav3
            // 
            lblFav3.AutoSize = true;
            lblFav3.Font = new Font("Segoe UI", 10F);
            lblFav3.Location = new Point(10, 295);
            lblFav3.Name = "lblFav3";
            lblFav3.Size = new Size(0, 19);
            lblFav3.TabIndex = 97;
            // 
            // lblFav2
            // 
            lblFav2.AutoSize = true;
            lblFav2.Font = new Font("Segoe UI", 10F);
            lblFav2.Location = new Point(10, 275);
            lblFav2.Name = "lblFav2";
            lblFav2.Size = new Size(0, 19);
            lblFav2.TabIndex = 96;
            // 
            // lblFav1
            // 
            lblFav1.AutoSize = true;
            lblFav1.Font = new Font("Segoe UI", 10F);
            lblFav1.Location = new Point(10, 255);
            lblFav1.Name = "lblFav1";
            lblFav1.Size = new Size(0, 19);
            lblFav1.TabIndex = 95;
            // 
            // lblTop3Title
            // 
            lblTop3Title.AutoSize = true;
            lblTop3Title.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTop3Title.Location = new Point(10, 235);
            lblTop3Title.Name = "lblTop3Title";
            lblTop3Title.Size = new Size(190, 19);
            lblTop3Title.TabIndex = 94;
            lblTop3Title.Text = "Top 3 Favoriete Producten:";
            // 
            // cb_category
            // 
            cb_category.Font = new Font("Segoe UI", 10F);
            cb_category.FormattingEnabled = true;
            cb_category.Location = new Point(124, 158);
            cb_category.Margin = new Padding(3, 2, 3, 2);
            cb_category.Name = "cb_category";
            cb_category.Size = new Size(176, 25);
            cb_category.TabIndex = 29;
            // 
            // nud_price
            // 
            nud_price.Font = new Font("Segoe UI", 10F);
            nud_price.Location = new Point(124, 117);
            nud_price.Margin = new Padding(3, 2, 3, 2);
            nud_price.Name = "nud_price";
            nud_price.Size = new Size(175, 25);
            nud_price.TabIndex = 28;
            // 
            // txt_productName
            // 
            txt_productName.Font = new Font("Segoe UI", 10F);
            txt_productName.Location = new Point(124, 74);
            txt_productName.Margin = new Padding(3, 2, 3, 2);
            txt_productName.Name = "txt_productName";
            txt_productName.Size = new Size(176, 25);
            txt_productName.TabIndex = 24;
            // 
            // dvg_products
            // 
            dvg_products.BackgroundColor = Color.White;
            dvg_products.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvg_products.GridColor = Color.LightGray;
            dvg_products.Location = new Point(393, 80);
            dvg_products.Margin = new Padding(3, 2, 3, 2);
            dvg_products.Name = "dvg_products";
            dvg_products.RowHeadersWidth = 51;
            dvg_products.Size = new Size(389, 145);
            dvg_products.TabIndex = 23;
            dvg_products.RowHeaderMouseDoubleClick += dvg_products_RowHeaderMouseDoubleClick;
            // 
            // lb_close
            // 
            lb_close.Image = Properties.Resources.Close;
            lb_close.Location = new Point(802, 9);
            lb_close.Margin = new Padding(3, 2, 3, 2);
            lb_close.Name = "lb_close";
            lb_close.Size = new Size(34, 31);
            lb_close.SizeMode = PictureBoxSizeMode.Zoom;
            lb_close.TabIndex = 93;
            lb_close.TabStop = false;
            lb_close.Click += lb_close_Click;
            // 
            // pc_LogOut
            // 
            pc_LogOut.Image = (Image)resources.GetObject("pc_LogOut.Image");
            pc_LogOut.Location = new Point(770, 329);
            pc_LogOut.Margin = new Padding(3, 2, 3, 2);
            pc_LogOut.Name = "pc_LogOut";
            pc_LogOut.Size = new Size(68, 46);
            pc_LogOut.SizeMode = PictureBoxSizeMode.Zoom;
            pc_LogOut.TabIndex = 92;
            pc_LogOut.TabStop = false;
            pc_LogOut.Click += pc_LogOut_Click;
            // 
            // ic_back
            // 
            ic_back.Image = Properties.Resources.iconBack;
            ic_back.Location = new Point(7, 3);
            ic_back.Name = "ic_back";
            ic_back.Size = new Size(44, 50);
            ic_back.SizeMode = PictureBoxSizeMode.Zoom;
            ic_back.TabIndex = 91;
            ic_back.TabStop = false;
            ic_back.Click += ic_back_Click;
            // 
            // ProductManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 236, 230);
            ClientSize = new Size(850, 385);
            ControlBox = false;
            Controls.Add(lb_close);
            Controls.Add(pc_LogOut);
            Controls.Add(ic_back);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(btn_delete);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(lblTop3Title);
            Controls.Add(lblFav1);
            Controls.Add(lblFav2);
            Controls.Add(lblFav3);
            Controls.Add(cb_category);
            Controls.Add(nud_price);
            Controls.Add(txt_productName);
            Controls.Add(dvg_products);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ProductManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductManagementForm";
            Load += ProductManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)nud_price).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvg_products).EndInit();
            ((System.ComponentModel.ISupportInitialize)lb_close).EndInit();
            ((System.ComponentModel.ISupportInitialize)pc_LogOut).EndInit();
            ((System.ComponentModel.ISupportInitialize)ic_back).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_update;
        private Button btn_add;
        private Button btn_delete;
        private Label label6;
        private Label label5;
        private Label label1;
        private ComboBox cb_category;
        private NumericUpDown nud_price;
        private TextBox txt_productName;
        private DataGridView dvg_products;
        private PictureBox lb_close;
        private PictureBox pc_LogOut;
        private PictureBox ic_back;
        private Label lblFav3;
        private Label lblFav2;
        private Label lblFav1;
        private Label lblTop3Title;
    }
}