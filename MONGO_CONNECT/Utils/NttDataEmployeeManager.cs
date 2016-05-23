using MONGO_CONNECT.Dto;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MONGO_CONNECT.Utils
{
    public class NttDataEmployeeManager
    {
        private IMongoCollection<NttEmployeeDTO> collecion { get; set; }

        public NttDataEmployeeManager()
        {
            this.collecion = ConnectDatabase.database.GetCollection<NttEmployeeDTO>("ntt-employee");
        }

        public bool InsertNTTEmployee(NttEmployeeDTO emp)
        {
            long beforeCount = CountActive();
            Insert(emp);
            long afterCount = CountActive();

            if (beforeCount < afterCount)
            {
                return true;
            }

            return false;
        }

        private void Insert(NttEmployeeDTO emp)
        {
            emp.DeleteFlag = false;
            this.collecion.InsertOneAsync(emp);
        }

        private long CountActive()
        {
            return this.collecion.Count(x => x.DeleteFlag == false);
        }

        private long CountInactive()
        {
            return this.collecion.Count(new BsonDocument());
        }
    }
}