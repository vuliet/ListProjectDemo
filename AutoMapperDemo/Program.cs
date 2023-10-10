// Install-Package AutoMapper.Extensions.Microsoft.DependencyInjection

using AutoMapper;
using AutoMapperDemo;
using Newtonsoft.Json;

var config = new MapperConfiguration(cfg =>
{
    cfg.CreateMap<Employee, EmployeeDto>()
    .ForMember(dest => dest.FullName, opt => opt.Condition(src => src.Role == "Manager"))
    //.ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.GetFullName()))
    .ForMember(dest => dest.FullName, opt => opt.MapFrom<FullNameResolver>()).ReverseMap();
});

var employee = new Employee
{
    Address = new Address
    {
        City = "HCM",
        Country = "VIETNAM",
        Door = "1",
        Id = 1,
        State = "2",
        Street1 = "3",
        Street2 = "4",
        ZipCode = "5"
    },
    FirstName = "Thai",
    LastName = "Vu",
    Role = "Manager"
};

var request = new EmployeeDto
{
    Role = "Staff"
};

IMapper mapper = config.CreateMapper();
var employeeDto = mapper.Map<EmployeeDto>(employee);

Console.WriteLine($"EmployeeDto={JsonConvert.SerializeObject(employeeDto)}");

mapper.Map(request, employee);

Console.WriteLine($"Employee={JsonConvert.SerializeObject(employee)}");

Console.ReadLine();