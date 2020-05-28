using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryService.App.Models.Input
{
    public interface IPagination
    {
        int Offset { get; }
        int Limit { get; }
        int Total { get; }
    }
}
