namespace CapitalPlatforms.Application.DiscretionaryRules.Commands.UpdateDiscretionaryRule
{
    public class UpdateDiscretionaryRuleModel
    {
        public int Id { get; set; }
        public bool ConsultantBuy { get; set; }
        public bool ConsultantSell { get; set; }
        public bool CustomerBuy { get; set; }
        public bool CustomerSell { get; set; }
    }
}
