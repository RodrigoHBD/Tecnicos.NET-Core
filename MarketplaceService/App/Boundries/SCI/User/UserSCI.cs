using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketplaceService.App.Boundries.SCI.User
{
    public class UserSCI
    {
        public static async Task<bool> ValidateUsernameBool(string username)
        {
            try
            {
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
