using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS_Rest_API.UI.Models.DTOs
{
    public class ProductDTO:Profile
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string UnitPrice { get; set; }
    }
}
