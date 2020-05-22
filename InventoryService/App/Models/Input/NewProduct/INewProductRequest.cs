using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryService.App.Models.Input
{
    public interface INewProductRequest
    {
        string Name { get; }

        string Description { get; }

        float Price { get; }

        string Seller { get; }

        List<string> PicturesUris { get; }
    }
}
