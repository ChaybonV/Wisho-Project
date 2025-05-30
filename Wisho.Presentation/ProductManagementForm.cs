using System;
using System.Data;
using Wisho.BusinessLogic;
using System.Drawing;
using System.Windows.Forms;


namespace Wisho.Presentation
{
    public partial class ProductManagementForm : Form
    {
        DataTable User;
        ProductService productService;
        FavoriteService favoriteService;
        public ProductManagementForm(DataTable user)
        {
            productService = new ProductService();
            favoriteService = new FavoriteService();
            InitializeComponent();
            User = user;
        }

        private void ProductManagementForm_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            dvg_products.DataSource = productService.getAllProducts();
            loadTop3Favorites();

            if (dvg_products.Columns.Contains("ProductID"))
                dvg_products.Columns["ProductID"].Visible = false;

            dvg_products.Columns["ProductName"].HeaderText = "Product";
            dvg_products.Columns["Price"].HeaderText = "Price (€)";
            dvg_products.Columns["CategoryName"].HeaderText = "Category";

            dvg_products.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dvg_products.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvg_products.MultiSelect = false;

            dvg_products.RowTemplate.Height = 30;
            dvg_products.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            cb_category.DataSource = productService.getCategories();
            cb_category.DisplayMember = "CategoryName";
            cb_category.ValueMember = "CategoryId";

            btn_add.Show();
            btn_delete.Hide();
            btn_update.Hide();
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
        private void clearInputs()
        {
            txt_productName.Clear();
            nud_price.Value = 0;
            cb_category.SelectedIndex = -1; // Reset ComboBox selection
        }

        private void loadTop3Favorites()
        {
            DataTable topProducts = favoriteService.GetTopThreePopularProducts();
            if (topProducts.Rows.Count > 0)
                lblFav1.Text = $"1. {topProducts.Rows[0]["ProductName"]} ({topProducts.Rows[0]["FavoriteCount"]}x)";
            else
                lblFav1.Text = "1. -";

            if (topProducts.Rows.Count > 1)
                lblFav2.Text = $"2. {topProducts.Rows[1]["ProductName"]} ({topProducts.Rows[1]["FavoriteCount"]}x)";
            else
                lblFav2.Text = "2. -";

            if (topProducts.Rows.Count > 2)
                lblFav3.Text = $"3. {topProducts.Rows[2]["ProductName"]} ({topProducts.Rows[2]["FavoriteCount"]}x)";
            else
                lblFav3.Text = "3. -";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (validateInputs())
            {
                string productName = txt_productName.Text;
                decimal price = nud_price.Value;
                int category = (int)cb_category.SelectedValue;

                int rowsAffected = productService.addProduct(productName, price, category);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    clearInputs();
                    loadData();
                }
                else
                {
                    MessageBox.Show("Failed to add product. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool validateInputs()
        {
            if (string.IsNullOrWhiteSpace(txt_productName.Text))
            {
                MessageBox.Show("Product Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (nud_price.Value <= 0)
            {
                MessageBox.Show("Price must be greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cb_category.SelectedItem == null)
            {
                MessageBox.Show("Please select a category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        int id;
        private void dvg_products_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dvg_products.Rows[e.RowIndex];
                id = Convert.ToInt32(dvg_products.SelectedRows[0].Cells["ProductID"].Value);

                txt_productName.Text = selectedRow.Cells["ProductName"].Value.ToString();
                nud_price.Value = Convert.ToDecimal(selectedRow.Cells["Price"].Value);

                string categoryName = selectedRow.Cells["CategoryName"].Value.ToString();
                cb_category.SelectedIndex = cb_category.FindStringExact(categoryName);
                btn_add.Hide();
                btn_delete.Show();
                btn_update.Show();
            }
        }


        private void btn_update_Click(object sender, EventArgs e)
        {
            if (validateInputs())
            {
                if (dvg_products.SelectedRows.Count > 0)
                {

                    string productName = txt_productName.Text;
                    decimal price = nud_price.Value;
                    int category = (int)cb_category.SelectedValue;

                    int rowsAffected = productService.updateProduct(productName, price, category, id);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        loadData();
                        clearInputs();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update product. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a product to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dvg_products.SelectedRows.Count > 0)
            {


                DialogResult confirmResult = MessageBox.Show("Are you sure you want to delete this product?",
                    "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    int rowsAffected = productService.deleteProduct(id);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Product deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        loadData();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete product. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a product to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            Application.Exit();
        }

        private void ic_back_Click(object sender, EventArgs e)
        {
            AdminDashBoard adminDashBoard = new AdminDashBoard(User);
            adminDashBoard.Show();
            this.Close();
        }
    }
}