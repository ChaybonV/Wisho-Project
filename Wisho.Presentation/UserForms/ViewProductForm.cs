using System;
using System.Data;
using Wisho.BusinessLogic;
using System.Drawing;
using System.Windows.Forms;


namespace Wisho.Presentation.UserForms
{
    public partial class ViewProductForm : Form
    {
        FavoriteService favoriteService;
        ProductService productService;
        DataTable User;
        public ViewProductForm(DataTable user)
        {
            favoriteService = new FavoriteService();
            productService = new ProductService();
            InitializeComponent();
            User = user;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Close();
        }
        int id;
        private void ViewProductForm_Load(object sender, EventArgs e)
        {
            DataRow userRow = User.Rows[0];
            id = Convert.ToInt32(userRow["UserId"]);
            loadData();
        }

        private void loadData()
        {
            btn_addFav.Hide();
            panel_products.Controls.Clear();

            DataTable products = productService.ProductDataFavorite(id);
            int y = 10;

            foreach (DataRow row in products.Rows)
            {
                int productId = Convert.ToInt32(row["ProductId"]);
                string name = row["ProductName"].ToString();
                decimal price = Convert.ToDecimal(row["Price"]);

                // Maak een panel voor elk product
                Panel productPanel = new Panel
                {
                    Size = new Size(440, 40),
                    Location = new Point(10, y),
                    BorderStyle = BorderStyle.FixedSingle
                };

                Label lblName = new Label
                {
                    Text = name,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    Location = new Point(10, 10),
                    AutoSize = true
                };

                Label lblPrice = new Label
                {
                    Text = price.ToString("C2"),
                    Font = new Font("Segoe UI", 10),
                    Location = new Point(250, 10),
                    AutoSize = true
                };

                Button selectBtn = new Button
                {
                    Text = "Select",
                    Tag = productId,
                    Location = new Point(360, 5),
                    Size = new Size(60, 25)
                };
                selectBtn.Click += SelectBtn_Click;

                productPanel.Controls.Add(lblName);
                productPanel.Controls.Add(lblPrice);
                productPanel.Controls.Add(selectBtn);
                panel_products.Controls.Add(productPanel);

                y += 50;
            }
        }

        private int selectedProductId;

        private void SelectBtn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && btn.Tag != null)
            {
                selectedProductId = (int)btn.Tag;
                btn_addFav.Show();
            }
        }

        private void btn_addFav_Click(object sender, EventArgs e)
        {
            int rowsAffected = favoriteService.addFav(selectedProductId, id);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Product added to favorites!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
            }
            else
            {
                MessageBox.Show("Failed to add product to favorites.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ic_back_Click(object sender, EventArgs e)
        {
            UserDashBoard userDashBoard = new UserDashBoard(User);
            userDashBoard.Show();
            this.Close();
        }

        private void pc_LogOut_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Close();
        }
    }
}