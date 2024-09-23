using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCL_DbFirst.BusinessEntities.Interface
{
    public interface ICustomerRepository
    {
        List<Customer> GetAllCustomerDetails();
        List<Customer> GetCustomerDetailsByID(int id);
        bool AddCustomerDetails(Customer customer);
        bool UpdateCustomerDetails(Customer customer);
        bool DeleteCustomerDetails(int id);
    }
}
