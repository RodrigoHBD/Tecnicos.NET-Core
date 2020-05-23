using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.gRPC.Server.Protos;

namespace UserService.App.TypeAdapters
{
    public class ValidateUserBoolRequestAdapter
    {
        public static string Adapt(GrpcValidateUsernameRequest request)
        {
            return request.User;
        }
    }
}
