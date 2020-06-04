using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PepeTheDog.Core.Services.Auth;
using AutoMapper;
using PepeTheDog.Data;
using PepeTheDog.Core.Entities.Auth;
using PepeTheDog.Core.Dtos.Auth;

namespace PepeTheDog.Api.Controllers.V1
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuersController : ControllerBase
    {
        private readonly IAppUserService _appUserService;

        public UsuersController(IAppUserService appUserService) => _appUserService = appUserService;

        [Route("AsignarUsuarioRol")]
        public async Task<ActionResult> AsignarRolUsuario(UpdateRolUserDto rol)
        {
            await _appUserService.AssignUserRole(rol);
            return Ok();
        }

        [Route("RemoverUsuarioRol")]
        public async Task<ActionResult> RemoverUsuarioRol(UpdateRolUserDto rol)
        {
            await _appUserService.RemoveUserRole(rol);
            return Ok();
        }

    }
}
