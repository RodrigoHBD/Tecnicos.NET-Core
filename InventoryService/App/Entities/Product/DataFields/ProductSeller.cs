using InventoryService.App.UseCases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryService.App.Entities.ProductDataFields
{
    public class ProductSeller
    {
        public static async Task Validate(string user)
        {
            try
            {
                await ValidateUsername.Execute(user);
                return;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
