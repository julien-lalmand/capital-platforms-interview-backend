using CapitalPlatforms.Domain.Consultants;
using CapitalPlatforms.Domain.Customers;

namespace CapitalPlatforms.Domain.DiscretionaryRules
{
    public class DiscretionaryRule
    {
        public int Id { get; set; }
        public Consultant Consultant { get; set; }
        public Customer Customer { get; set; }
        public string? Rules { get; set; }
        public bool CustomerBuy { get; set; }
        public bool CustomerSell { get; set; }
        public bool ConsultantBuy { get; set; }
        public bool ConsultantSell { get; set; }

    }
}
