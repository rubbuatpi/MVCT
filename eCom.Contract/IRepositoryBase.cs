using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace eCom.Contract
{
    public interface IRepositoryBase<TEntity> where TEntity : class 
    {
        IQueryable<TEntity> GetAll();

        Task<TEntity> GetbyId(Int32 _id);

        Task Create(TEntity entity);

        Task Update(Int32 _id,  TEntity _entity);
        Task Delete(Int32 _id, TEntity _entity);
    }
}
