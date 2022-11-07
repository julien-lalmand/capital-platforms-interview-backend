using CapitalPlatforms.Application.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CapitalPlatforms.Application.Customers.Commands.UpdateCustomer
{
    public class UpdateCustomerCommand : IUpdateCustomerCommand
    {
        private readonly IDatabaseService _database;
        public UpdateCustomerCommand(IDatabaseService database)
        {
            _database = database;
        }
        public void Execute(UpdateCustomerModel model)
        {
            var customer = _database.Customers.Include(c => c.Consultant).Single(c => c.Id == model.Id);

            customer.Address = model.Address;
            customer.EmailAddress = model.EmailAddress;
            customer.FirstName = model.FirstName;
            customer.LastName = model.LastName;
            customer.DOB = model.DOB;
            customer.Gender = model.Gender;

            if (customer.Consultant.Id != model.Consultant.Id)
            {
                var newConsultant = _database.Consultants.Single(c => c.Id == model.Consultant.Id);
                customer.Consultant = newConsultant;
            }

            _database.Customers.Update(customer);
            _database.Save();
        }
    }
}
