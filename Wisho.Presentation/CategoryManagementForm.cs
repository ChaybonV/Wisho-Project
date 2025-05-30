using System;
using System.Data;
using Wisho.BusinessLogic;
using System.Drawing;
using System.Windows.Forms;


namespace Wisho.Presentation
{
    public partial class CategoryManagementForm : Form
    {
        DataTable User;
        CategoryService categoryService;
        public CategoryManagementForm(DataTable user)
        {
            categoryService = new CategoryService();
            InitializeComponent();
            User = user;
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

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (validateInputs())
            {
                string categoryName = txt_categoryName.Text;
                int rowsAffected = categoryService.addCategory(categoryName);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Category added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                    clearInputs();
                }
                else
                {
                    MessageBox.Show("Failed to add category. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void clearInputs()
        {
            txt_categoryName.Text = "";
        }

        private bool validateInputs()
        {
            if (string.IsNullOrWhiteSpace(txt_categoryName.Text))
            {
                MessageBox.Show("Category Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void CategoryManagementForm_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            dgv_categories.DataSource = categoryService.getAllCategoriesData();

            if (dgv_categories.Columns.Contains("CategoryId"))
                dgv_categories.Columns["CategoryId"].Visible = false;

            if (dgv_categories.Columns.Contains("CategoryName"))
                dgv_categories.Columns["CategoryName"].HeaderText = "Categorie";

            dgv_categories.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgv_categories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            btn_add.Show();
            btn_delete.Hide();
            btn_update.Hide();
        }
        int id;
        private void dgv_categories_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                id = Convert.ToInt32(dgv_categories.SelectedRows[0].Cells["CategoryId"].Value);
                DataGridViewRow selectedRow = dgv_categories.Rows[e.RowIndex];

                txt_categoryName.Text = selectedRow.Cells["CategoryName"].Value.ToString();
                btn_add.Hide();
                btn_update.Show();
                btn_delete.Show();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (validateInputs())
            {

                if (dgv_categories.SelectedRows.Count > 0)
                {
                    string categoryName = txt_categoryName.Text;

                    int rowsAffected = categoryService.updateCategory(id, categoryName);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Category updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();
                        clearInputs();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update category. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a category to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgv_categories.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this category?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {


                    int rowsAffected = categoryService.deleteCategory(id);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Category deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete category. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a category to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ic_back_Click(object sender, EventArgs e)
        {
            AdminDashBoard adminDashBoard = new AdminDashBoard(User);
            adminDashBoard.Show();
            this.Close();
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
        
    }
}