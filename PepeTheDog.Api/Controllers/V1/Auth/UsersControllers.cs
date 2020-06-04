using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PepeTheDog.Core.Services.Auth;
using PepeTheDog.Core.Dtos.Auth;

namespace PepeTheDog.Api.Controllers.V1
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuersController : ControllerBase
    {
        private readonly IAppUserService _appUserService;

        public UsuersController(IAppUserService appUserService) => _appUserService = appUserService;

        [HttpPost("AsignarUsuarioRol")]
        public async Task<ActionResult> AssignUserRole(UpdateRolUserDto rol)
        {
            await _appUserService.AssignUserRole(rol);
            return Ok();
        }

        [HttpDelete("RemoverUsuarioRol")]
        public async Task<ActionResult> RemoverUsuarioRol(UpdateRolUserDto rol)
        {
            await _appUserService.RemoveUserRole(rol);
            return Ok();
        }

    }
}
