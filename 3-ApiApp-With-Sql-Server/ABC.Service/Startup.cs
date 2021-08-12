using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ABC.Business.Abstract;
using ABC.Business.Concrete;
using ABC.DAL.Abstract;
using ABC.DAL.EF.Concrete;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Ttar.DAL.Concrete;

namespace ABC.Service
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
            //services.AddDbContext<EfContext>(options => options.UseSqlServer(Configuration.GetConnectionString("SqlConnection")));

            services.AddScoped<ICompanyDal, CompanyDal>();
            services.AddScoped<ICompanyManager, CompanyManager>();

        }

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
