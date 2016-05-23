using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace MONGO_CONNECT.Dto
{
    public class NttEmployeeDTO
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }

        public string Name { get; set; }
        public string NameJp { get; set; }
        public DateTime DayOfBirth { get; set; }
        public DateTime JoinDate { get; set; }
        public byte Age { get; set; }
        public bool Gender { get; set; }
        public string Note { get; set; }
        public string ImageURL { get; set; }
        public bool DeleteFlag { get; set; }
    }
}