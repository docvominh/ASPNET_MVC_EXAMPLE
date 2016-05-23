using MongoDB.Driver;
using System.Configuration;

namespace MONGO_CONNECT
{
    public class ConnectDatabase
    {
        public static IMongoDatabase database { get; set; }

        public static void Init()
        {
            string mongoUri = ConfigurationManager.AppSettings["mongo-uri"];
            string mongoDatabase = ConfigurationManager.AppSettings["mongo-database"];

            System.Diagnostics.Debug.WriteLine(mongoUri + " | " + mongoDatabase);

            var client = new MongoClient(mongoUri);
            database = client.GetDatabase(mongoDatabase);
        }
    }
}