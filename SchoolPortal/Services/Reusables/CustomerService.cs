using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Vidly.Models;
using System.Data.Entity;
using System.Linq.Expressions;

namespace Vidly.ModelRepository
{
    public class CustomerService : GenericRepository<ApplicationDbContext, Customer>
    {
        public CustomerService(ApplicationDbContext _context) : base(_context)
        { } 

        public IQueryable<Customer> GetAllWithProperties()
        {
            return GetAllWithProperties(c => c.MembershipType);
        }

        public IQueryable<Customer> GetAllWithSpecializedQuery()
        {
            return base.context.Set<Customer>().SqlQuery("SELECT Name FROM Customers") as IQueryable<Customer>;
        }
    }
}