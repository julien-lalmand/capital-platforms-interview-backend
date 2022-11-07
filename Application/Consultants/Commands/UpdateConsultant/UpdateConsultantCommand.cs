using CapitalPlatforms.Application.Interfaces;

namespace CapitalPlatforms.Application.Consultants.Commands.UpdateConsultant
{
    public class UpdateConsultantCommand : IUpdateConsultantCommand
    {
        private readonly IDatabaseService _database;

        public UpdateConsultantCommand(IDatabaseService database)
        {
            _database = database;
        }

        public void Execute(UpdateConsultantModel model)
        {
            var consultant = _database.Consultants.Single(c => c.Id == model.Id);

            consultant.FirstName = model.FirstName;
            consultant.LastName = model.LastName;
            consultant.EmailAddress = model.EmailAddress;
            consultant.MobileNo = model.MobileNo;

            _database.Consultants.Update(consultant);

            _database.Save();
        }
    }
}
