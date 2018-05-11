using eCom.Contract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using eCom.DAL;
using eCom.DAL.Data;
using System.Data.Entity;
using System.Linq;

//using eCom.Contract;
namespace eCom.DAL.Repo
{
   public abstract class RepositoryBase<TEntity>  where TEntity : class
    {
        internal DataContext _dbContext;
        internal DbSet<TEntity> dbset;

        public RepositoryBase(DataContext _context)
        {
            this._dbContext = _context;
            this.dbset = _context.Set<TEntity>();
        }

        public IQueryable<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>().AsNoTracking();
        }

        public virtual TEntity GetById(int id)
        {
            return dbset.Find(id);
            //return await _dbContext.Set<TEntity>().Find(id); //  dbset.Find(id);
            //return await _dbContext.Set<TEntity>()
            //    .AsNoTracking()
            //    .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task Create(TEntity entity)
        {
            //await _dbContext.Set<TEntity>().AddAsync(entity);
             _dbContext.Set<TEntity>().Add(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Update(int id, TEntity entity)
        {
            //_dbContext.Set<TEntity>().Update(entity);
            _dbContext.Set<TEntity>().Attach(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity = await _dbContext.Set<TEntity>().FindAsync(id);
            _dbContext.Set<TEntity>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}
