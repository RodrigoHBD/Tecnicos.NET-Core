using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryService.App.Boundries.SCI.User;
using InventoryService.gRPC.Client.Services;

namespace InventoryService.App.Boundries.SCI
{
    public class UserSCI
    {
        public static async Task<bool> ValidateUsernameBool(string user)
        {
			try
			{
				var request = GrpcValidateUsernameRequestFactory.MakeRequest(user);
				var response = await Services.User.ValidateUserBoolean(request);
				return GrpcValidateUsernameBoolAdapter.Adapt(response);
			}
			catch (Exception e)
			{
				throw e;
			}
        }
    }
}
