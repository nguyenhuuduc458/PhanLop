using DAO.Interface;
using DAO.Repository;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork 
    {
        private readonly TourManagementEntities context = new TourManagementEntities(); 
        public UnitOfWork(TourManagementEntities context)
        {
            Customers = new CustomerRepository(context);
        }

        public ICustomerRepository Customers { get; private set; }

        public int Complete()
        {
            return context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
