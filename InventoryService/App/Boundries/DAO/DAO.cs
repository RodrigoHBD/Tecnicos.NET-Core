using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryService.App.Models;

namespace InventoryService.App.Boundries
{
    public class DAO
    {
        private static Collections Collections { get; } = new Collections();

        public static async Task RegisterService(Service service)
        {
            try
            {
                await Collections.Services.InsertOneAsync(service);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
