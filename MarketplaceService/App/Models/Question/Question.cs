using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketplaceService.App.Models.Question
{
    public class Question
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string Text { get; set; }
        public string Asker { get; set; }
        public DateTime AskedAt { get; set; }
    }
}
