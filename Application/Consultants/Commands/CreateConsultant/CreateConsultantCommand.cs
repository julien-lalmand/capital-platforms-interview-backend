using CapitalPlatforms.Application.Consultants.Commands.CreateConsultant.Factory;
using CapitalPlatforms.Application.Interfaces;

namespace CapitalPlatforms.Application.Consultants.Commands.CreateConsultant
{
    public class CreateConsultantCommand : ICreateConsultantCommand
    {
        private readonly IDatabaseService _database;
        private readonly IConsultantFactory _factory;

        public CreateConsultantCommand(IDatabaseService database, IConsultantFactory factory)
        {
            _database = database;
            _factory = factory;
        }

        public int Execute(CreateConsultantModel model)
        {
            var consultant = _factory.Create(model.FirstName, model.LastName, model.EmailAddress, model.MobileNo);

            _database.Consultants.Add(consultant);
            _database.Save();

            return consultant.Id;
        }
    }
}
