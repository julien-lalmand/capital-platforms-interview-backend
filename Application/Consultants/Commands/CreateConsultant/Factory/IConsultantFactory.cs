using CapitalPlatforms.Domain.Consultants;

namespace CapitalPlatforms.Application.Consultants.Commands.CreateConsultant.Factory
{
    public interface IConsultantFactory
    {
        Consultant Create(string? firstName, string? lastName, string? emailAddress, string? mobileNo);
    }
}
