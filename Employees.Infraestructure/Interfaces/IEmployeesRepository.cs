using Employees.Infraestructure.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Employees.Infraestructure.Interfaces
{
    public interface IEmployeesRepository
    {
        Task<IEnumerable<Employee>> GetEmployees();
    }
}
