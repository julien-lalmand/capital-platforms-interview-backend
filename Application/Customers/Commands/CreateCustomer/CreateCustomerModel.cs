using System.ComponentModel.DataAnnotations;

namespace CapitalPlatforms.Application.Customers.Commands.CreateCustomer
{
    public class CreateCustomerModel
    {
        public int? ConsultantId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Address { get; set; }
        public string? Gender { get; set; }
        public DateTime? DOB { get; set; }
        public string? MobileNo { get; set; }
        [EmailAddress]
        public string EmailAddress { get; set; }
    }
}
