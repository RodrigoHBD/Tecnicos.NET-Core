using InventoryService.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryService.App.Entities.ProductTypes;

namespace InventoryService.App.UseCases
{
    public class ValidateNewService
    {
        public static async Task Execute(Service service)
        {
			try
			{
				await ServiceEntity.ValidateNewService(service);
			}
			catch (Exception e)
			{
				throw e;
			}
        }
    }
}
