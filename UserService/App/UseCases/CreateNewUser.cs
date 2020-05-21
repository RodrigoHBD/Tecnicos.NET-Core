using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.App.Models.UseCases.Input;
using UserService.App.Entities;
using UserService.App.Factories;
using UserService.App.Models;

namespace UserService.App.UseCases
{
    public class CreateNewUser
    {
        public static async Task<User> Execute(INewUserRequest request)
        {
            var user = UserFactory.MakeUser(request);
            await UserEntity.Validate(user);
            return user;
        }
    }
}
