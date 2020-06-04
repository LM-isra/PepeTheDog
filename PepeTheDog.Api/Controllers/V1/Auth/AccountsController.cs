using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PepeTheDog.Core.Services.Auth;
using PepeTheDog.Core.Entities.Auth;

namespace PepeTheDog.Api.Controllers.V1
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountsController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountsController(IAccountService accountService) => _accountService = accountService;

        [HttpPost("Crear")]
        public async Task<ActionResult<UserToken>> CreateUser([FromBody] UserInfo userInfo)
        {
            return await _accountService.CreateUser(userInfo);
        }

        [HttpPost("Login")]
        public async Task<ActionResult<UserToken>> Login([FromBody] UserInfo userInfo)
        {
            return await _accountService.Login(userInfo);
        }
    }
}
