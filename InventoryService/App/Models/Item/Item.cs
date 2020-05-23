using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryService.App.Models
{
    public class Item : Product
    {
        public List<ItemDetail> Details { get; set; } 
    }
}
