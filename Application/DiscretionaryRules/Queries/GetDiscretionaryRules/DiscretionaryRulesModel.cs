namespace CapitalPlatforms.Application.DiscretionaryRules.Queries.GetDiscretionaryRules
{
    public class DiscretionaryRulesModel
    {
        public int Id { get; set; }
        public int ConsultantId { get; set; }
        public int CustomerId { get; set; }
        public string? Rules { get; set; }
        public bool CustomerBuy { get; set; }
        public bool CustomerSell { get; set; }
        public bool ConsultantBuy { get; set; }
        public bool ConsultantSell { get; set; }
    }
}
