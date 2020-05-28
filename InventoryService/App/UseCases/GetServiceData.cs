using InventoryService.App.Boundries;
using InventoryService.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryService.App.UseCases
{
    public class GetServiceData
    {
        public static async Task<Service> Execute(string id)
        {
            try
            {
                return await ServiceDAO.GetServiceById(id);
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
