using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Seccion.Data.Infrastructure
{
    public abstract class RepositoryBase<T> where T : class
    {
        #region Properties
        private StoreEntities _dataContext;
        private readonly DbSet<T> _dbSet;
        protected IDbFactory DbFactory
        {
            get;
            private set;
        }
        protected StoreEntities DbContext
        {
            get { return _dataContext ?? (_dataContext = DbFactory.Init()); }
        }
        #endregion

        protected RepositoryBase(IDbFactory dbFactory)
        {
            DbFactory = dbFactory;
            _dbSet = DbContext.Set<T>();
        }

        #region Implementation
        public virtual void Add(T entity)
        {
            try
            {
                _dataContext.ChangeTracker.AutoDetectChangesEnabled = false;
                _dbSet.Add(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _dataContext.ChangeTracker.AutoDetectChangesEnabled = true;
            }

        }
        /// <summary>
        /// Insert entities
        /// </summary>
        /// <param name="entities">Entities</param>
        public virtual void Add(IEnumerable<T> entities)
        {
            try
            {
                if (entities == null)
                    throw new ArgumentNullException(nameof(entities));

                _dataContext.ChangeTracker.AutoDetectChangesEnabled = false;

                _dataContext.Set<T>().AddRange(entities);
                _dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _dataContext.ChangeTracker.AutoDetectChangesEnabled = true;
            }
        }
        public virtual void Update(T entity)
        {
            //_dbSet.Attach(entity);
            //_dataContext.Entry(entity).State = EntityState.Modified;
            var entry = _dataContext.Entry(entity);
            if (entry.State == EntityState.Detached || entry.State == EntityState.Modified)
            {
                _dbSet.Attach(entity); //attach
                entry.State = EntityState.Modified; //do it here
            }
            if (entry.State == EntityState.Unchanged)
            {
                entry.State = EntityState.Detached;
                _dbSet.Attach(entity);
                entry.State = EntityState.Modified;
            }
        }

        /// <summary>
        /// Update entities
        /// </summary>
        /// <param name="entities">Entities</param>
        public virtual void Update(IEnumerable<T> entities)
        {
            try
            {

                if (entities == null)
                    throw new ArgumentNullException(nameof(entities));

                _dataContext.ChangeTracker.AutoDetectChangesEnabled = false;
                //var cont = 0;
                foreach (var entity in entities)
                {
                    //cont++;
                    _dataContext.Entry(entity).State = EntityState.Modified;
                }
                _dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _dataContext.ChangeTracker.AutoDetectChangesEnabled = true;
            }
        }

        public virtual void Delete(T entities)
        {
            try
            {
                
                if (entities == null)
                    throw new ArgumentNullException(nameof(entities));

                _dataContext.ChangeTracker.AutoDetectChangesEnabled = false;
                _dbSet.Remove(entities);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _dataContext.ChangeTracker.AutoDetectChangesEnabled = true;
            }
            
        }

        public virtual void Delete(Expression<Func<T, bool>> where)
        {
            IEnumerable<T> objects = _dbSet.Where(where).AsEnumerable();
            foreach (T obj in objects)
                _dbSet.Remove(obj);
        }

        public virtual T GetById(int id)
        {
            try
            {
                _dataContext.ChangeTracker.AutoDetectChangesEnabled = false;
                return _dbSet.Find(id);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                _dataContext.ChangeTracker.AutoDetectChangesEnabled = true;
            }

        }
        public virtual T GetByUUID(Guid id)
        {
            try
            {
                _dataContext.ChangeTracker.AutoDetectChangesEnabled = false;
                return _dbSet.Find(id);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                _dataContext.ChangeTracker.AutoDetectChangesEnabled = true;
            }

        }

        public virtual IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> where)
        {
            return _dbSet.Where(where).ToList();
        }

        public T Get(Expression<Func<T, bool>> where)
        {
            return _dbSet.Where(where).FirstOrDefault();
        }

        public virtual List<T> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, params Expression<Func<T, object>>[] includes)
        {

            var query = includes.Aggregate<Expression<Func<T, object>>, IQueryable<T>>(_dbSet, (current, include) => current.Include(include));

            if (filter != null)
                query = query.Where(filter);

            if (orderBy != null)
                query = orderBy(query);

            return query.ToList();
        }


        //public virtual DbRawSqlQuery<T> ExecWithStoreProcedure(string query, params object[] parameters)
        //{
        //    return _dataContext.Database.SqlQuery<T>(query, parameters);
        //}
        #endregion
    }
}
