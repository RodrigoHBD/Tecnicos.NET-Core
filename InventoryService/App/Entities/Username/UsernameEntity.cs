using InventoryService.App.Boundries.SCI;
using InventoryService.App.CustomExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryService.App.Entities
{
    public class UsernameEntity
    {
        public static async Task<bool> ValidateUsernameBool(string user)
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

		public static async Task ValidateUsername(string username)
		{
			try
			{
				var isValid = await UserSCI.ValidateUsernameBool(username);

				if (!isValid)
				{
					throw new ValidationException("Username", "Esse nome de usuario nao existe");
				}
			}
			catch (Exception e)
			{
				throw e;
			}
		}
    }
}
