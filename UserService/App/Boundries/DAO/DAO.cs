using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.App.Models;

namespace UserService.App.Boundries
{
    public class DAO
    {
        private static Collections Collections { get; } = new Collections();

        public static async Task RegisterUser(User user)
        {
            try
            {
                await Collections.User.InsertOneAsync(user);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static async Task<User> GetUserData(string user)
        {
            try
            {
                var filter = Builders<User>.Filter.Eq("Username", user);
                var data = (await Collections.User.FindAsync(filter)).First();
                return data;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static async Task<bool> CheckIfUserExist(string user)
        {
            try
            {
                var filter = Builders<User>.Filter.Eq("Username", user);
                var documents = (await Collections.User.FindAsync(filter)).ToList();
                var count = documents.Count();
                var usernameExist = !count.Equals(0);
                return usernameExist;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static async Task DeleteUser(string user)
        {
            try
            {
                

                return;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static async Task UpdateUserData(UserUpdate update)
        {
            try
            {
                if (update.MustUpdate.Password)
                {
                    await UpdateUserPassword(update.Username, update.Password);
                }

                return;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private static async Task UpdateUserPassword(string user, string newPassword)
        {
            try
            {
                var filter = Builders<User>.Filter.Eq("Username", user);
                var update = Builders<User>.Update.Set("Password", newPassword);
                await Collections.User.UpdateOneAsync(filter, update);
                return;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
