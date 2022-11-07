using CapitalPlatforms.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlatforms.Application.Consultants.Queries.GetConsultant
{
    public class GetConsultantQuery : IGetConsultantQuery
    {
        private readonly IDatabaseService _database;
        public GetConsultantQuery(IDatabaseService database)
        {
            _database = database;
        }

        public ConsultantModel Execute(int Id)
        {
            var consultant = _database.Consultants
                .Where(c => c.Id == Id)
                .Select(c => new ConsultantModel()
                {
                    Id = c.Id,
                    EmailAddress = c.EmailAddress,
                    FirstName = c.FirstName,
                    LastName = c.LastName,
                    MobileNo = c.MobileNo
                }).Single();

            return consultant;
        }
    }
}
