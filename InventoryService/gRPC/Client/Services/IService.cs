using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Net.Client;

namespace InventoryService.gRPC.Client.Services
{
    interface IService
    {
        string Uri { get; }

    }
}
