using CapitalPlatforms.Domain.Consultants;
using CapitalPlatforms.Domain.Customers;
using CapitalPlatforms.Domain.DiscretionaryRules;

namespace CapitalPlatforms.Application.DiscretionaryRules.Commands.CreateDiscretionaryRule.Factory
{
    public class DiscretionaryRuleFactory : IDiscretionaryRuleFactory
    {
        public DiscretionaryRule Create(Consultant consultant, Customer customer, bool customerBuy, bool customerSell, bool consultantBuy, bool consultantSell)
        {
            var discretionaryRule = new DiscretionaryRule();

            discretionaryRule.Consultant = consultant;
            discretionaryRule.Customer = customer;
            discretionaryRule.CustomerBuy = customerBuy;
            discretionaryRule.CustomerSell = customerSell;
            discretionaryRule.ConsultantBuy = consultantBuy;
            discretionaryRule.ConsultantSell = consultantSell;

            return discretionaryRule;
        }
    }
}
