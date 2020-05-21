using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.App.Entities;
using UserService.App.Factories;
using UserService.App.Models;
using UserService.App.Models.Input;

namespace UserService.App.UseCases
{
    public class CreateUserUpdate
    {
        public static async Task<UserUpdate> Execute(IUserUpdateRequest request)
        {
			try
			{
				var update = UserUpdateFactory.MakeUserUpdate(request);
				await UserEntity.ValidateUpdate(update);
				return update;
			}
			catch (Exception e)
			{
				throw e;
			}
        }
    }
}
