using InventoryService.App.Boundries.SCI;
using InventoryService.App.CustomExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryService.App.UseCases
{
    public class ValidateUsernameBool
    {
        public static async Task<bool> Execute(string user)
        {
			try
			{
				return await UserSCI.ValidateUsernameBool(user);
			}
			catch (Exception e)
			{
				throw e;
			}
        }
    }
}
