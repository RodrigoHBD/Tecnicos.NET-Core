using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketplaceService.App.Models
{
    public class Discount
    {
        public string Name { get; set; }
        public decimal Percentage { get; set; }
        public bool IsActive { get; set; }
    }
}
