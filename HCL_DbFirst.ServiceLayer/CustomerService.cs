using HCL_DbFirst.BusinessEntities.Interface;
using HCL_DbFirst.BusinessEntities.ModelsDTO;
using HCL_DbFirst.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HCL_DbFirst.ServiceLayer
{
    public class CustomerService : ICustomerServicecs
    {
        ICustomerRepository _repository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            _repository = customerRepository;
        }

        public bool AddCustomerDetails(CustomerDTO customerDTO)
        {
            Customer customerobj = new Customer();
            customerobj.CustomerId = customerDTO.CustomerId;
            customerobj.CompanyName = customerDTO.CompanyName;
            customerobj.ContactName = customerDTO.ContactName;
            customerobj.PostalCode = customerDTO.PostalCode;
            customerobj.Country = customerDTO.Country;
            customerobj.Phone = customerDTO.Phone;
            customerobj.Region = customerDTO.Region;
            customerobj.Fax = customerDTO.Fax;
            customerobj.ContactTitle = customerDTO.ContactTitle;
            customerobj.Address = customerDTO.Address;
            _repository.AddCustomerDetails(customerobj);
            return true;
        }

        public bool DeleteCustomerDetails(int id)
        {
            _repository.DeleteCustomerDetails(id);
            return true;
        }

        public List<CustomerDTO> GetAllCustomerDetails()
        {
            List<CustomerDTO> customerDTOobj = new List<CustomerDTO>();

            List<Customer> customer = _repository.GetAllCustomerDetails();
            foreach (Customer customerDTO in customer)
            {
                CustomerDTO customerobj = new CustomerDTO();
                customerobj.CustomerId = customerDTO.CustomerId;
                customerobj.CompanyName = customerDTO.CompanyName;
                customerobj.ContactName = customerDTO.ContactName;
                customerobj.PostalCode = customerDTO.PostalCode;
                customerobj.Country = customerDTO.Country;
                customerobj.Phone = customerDTO.Phone;
                customerobj.Region = customerDTO.Region;
                customerobj.Fax = customerDTO.Fax;
                customerobj.ContactTitle = customerDTO.ContactTitle;
                customerobj.Address = customerDTO.Address;
                customerDTOobj.Add(customerobj);
            }
            return customerDTOobj;
        }

        public List<CustomerDTO> GetCustomerDetailsByID(int id)
        {
            List<CustomerDTO> customerDTOobj = new List<CustomerDTO>();

            List<Customer> customers = _repository.GetCustomerDetailsByID(id);
            foreach (Customer customerDTO in customers)
            {
                CustomerDTO customerobj = new CustomerDTO();
                customerobj.CustomerId = customerDTO.CustomerId;
                customerobj.CompanyName = customerDTO.CompanyName;
                customerobj.ContactName = customerDTO.ContactName;
                customerobj.PostalCode = customerDTO.PostalCode;
                customerobj.Country = customerDTO.Country;
                customerobj.Phone = customerDTO.Phone;
                customerobj.Region = customerDTO.Region;
                customerobj.Fax = customerDTO.Fax;
                customerobj.ContactTitle = customerDTO.ContactTitle;
                customerobj.Address = customerDTO.Address;
                customerDTOobj.Add(customerobj);
            }
            return customerDTOobj;
        }

        public bool UpdateCustomerDetails(CustomerDTO customerDTO)
        {
            Customer customerobj = new Customer();
            customerobj.CustomerId = customerDTO.CustomerId;
            customerobj.CompanyName = customerDTO.CompanyName;
            customerobj.ContactName = customerDTO.ContactName;
            customerobj.PostalCode = customerDTO.PostalCode;
            customerobj.Country = customerDTO.Country;
            customerobj.Phone = customerDTO.Phone;
            customerobj.Region = customerDTO.Region;
            customerobj.Fax = customerDTO.Fax;
            customerobj.ContactTitle = customerDTO.ContactTitle;
            customerobj.Address = customerDTO.Address;
            _repository.UpdateCustomerDetails(customerobj);
            return true;
        }
    }
}
