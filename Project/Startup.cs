using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using JsonApiDotNetCore.Extensions;

namespace _JADNC.App
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
          services.AddDbContext<SampleDbContext>(options => {
            options.UseSqlite("Data Source=sample.db");
          });

          services.AddJsonApi<SampleDbContext>(options => {
            options.Namespace = "api";
          });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, SampleDbContext context)
        {
            if (env.IsDevelopment())
            {
              app.UseDeveloperExceptionPage();
            }

            context.Database.EnsureCreated();
            if(!context.SampleModels.Any())
            {
              context.SampleModels.Add(new SampleModel {
                StringData = "Foobar",
                IntegerData = 9876,
              });

              context.SaveChanges();
            }

            app.UseJsonApi();
        }
    }
}
