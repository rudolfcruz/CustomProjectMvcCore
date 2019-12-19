using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace Seccion.Data.Infrastructure
{
    public interface IRepository<T> where T : class
    {
        // Marks an entity as new
        void Add(T entity);
        /// <summary>
        /// Insert entities
        /// </summary>
        /// <param name="entities">Entities</param>
        void Add(IEnumerable<T> entities);
        // Marks an entity as modified
        void Update(T entity);
        /// <summary>
        /// Update entities
        /// </summary>
        /// <param name="entities">Entities</param>
        void Update(IEnumerable<T> entities);
        // Marks an entity to be removed
        void Delete(T entity);
        void Delete(Expression<Func<T, bool>> where);

        ///// <summary>
        ///// Delete entities
        ///// </summary>
        ///// <param name="entities">Entities</param>
        ////void Delete(IEnumerable<T> entities);

        // Get an entity by int id
        T GetById(int id);

        T GetByUUID(Guid id);
        // Get an entity using delegate
        T Get(Expression<Func<T, bool>> where);
        // Gets all entities of type T
        IEnumerable<T> GetAll();
        // Gets entities using delegate
        IEnumerable<T> GetMany(Expression<Func<T, bool>> where);

        /// <summary>
        /// Get all entities from db
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="orderBy"></param>
        /// <param name="includes"></param>
        /// <returns></returns>
        List<T> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, params Expression<Func<T, object>>[] includes);

        //DbQuery<T> ExecWithStoreProcedure(string query, params object[] parameters);
        //IQueryable<T> GetPaginated(string filter, int initialPage, int pageSize, out int totalRecords, out int recordsFiltered);

        //void BulkInsert(List<T> data, string tableName);
    }
}
