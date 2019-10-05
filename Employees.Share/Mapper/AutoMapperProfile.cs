using AutoMapper;
using Employees.Infraestructure.Entities;
using Employees.Share.Models;

namespace Employees.Share.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Employee, EmployeeDto>();
            CreateMap<Role, RoleDto>();
        }
    }
}
