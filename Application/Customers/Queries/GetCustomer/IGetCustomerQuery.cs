using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlatforms.Application.Customers.Queries.GetCustomer
{
    public interface IGetCustomerQuery
    {
        CustomerModel Execute(int id);
    }
}
