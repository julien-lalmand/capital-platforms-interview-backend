using CapitalPlatforms.Application.Interfaces;

namespace CapitalPlatforms.Application.Customers.Queries.GetCustomers
{
    public class GetCustomersQuery : IGetCustomersQuery
    {
        private readonly IDatabaseService _database;
        public GetCustomersQuery(IDatabaseService database)
        {
            _database = database;
        }

        public List<CustomersModel> Execute()
        {
            var customers = _database.Customers
                .Select(c => new CustomersModel()
                {
                    Id = c.Id,
                    FirstName = c.FirstName,
                    LastName = c.LastName,
                    EmailAddress = c.EmailAddress,
                    MobileNo = c.MobileNo,
                    Address = c.Address,
                    Consultant = c.Consultant,
                    DOB = c.DOB,
                    Gender = c.Gender
                });

            return customers.ToList();
        }
    }
}
