using AutoMapper;
using System.ComponentModel.DataAnnotations;

namespace AutoMapperDemo
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        public string Role { get; set; }

        public string GetFullName()
        {
            return $"{LastName} {FirstName}";
        }
    }

    public class EmployeeDto
    {
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Country")]
        public string AddressCountry { get; set; }

        public string Role { get; set; }
    }

    public class Address
    {
        public int Id { get; set; }
        public string Door { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
    }

    // Let's create a custom resolver
    public class FullNameResolver : IValueResolver<Employee, EmployeeDto, string>
    {
        public string Resolve(
            Employee source,
            EmployeeDto destination,
            string destMember,
            ResolutionContext context)
        {
            return source.FirstName + " " + source.LastName;
        }
    }
}
