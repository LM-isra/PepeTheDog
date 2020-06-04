using System.Threading.Tasks;
using PepeTheDog.Core.Entities.Auth;
using PepeTheDog.Core.Repositories.Auth;
using PepeTheDog.Core.Dtos.Auth;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace PepeTheDog.Data.Repositories
{
    public class UserRepository : Repository<UpdateRolUserDto>, IUserRepository
    {
        public UserRepository(AppDbContext context, UserManager<AppUser> userManager) : base (context) 
        {
            _userManager = userManager;
        }

        private readonly UserManager<AppUser> _userManager;

        public async Task AssignUserRole(UpdateRolUserDto rol)
        {
            var usuario = await _userManager.FindByIdAsync(rol.UserId);
            await _userManager.AddClaimAsync(usuario, new Claim(ClaimTypes.Role, rol.RoleName));
            await _userManager.AddToRoleAsync(usuario, rol.RoleName);
        }

        public async Task RemoveUserRole(UpdateRolUserDto rol)
        {
            var usuario = await _userManager.FindByIdAsync(rol.UserId);
            await _userManager.RemoveClaimAsync(usuario, new Claim(ClaimTypes.Role, rol.RoleName));
            await _userManager.RemoveFromRoleAsync(usuario, rol.RoleName);
        }
    }
}
