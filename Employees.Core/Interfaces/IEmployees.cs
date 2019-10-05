using Employees.Share.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Core.Interfaces
{
    public interface IEmployees
    {
        Task<IEnumerable<EmployeeDto>> GetEmployees(int id);
    }
}
