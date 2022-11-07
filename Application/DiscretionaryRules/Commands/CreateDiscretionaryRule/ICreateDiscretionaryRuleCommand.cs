namespace CapitalPlatforms.Application.DiscretionaryRules.Commands.CreateDiscretionaryRule
{
    public interface ICreateDiscretionaryRuleCommand
    {
        int Execute(CreateDiscretionaryRuleModel model);
    }
}
