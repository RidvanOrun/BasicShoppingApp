using CMS_Rest_API.EntityLayer.Entities.Interface;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
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
        
        Task<List<T>> Get(Expression<Func<T, bool>> expression);       
        Task<T> FirstOrDefault(Expression<Func<T, bool>> expression);
        Task<T> FindByDefault(Expression<Func<T, bool>> expression);
        Task<bool> Any(Expression<Func<T, bool>> expression);

      

        Task Save();
    }
}
