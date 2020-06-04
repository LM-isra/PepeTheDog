using System.Threading.Tasks;
using PepeTheDog.Core;
using PepeTheDog.Core.Entities.Auth;
using PepeTheDog.Core.Services.Auth;

namespace PepeTheDog.Services.Auth
{
    public class AccountService : IAccountService
    {
        private readonly IUnitOfWork _unitOfWork;
        public AccountService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<UserToken> CreateUser(UserInfo model)
        {
             return await _unitOfWork.Accounts.CreateUser(model);
        }
        public async Task<UserToken> Login(UserInfo userInfo) 
        {
            return await _unitOfWork.Accounts.Login(userInfo);
        }
    }
}
