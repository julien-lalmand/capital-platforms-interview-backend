using CapitalPlatforms.Domain.Consultants;
using CapitalPlatforms.Domain.Customers;
using CapitalPlatforms.Domain.DiscretionaryRules;

namespace CapitalPlatforms.Application.DiscretionaryRules.Commands.CreateDiscretionaryRule.Factory
{
    public interface IDiscretionaryRuleFactory
    {
        DiscretionaryRule Create(Consultant consultant, Customer customer, bool customerBuy, bool customerSell, bool consultantBuy, bool consultantSell);
    }
}
