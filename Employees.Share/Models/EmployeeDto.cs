namespace Employees.Share.Models
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContractTypeName { get; set; }
        public double HourlySalary { get; set; }
        public double MonthlySalary { get; set; }
        public RoleDto RoleId { get; set; }
        public double AnualSalary { get; set; }
    }
}
