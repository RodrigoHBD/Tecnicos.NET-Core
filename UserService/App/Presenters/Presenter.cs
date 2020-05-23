using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.gRPC.Server.Protos;

namespace UserService.App.Presenters
{
    public class Presenter
    {
        public static GrpcStatusResponse OkStatusResponse()
        {
            return new GrpcStatusResponse()
            {
                Ok = true
            };
        }

        public static GrpcBooleanResponse BooleanResponse(bool boolean)
        {
            return new GrpcBooleanResponse()
            {
                Boolean = boolean
            };
        }
    }
}
