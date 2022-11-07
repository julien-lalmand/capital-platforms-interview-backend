using CapitalPlatforms.Domain.Consultants;
using CapitalPlatforms.Domain.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlatforms.Application.DiscretionaryRules.Queries.GetDiscretionaryRule
{
    public class DiscretionaryRuleModel
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
