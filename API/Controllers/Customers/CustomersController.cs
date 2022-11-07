using CapitalPlatforms.Application.Customers.Commands.CreateCustomer;
using CapitalPlatforms.Application.Customers.Commands.DeleteCustomer;
using CapitalPlatforms.Application.Customers.Commands.UpdateCustomer;
using CapitalPlatforms.Application.Customers.Queries.GetCustomer;
using CapitalPlatforms.Application.Customers.Queries.GetCustomers;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace CapitalPlatforms.API.Controllers.Customers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly IGetCustomersQuery _getAllQuery;
        private readonly IGetCustomerQuery _getQuery;
        private readonly ICreateCustomerCommand _createCommand;
        private readonly IUpdateCustomerCommand _updateCommand;
        private readonly IDeleteCustomerCommand _deleteCommand;

        public CustomersController(
            IGetCustomersQuery getAllQuery,
            IGetCustomerQuery getQuery,
            ICreateCustomerCommand createCommand,
            IUpdateCustomerCommand updateCommand,
            IDeleteCustomerCommand deleteCommand
            )
        {
            _getAllQuery = getAllQuery;
            _getQuery = getQuery;
            _createCommand = createCommand;
            _updateCommand = updateCommand;
            _deleteCommand = deleteCommand;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CustomersModel>> Get()
        {
            return Ok(_getAllQuery.Execute());
        }

        [HttpGet("{Id:int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ProblemDetails))]
        [ProducesErrorResponseType(typeof(ProblemDetails))]
        public ActionResult<IEnumerable<CustomerModel>> Get(int Id)
        {
            try
            {
                return Ok(_getQuery.Execute(Id));
            }
            catch (InvalidOperationException)
            {
                return Problem("Customer not found", null, StatusCodes.Status400BadRequest);
            }
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ProblemDetails))]
        [ProducesErrorResponseType(typeof(ProblemDetails))]
        public ActionResult<int> Create(CreateCustomerModel customer)
        {
            try
            {
                int id = _createCommand.Execute(customer);
                return Created(HttpContext.Request.GetDisplayUrl(), id);
            }
            catch (InvalidOperationException)
            {
                return Problem("Invalid consultant", null, StatusCodes.Status400BadRequest);
            }
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ProblemDetails))]
        [ProducesErrorResponseType(typeof(ProblemDetails))]
        public ActionResult<string> Update(UpdateCustomerModel customer)
        {
            try
            {
                _updateCommand.Execute(customer);
                return Ok();
            }
            catch (InvalidOperationException)
            {
                return Problem("Invalid consultant", null, StatusCodes.Status400BadRequest);
            }
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ProblemDetails))]
        [ProducesErrorResponseType(typeof(ProblemDetails))]
        public ActionResult<string> Delete(DeleteCustomerModel customer)
        {
            try
            {
                _deleteCommand.Execute(customer);
                return Ok();
            }
            catch (InvalidOperationException)
            {
                return Problem("Invalid customer", null, StatusCodes.Status400BadRequest);
            }
        }

    }
}
