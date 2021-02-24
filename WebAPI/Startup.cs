using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using ReCapProject1.Business;
using ReCapProject1.Business.Abstract;
using ReCapProject1.Business.Concrete;
using ReCapProject1.DataAccess;
using ReCapProject1.DataAccess.Abstract;
using ReCapProject1.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI
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
            services.AddSingleton<ICarService, CarManager>();
            services.AddSingleton<ICarDal, EfCarDal>();

            services.AddSingleton<IColorService, ColorManager>();
            services.AddSingleton<IColorDal, EfColorDal>();

            services.AddSingleton<IBrandService, BrandManager>();
            services.AddSingleton<IBrandDal, EfBrandDal>();

            services.AddSingleton<ICustomerService, CustomerManager>();
            services.AddSingleton<ICustomersDal, EfCustomersDal>();

            services.AddSingleton<IRentalsService, RentalsManager>();
            services.AddSingleton<IRentalsDal, EfRentalsDal>();

            services.AddSingleton<IUsersService, UsersManager>();
            services.AddSingleton<IUsersDal, EfUsersDal>();

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebAPI", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebAPI v1"));
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
