using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wisho.DataAccess;

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
