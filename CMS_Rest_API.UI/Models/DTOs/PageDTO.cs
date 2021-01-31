using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS_Rest_API.UI.Models.DTOs
{
    public class PageDTO:Profile
    {
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Content { get; set; }
        public int? Sorting { get; set; }
    }
}
