using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryService.App.Models;

namespace InventoryService.App.Models.Output
{
    public interface IServiceList
    {
        List<Service> Services { get; }
        Pagination Pagination { get; }
    }
}
