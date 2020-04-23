using CoffeeShop.Domain;
using CoffeeShop.Settings;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MySql.Data.MySqlClient;

namespace CoffeeShop
{
    public class Startup
    {
        /// <summary>
        /// Application settings (read from appsettings.json)
        /// </summary>
        public AppSettings AppSettings { get; set; }
        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            Configuration = configuration;
            Env = env;
        }

        public IWebHostEnvironment Env { get; set; }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            IMvcBuilder builder = services.AddRazorPages();

            if (Env.IsDevelopment())
            {
              //  builder.AddRazorRuntimeCompilation();
            }
            services.AddRazorPages().AddRazorRuntimeCompilation();
            services.AddMvc();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

            // Get appsettings
            var appSettingsConfigurationSection = Configuration.GetSection(typeof(AppSettings).Name);
            AppSettings = appSettingsConfigurationSection.Get<AppSettings>();
            services.Configure<AppSettings>(appSettingsConfigurationSection);

            // Setting database
            services.AddScoped(_ => new MySqlConnection(AppSettings.ConnectionStrings));

            // Create repository
            services.UseRepositoryExtension();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
