﻿using AutoMapper;
using CMS_Rest_API.EntityLayer.Entities.Concrete;
using CMS_Rest_API.UI.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS_Rest_API.UI.Mapper
{
    public class AppUserMapper:Profile
    {
        public AppUserMapper() => CreateMap<AppUser, AppUserDTO>().ReverseMap();
        
    }
}
