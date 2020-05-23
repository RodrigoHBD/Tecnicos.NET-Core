using InventoryService.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryService.App.Entities.ProductDataFields;

namespace InventoryService.App.Entities
{
    public class ProductEntity
    {
        public static async Task Validate(Product product)
        {
            try
            {
                await ValidateDataFields(product);
                return;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private static async Task ValidateDataFields(Product product)
        {
            try
            {
                await ProductSeller.Validate(product.Seller);
                ProductName.Validate(product.Name);
                ProductPrice.Validate(product.Price);
                return;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
