using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryService.App.Models
{
    public class Product
    {
        public ObjectId Id { get; set; }

        public string Seller { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public float Price { get; set; }

        public List<string> PicturesUris { get; set; }
    }
}
