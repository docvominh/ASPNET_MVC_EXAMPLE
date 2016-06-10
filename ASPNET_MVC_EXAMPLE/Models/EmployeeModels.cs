using MONGO_CONNECT.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNET_MVC_EXAMPLE.Models
{
    public class EmployeeModels
    {
        public ICollection<NttEmployeeDTO> listModel { get; set; }
        public NttEmployeeDTO insertModel { get; set; }
    }
}