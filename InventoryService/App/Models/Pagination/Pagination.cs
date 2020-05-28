using InventoryService.App.Models.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryService.App.Models
{
    public class Pagination : IPagination
    {
        public int Offset { get; set; }
        public int Limit { get; set; }
        public int Total { get; set; }
    }
}
