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

        public Collections()
        {
            Services = Connection.GetCollection<Service>("Services");
        }

        public IMongoCollection<Service> Services { get; set; }
    }
}
