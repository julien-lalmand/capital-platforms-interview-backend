using CapitalPlatforms.Domain.Common;
using CapitalPlatforms.Domain.Consultants;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CapitalPlatforms.Domain.Customers
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public Consultant? Consultant { get; set; }
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
