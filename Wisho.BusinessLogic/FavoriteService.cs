using System;
using System.Data;
using Wisho.DataAccess;


namespace Wisho.BusinessLogic
{
    public class FavoriteService
    {
        DBContext dbContext;

        public FavoriteService()
        {
            dbContext = new DBContext();
        }

        public int addFav(int productID, int UserID)
        {
            string query = $"INSERT INTO Favorites (`UserId`, `ProductId`) VALUES ({UserID}, {productID})";
            int rowAffected = dbContext.ExecuteNonQuery(query);
            return rowAffected;
        }

        public int deleteFav(int productID, int UserID)
        {
            string query = $"DELETE FROM Favorites WHERE `ProductId` = {productID} AND `UserId` = {UserID}";
            int rowAffected = dbContext.ExecuteNonQuery(query);
            return rowAffected;
        }

        public DataTable GetTopThreePopularProducts()
        {
            string query = "SELECT p.ProductName, COUNT(f.ProductId) AS FavoriteCount FROM Favorites f JOIN Products p ON p.ProductID = f.ProductId GROUP BY f.ProductId ORDER BY FavoriteCount DESC LIMIT 3";
            DataTable dataTable = dbContext.ExecuteQuery(query);
            return dataTable;
        }

    }
}