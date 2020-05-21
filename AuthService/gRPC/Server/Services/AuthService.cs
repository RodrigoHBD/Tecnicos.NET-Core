using AuthService.gRPC.Server.Protos;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthService.gRPC.Server.Services
{
    public class AuthServiceImplementation : Auth.AuthBase
    {
        public RpcException HandleError(Exception error, ServerCallContext call)
        {
            Console.WriteLine(error);
            return new RpcException(new Status(StatusCode.Internal, error.Message));
        }
    }
}
