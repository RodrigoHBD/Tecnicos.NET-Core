using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.App.Boundries;
using UserService.App.Models;

namespace UserService.App.UseCases
{
    public class UpdateUser
    {
        public static async Task Execute(UserUpdate update)
        {
			try
			{
				await DAO.UpdateUserData(update);
				return;
			}
			catch (Exception e)
			{
				throw e;
			}
        }
    }
}
