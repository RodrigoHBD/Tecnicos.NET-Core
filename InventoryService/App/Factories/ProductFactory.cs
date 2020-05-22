using InventoryService.App.Models;
using InventoryService.App.Models.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryService.App.Factories
{
    public class ProductFactory
    {
        public static Product MakeProduct(INewProductRequest request)
        {
            return new Product()
            {
                Name = request.Name,
                Description = request.Description,
                Price = request.Price,
                Seller = request.Seller,
                PicturesUris = request.PicturesUris
            };
        }
    }
}
