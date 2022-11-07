using CapitalPlatforms.Domain.Consultants;
using CapitalPlatforms.Domain.Customers;

namespace CapitalPlatforms.Application.Customers.Commands.CreateCustomer.Factory
{
    public class CustomerFactory : ICustomerFactory
    {
        public Customer Create(Consultant? consultant, string? firstName, string? lastName, string? address, string? gender, DateTime? dob, string? mobileNo, string? emailAddress)
        {
            var customer = new Customer();

            customer.Address = address;
            customer.Consultant = consultant;
            customer.EmailAddress = emailAddress;
            customer.Gender = gender;
            customer.DOB = dob;
            customer.MobileNo = mobileNo;
            customer.FirstName = firstName;
            customer.LastName = lastName;

            return customer;
        }
    }
}
