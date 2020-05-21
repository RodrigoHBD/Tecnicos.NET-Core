using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.App.Models;
using UserService.App.Entities.UserDataFields;
using UserService.App.UseCases;
using UserService.App.Boundries;

namespace UserService.App.Entities
{
    public class UserEntity
    {
        public static async Task Validate(User user)
        {
			try
			{
				await UsernameEntity.ValidateNew(user.Username);
				PasswordEntity.Validate(user.Password);
				return;
			}
			catch (Exception e)
			{
				throw e;
			}
        }

		public static async Task ValidateUpdate(UserUpdate update)
		{
			try
			{
				await UsernameEntity.ValidateExistent(update.Username);

				if(update.MustUpdate.Password)
				{
					PasswordEntity.Validate(update.Password);
				}
				return;
			}
			catch (Exception e)
			{
				throw e;
			}
		}
    }
}
