using HCL_DbFirst.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCL_DbFirst.BusinessEntities.Interface
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAllEmployeeDetails();
        List<Employee> GetEmployeeDetailsByID(int id);
        bool AddEmployeeDetails(Employee employee);
        bool UpdateEmployeeDetails(Employee employee);
        bool DeleteEmployeeDetails(int id);
    }
}
