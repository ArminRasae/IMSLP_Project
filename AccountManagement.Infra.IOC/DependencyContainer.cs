using AccountManagement.Application.Interfaces;
using AccountManagement.Application.Services;
using AccountManagement.Domain.Interfaces;
using AccountManagement.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Shop.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterService(IServiceCollection services,string connectionString)
        {
            #region services
            services.AddScoped<IUserService, UserService>();
            #endregion

            #region repositories
            services.AddScoped<IUserRepository, UserRepository>();
            #endregion

            #region tools
            services.AddScoped<IPasswordHelper, PasswordHelper>();


            #endregion
            services.AddDbContext<AccountContext>(x =>
                x.UseSqlServer(connectionString));
        }
    }
}
