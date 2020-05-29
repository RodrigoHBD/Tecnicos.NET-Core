using InventoryService.App.Models;
using InventoryService.App.Models.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryService.App.Boundries.DAOReturnModels
{
    public class ItemList : IItemList
    {
        public List<Item> Items { get; set; }

        public Pagination Pagination { get; set; }
    }
}
