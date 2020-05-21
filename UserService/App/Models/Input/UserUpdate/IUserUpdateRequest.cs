using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserService.App.Models.Input
{
    public interface IUserUpdateRequest
    {
        string Username { get; }
        string Password { get; }
    }
}
