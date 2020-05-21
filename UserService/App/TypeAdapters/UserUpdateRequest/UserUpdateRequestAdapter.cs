using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.App.Models.Input;
using UserService.gRPC.Server.Protos;

namespace UserService.App.TypeAdapters.UserUpdateRequest
{
    public class UserUpdateRequestAdapter
    {
        public static IUserUpdateRequest Adapt(GrpcUserUpdateRequest request)
        {
            return new UpdateUserRequest()
            {
                Username = request.User,
                Password = request.Password
            };
        }
    }

    public class UpdateUserRequest : IUserUpdateRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
