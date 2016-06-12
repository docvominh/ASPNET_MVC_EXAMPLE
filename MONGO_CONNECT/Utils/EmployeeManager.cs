using MONGO_CONNECT.Dto;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;

namespace MONGO_CONNECT.Utils
{
    public class EmployeeManager
    {
        private IMongoCollection<EmployeeDTO> collecion { get; set; }

        public EmployeeManager()
        {
            this.collecion = ConnectDatabase.database.GetCollection<EmployeeDTO>("employee");
        }

        public ICollection<EmployeeDTO> GetEmployeeList()
        {
            ICollection<EmployeeDTO> list = new List<EmployeeDTO>();
            list = this.collecion.Find(x => x.DeleteFlag == false).ToList();

            return list;
        }

        public bool InsertEmployee(EmployeeDTO emp)
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

        private void Insert(EmployeeDTO emp)
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