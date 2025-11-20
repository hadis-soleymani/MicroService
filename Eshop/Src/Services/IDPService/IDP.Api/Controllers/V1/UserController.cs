using Asp.Versioning;
using IDP.Api.Controllers.BaseController;
using IDP.Application.Command.User;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace IDP.Api.Controllers.V1
{
    
    [ApiController]
    [ApiVersion(2)]
    [ApiVersion(1)]
    [Route("api/v{v:apiVersion}/Users")]

    public class UserController : IBaseController
    {
        public readonly IMediator _mediator;
        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary> 
        /// ورود کاربر
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [MapToApiVersion(1)]
        [HttpPost("Insert")]
        public async Task<IActionResult> Insert([FromBody] UserCommand userCommand)
        {
            var res = await _mediator.Send(userCommand);
            return Ok();
        }
    }
}
