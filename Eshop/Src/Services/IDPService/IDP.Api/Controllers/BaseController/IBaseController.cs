using IDP.Application.Command.User;
using Microsoft.AspNetCore.Mvc;

namespace IDP.Api.Controllers.BaseController
{
    [Route("api/[controller]")]
    [ApiController]
    public class IBaseController : ControllerBase
    {
        /// <summary> 
        /// ورود کاربر
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpPost("Insert")]
        public async Task<IActionResult> Insert([FromBody] UserCommand userCommand)
        {
            return Ok();
        }
    }
}
