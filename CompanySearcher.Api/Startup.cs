using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompanySearcher.Api.Data;
using CompanySearcher.Api.Repositories;
using CompanySearcher.Api.Repositories.Interfaces;
using CompanySearcher.Api.Services;
using CompanySearcher.Api.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace CompanySearcher.Api
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
            services.AddMvc();
            services.AddCors();
            services.AddDbContext<ApplicationDbContext>
                (options => options.UseSqlServer((Configuration.GetSection("ConnectionString:DefaultConnection")).Value));

            services.AddSingleton(AutoMapperConfig.Initialize());
            services.AddScoped<IDbInitializer, DbInitializer>();                
            services.AddScoped<ICompanyRepository, CompanyRepository>();
            services.AddScoped<ICompanyService, CompanyService>();
            services.AddScoped<ILogRepository, LogRepository>();
            services.AddScoped<ILogService, LogService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IDbInitializer dbInitializer)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                dbInitializer.Initialize().Wait();
            }

            app.UseCors(
                options => options.WithOrigins("http://localhost:8080").AllowAnyMethod()
            );

            app.UseMvc();
        }
    }
}
