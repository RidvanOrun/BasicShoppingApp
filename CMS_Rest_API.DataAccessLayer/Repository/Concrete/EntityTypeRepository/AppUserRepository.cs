﻿using CMS_Rest_API.DataAccessLayer.Context;
using CMS_Rest_API.DataAccessLayer.Repository.Concrete.Base;
using CMS_Rest_API.DataAccessLayer.Repository.Interfaces.EntityTypeRepository;
using CMS_Rest_API.EntityLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMS_Rest_API.DataAccessLayer.Repository.Concrete.EntityTypeRepository
{
    public class AppUserRepository:KernelRepository<AppUser>,IAppUserRepository
    {
        public AppUserRepository(ApplicationDbContext applicationDbContext):base (applicationDbContext)
        {}
    }
}
