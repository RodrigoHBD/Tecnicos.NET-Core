using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryService.gRPC.Server.Protos;
using Grpc.Core;
using InventoryService.App.Controllers;
using InventoryService.App.CustomExceptions;

namespace InventoryService.gRPC.Server.Services
{
    public class InventoryServiceImplementation : Inventory.InventoryBase
    {
        public override async Task<GrpcStatusResponse> AddService(GrpcNewServiceRequest request, ServerCallContext call)
        {
            try
            {
                return await Controller.AddServiceToInventory(request);
            }
            catch(CustomException customException)
            {
                throw HandleCustomException(customException);
            }
            catch (Exception e)
            {
                throw HandleException(e);
            }
        }


        //----------------------------------------------------------------
        // Exception Handling --------------------------------------------
        public RpcException HandleCustomException(CustomException exception)
        {
            if (exception.Type == "InvalidInputData")
            {
                return new RpcException(new Status(StatusCode.InvalidArgument, exception.Message));
            }
            else
            {
                return new RpcException(new Status(StatusCode.Unknown, "Erro interno desconhecido."));
            }
        }

        public RpcException HandleException(Exception error)
        {
            Console.WriteLine(error);
            return new RpcException(new Status(StatusCode.Internal, error.Message));
        }
    }
}
