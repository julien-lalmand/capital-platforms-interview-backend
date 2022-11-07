using CapitalPlatforms.Domain.Consultants;

namespace CapitalPlatforms.Application.Consultants.Commands.CreateConsultant.Factory
{
    public class ConsultantFactory : IConsultantFactory
    {
        public Consultant Create(string? firstName, string? lastName, string? emailAddress, string? mobileNo)
        {
            var consultant = new Consultant();

            consultant.FirstName = firstName;
            consultant.LastName = lastName;
            consultant.EmailAddress = emailAddress;
            consultant.MobileNo = mobileNo;

            return consultant;
        }
    }
}
