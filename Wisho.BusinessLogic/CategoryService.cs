using System;
using System.Data;
using Wisho.DataAccess;
using System.Drawing;
using Wisho.BusinessLogic;


namespace Wisho.BusinessLogic
{
    public class CategoryService
    {
        DBContext dbContext;

        public CategoryService()
        {
            dbContext = new DBContext();
        }

        public DataTable getAllCategoriesData()
        {
            string query = "SELECT `CategoryId`, `CategoryName` FROM `Categories`";
            DataTable dt = new DataTable();
            dt = dbContext.ExecuteQuery(query);
            return dt;
        }

        public int addCategory(string categoryName)
        {
            string query = $"INSERT INTO `Categories` (`CategoryName`) VALUES ('{categoryName}')";
            int rowAffected = dbContext.ExecuteNonQuery(query);
            return rowAffected;
        }

        public int updateCategory(int id, string categoryName)
        {
            string query = $"UPDATE `Categories` SET `CategoryName` = '{categoryName}' WHERE `CategoryId` = {id}";
            int rowAffected = dbContext.ExecuteNonQuery(query);
            return rowAffected;
        }

        public int deleteCategory(int id)
        {
            string query = $"DELETE FROM `Categories` WHERE `CategoryId` = {id}";
            int rowAffected = dbContext.ExecuteNonQuery(query);
            return rowAffected;
        }
    }
}