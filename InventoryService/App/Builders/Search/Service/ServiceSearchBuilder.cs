using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryService.App.Models;

namespace InventoryService.App.Builders
{
    public class ServiceSearchBuilder : ProductSearchBuilder
    {
        public static ServiceSearch BuildServiceSearch()
        {
            return new ServiceSearch() 
            {

            };
        }
    }
}
