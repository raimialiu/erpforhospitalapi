using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicloud.emr.api.DataContextRepo
{
    public interface IDataContextRepo<T>
    {
       // bool SaveChanges();
        bool AddNew(T entity);
        bool Update(T entity);
        T GetSingle(Func<T, bool> filter);
        IQueryable<T> GetAll(Func<T, bool> filter);
        IEnumerable<T> GetAll();
        bool Delete(Func<T, bool> filters);
        bool Delete(T entity);
        IQueryable<T> ExecuteRawSql(string query);
        void CloseConnection();
    }

    public class DataContextRepo<T> : IDataContextRepo<T> where T : class
    {
        private DbSet<T> dbSet;
        private Data.DataContext _dbContext;
        public DataContextRepo()
        {
            _dbContext = new Data.DataContext();
            dbSet = _dbContext.Set<T>();
        }
        public bool AddNew(T entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Func<T, bool> filters)
        {
            throw new NotImplementedException();
        }

        public bool Delete(T entity)
        {
            dbSet.Remove(entity);
            return SaveChanges();
        }

        public IQueryable<T> GetAll(Func<T, bool> filter)
        {
            return dbSet.Where(filter).AsQueryable<T>();
        }

        public IEnumerable<T> GetAll()
        {
            
            return dbSet.AsEnumerable<T>();
        }

        public T GetSingle(Func<T, bool> filter)
        {
            return dbSet.FirstOrDefault(filter);
        }

        private bool SaveChanges()
        {
            return _dbContext.SaveChanges() > 0;
        }

        public bool Update(T entity)
        {
            dbSet.Update(entity);
            return SaveChanges();
        }

        public IQueryable<T> ExecuteRawSql(string query)
        {
            
            return dbSet.FromSqlRaw(query);
        }

        public void CloseConnection()
        {
            _dbContext.Database.CloseConnection();
        }
    }
}
