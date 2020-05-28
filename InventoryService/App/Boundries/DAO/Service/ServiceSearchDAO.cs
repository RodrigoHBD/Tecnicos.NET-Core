using InventoryService.App.Boundries.DAOReturnModels;
using InventoryService.App.Models;
using InventoryService.App.Models.Input;
using InventoryService.App.Models.Output;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryService.App.Boundries
{
    public class ServiceSearchDAO
    {
        private static Collections Collections { get; } = new Collections();

        public static async Task<IServiceList> SerachService(IProductSearchRequest search)
        {
            try
            {
                var filterList = new List<FilterDefinition<Service>>();
                var nameFilter = CreateNameFilter(search.Name);
                var priceFilter = Builders<Service>.Filter.Empty;
                var sellerFilter = CreateSellerFilter(search.Seller);
                var pagination = search.Pagination;

                if (search.Name.Flags.IsActive)
                {
                    filterList.Add(nameFilter);
                }
                if (search.Seller.Flags.IsActive)
                {
                    filterList.Add(sellerFilter);
                }
                if (search.Price.Flags.IsActive)
                {
                    //filterList.Add(priceFilter);
                }

                var filter = CombineFilters(filterList);
                var query = Collections.Services.Find(filter).Skip(pagination.Offset).Limit(pagination.Limit);
                var total = (int) Collections.Services.Count(filter);

                return new ServiceList()
                {
                    Pagination = new Pagination()
                    {
                        Limit = pagination.Limit,
                        Offset = pagination.Offset,
                        Total = total
                    },
                    Services = query.ToList()
                };
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private static FilterDefinition<Service> CreateNameFilter(IStringSearchField name)
        {
            try
            {
                var filter = Builders<Service>.Filter.Empty;

                if (!name.ExactMatch)
                {
                    filter = Builders<Service>.Filter.Where(service => service.Name.Contains(name.Value));
                }
                else
                {
                    filter = Builders<Service>.Filter.Where(service => service.Name == name.Value);
                }
                return filter;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private static FilterDefinition<Service> CreateSellerFilter(IStringSearchField seller)
        {
            try
            {
                var filter = Builders<Service>.Filter.Empty;
                filter = Builders<Service>.Filter.Where(service => service.Seller == seller.Value);
                return filter;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private static FilterDefinition<Service> CombineFilters(List<FilterDefinition<Service>> filters)
        {
            try
            {
                var combined = Builders<Service>.Filter.Empty;
                filters.ForEach(filter => combined = combined & filter);
                return combined;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }

}
