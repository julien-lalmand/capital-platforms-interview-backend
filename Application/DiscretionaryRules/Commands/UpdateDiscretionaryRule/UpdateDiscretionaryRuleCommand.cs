using CapitalPlatforms.Application.Interfaces;

namespace CapitalPlatforms.Application.DiscretionaryRules.Commands.UpdateDiscretionaryRule
{
    public class UpdateDiscretionaryRuleCommand : IUpdateDiscretionaryRuleCommand
    {
        private readonly IDatabaseService _database;
        public UpdateDiscretionaryRuleCommand(IDatabaseService database)
        {
            _database = database;
        }
        public void Execute(UpdateDiscretionaryRuleModel model)
        {
            var discretionaryRule = _database.DiscretionaryRules.Single(d => d.Id == model.Id);

            discretionaryRule.CustomerSell = model.CustomerSell;
            discretionaryRule.CustomerBuy = model.CustomerBuy;
            discretionaryRule.ConsultantBuy = model.ConsultantBuy;
            discretionaryRule.ConsultantSell = model.ConsultantSell;

            _database.DiscretionaryRules.Update(discretionaryRule);

            _database.Save();
        }
    }
}
