using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace UserService
{
    public class DB
    {
        private static string ConnectionString { get; } = "mongodb+srv://System:7PLqagSG9u79yHX@cluster0-siia7.gcp.mongodb.net/test?retryWrites=true&w=majority";

        private static string DatabaseName { get; } = "UserService";

        public static IMongoDatabase Connection { get; private set; }

        public static async Task Connect()
        {
            try
            {
                var client = new MongoClient(ConnectionString);
                Connection = client.GetDatabase(DatabaseName);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}