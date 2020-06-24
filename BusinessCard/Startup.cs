namespace BusinessCard
{
    using BusinessCard.Data;
    using BusinessCard.Insfrastructure.Data;
    using BusinessCard.Insfrastructure.Providers;
    using BusinessCard.Options;
    using BusinessCard.Providers;
    using BusinessCard.Services.Badges;
    using BusinessCard.Services.Badges.Repository;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Http;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;

    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddSingleton<IDbConnectionStringProvider, DbConnectionStringProvider>();

            var connectionString = this.Configuration.GetSection("DbConnectionString").Get<DbConnectionString>();

            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString.Database));

            services.AddScoped<IAppDbContext, ApplicationDbContext>();
            services.AddScoped<IBadgesRepository, BadgesRepository>();
            services.AddScoped<IBadgeService, BadgeService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(x => x
              .AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader());

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();

                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("It works!");
                });
            });
        }
    }
}
