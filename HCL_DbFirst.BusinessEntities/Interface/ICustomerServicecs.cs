using HCL_DbFirst.BusinessEntities.ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCL_DbFirst.BusinessEntities.Interface
{
    public interface ICustomerServicecs
    {
        List<CustomerDTO> GetAllCustomerDetails();
        List<CustomerDTO> GetCustomerDetailsByID(int id);
        bool AddCustomerDetails(CustomerDTO customerDTO);
        bool UpdateCustomerDetails(CustomerDTO customerDTO);
        bool DeleteCustomerDetails(int id);
    }
}
