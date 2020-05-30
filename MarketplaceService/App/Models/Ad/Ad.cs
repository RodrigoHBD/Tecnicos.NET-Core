using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketplaceService.App.Models
{
    public class Ad
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Owner { get; set; }
        public decimal Price { get; set; }
        public List<Discount> Discounts { get; set; }
        public string ProductId { get; set; }
        public string Category { get; set; }
        public ShippingOption Shipping { get; set; }
    }
}
