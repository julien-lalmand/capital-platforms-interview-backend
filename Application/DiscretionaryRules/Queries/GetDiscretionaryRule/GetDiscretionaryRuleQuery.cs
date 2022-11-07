using CapitalPlatforms.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlatforms.Application.DiscretionaryRules.Queries.GetDiscretionaryRule
{
    public class GetDiscretionaryRuleQuery : IGetDiscretionaryRuleQuery
    {
        private readonly IDatabaseService _database;
        public GetDiscretionaryRuleQuery(IDatabaseService database)
        {
            _database = database;
        }

        public DiscretionaryRuleModel Execute(int Id)
        {
            var discretionaryRule = _database.DiscretionaryRules
                .Where(d => d.Id == Id)
                .Select(d => new DiscretionaryRuleModel()
                {
                    Id = d.Id,
                    ConsultantBuy = d.ConsultantBuy,
                    ConsultantSell = d.ConsultantSell,
                    CustomerBuy = d.CustomerBuy,
                    CustomerSell = d.CustomerSell,
                    Consultant = d.Consultant,
                    Customer = d.Customer,
                    Rules = d.Rules
                })
                .Single();

            return discretionaryRule;
        }
    }
}
