using CapitalPlatforms.Domain.Consultants;
using CapitalPlatforms.Domain.Customers;

namespace CapitalPlatforms.Application.Customers.Commands.CreateCustomer.Factory
{
    public interface ICustomerFactory
    {
        Customer Create(Consultant? consultant, string? firstName, string? lastName, string? address, string? gender, DateTime? dob, string? mobileNo, string? emailAddress);
    }
}
