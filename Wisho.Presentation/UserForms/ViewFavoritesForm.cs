using System;
using System.Data;
using System.Drawing;
using System.Net.Mail;
using System.Windows.Forms;
using Wisho.BusinessLogic;

namespace Wisho.Presentation.UserForms
{
    public partial class ViewFavoritesForm : Form
    {
        FavoriteService favoriteService;
        ProductService productService;
        DataTable User;
        int id;
        int selectedFavoriteProductId;

        public ViewFavoritesForm(DataTable user)
        {
            favoriteService = new FavoriteService();
            productService = new ProductService();
            InitializeComponent();
            User = user;
        }

        private void ViewFavoritesForm_Load(object sender, EventArgs e)
        {
            id = Convert.ToInt32(User.Rows[0]["UserId"]);
            LoadFavorites();
        }

        private void LoadFavorites()
        {
            panel_favorites.Controls.Clear();
            btn_deleteFav.Visible = false;

            DataTable favorites = productService.ProductDataFavoriteExist(id);
            int y = 10;

            foreach (DataRow row in favorites.Rows)
            {
                int productId = Convert.ToInt32(row["ProductId"]);
                string name = row["ProductName"].ToString();
                decimal price = Convert.ToDecimal(row["Price"]);

                Panel productPanel = new Panel
                {
                    Size = new Size(370, 40),
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
                    Location = new Point(200, 10),
                    AutoSize = true
                };

                Button selectBtn = new Button
                {
                    Text = "Select",
                    Tag = productId,
                    Location = new Point(290, 5),
                    Size = new Size(60, 25)
                };
                selectBtn.Click += SelectBtn_Click;

                productPanel.Controls.Add(lblName);
                productPanel.Controls.Add(lblPrice);
                productPanel.Controls.Add(selectBtn);
                panel_favorites.Controls.Add(productPanel);

                y += 50;
            }
        }

        private void SelectBtn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn?.Tag != null)
            {
                selectedFavoriteProductId = (int)btn.Tag;
                btn_deleteFav.Visible = true;
            }
        }

        private void btn_deleteFav_Click(object sender, EventArgs e)
        {
            if (selectedFavoriteProductId > 0)
            {
                int rows = favoriteService.deleteFav(selectedFavoriteProductId, id);
                if (rows > 0)
                {
                    MessageBox.Show("Product removed from favorites.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadFavorites();
                }
                else
                {
                    MessageBox.Show("Failed to remove favorite.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_sendFavByMail_Click(object sender, EventArgs e)
        {
            Form prompt = new Form()
            {
                Width = 400,
                Height = 250,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Favorites sending",
                StartPosition = FormStartPosition.CenterScreen
            };

            Label textLabel = new Label() { Left = 20, Top = 20, Text = "E-mail:" };
            TextBox emailBox = new TextBox() { Left = 20, Top = 45, Width = 340 };

            Label nameLabel = new Label() { Left = 20, Top = 80, Text = "Name (optional):" };
            TextBox nameBox = new TextBox() { Left = 20, Top = 105, Width = 340 };

            Button confirmation = new Button() { Text = "Send", Left = 240, Width = 120, Top = 150 };
            confirmation.DialogResult = DialogResult.OK;

            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(emailBox);
            prompt.Controls.Add(nameLabel);
            prompt.Controls.Add(nameBox);
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;

            if (prompt.ShowDialog() == DialogResult.OK)
            {
                string recipient = emailBox.Text.Trim();
                string name = nameBox.Text.Trim();

                if (string.IsNullOrWhiteSpace(recipient))
                {
                    MessageBox.Show("Please enter a valid email address.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string body = $"Hello {(string.IsNullOrEmpty(name) ? "" : name)},\n\nHere is my favoritelist from Wisho:\n\n";

                foreach (Control ctrl in panel_favorites.Controls)
                {
                    if (ctrl is Panel productPanel)
                    {
                        string productName = "";
                        string price = "";

                        foreach (Control child in productPanel.Controls)
                        {
                            if (child is Label lbl)
                            {
                                if (lbl.Location.X < 150) // Eerste label = naam
                                    productName = lbl.Text;
                                else if (lbl.Location.X >= 150) // Tweede label = prijs
                                    price = lbl.Text;
                            }
                        }

                        if (!string.IsNullOrEmpty(productName) && !string.IsNullOrEmpty(price))
                        {
                            body += $"- {productName} ({price})\n";
                        }
                    }
                }

                body += $"\n\n\nKing Regards,\n{User.Rows[0]["Username"].ToString()}";

                try
                {
                    MailMessage mail = new MailMessage("chaybon2006@gmail.com", recipient);
                    mail.Subject = "My favoritelist from Wisho";
                    mail.Body = body;

                    SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                    client.Credentials = new System.Net.NetworkCredential("chaybon2006@gmail.com", "wkzp ldto szcb grbu");
                    client.EnableSsl = true;
                    client.Send(mail);

                    MessageBox.Show("Favorites sent successfully!", "Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error by sending: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ic_back_Click(object sender, EventArgs e)
        {
            UserDashBoard dash = new UserDashBoard(User);
            dash.Show();
            Close();
        }

        private void pc_LogOut_Click(object sender, EventArgs e)
        {
            LoginScreen login = new LoginScreen();
            login.Show();
            Close();
        }
    }
}