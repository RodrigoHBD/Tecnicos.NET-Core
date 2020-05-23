using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryService.gRPC.Client.Protos;

namespace InventoryService.App.Boundries.SCI.User
{
    public class GrpcValidateUsernameRequestFactory
    {
        public static GrpcValidateUsernameRequest MakeRequest(string user)
        {
            return new GrpcValidateUsernameRequest()
            {
                User = user
            };
        }
    }
}
