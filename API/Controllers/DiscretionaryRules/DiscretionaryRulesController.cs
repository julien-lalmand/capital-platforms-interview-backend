using CapitalPlatforms.Application.Consultants.Queries.GetConsultant;
using CapitalPlatforms.Application.DiscretionaryRules.Commands.CreateDiscretionaryRule;
using CapitalPlatforms.Application.DiscretionaryRules.Commands.DeleteDiscretionaryRule;
using CapitalPlatforms.Application.DiscretionaryRules.Commands.UpdateDiscretionaryRule;
using CapitalPlatforms.Application.DiscretionaryRules.Queries.GetDiscretionaryRule;
using CapitalPlatforms.Application.DiscretionaryRules.Queries.GetDiscretionaryRules;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace CapitalPlatforms.API.Controllers.DiscretionaryRules
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscretionaryRulesController : ControllerBase
    {
        private readonly IGetDiscretionaryRulesQuery _getAllQuery;
        private readonly IGetDiscretionaryRuleQuery _getQuery;
        private readonly ICreateDiscretionaryRuleCommand _createCommand;
        private readonly IUpdateDiscretionaryRuleCommand _updateCommand;
        private readonly IDeleteDiscretionaryRuleCommand _deleteCommand;
        public DiscretionaryRulesController(
            IGetDiscretionaryRulesQuery getAllQuery,
            IGetDiscretionaryRuleQuery getQuery,
            ICreateDiscretionaryRuleCommand createCommand,
            IUpdateDiscretionaryRuleCommand updateCommand,
            IDeleteDiscretionaryRuleCommand deleteCommand
            )
        {
            _getAllQuery = getAllQuery;
            _getQuery = getQuery;
            _createCommand = createCommand;
            _updateCommand = updateCommand;
            _deleteCommand = deleteCommand;
        }

        [HttpGet]
        public ActionResult<IEnumerable<DiscretionaryRulesModel>> Get()
        {
            return Ok(_getAllQuery.Execute());
        }

        [HttpGet("{Id:int}")]
        public ActionResult<IEnumerable<DiscretionaryRuleModel>> Get(int Id)
        {
            try
            {
                return Ok(_getQuery.Execute(Id));
            }
            catch (InvalidOperationException)
            {
                return Problem("Rule not found", null, StatusCodes.Status400BadRequest);
            }
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(int))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ProblemDetails))]
        [ProducesErrorResponseType(typeof(ProblemDetails))]
        public ActionResult<int> Create(CreateDiscretionaryRuleModel discretionaryRule)
        {
            try
            {
                int id = _createCommand.Execute(discretionaryRule);
                return Created(HttpContext.Request.GetDisplayUrl(), id);
            }
            catch (InvalidOperationException)
            {
                return Problem("Invalid customer or consultant", null, StatusCodes.Status400BadRequest);
            }
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ProblemDetails))]
        [ProducesErrorResponseType(typeof(ProblemDetails))]
        public ActionResult Update(UpdateDiscretionaryRuleModel discretionaryRule)
        {
            try
            {
                _updateCommand.Execute(discretionaryRule);
                return Ok();
            }
            catch (InvalidOperationException)
            {
                return Problem("Invalid discretionary rule", null, StatusCodes.Status400BadRequest);
            }
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ProblemDetails))]
        [ProducesErrorResponseType(typeof(ProblemDetails))]
        public ActionResult Delete(DeleteDiscretionaryRuleModel discretionaryRuleModel)
        {
            try
            {
                _deleteCommand.Execute(discretionaryRuleModel);
                return Ok();
            }
            catch (InvalidOperationException)
            {
                return Problem("Invalid discretionary rule", null, StatusCodes.Status400BadRequest);
            }
        }
    }
}
