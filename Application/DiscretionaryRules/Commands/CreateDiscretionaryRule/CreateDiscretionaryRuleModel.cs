namespace CapitalPlatforms.Application.DiscretionaryRules.Commands.CreateDiscretionaryRule
{
    public class CreateDiscretionaryRuleModel
    {
        public int ConsultantId { get; set; }
        public int CustomerId { get; set; }
        public bool CustomerBuy { get; set; }
        public bool CustomerSell { get; set; }
        public bool ConsultantBuy { get; set; }
        public bool ConsultantSell { get; set; }
    }
}
