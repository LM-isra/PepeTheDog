using System.Threading.Tasks;
using PepeTheDog.Core.Dtos.Auth;

namespace PepeTheDog.Core.Services.Auth
{
    public interface IAppUserService
    {
        Task AssignUserRole(UpdateRolUserDto rol);
        Task RemoveUserRole(UpdateRolUserDto rol);
    }
}
