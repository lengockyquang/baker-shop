using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BakerShopApp.Interface;
using BakerShopApp.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using TodoApp.Models;
using static BakerShopApp.Interface.SomeInterfaces;

namespace BakerShopApp
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

            services.AddDbContext<ApiContext>(options =>
          options.UseSqlServer(Configuration.GetConnectionString("DevConnection")), ServiceLifetime.Transient);


            services.AddControllers();
            //services.AddTransient<IProductService, ProductService>();
            //services.AddTransient<IProductService, BetterProductService>();

            //services.AddTransient<ITransientService, SomeService>();
            //services.AddScoped<IScopedService, SomeService>();
            //services.AddSingleton<ISingletonService, SomeService>();


            services.AddScoped<IGroupService, GroupService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
