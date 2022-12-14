using CapitalPlatforms.Domain.Consultants;
using System.ComponentModel.DataAnnotations;

namespace CapitalPlatforms.Application.Customers.Commands.UpdateCustomer
{
    public class UpdateCustomerModel
    {
        public int Id { get; set; }
        //public int? ConsultantId { get; set; }
        public Consultant Consultant { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public string? Gender { get; set; }
        public DateTime? DOB { get; set; }
        public string? MobileNo { get; set; }
        [EmailAddress]
        public string? EmailAddress { get; set; }
    }
}
