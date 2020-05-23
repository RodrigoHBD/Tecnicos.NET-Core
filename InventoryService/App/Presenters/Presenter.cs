using InventoryService.gRPC.Server.Protos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryService.App.Presenters
{
    public class Presenter
    {
        public static GrpcStatusResponse CreateStatusResponse(bool isOk, string message = "")
        {
            return new GrpcStatusResponse()
            {
                Ok = isOk,
                Message = message
            };
        }
    }
}
