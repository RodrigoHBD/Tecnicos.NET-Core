using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.App.Models.UseCases.Input;

namespace UserService.App.Models.UseCases.Input
{
    public interface INewUserRequest
    {
        string Username
        {
            get;
        }
        string Password
        {
            get;
        }
    }
}
