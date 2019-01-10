using System;
using System.Linq;
using System.Data.Entity;
using System.Linq.Expressions;

namespace SchoolPortal.Services.Reusables
{

    /* TODO:   
     *  1. Update by ID
     *  2. Delete by ID
     */

    public class GenericRepository<C, T>
        where C : DbContext
        where T : class
    {
        public readonly C context;

        /// <summary>
        /// Construct the base repository with the given DbContext to use.
        /// </summary>
        /// <param name="_context"> The DbContext to be used. </param>
        public GenericRepository(C _context)
        {
            context = _context as C;
        }

        /// <summary>
        /// Get all the related entities based on the give
        /// </summary>
        /// <returns>Returns an IQueryable of Type (T)."/></returns>
        public virtual IQueryable<T> GetAll()
        {
            return context.Set<T>();
        }

        /// <summary>
        /// Get All related entities based on the given Type (T) with specific conditions.
        /// </summary>
        /// <param name="filters"></param>
        /// <returns></returns>
        /// /// <usage> GetAllProperties(p => p.Property ==/!=/>/< Type) </usage>
        public virtual IQueryable<T> GetAllWithFilters(params Expression<Func<T, bool>>[] filters)
        {
            var query = context.Set<T>() as IQueryable<T>;

            foreach (var item in filters)
                query = query.Where(item);

            return query;
        }

        /// <summary>
        /// Get all the records of the given entity and include the specified related entities with it.
        /// </summary>
        /// <param name="includes"> Navigational Properties related to the entity that is to be selected. </param>
        /// <returns></returns>
        /// <usage> GetAllWithProperties(p => p.RelatedTableOne, p => p.RelatedTableTwo) </usage>
        public virtual IQueryable<T> GetAllWithProperties(params Expression<Func<T, object>>[] includes)
        {
            var query = context.Set<T>() as IQueryable<T>;
            return includes.Aggregate(query,
                                     (current, include) => current.Include(include));
        }

        /// <summary>
        /// Insert an entity based on the Type(T).
        /// </summary>
        /// <param name="entity"> The instance of the entity that is to be inserted. </param>
        public virtual void Insert(T entity)
        {
            context.Set<T>().Add(entity);
        }

        /// <summary>
        /// Updates the entity based on the Type (T).
        /// </summary>
        /// <param name="entity"> The instance of the entity that is to be updated. </param>
        public virtual void Update(T entity)
        {
            context.Entry<T>(entity).State = EntityState.Modified;
        }

        /// <summary>
        /// Deletes the entity based on the Type (T).
        /// </summary>
        /// <param name="id">The instance of the entity that is to be deleted. </param>
        public virtual void Delete(int id)
        {
            var entity = context.Set<T>().Find(id);
            context.Set<T>().Remove(entity);
        }
    }
}