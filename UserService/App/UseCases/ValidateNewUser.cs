using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.App.Models;
using UserService.App.Entities;

namespace UserService.App.UseCases
{
    public class ValidateNewUser
    {
        public static async Task Execute(User user)
        {
			try
			{
				await UserEntity.Validate(user);
				return;
			}
			catch (Exception e)
			{
				throw e;
			}
        }
    }
}
