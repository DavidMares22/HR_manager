using AutoMapper;
using HR_manager.Server.Data;
using HR_manager.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_manager.Server.Configurations
{
    public class MapperInitilizer : Profile
    {
        public MapperInitilizer()
        {
            CreateMap<Department, DepartmentDTO>().ReverseMap();
            CreateMap<Department, CreateDepartmentDTO>().ReverseMap();
            CreateMap<Employee, EmployeeDTO>().ReverseMap();
            CreateMap<EmployeeData, EmpDataDTO>().ReverseMap();
            CreateMap<LoggedTime, LoggedTimeDTO>().ReverseMap();
            CreateMap<EmployeeTime, EmpTimeDTO>().ReverseMap();
            CreateMap<EmployeeTime, EmpTimeIDsDTO>().ReverseMap();
            CreateMap<Employee, CreateEmployeeDTO>().ReverseMap();
            CreateMap<ApiUser, UserDTO>().ReverseMap();
        }
    }
}
