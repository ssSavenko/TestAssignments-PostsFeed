using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using TestAssigment.Models.DAL;

namespace TestAssigment
{
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

            services.AddCors(options=>
            {
                options.AddDefaultPolicy(builder =>
                {
                    builder.AllowAnyOrigin();
                    builder.AllowAnyMethod();
                    builder.AllowAnyHeader();
                });
            });
            DbContextOptionsBuilder contextBuilder = new DbContextOptionsBuilder();
           
            services.AddDbContext<DatabseContext>( 
                ob => ob.UseSqlServer(Configuration.GetConnectionString("PostsNComments"),
                    sso => sso.MigrationsAssembly(Assembly.GetExecutingAssembly().GetName().Name)));

             
        }
         
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env , IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            serviceProvider.GetService<Models.DAL.DatabseContext>()
                .Database.GetService<IMigrator>()
                .Migrate(Configuration.GetValue<string>("Migrations"));
        }
    }
}
