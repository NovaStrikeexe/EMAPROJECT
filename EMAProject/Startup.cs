using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMAProject.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using EMAProject.Domain;
using EMAProject.Domain.Repositories.Abstract;
using EMAProject.Domain.Repositories.EntityFramework;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace EMAProject
{
    
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration) => Configuration = configuration;
        public void ConfigureServices(IServiceCollection services)
        {
            Configuration.Bind("Project", new ConfigureService());
            services.AddTransient<ITextFieldsRepository,EFTextFieldsRepository>();
            services.AddTransient<IServiceItemRepository, EFServiceItemsRepository>();
            services.AddTransient<DataManager>();
            //services.AddControllersWithViews().SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Latest).AddSessionStateTempDataProvider();
            //services.AddDbContext<AppDbContext>(x => x.UseNoSqlServer)
            //TODO Подрубить базу к прилажухе
            services.AddIdentity<IdentityUser,IdentityRole>(opts =>{
                opts.User.RequireUniqueEmail = true;
                opts.Password.RequiredLength = 14;
                opts.Password.RequireNonAlphanumeric = false;
                opts.Password.RequireLowercase = false;
                opts.Password.RequireUppercase = false;
                opts.Password.RequireDigit = false;
            }).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

            services.ConfigureApplicationCookie(options =>{
                options.Cookie.Name= "EMAProjectAuth";
                options.Cookie.HttpOnly = true;
                options.LoginPath = "/account/login";
                options.AccessDeniedPath = "/account/accessdenided";
                options.SlidingExpiration = true;
            });
            services.AddAuthorization(x =>
            {
                x.AddPolicy("AdminArea", policy => { policy.RequireRole("admin"); });
            });
             services.AddControllersWithViews().SetCompatibilityVersion(CompatibilityVersion.Latest).AddSessionStateTempDataProvider();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) app.UseDeveloperExceptionPage();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseAuthorization();
            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}"); });
        }
    }
}
