using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MVC_application
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseExceptionHandler("/error.html");
            var configuration = new ConfigurationBuilder()
                                   .AddEnvironmentVariables()
                                   .AddJsonFile(env.ContentRootPath + "/myconfig.json") // could use this as default one
                                   .AddJsonFile(env.ContentRootPath + "/otherconfig.development.json", true) // the second parameter mean this fild is optional if exit use it this one instead
                                   .Build();

            if (configuration.GetValue<bool>("FeatureToggle:EnableDevelopment"))
            {
                app.UseDeveloperExceptionPage();
            }

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!"); // 
            //});
            app.Use(async (context, next) =>
            {
                if(context.Request.Path.Value.Contains("invaild")) //if my URL path is localhost<portnumber>/Invaild will give me a error page 
                {
                    throw new Exception("Error!");
                }
                await next();
            });
            app.UseFileServer();
        }
    }
}
