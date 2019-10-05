using Employees.Infraestructure.Enum;

namespace Employees.Infraestructure.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ContractType ContractTypeName { get; set; }
        public double HourlySalary { get; set; }
        public double MonthlySalary { get; set; }
        public Role RoleId { get; set; }
    }
}
