using BUS.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Linq.Expressions;
using DAO.UnitOfWork;

namespace BUS.Services
{
    public class CustomerServices : ICustomerServices
    {
        private readonly UnitOfWork unitOfWork;

        public CustomerServices(UnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void Delete(Customer entity)
        {
            unitOfWork.Customers.Delete(entity);
        }

        public void DeleteRange(IEnumerable<Customer> entities)
        {
            unitOfWork.Customers.DeleteRange(entities);
        }

        public IEnumerable<Customer> Find(Expression<Func<Customer, bool>> predicate)
        {
            return unitOfWork.Customers.Find(predicate);
        }

        public IEnumerable<Customer> GetAll()
        {
            return unitOfWork.Customers.getAll();
        }

        public Customer GetById(int id)
        {
            return unitOfWork.Customers.GetById(id);
        }

        public IEnumerable<Customer> getCustomers()
        {
            return unitOfWork.Customers.GetAll();
        }

        public void Insert(Customer entity)
        {
            unitOfWork.Customers.Insert(entity);
        }

        public void InsertRange(IEnumerable<Customer> entities)
        {
            unitOfWork.Customers.InsertRange(entities);
        }

        public void Update(Customer entity)
        {
            unitOfWork.Customers.Update(entity);
        }

    }
}
