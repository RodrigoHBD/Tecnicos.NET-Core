using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryService.App.Models;

namespace InventoryService.App.Models.Output
{
    public interface IServiceSearchResult
    {
        Pagination Pagination { get; }
        List<Service> Results { get; }
    }
}
