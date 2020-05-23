using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryService.gRPC.Client.Protos;

namespace InventoryService.App.Boundries.SCI.User
{
    public class GrpcValidateUsernameBoolAdapter
    {
        public static bool Adapt(GrpcBooleanResponse request)
        {
            return request.Boolean;
        }
    }
}
