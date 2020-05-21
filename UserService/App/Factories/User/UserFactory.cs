using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.App.Models;
using UserService.App.Models.UseCases.Input;

namespace UserService.App.Factories
{
    public class UserFactory
    {
        public static User MakeUser(INewUserRequest request)
        {
            return new User()
            {
                Username = request.Username,
                Password = request.Password
            };
        }
    }
}
