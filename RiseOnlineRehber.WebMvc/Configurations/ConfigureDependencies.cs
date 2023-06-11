using Microsoft.Extensions.DependencyInjection;
using RiseOnlineRehber.Business.Abstract;
using RiseOnlineRehber.Business.Concrete;
using RiseOnlineRehber.WebMvc.Abstract;
using RiseOnlineRehber.WebMvc.Helpers;

namespace RiseOnlineRehber.WebMvc.Configurations
{
    public class ConfigureDependencies
    {
        public static void AddServices(IServiceCollection services)
        {
            services.AddScoped<IAuthenticationService, AuthenticationManager>();

            services.AddTransient<IUserAccessor, UserAccessor>();
            services.AddTransient<IFileHelper, FileHelper>();


        }



    }
}
