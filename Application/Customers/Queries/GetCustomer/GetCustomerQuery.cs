using CapitalPlatforms.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlatforms.Application.Customers.Queries.GetCustomer
{
    public class GetCustomerQuery : IGetCustomerQuery
    {
        private readonly IDatabaseService _database;
        public GetCustomerQuery(IDatabaseService database)
        {
            _database = database;
        }

        public CustomerModel Execute(int id)
        {
            var customer = _database.Customers
                .Where(c => c.Id == id)
                .Select(c => new CustomerModel()
                {
                    Id = c.Id,
                    Address = c.Address,
                    Consultant = c.Consultant,
                    DOB = c.DOB,
                    EmailAddress = c.EmailAddress,
                    FirstName = c.FirstName,
                    Gender = c.Gender,
                    LastName = c.LastName,
                    MobileNo = c.MobileNo
                }).Single();

            return customer;
        }
    }
}
