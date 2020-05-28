using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryService.gRPC.Server.Protos;
using InventoryService.App.TypeAdapters;
using InventoryService.App.UseCases;
using InventoryService.App.Presenters;

namespace InventoryService.App.Controllers
{
    public class Controller
    {
        public static async Task<GrpcStatusResponse> AddServiceToInventory(GrpcNewServiceRequest grpcRequest)
        {
            try
            {
                var request = NewServiceRequestAdapter.Adapt(grpcRequest);
                await UseCaseController.AddServiceToUserInventory(request);
                return Presenter.CreateStatusResponse(true);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public static async Task<GrpcServiceList> SearchService(GrpcServiceSearchRequest grpcRequest)
        {
            try
            {
                var request = ServiceSearchRequestAdapter.Adapt(grpcRequest);
                var response = await UseCaseController.SearchServicesWithFilters(request);
                return Presenter.PresentServiceList(response);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
