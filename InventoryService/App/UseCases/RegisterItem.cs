using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryService.App.Boundries;
using InventoryService.App.Models;

namespace InventoryService.App.UseCases
{
    public class RegisterItem
    {
        public static async Task Execute(Item item)
        {
			try
			{
				await ItemDAO.RegisterItem(item);
			}
			catch (Exception e)
			{
				throw e;
			}
        }
    }
}
