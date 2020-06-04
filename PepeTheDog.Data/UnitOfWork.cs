using System.Threading.Tasks;
using PepeTheDog.Core;
using PepeTheDog.Core.Repositories;
using PepeTheDog.Data.Repositories;
using PepeTheDog.Core.Repositories.Auth;
using Microsoft.AspNetCore.Identity;
using PepeTheDog.Core.Entities.Auth;
using PepeTheDog.Data.Repositories.Auth;

namespace PepeTheDog.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        private UserRepository _userRepository;
        private AccountRepository _accountRepository;

        public UnitOfWork(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IAccountRepository Accounts => _userRepository ??= new UserRepository(_context, _userManager);
        public IUserRepository Users => _userRepository ??= new UserRepository(_context, _userManager);

        public async Task<int> CommitAsync() => await _context.SaveChangesAsync();
        public void Dispose() => _context.Dispose();
        
    }
}
