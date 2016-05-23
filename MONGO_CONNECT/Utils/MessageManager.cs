using MONGO_CONNECT.Dto;
using MongoDB.Driver;

namespace MONGO_CONNECT.Utils
{
    public class MessageManager
    {
        private IMongoCollection<MessageDTO> collecion { get; set; }

        public MessageManager()
        {
            this.collecion = ConnectDatabase.database.GetCollection<MessageDTO>("system-message");
        }

        public string GetMessage(string messageName)
        {
            return this.collecion.Find(x => x.name.Equals(messageName)).Single().content;
        }

        public long Count()
        {
            //return this.collecion.Count(new BsonDocument());
            //return this.collecion.Count(new BsonDocument("name", "hello-mongo"));
            return this.collecion.Count(x => x.name != string.Empty);
        }

        public string GetInfo()
        {
            return this.collecion.Indexes.ToString();
        }

        public void Dispose()
        {
            this.Dispose();
        }
    }
}