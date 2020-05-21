using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.App.Entities;
using UserService.App.Models.UseCases.Input;
using UserService.App.Boundries;
using UserService.App.Models.Input.SignIn;
using UserService.App.Models.Input;

namespace UserService.App.UseCases
{
    public class UseCaseController
    {
        public static async Task CreateUser(INewUserRequest request)
        {
			try
			{
				NewUserRequestEntity.Validate(request);
				var user = await CreateNewUser.Execute(request);
				await ValidateNewUser.Execute(user);
				await RegisterUser.Execute(user);
				return;
			}
			catch (Exception e)
			{
				throw e;
			}
        }

		public static async Task SignIn(ISignInRequest request)
		{
			try
			{
				await ValidateUsername.Execute(request.Username);
				var user = await GetUserData.Execute(request.Username);
				var passwordMatches = MatchUserPassword.Execute(user, request.Password);

				if (passwordMatches)
				{
					//TODO CREATE A RESPONSE MODEL 		
					return;
				}
				else
				{
					throw new Exception("Senha Inválida!");
				}
			}
			catch (Exception e)
			{
				throw e;
			}
		}

		public static async Task UpdateUserData(IUserUpdateRequest request)
		{
			try
			{
				var update = await CreateUserUpdate.Execute(request);
				await UpdateUser.Execute(update);
				return;
			}
			catch (Exception e)
			{
				throw e;
			}
		}

		public static async Task DeleteUser(string user)
		{
			try
			{
				await ValidateUsername.Execute(user);
				await DeleteUser_.Execute(user);
				return;
			}
			catch (Exception e)
			{
				throw e;
			}
		}
	}
}
