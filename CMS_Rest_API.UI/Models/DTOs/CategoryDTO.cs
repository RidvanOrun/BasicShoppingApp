using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS_Rest_API.UI.Models.DTOs
{
    public class CategoryDTO:Profile
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
    }
}
