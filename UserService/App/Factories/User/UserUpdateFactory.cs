using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.App.Models;
using UserService.App.Models.Input;

namespace UserService.App.Factories
{
    public class UserUpdateFactory
    {
        public static UserUpdate MakeUserUpdate(IUserUpdateRequest request)
        {
            return new UserUpdate()
            {
                Username = request.Username,
                Password = request.Password
            };
        }
    }
}
