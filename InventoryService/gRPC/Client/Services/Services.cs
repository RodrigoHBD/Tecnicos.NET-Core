using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryService.gRPC.Client.Services
{
    public class Services
    {
        public static UserService User { get; } = new UserService();
    }
}
