using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryService.App.Models;

namespace InventoryService
{
    public class Collections
    {
        private static IMongoDatabase Connection
        {
            get
            {
                return DB.Connection;
            }
        }

        public static async Task Initialize()
        {
            try
            {
                Services = Connection.GetCollection<Service>("Services");
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public static IMongoCollection<Service> Services { get; set; }
    }
}
