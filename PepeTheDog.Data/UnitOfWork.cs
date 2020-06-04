using System.Threading.Tasks;
using PepeTheDog.Core;
using PepeTheDog.Core.Repositories;
using PepeTheDog.Data.Repositories;
using PepeTheDog.Core.Repositories.Auth;
using Microsoft.AspNetCore.Identity;
using PepeTheDog.Core.Entities.Auth;
using PepeTheDog.Data.Repositories.Auth;
using Microsoft.Extensions.Configuration;

namespace PepeTheDog.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        private UserRepository _userRepository;
        private AccountRepository _accountRepository;

        private readonly SignInManager<AppUser> _signInManager;
        private readonly IConfiguration _configuration;

        public UnitOfWork(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IAccountRepository Accounts => _accountRepository ??= new AccountRepository(_context, _userManager, _signInManager, _configuration);
        public IUserRepository Users => _userRepository ??= new UserRepository(_context, _userManager);

        public async Task<int> CommitAsync() => await _context.SaveChangesAsync();
        public void Dispose() => _context.Dispose();
        
    }
}
