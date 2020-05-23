using InventoryService.App.Models;
using InventoryService.App.Models.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryService.App.Factories
{
    public class ServiceFactory : ProductFactory
    {
        public static Service MakeService(INewServiceRequest request)
        {
            var product = MakeProduct(request);
            return new Service()
            {
                Seller = product.Seller,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                PicturesUris = product.PicturesUris,
                WarrantyInDays = request.WarrantyInDays
            };
        }
    }
}
