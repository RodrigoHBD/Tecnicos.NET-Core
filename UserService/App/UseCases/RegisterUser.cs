using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.App.Boundries;
using UserService.App.Models;

namespace UserService.App.UseCases
{
    public class RegisterUser
    {
        public static async Task Execute(User user)
        {
			try
			{
				await DAO.RegisterUser(user);
			}
			catch (Exception e)
			{
				throw e;
			}
        }
    }
}
