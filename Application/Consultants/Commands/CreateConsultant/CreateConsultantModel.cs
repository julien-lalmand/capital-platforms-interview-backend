using System.ComponentModel.DataAnnotations;

namespace CapitalPlatforms.Application.Consultants.Commands.CreateConsultant
{
    public class CreateConsultantModel
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        [EmailAddress]
        public string EmailAddress { get; set; }
        public string? MobileNo { get; set; }
    }
}
