using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryService.App.Models;
using InventoryService.App.Models.Output;

namespace InventoryService.App.Boundries.DAOReturnModels
{
    public class ServiceList : IServiceList
    {
        public Pagination Pagination { get; set; }
        public List<Service> Services { get; set; }
    }
}
