using InventoryService.App.Boundries.SCI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryService.App.UseCases
{
    public class ValidateUsername
    {
        public static async Task Execute(string user)
        {
			try
			{
				await UserSCI.ValidateUsername(user);
				return;
			}
			catch (Exception e)
			{
				throw e;
			}
        }
    }
}
