using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.ComponentModel.DataAnnotations;

namespace MONGO_CONNECT.Dto
{
    public class NttEmployeeDTO
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Name in Japan")]
        public string NameJp { get; set; }

        [Display(Name = "Day Of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DayOfBirth { get; set; }

        [Display(Name = "Join Date")]

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime JoinDate { get; set; }

        [Display(Name = "Age")]
        public byte Age { get; set; }

        [Display(Name = "Gender")]
        public bool Gender { get; set; }

        [Display(Name = "Note")]
        public string Note { get; set; }

        [Display(Name = "ImageURL")]
        public string ImageURL { get; set; }

        public bool DeleteFlag { get; set; }
    }
}