using Microsoft.Extensions.DependencyInjection;
using PepeTheDog.Core.Repositories;
using PepeTheDog.Core.Services.Auth;
using PepeTheDog.Data.Repositories;
using PepeTheDog.Services.Auth;

namespace PepeTheDog.Api.Root
{
    public class MyServicesRoot
    {
        public MyServicesRoot() { }

        public static void InjectDependencies(IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            //services.AddTransient<IAppUserService, AppUserService>();
        }
    }
}