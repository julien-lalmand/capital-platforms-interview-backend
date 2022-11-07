using CapitalPlatforms.Application.Interfaces;

namespace CapitalPlatforms.Application.Customers.Commands.DeleteCustomer
{
    public class DeleteCustomerCommand : IDeleteCustomerCommand
    {
        private readonly IDatabaseService _database;

        public DeleteCustomerCommand(IDatabaseService database)
        {
            _database = database;
        }

        public void Execute(DeleteCustomerModel model)
        {
            var customer = _database.Customers.Single(c => c.Id == model.Id);

            _database.Customers.Remove(customer);
            _database.Save();
        }
    }
}
