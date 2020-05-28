using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryService.App.Models.Input;
using InventoryService.gRPC.Server.Protos;

namespace InventoryService.App.TypeAdapters
{
    public class ServiceSearchRequestAdapter 
    {
        public static IServiceSearchRequest Adapt(GrpcServiceSearchRequest request)
        {
            try
            {
                var product = request.ProductData;
                var name = new StringSearchField()
                {
                    Value = product.Name.Value,
                    ExactMatch = product.Name.Falgs.ExactMatch
                };
                var seller = new StringSearchField()
                {
                    Value = product.Seller.Value,
                    ExactMatch = product.Seller.Falgs.ExactMatch
                };
                var price = new DecimalSearchField()
                {
                    Value = (decimal) product.Price,
                    Operator = NumberOperator.Equals
                };
                var pagination = new SearchPagination()
                {
                    Limit = product.Pagination.Limit,
                    Offset = product.Pagination.Offset
                };

                return new ServiceSearchRequest()
                {
                    Name = name,
                    Seller = seller,
                    Price = price,
                    Pagination = pagination
                };
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }

    public class ServiceSearchRequest : ProductSearchRequest, IServiceSearchRequest
    {

    }
}
