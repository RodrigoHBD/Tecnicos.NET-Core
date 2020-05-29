using InventoryService.App.Boundries.DAOReturnModels;
using InventoryService.App.Models;
using InventoryService.App.Models.Input;
using InventoryService.App.Models.Output;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryService.App.Boundries
{
    public class ItemDAO
    {
        public static async Task RegisterItem(Item item)
        {
			try
			{
				await Collections.Items.InsertOneAsync(item);
			}
			catch (Exception e)
			{
				throw e;
			}
        }

        public static async Task<Item> GetItemById(string id)
        {
            try
            {
                var filter = Builders<Item>.Filter.Where(item => item.Id == ObjectId.Parse(id));
                var query = await Collections.Items.FindAsync(filter);
                return query.First();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static async Task<bool> CheckIfItemExist(string id)
        {
            try
            {
                var filter = Builders<Item>.Filter.Eq("_id", ObjectId.Parse(id));
                var result = await Collections.Items.CountDocumentsAsync(filter);
                var ItemExists = result > 0;

                if (ItemExists)
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

        public static async Task<IItemList> GetUserItems(string user, IPagination pagination)
        {
            try
            {
                var filter = Builders<Item>.Filter.Eq("Seller", user);
                var query = Collections.Items.Find(filter).Limit(pagination.Limit).Skip(pagination.Offset);
                var total = await Collections.Items.CountDocumentsAsync(filter);

                return new ItemList()
                {
                    Items = query.ToList(),
                    Pagination = new Pagination()
                    {
                        Limit = pagination.Limit,
                        Offset = pagination.Offset,
                        Total = (int)total
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
