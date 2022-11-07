using CapitalPlatforms.Application.Interfaces;

namespace CapitalPlatforms.Application.DiscretionaryRules.Queries.GetDiscretionaryRules
{
    public class GetDiscretionaryRulesQuery : IGetDiscretionaryRulesQuery
    {
        private readonly IDatabaseService _database;
        public GetDiscretionaryRulesQuery(IDatabaseService database)
        {
            _database = database;
        }

        public List<DiscretionaryRulesModel> Execute()
        {
            var discretionaryRules = _database.DiscretionaryRules
                .Select(c => new DiscretionaryRulesModel()
                {
                    Id = c.Id,
                    ConsultantId = c.Consultant.Id,
                    CustomerId = c.Customer.Id,
                    ConsultantBuy = c.ConsultantBuy,
                    ConsultantSell = c.ConsultantSell,
                    CustomerBuy = c.CustomerBuy,
                    CustomerSell = c.CustomerSell,
                    Rules = c.Rules
                });

            return discretionaryRules.ToList();
        }
    }
}
