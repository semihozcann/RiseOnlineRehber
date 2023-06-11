using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RiseOnlineRehber.DataAccess.Concrete;
using RiseOnlineRehber.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiseOnlineRehber.Business.Configuration
{
    public class ConfigureRepositories
    {
        public static void AddService(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<RiseOnlieRehberContext>((option) =>
            {
                option.UseSqlServer(configuration.GetConnectionString("DbConnection"));
            });


            services.AddIdentity<User, Role>(option =>
            {
                option.Password.RequiredLength = 6; //6 karakter gerekli
                option.Password.RequireDigit = false; //
                option.Password.RequiredUniqueChars = 0;
                option.Password.RequireNonAlphanumeric = false;
                option.Password.RequireLowercase = false;
                option.Password.RequireUppercase = false;
                //User Username and email options
                option.User.AllowedUserNameCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789-._@+";
                option.User.RequireUniqueEmail = true;
            }).AddEntityFrameworkStores<RiseOnlieRehberContext>();

            services.ConfigureApplicationCookie(option =>
            {
                option.Cookie.HttpOnly = true; //ilgili cookie başka yerden çekilemez
                option.Cookie.SameSite = SameSiteMode.Strict; //cookie sadece ilgili domainde kullanılabilir
                option.Cookie.SecurePolicy = CookieSecurePolicy.SameAsRequest; // Httpve Https de çalışsın
                option.Cookie.Name = "RiseOnlineRehber";
                option.ExpireTimeSpan = TimeSpan.FromDays(25); // ilgili kullanıcının cookie bilgisini 25 gün sakla
                option.LoginPath = new PathString("/Account/Unauthorize"); //cookie olmayan bir talep olursa bu sayfaya yönlendir.

            });

            services.AddScoped<DbContext, RiseOnlieRehberContext>();



        }
        //AddTransient:yukardaki nesneleri her kullanımıda  tekrar cagırma işlemini yapar tekrar tekrar her istekte nesne olusur kısacası 





    }
}
