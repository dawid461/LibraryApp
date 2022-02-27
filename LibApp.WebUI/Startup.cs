using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using LibApp.Application;
using LibApp.Persistence;
using LibApp.WebUI.Profiles;
using LibApp.Domain.Enums;

namespace LibApp.WebUI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages().AddRazorRuntimeCompilation();
            services.AddControllersWithViews();
            services.AddDatabaseDeveloperPageExceptionFilter();
            services.ReisterApplication(Configuration);
            services.ReisterPersistence(Configuration);
            services.AddAutoMapper(typeof(MappingProfiles).Assembly);

            services.AddAuthorization(opt =>
            {
                opt.AddPolicy("AdminAccess", policy =>
                {
                    policy.RequireRole(RoleEnum.Owner.ToString());
                });

                opt.AddPolicy("EditAccess", policy =>
                {
                    policy.RequireAssertion(context => context.User.IsInRole(RoleEnum.StoreManager.ToString())
                    || context.User.IsInRole(RoleEnum.Owner.ToString()));
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
