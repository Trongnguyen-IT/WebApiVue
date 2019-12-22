using Microsoft.Extensions.DependencyInjection;
using T.Services;

namespace T.DependencyRegistrar
{
    public static class DependencyRegistrar
    {
        public static void Register(IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
        }
    }
}
