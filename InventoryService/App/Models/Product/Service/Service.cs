using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryService.App.Models
{
    public class Service : Product
    {
        public int WarrantyInDays { get; set; }
    }
}
