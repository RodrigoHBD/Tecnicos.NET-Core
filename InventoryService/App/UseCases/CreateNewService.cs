using InventoryService.App.Factories;
using InventoryService.App.Models;
using InventoryService.App.Models.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryService.App.UseCases
{
    public class CreateNewService
    {
        public static Service Execute(INewServiceRequest request)
        {
            try
            {
                return ServiceFactory.MakeService(request);
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
