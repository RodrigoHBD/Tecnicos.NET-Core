using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.App.Models.Input.SignIn;
using UserService.gRPC.Server.Protos;

namespace UserService.App.TypeAdapters
{
    public class SignInRequestAdapter
    {
        public static ISignInRequest Adapt(GrpcSignInRequest request)
        {
            return new SignInRequest()
            {
                Username = request.User,
                Password = request.Password
            };
        }

    }

    public class SignInRequest : ISignInRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
