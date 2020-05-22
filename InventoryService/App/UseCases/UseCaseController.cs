using InventoryService.App.Factories;
using InventoryService.App.Models.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryService.App.UseCases
{
    public class UseCaseController
    {
        public static async Task AddProductToUserInventory(INewProductRequest request)
        {
			try
			{
				var product = ProductFactory.MakeProduct(request);
				await RegisterProduct.Execute(product);
				return;
			}
			catch (Exception e)
			{
				throw e;
			}
        }
    }
}
