using System;
using System.Threading.Tasks;
using PepeTheDog.Core.Repositories.Auth;

namespace PepeTheDog.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IAccountRepository Accounts { get; }
        IUserRepository Users { get; }
        Task<int> CommitAsync();
    }
}
