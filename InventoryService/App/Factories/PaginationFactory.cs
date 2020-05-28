using InventoryService.App.Models;
using InventoryService.App.Models.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryService.App.Factories
{
    public class PaginationFactory
    {
        public static Pagination MakePagination(IPagination pagination)
        {
            return new Pagination()
            {
                Offset = pagination.Offset,
                Limit = pagination.Limit
            };
        }
    }
}
