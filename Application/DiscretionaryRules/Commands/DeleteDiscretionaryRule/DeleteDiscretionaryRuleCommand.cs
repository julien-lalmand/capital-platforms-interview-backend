using CapitalPlatforms.Application.Interfaces;

namespace CapitalPlatforms.Application.DiscretionaryRules.Commands.DeleteDiscretionaryRule
{
    public class DeleteDiscretionaryRuleCommand : IDeleteDiscretionaryRuleCommand
    {
        private readonly IDatabaseService _database;
        public DeleteDiscretionaryRuleCommand(IDatabaseService database)
        {
            _database = database;
        }

        public void Execute(DeleteDiscretionaryRuleModel model)
        {
            var discretionaryRule = _database.DiscretionaryRules.Single(d => d.Id == model.Id);

            _database.DiscretionaryRules.Remove(discretionaryRule);

            _database.Save();
        }
    }
}
