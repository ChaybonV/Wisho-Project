using System;
using System.Data;
using Wisho.DataAccess;

namespace Wisho.BusinessLogic
{
    public class UserService
    {
        DBContext dbContext;

        public UserService()
        {
            dbContext = new DBContext();
        }

        public int addUser(string username, string password, string email, int age, string address, string role = "User")
        {
            string query = $"INSERT INTO Users (Username, Password, Email, Age, Address, Role) VALUES ('{username}', '{password}', '{email}', {age}, '{address}', '{role}')";
            int rowAffected = dbContext.ExecuteNonQuery(query);
            return rowAffected;
        }

        public bool authenticateUser(string userName, string password)
        {
            string query = $"SELECT `Username`, `Password` FROM Users WHERE `Password` = '{password}' AND `Username` = '{userName}' AND `Role` = 'User'";
            DataTable dataTable = dbContext.ExecuteQuery(query);
            return dataTable.Rows.Count > 0;
        }

        public bool authenticateAdmin(string userName, string password)
        {
            string query = $"SELECT `Username`, `Password` FROM Users WHERE `Password` = '{password}' AND `Username` = '{userName}' AND `Role` = 'Admin'";
            DataTable dataTable = dbContext.ExecuteQuery(query);
            return dataTable.Rows.Count > 0;
        }

        public DataTable authenticateAdminData(string userName, string password)
        {
            string query = $"SELECT `UserId`, `Username`, `Password`, `Email`, `Age`, `Address`, `Role` FROM Users WHERE `Username` = '{userName}' AND `Role` = 'Admin'";
            DataTable dataTable = dbContext.ExecuteQuery(query);
            return dataTable;
        }

        public DataTable authenticateUserData(string userName, string password)
        {
            string query = $"SELECT `UserId`, `Username`, `Password`, `Email`, `Age`, `Address`, `Role` FROM Users WHERE `Username` = '{userName}' AND `Role` = 'User'";
            DataTable dataTable = dbContext.ExecuteQuery(query);
            return dataTable;
        }

        public DataTable getAllUsers(int id)
        {
            string query = $"SELECT `UserId`, `Username`, `Password`, `Email`, `Age`, `Address`, `Role` FROM Users WHERE `UserId` != {id}";
            DataTable dataTable = dbContext.ExecuteQuery(query);
            return dataTable;
        }

        public int updateUser(int userId, string userName, string password, string email, int age, string address, string role)
        {
            string query = $"UPDATE Users SET `Username` = '{userName}', `Password` = '{password}', `Email` = '{email}', `Age` = {age}, `Address` = '{address}', `Role` = '{role}' WHERE `UserId` = {userId}";
            int rowAffected = dbContext.ExecuteNonQuery(query);
            return rowAffected;
        }

        public int deleteUser(int userId)
        {
            // First delete favorites to be sure there are no favorites anymore if you are deleting a account
            string deleteFavoritesQuery = $"DELETE FROM Favorites WHERE `UserId` = {userId}";
            dbContext.ExecuteNonQuery(deleteFavoritesQuery);

            string deleteUserQuery = $"DELETE FROM Users WHERE `UserId` = {userId}";
            int rowsAffected = dbContext.ExecuteNonQuery(deleteUserQuery);

            return rowsAffected;
        }

        public int updateUserProfile(int userId, string userName, string email, int age, string address)
        {
            string query = $"UPDATE Users SET `Username` = '{userName}', `Email` = '{email}', `Age` = {age}, `Address` = '{address}' WHERE `UserId` = {userId}";
            int rowAffected = dbContext.ExecuteNonQuery(query);
            return rowAffected;
        }

        public int UpdateUserPassword(int userId, string userName, string password)
        {
            string query = $"UPDATE Users SET `Username` = '{userName}', `Password` = '{password}' WHERE `UserId` = {userId}";
            int rowAffected = dbContext.ExecuteNonQuery(query);
            return rowAffected;
        }

        public int UpdateUserProfileImage(int userId, byte[] imageData)
        {
            // First check if a record already exists
            string checkQuery = $"SELECT COUNT(*) FROM UserProfileImages WHERE UserId = {userId}";
            DataTable checkResult = dbContext.ExecuteQuery(checkQuery);

            string query;
            if (checkResult.Rows.Count > 0 && Convert.ToInt32(checkResult.Rows[0][0]) > 0)
            {
                query = $"UPDATE UserProfileImages SET ProfileImage = @imageData WHERE UserId = {userId}";
            }
            else
            {
                query = $"INSERT INTO UserProfileImages (UserId, ProfileImage) VALUES ({userId}, @imageData)";
            }

            string base64Image = Convert.ToBase64String(imageData);
            string finalQuery = query.Replace("@imageData", $"'{base64Image}'");
            return dbContext.ExecuteNonQuery(finalQuery);
        }

        public byte[] GetUserProfileImage(int userId)
        {
            string query = $"SELECT ProfileImage FROM UserProfileImages WHERE UserId = {userId}";
            DataTable result = dbContext.ExecuteQuery(query);

            if (result.Rows.Count > 0 && result.Rows[0]["ProfileImage"] != DBNull.Value)
            {
                string base64String = result.Rows[0]["ProfileImage"].ToString();
                return Convert.FromBase64String(base64String);
            }

            return null;
        }
    }
}