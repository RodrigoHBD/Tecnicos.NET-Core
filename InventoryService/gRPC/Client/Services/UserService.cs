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
		private string Uri { get; } = "0.0.0.0:5000";
		private User.UserClient Client { get; set; }

		public UserService()
		{
			var channel = GrpcChannel.ForAddress(Uri);
			Client =  new User.UserClient(channel);
		}

        public async Task<bool> ValidateUserBoolean(string user)
        {
			try
			{
				var request = GrpcValidateUsernameRequestFactory.MakeRequest(user);
				var response = await Client.ValidateUsernameBoolAsync(request);
				return GrpcValidateUsernameBoolAdapter.Adapt(response);
			}
			catch (Exception e)
			{
				throw e;
			}
        }
    }
}
