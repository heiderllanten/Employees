using Employees.Infraestructure.Entities;
using Employees.Infraestructure.Interfaces;
using Employees.Infraestructure.RequestModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Employees.Infraestructure.Data
{
    public class EmployeesRepository : IEmployeesRepository
    {
        private readonly IHttpClientFactory _clientFactory;

        public EmployeesRepository(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();

            var request = new HttpRequestMessage(HttpMethod.Get,
                "http://masglobaltestapi.azurewebsites.net/api/Employees");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                string aux = await response.Content.ReadAsStringAsync();
                IEnumerable<EmployeesApiModel> employeesList = JsonConvert.DeserializeObject<IEnumerable<EmployeesApiModel>>(aux);
                foreach (EmployeesApiModel e in employeesList)
                {
                    Role role = new Role();
                    role.RoleId = e.RoleId;
                    role.RoleName = e.RoleName;
                    role.RoleDescription = e.RoleDescription;

                    Employee employee = new Employee();
                    employee.ContractTypeName = e.ContractTypeName;
                    employee.HourlySalary = e.HourlySalary;
                    employee.Id = e.Id;
                    employee.MonthlySalary = e.MonthlySalary;
                    employee.Name = e.Name;
                    employee.RoleId = role;

                    employees.Add(employee);
                }
            }

            return employees;
        }
    }
}
