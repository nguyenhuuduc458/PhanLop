using DAO.Interface;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Repository
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(TourManagementEntities context) : base(context) { }
        public TourManagementEntities context
        {
            get { return Context as TourManagementEntities; }
        }

        public IEnumerable<Customer> getAll()
        {
            var customers = from n in context.Customers
                            select n;
            return customers.ToList();
        }
    }
}
