using Employees.Infraestructure.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employees.Infraestructure.RequestModel
{
    public class EmployeesApiModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ContractType ContractTypeName { get; set; }
        public double HourlySalary { get; set; }
        public double MonthlySalary { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public double AnualSalary { get; set; }
    }
}
