using CapitalPlatforms.Domain.Consultants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlatforms.Application.Customers.Queries.GetCustomer
{
    public class CustomerModel
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
