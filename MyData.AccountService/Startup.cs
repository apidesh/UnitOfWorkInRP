using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyData.AccountService.BL;
using MyData.AccountService.BL.Interfaces;
using MyData.AccountService.Services;
using MyData.AccountService.Services.Interfaces;
using MyData.Db.Contexts;

namespace MyData.AccountService
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
            services.AddDbContext<MyDataDbContext>(options => options.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"]));
            InjectAllDependencies(services);
            services.AddMvc();
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        private void InjectAllDependencies(IServiceCollection services)
        {
            services.AddScoped<IAccountManagement, AccountManagement>();
            services.AddScoped<IAccountManagementService, AccountManagementService>();
            // services.AddScoped<IAccountManagement, AccountManagement>();
        }
    }
}