using CapitalPlatforms.Application.Consultants.Commands.CreateConsultant;
using CapitalPlatforms.Application.Consultants.Commands.DeleteConsultant;
using CapitalPlatforms.Application.Consultants.Commands.UpdateConsultant;
using CapitalPlatforms.Application.Consultants.Queries.GetConsultant;
using CapitalPlatforms.Application.Consultants.Queries.GetConsultants;
using CapitalPlatforms.Application.Customers.Queries.GetCustomers;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace CapitalPlatforms.API.Controllers.Consultants
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultantsController : ControllerBase
    {
        private readonly IGetConsultantsQuery _getAllQuery;
        private readonly IGetConsultantQuery _getQuery;
        private readonly ICreateConsultantCommand _createCommand;
        private readonly IUpdateConsultantCommand _updateCommand;
        private readonly IDeleteConsultantCommand _deleteCommand;


        public ConsultantsController(
            IGetConsultantsQuery getAllQuery,
            IGetConsultantQuery getQuery,
            ICreateConsultantCommand createCommand,
            IUpdateConsultantCommand updateCommand,
            IDeleteConsultantCommand deleteCommand)
        {
            _getAllQuery = getAllQuery;
            _getQuery = getQuery;
            _createCommand = createCommand;
            _updateCommand = updateCommand;
            _deleteCommand = deleteCommand;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ConsultantsModel>> Get()
        {
            return Ok(_getAllQuery.Execute());
        }

        [HttpGet("{Id:int}")]
        public ActionResult<IEnumerable<ConsultantModel>> Get(int Id)
        {
            try
            {
                return Ok(_getQuery.Execute(Id));
            }
            catch (InvalidOperationException)
            {
                return Problem("Consultant not found", null, StatusCodes.Status400BadRequest);
            }
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult<int> Create(CreateConsultantModel consultant)
        {
            int id = _createCommand.Execute(consultant);
            return Created(HttpContext.Request.GetDisplayUrl(), id);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ProblemDetails))]
        [ProducesErrorResponseType(typeof(ProblemDetails))]
        public ActionResult<string> Update(UpdateConsultantModel consultant)
        {
            try
            {
                _updateCommand.Execute(consultant);
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
        public ActionResult<string> Delete(DeleteConsultantModel consultant)
        {
            try
            {
                _deleteCommand.Execute(consultant);
                return Ok();
            }
            catch (InvalidOperationException)
            {
                return Problem("Invalid customer or consultant", null, StatusCodes.Status400BadRequest);
            }
        }
    }
}
