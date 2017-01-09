using Ecat.DataLib.Context;
using Ecat.LogicLib.Interfaces;
using Ecat.LogicLib.User;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Ecat.ModelLib.Utility.Configuration;

namespace Ecat.WebApp
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            //builder.AddUserSecrets();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<EcAppConfig>(Configuration.GetSection("AppConfig"));
            var connectionString = Configuration["DbConnection"];
            services.AddScoped(_ => new ContextUser(connectionString));
            services.AddScoped(_ => new EcEfContext<ContextUser>(connectionString));
            services.AddScoped(_ => new ContextSchool(connectionString));
            services.AddScoped(_ => new EcEfContext<ContextSchool>(connectionString));
            services.AddScoped<IUserLogic, UserLogic>();
            // Add framework services.
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseMvc();
        }
    }
}
