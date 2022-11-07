using CapitalPlatforms.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace CapitalPlatforms.Domain.Consultants
{
    public class Consultant : IEntity
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? EmailAddress { get; set; }
        public string? MobileNo { get; set; }
    }
}
