using InventoryService.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using InventoryService.App.Models.Output;
using InventoryService.App.Boundries.DAOReturnModels;
using InventoryService.App.Models.Input;

namespace InventoryService.App.Boundries
{
    public class ServiceDAO
    {
        public static async Task RegisterService(Service service)
        {
            try
            {
                await Collections.Services.InsertOneAsync(service);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static async Task<Service> GetServiceById(string id)
        {
            try
            {
                var filter = Builders<Service>.Filter.Where(service => service.Id == ObjectId.Parse(id));
                var query = await Collections.Services.FindAsync(filter);
                return query.First();
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public static async Task<bool> CheckIfServiceExist(string id)
        {
            try
            {
                var filter = Builders<Service>.Filter.Eq("_id", ObjectId.Parse(id));
                var result = await Collections.Services.CountDocumentsAsync(filter);
                var serviceExist = result > 0;

                if (serviceExist)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static async Task<IServiceList> GetUserServices(string user, IPagination pagination)
        {
            try
            {
                var filter = Builders<Service>.Filter.Eq("Seller", user);
                var query = await Collections.Services.FindAsync(filter);
                var total = await Collections.Services.CountDocumentsAsync(filter);

                return new ServiceList()
                {
                    Services = query.ToList(),
                    Pagination = new Pagination()
                    {
                        Limit = pagination.Limit,
                        Offset = pagination.Offset,
                        Total = (int) total
                    }
                };
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
