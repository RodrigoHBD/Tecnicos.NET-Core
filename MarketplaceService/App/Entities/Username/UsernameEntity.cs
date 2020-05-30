using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarketplaceService.App.Boundries.SCI.User;

namespace MarketplaceService.App.Entities
{
    public class UsernameEntity
    {
        public static async Task<bool> ValidateUsernameBool(string username)
        {
            try
            {
                return await UserSCI.ValidateUsernameBool(username);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
