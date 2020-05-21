using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.App.Models;

namespace UserService
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
            User = Connection.GetCollection<User>("Users");
        }

        public IMongoCollection<User> User { get; set; }
    }
}
