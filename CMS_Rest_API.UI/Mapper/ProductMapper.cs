using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CMS_Rest_API.EntityLayer.Entities.Concrete;
using CMS_Rest_API.UI.Models.DTOs;

namespace CMS_Rest_API.UI.Mapper
{
    public class ProductMapper:Profile
    {        
        public ProductMapper() => CreateMap<Product, ProductDTO>().ReverseMap();

    }
}
