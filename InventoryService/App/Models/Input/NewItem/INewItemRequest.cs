using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryService.App.Models.Input
{
    public interface INewItemRequest : INewProductRequest
    {
        List<IItemDetail> Details { get; }
    }

    public interface IItemDetail
    {
        string Name { get; }
        string Value { get; }
    }
}
