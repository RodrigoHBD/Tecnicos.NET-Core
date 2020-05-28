using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryService.App.Models.Input;
using InventoryService.App.Models.Output;
using InventoryService.App.Builders;
using InventoryService.App.Boundries;

namespace InventoryService.App.UseCases
{
    public class SearchService
    {
        public static async Task<IServiceList> Execute(IServiceSearchRequest request)
        {
            try
            {
                return await ServiceSearchDAO.SerachService(request);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
