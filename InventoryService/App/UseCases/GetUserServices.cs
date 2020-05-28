using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryService.App.Models;
using InventoryService.App.Models.Input;
using InventoryService.App.Factories;
using InventoryService.App.Boundries;
using InventoryService.App.Models.Output;

namespace InventoryService.App.UseCases
{
    public class GetUserServices
    {
        public static async Task<IServiceList> Execute(IGetProductRequest request)
        {
            try
            {
                var pagination = PaginationFactory.MakePagination(request.Pagination);
                var user = request.Seller;
                return await ServiceDAO.GetUserServices(request.Seller, request.Pagination);
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
