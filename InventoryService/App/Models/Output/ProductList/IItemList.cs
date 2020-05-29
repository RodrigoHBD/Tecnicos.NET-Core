using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryService.App.Models.Output
{
    public interface IItemList
    {
        List<Item> Items { get; }
        Pagination Pagination { get; }
    }
}
