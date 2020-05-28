using InventoryService.gRPC.Server.Protos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryService.App.Models.Output;
using Google.Protobuf.Collections;

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

        public static GrpcServiceList PresentServiceList(IServiceList list)
        {
            var grpcServiceList = new GrpcServiceList()
            {
                Pagination = new SearchPagination()
            };

            list.Services.ForEach((service) =>
            {
                var _service = new Service();
                _service.Id = service.Id.ToString();
                _service.Name = service.Name;
                _service.Description = service.Description;
                service.PicturesUris.ForEach(pic => _service.Pictures.Add(pic));
                _service.Price = (double)service.Price;
                _service.Seller = service.Seller;
                _service.WarrantyInDays = service.WarrantyInDays;
                grpcServiceList.Services.Add(_service);
            });
            return grpcServiceList;
        }
    }
}
