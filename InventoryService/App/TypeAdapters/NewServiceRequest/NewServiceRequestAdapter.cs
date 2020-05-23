using InventoryService.App.Models.Input;
using InventoryService.gRPC.Server.Protos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryService.App.TypeAdapters
{
    public class NewServiceRequestAdapter
    {
        public static INewServiceRequest Adapt(GrpcNewServiceRequest request)
        {
            return new NewServiceRequest()
            {
                Seller = request.ProductData.Seller,
                Name = request.ProductData.Name,
                Description = request.ProductData.Description,
                Price = request.ProductData.Price,
                PicturesUris = request.ProductData.PicturesUris.ToList(),
                WarrantyInDays = request.WarrantyInDays
            };
        }
    }

    public class NewServiceRequest : INewServiceRequest
    {
        public int WarrantyInDays { get; set; }

        public string Seller { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public float Price { get; set; }

        public List<string> PicturesUris { get; set; }
    }
}
