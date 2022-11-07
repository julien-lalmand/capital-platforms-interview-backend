using CapitalPlatforms.Application.Customers.Commands.CreateCustomer.Factory;
using CapitalPlatforms.Application.Interfaces;

namespace CapitalPlatforms.Application.Customers.Commands.CreateCustomer
{
    public class CreateCustomerCommand : ICreateCustomerCommand
    {
        private readonly IDatabaseService _database;
        private readonly ICustomerFactory _factory;
        public CreateCustomerCommand(IDatabaseService database, ICustomerFactory factory)
        {
            _database = database;
            _factory = factory;
        }

        public int Execute(CreateCustomerModel model)
        {
            var consultant = _database.Consultants.Single(c => c.Id == model.ConsultantId);

            var customer = _factory.Create(consultant, model.FirstName, model.LastName, model.Address, model.Gender, model.DOB, model.MobileNo, model.EmailAddress);

            _database.Customers.Add(customer);
            _database.Save();

            return customer.Id;
        }
    }
}
