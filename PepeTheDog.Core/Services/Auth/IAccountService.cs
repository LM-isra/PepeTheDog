using System.Threading.Tasks;
using PepeTheDog.Core.Entities.Auth;

namespace PepeTheDog.Core.Services.Auth
{
    public interface IAccountService
    {
        Task<UserToken> CreateUser(UserInfo model);
        Task<UserToken> Login(UserInfo userInfo);
    }
}
