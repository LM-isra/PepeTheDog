using System.Threading.Tasks;
using PepeTheDog.Core.Dtos.Auth;


namespace PepeTheDog.Core.Repositories.Auth
{
    public interface IUserRepository : IRepository<UpdateRolUserDto>
    {
        Task AssignUserRole(UpdateRolUserDto rol);
        Task RemoveUserRole(UpdateRolUserDto rol);
    }
}
