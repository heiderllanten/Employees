using Employees.Core.Interfaces;
using Employees.Share.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Employees.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployees _employees;

        public EmployeesController(IEmployees employees)
        {
            _employees = employees;
        }
        
        [HttpGet]
        public async Task<IEnumerable<EmployeeDto>> GetEmployees(int id = -1)
        {
            return await _employees.GetEmployees(id);
        }
    }
}
