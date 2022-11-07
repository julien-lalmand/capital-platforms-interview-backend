using CapitalPlatforms.Application.Interfaces;

namespace CapitalPlatforms.Application.Consultants.Queries.GetConsultants
{
    public class GetConsultantsQuery : IGetConsultantsQuery
    {
        private readonly IDatabaseService _database;

        public GetConsultantsQuery(IDatabaseService database)
        {
            _database = database;
        }

        public List<ConsultantsModel> Execute()
        {
            var consultants = _database.Consultants
                .Select(c => new ConsultantsModel()
                {
                    Id = c.Id,
                    FirstName = c.FirstName,
                    LastName = c.LastName,
                    EmailAddress = c.EmailAddress,
                    MobileNo = c.MobileNo
                });

            return consultants.ToList();
        }
    }
}
