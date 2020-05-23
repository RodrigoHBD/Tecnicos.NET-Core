using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryService.App.Models;
using InventoryService.App.Boundries;

namespace InventoryService.App.UseCases
{
    public class RegisterService
    {
        public static async Task Execute(Service service)
        {
            try
            {
                await DAO.RegisterService(service);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
