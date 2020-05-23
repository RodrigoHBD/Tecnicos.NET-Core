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
        public static async Task AddServiceToUserInventory(INewServiceRequest request)
        {
			try
			{
				var service = CreateNewService.Execute(request);
				await ValidateNewService.Execute(service);
				await RegisterService.Execute(service);
			}
			catch (Exception e)
			{
				throw e;
			}
        }
    }
}
