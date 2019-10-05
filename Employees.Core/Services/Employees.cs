using AutoMapper;
using Employees.Core.Interfaces;
using Employees.Infraestructure.Entities;
using Employees.Infraestructure.Enum;
using Employees.Infraestructure.Interfaces;
using Employees.Share.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employees.Core.Services
{
    public class Employees : IEmployees
    {
        private readonly IEmployeesRepository _employees;
        private readonly IMapper _mapper;

        public Employees(IEmployeesRepository employees, IMapper mapper)
        {
            _employees = employees;
            _mapper = mapper;
        }

        public async Task<IEnumerable<EmployeeDto>> GetEmployees(int id)
        {
            IEnumerable<Employee> employees = await _employees.GetEmployees();
            List<EmployeeDto> resp = new List<EmployeeDto>();


            if (id == -1)
            {
                foreach (Employee e in employees)
                {
                    EmployeeDto empAux = _mapper.Map<EmployeeDto>(e);
                    empAux.AnualSalary = CalculateAnualSalary(empAux);
                    resp.Add(empAux);
                }
            }
            else
            {
                EmployeeDto empAux = _mapper.Map<EmployeeDto>(employees.Where(e => e.Id == id).FirstOrDefault());
                if(empAux != null)
                {
                    empAux.AnualSalary = CalculateAnualSalary(empAux);
                    resp.Add(empAux);
                }                
            }

            return resp;
        }

        private double CalculateAnualSalary(EmployeeDto employee)
        {
            if (employee.ContractTypeName.Equals(ContractType.HourlySalaryEmployee.ToString()))
            {
                return 120 * employee.HourlySalary * 12;
            }
            else
            {
                return employee.MonthlySalary * 12;
            }
        }
    }
}
