using AutoMapper;
using HCL_DbFirst.BusinessEntities;
using HCL_DbFirst.BusinessEntities.Interface;
using HCL_DbFirst.BusinessEntities.ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCL_DbFirst.ServiceLayer
{
    public class EmployeeService : IEmployeeServices
    {
        //IEmployeeRepository _employeeRepository;
        //public EmployeeService(IEmployeeRepository employeeRepository)
        //{
        //    this._employeeRepository = employeeRepository;
        //}
        //EmployeeRepository obj= new EmployeeRepository();
        IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;
        public EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            this._employeeRepository = employeeRepository;
            this._mapper = mapper;
        }
        public bool AddEmployeeDetails(EmployeeDTO employeeDTO)
        {
            Employee obj = new Employee();
            //obj.ID = employeeDTO.ID;
            //obj.FirstName = employeeDTO.FirstName;
            //obj.LastName = employeeDTO.LastName;
            //obj.Email = employeeDTO.Email;
            //obj.Phone = employeeDTO.Phone;
            //obj.Address = employeeDTO.Address;
            //obj.Gender = employeeDTO.Gender;
            _mapper.Map(employeeDTO, obj);
            _employeeRepository.AddEmployeeDetails(obj);
            return true;
        }

        public bool DeleteEmployeeDetails(int id)
        {
            _employeeRepository.DeleteEmployeeDetails(id);
            return true;
        }

        public List<EmployeeDTO> GetAllEmployeeDetails()
        {
            List<EmployeeDTO> employeeDTOobj = new List<EmployeeDTO>();

            List<Employee> employees = _employeeRepository.GetAllEmployeeDetails();
            //foreach (Employee employee in employees)
            //{
            //    EmployeeDTO obj = new EmployeeDTO();
            //    obj.ID = employee.ID;
            //    obj.FirstName = employee.FirstName;
            //    obj.LastName = employee.LastName;
            //    obj.Email = employee.Email;
            //    obj.Phone = employee.Phone;
            //    obj.Address = employee.Address;
            //    obj.Gender = employee.Gender;
            //    employeeDTOobj.Add(obj);
            //}
            return _mapper.Map<List<EmployeeDTO>>(employees);
        }

        public List<EmployeeDTO> GetEmployeeDetailsByID(int id)
        {
            List<EmployeeDTO> employeeDTOobj = new List<EmployeeDTO>();

            List<Employee> employees = _employeeRepository.GetEmployeeDetailsByID(id);
            foreach (Employee employee in employees)
            {
                EmployeeDTO obj = new EmployeeDTO();
                obj.ID = employee.ID;
                obj.FirstName = employee.FirstName;
                obj.LastName = employee.LastName;
                obj.Email = employee.Email;
                obj.Phone = employee.Phone;
                obj.Address = employee.Address;
                obj.Gender = employee.Gender;
                employeeDTOobj.Add(obj);
            }
            return employeeDTOobj;
        }

        public bool UpdateEmployeeDetails(EmployeeDTO employeeDTO)
        {
            Employee obj = new Employee();
            obj.ID = employeeDTO.ID;
            obj.FirstName = employeeDTO.FirstName;
            obj.LastName = employeeDTO.LastName;
            obj.Email = employeeDTO.Email;
            obj.Phone = employeeDTO.Phone;
            obj.Address = employeeDTO.Address;
            obj.Gender = employeeDTO.Gender;
            _employeeRepository.UpdateEmployeeDetails(obj);
            return true;
        }
    }
}
