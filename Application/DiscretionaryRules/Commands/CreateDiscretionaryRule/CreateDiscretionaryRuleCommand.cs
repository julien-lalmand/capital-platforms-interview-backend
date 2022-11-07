using CapitalPlatforms.Application.DiscretionaryRules.Commands.CreateDiscretionaryRule.Factory;
using CapitalPlatforms.Application.Interfaces;

namespace CapitalPlatforms.Application.DiscretionaryRules.Commands.CreateDiscretionaryRule
{
    public class CreateDiscretionaryRuleCommand : ICreateDiscretionaryRuleCommand
    {
        private readonly IDiscretionaryRuleFactory _factory;
        private readonly IDatabaseService _database;
        public CreateDiscretionaryRuleCommand(IDiscretionaryRuleFactory factory, IDatabaseService database)
        {
            _factory = factory;
            _database = database;
        }

        public int Execute(CreateDiscretionaryRuleModel model)
        {
            var customer = _database.Customers.Single(c => c.Id == model.CustomerId);
            var consultant = _database.Consultants.Single(c => c.Id == model.ConsultantId);

            var discretionaryRule = _factory.Create(consultant, customer, model.CustomerBuy, model.CustomerSell, model.ConsultantBuy, model.ConsultantSell);

            _database.DiscretionaryRules.Add(discretionaryRule);
            _database.Save();

            return discretionaryRule.Id;
        }
    }
}
