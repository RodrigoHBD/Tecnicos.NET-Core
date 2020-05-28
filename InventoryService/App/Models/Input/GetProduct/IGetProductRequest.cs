using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryService.App.Models.Input
{
    public interface IGetProductRequest
    {
        string Id { get; }
        string Seller { get; }
        IPagination Pagination { get; }
    }
}
