using InventoryService.App.Models;
using InventoryService.App.Models.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryService.App.Factories
{
    public class ItemFactory
    {
        public static Item MakeItem(INewItemRequest request)
        {
            try
            {
                var product = ProductFactory.MakeProduct(request);
                var detais = new List<ItemDetail>();
                var item = new Item()
                {
                    Seller = product.Seller,
                    Name = product.Name,
                    Description = product.Description,
                    Price = product.Price,
                    PicturesUris = product.PicturesUris
                };
                request.Details.ForEach(detail => item.Details.Add(AdaptItemDetail(detail)) );
                return item;
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        private static ItemDetail AdaptItemDetail(IItemDetail detail)
        {
            try
            {
                return new ItemDetail()
                {
                    Name = detail.Name,
                    Value = detail.Value
                };
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
