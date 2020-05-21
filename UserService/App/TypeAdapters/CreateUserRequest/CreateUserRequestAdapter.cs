using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.App.Models.UseCases.Input;
using UserService.gRPC.Server.Protos;

namespace UserService.App.TypeAdapters
{
    public class CreateUserRequestAdapter
    {
        public static INewUserRequest Adapt(GrpcCreateUserRequest request)
        {
            return new NewUserRequest()
            {
                Username = request.User,
                Password = request.Password
            };
        }
    }

    public class NewUserRequest : INewUserRequest
    {
        public string Username { get; set; }

        public string Password { get; set; }
    }
}
