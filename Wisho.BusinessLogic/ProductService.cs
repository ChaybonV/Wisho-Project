using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wisho.DataAccess;

namespace Wisho.BusinessLogic
{
    public class ProductService
    {
        DBContext dbContext;

        public ProductService()
        {
            dbContext = new DBContext();
        }

        public DataTable getAllProducts()
        {
            string query = "SELECT `ProductId`, `ProductName`, `Price`, `CategoryName` FROM Products p JOIN Categories c ON(p.CategoryId = c.CategoryId)";
            DataTable dataTable = dbContext.ExecuteQuery(query);
            return dataTable;
        }

        public DataTable getCategories()
        {
            string query = "SELECT `CategoryId`, `CategoryName` FROM Categories";
            DataTable dataTable = dbContext.ExecuteQuery(query);
            return dataTable;
        }

        public int addProduct(string productName, decimal price, int category_id)
        {
            string query = $"INSERT INTO Products (`ProductName`, `Price`, `CategoryId`) VALUES ('{productName}', {price}, {category_id})";
            int rowAffected = dbContext.ExecuteNonQuery(query);
            return rowAffected;
        }

        public int updateProduct(string productName, decimal price, int category_id, int id)
        {
            string query = $"UPDATE Products SET ProductName = '{productName}', Price = {price.ToString().Replace(',', '.')}, CategoryID = {category_id} WHERE ProductID = {id}";
            int rowAffected = dbContext.ExecuteNonQuery(query);
            return rowAffected;
        }

        public int deleteProduct(int id)
        {
            string query = $"DELETE FROM Products WHERE `ProductId` = {id}";
            int rowAffected = dbContext.ExecuteNonQuery(query);
            return rowAffected;
        }

        public DataTable ProductDataFavorite(int id)
        {
            string query = $"SELECT p.`ProductId`, p.`ProductName`, p.`Price`, c.`CategoryName` FROM Products p JOIN Categories c ON p.CategoryId = c.CategoryId WHERE NOT EXISTS (SELECT 1 FROM Favorites f WHERE f.ProductId = p.ProductId AND f.UserId = {id})";
            DataTable dataTable = dbContext.ExecuteQuery(query);
            return dataTable;
        }

        public DataTable ProductDataFavoriteExist(int id)
        {
            string query = $"SELECT p.`ProductId`, p.`ProductName`, p.`Price`, c.`CategoryName` FROM Products p JOIN Categories c ON p.CategoryId = c.CategoryId WHERE EXISTS (SELECT 1 FROM Favorites f WHERE f.ProductId = p.ProductId AND f.UserId = {id})";
            DataTable dataTable = dbContext.ExecuteQuery(query);
            return dataTable;
        }
    }
}
