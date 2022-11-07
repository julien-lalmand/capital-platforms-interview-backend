using CapitalPlatforms.Application.Interfaces;

namespace CapitalPlatforms.Application.Consultants.Commands.DeleteConsultant
{
    public class DeleteConsultantCommand : IDeleteConsultantCommand
    {

        private readonly IDatabaseService _database;

        public DeleteConsultantCommand(IDatabaseService database)
        {
            _database = database;
        }

        public void Execute(DeleteConsultantModel model)
        {
            var consultant = _database.Consultants.Single(c => c.Id == model.Id);

            _database.Consultants.Remove(consultant);

            _database.Save();
        }
    }
}
