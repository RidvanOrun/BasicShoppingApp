using CMS_Rest_API.DataAccessLayer.Repository.Interfaces.Base;
using CMS_Rest_API.EntityLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMS_Rest_API.DataAccessLayer.Repository.Interfaces.EntityTypeRepository
{
    public interface ICategoryRepository:IKernelRepository<Category>
    {
    }
}
