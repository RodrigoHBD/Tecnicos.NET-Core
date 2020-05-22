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
                await ProductUser.Validate(product.Seller);
                return;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
