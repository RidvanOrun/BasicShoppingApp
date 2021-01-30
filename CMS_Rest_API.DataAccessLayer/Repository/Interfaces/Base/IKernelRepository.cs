using CMS_Rest_API.EntityLayer.Entities.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CMS_Rest_API.DataAccessLayer.Repository.Interfaces.Base
{
    public interface IKernelRepository<T> where T: class, IBaseEntity
    {
        Task Add(T entity);
        Task Update(T entity);
        Task Delete(T entity);

        Task<List<T>> GetAll();

        Task<T> GetById(int Id);
    }
}
