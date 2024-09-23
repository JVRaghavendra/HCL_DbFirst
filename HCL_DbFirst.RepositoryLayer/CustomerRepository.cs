using HCL_DbFirst.BusinessEntities;
using HCL_DbFirst.BusinessEntities.Interface;
using HCL_DbFirst.DatabaseLogic.DbConnect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCL_DbFirst.RepositoryLayer
{
    public class CustomerRepository : ICustomerRepository
    {
        public Northwind_DBContext _northwind_DBContext;
        public CustomerRepository()
        {
            _northwind_DBContext=new Northwind_DBContext();
        }
        public bool AddCustomerDetails(Customer customer)
        {
            _northwind_DBContext.Customers.Add(customer);
            _northwind_DBContext.SaveChanges();
            return true;
        }

        public bool DeleteCustomerDetails(int id)
        {
            //select * from Employee where eid=id;

            Customer customer = _northwind_DBContext.Customers.SingleOrDefault(c => c.CustomerId ==id.ToString());
            if (customer != null)
            {
                _northwind_DBContext.Customers.Remove(customer);
                _northwind_DBContext.SaveChanges();
                return true;
            }
            else return false;
        }

        public List<Customer> GetAllCustomerDetails()
        {
            // select * from customer
            var customer = _northwind_DBContext.Customers.ToList();
            if (customer.Count == 0)
                return null;
            else return customer;
        }

        public List<Customer> GetCustomerDetailsByID(int id)
        {
            List<Customer> customers = _northwind_DBContext.Customers.ToList().FindAll(c => c.CustomerId == id.ToString());
            if (customers.Count == 0)
                return null;
            else
                return customers;
        }

        public bool UpdateCustomerDetails(Customer customer)
        {
            _northwind_DBContext.Customers.Update(customer);
            _northwind_DBContext.SaveChanges();
            return true;
        }
    }
}
