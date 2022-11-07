using System.ComponentModel.DataAnnotations;

namespace CapitalPlatforms.Application.Consultants.Commands.UpdateConsultant
{
    public class UpdateConsultantModel
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        [EmailAddress]
        public string EmailAddress { get; set; }
        public string? MobileNo { get; set; }
    }
}
