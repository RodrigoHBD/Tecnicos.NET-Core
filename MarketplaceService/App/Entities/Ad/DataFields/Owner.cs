using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketplaceService.App.Entities.AdDataFields
{
    public class Owner
    {
        public static async Task Validate(string username)
        {
            try
            {
                var isValid = await UsernameEntity.ValidateUsernameBool(username);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
