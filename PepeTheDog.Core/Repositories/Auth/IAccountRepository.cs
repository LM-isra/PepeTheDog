using PepeTheDog.Core.Entities.Auth;
using System.Threading.Tasks;

namespace PepeTheDog.Core.Repositories.Auth
{
    public interface IAccountRepository : IRepository<UserToken>
    {
        Task<UserToken> CreateUser(UserInfo model);
        Task<UserToken> Login(UserInfo userInfo);
    }
}
