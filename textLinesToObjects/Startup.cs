using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using textLinesToObjects.Context;


using Pomelo.EntityFrameworkCore.MySql.Infrastructure;//### for mysql 

namespace textLinesToObjects
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

            services.AddControllers();
            services.AddMvc(options => options.EnableEndpointRouting = false)
       // .AddNewtonsoftJson()
       .AddXmlSerializerFormatters();// above controller action _ [Produces("application/xml")] _ for xml format response other than json format

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "textLinesToObjects", Version = "v1" });
            });

            //### for mysql

            services.AddDbContextPool<appDBContext>(
        options => options.UseMySql(Configuration.GetConnectionString("DBConn"), new MySqlServerVersion("5.7.27")));
            //services.AddMvc();

            //services.AddTransient<MySqlConnection>(_ => new MySqlConnection(Configuration["ConnectionStrings:DBConn"]));

            /*
            //for sqlserver
            services.AddDbContext<appDBContext>(options =>
       options.UseSqlServer(Configuration.GetConnectionString("DBConnection")));
*/

            // services.AddTransient<MySqlConnection>(_ => new MySqlConnection(Configuration["ConnectionStrings:Default"]));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "textLinesToObjects v1"));
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
