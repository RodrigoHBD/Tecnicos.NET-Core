using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Net.Client;
using InventoryService.gRPC.Client.Protos;
using InventoryService.App.Boundries.SCI.User;

namespace InventoryService.gRPC.Client.Services
{
    public class UserService
    {
        private string Uri { get; } = "http://localhost:5000";
        private User.UserClient Client { get; set; }

        public UserService()
        {
            AppContext.SetSwitch("System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);
            var channel = GrpcChannel.ForAddress(Uri);
            Client = new User.UserClient(channel);
        }

        public async Task<GrpcBooleanResponse> ValidateUserBoolean(GrpcValidateUsernameRequest request)
        {
            try
            {
                return await Client.ValidateUsernameBoolAsync(request);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
