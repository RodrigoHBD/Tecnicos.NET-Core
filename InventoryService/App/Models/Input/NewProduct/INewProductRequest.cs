using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryService.App.Models.Input
{
    public interface INewProductRequest
    {
        string Seller { get; }
        string Name { get; }
        string Description { get; }
        decimal Price { get; }
        List<string> PicturesUris { get; }
    }
}
