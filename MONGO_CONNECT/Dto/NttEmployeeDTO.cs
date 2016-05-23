using System;

namespace MONGO_CONNECT.Dto
{
    public class NttEmployeeDTO
    {
        public string Name { get; set; }
        public string NameJp { get; set; }
        public DateTime DayOfBirth { get; set; }
        public byte Age { get; set; }
        public bool Gender { get; set; }
        public string Note { get; set; }
        public bool DeleteFlag { get; set; }
    }
}