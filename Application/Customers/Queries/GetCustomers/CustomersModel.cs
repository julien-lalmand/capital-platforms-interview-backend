using CapitalPlatforms.Domain.Consultants;

namespace CapitalPlatforms.Application.Customers.Queries.GetCustomers
{
    public class CustomersModel
    {
        public int Id { get; set; }
        public Consultant? Consultant { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public string? Gender { get; set; }
        public DateTime? DOB { get; set; }
        public string? MobileNo { get; set; }
        public string? EmailAddress { get; set; }
    }
}
