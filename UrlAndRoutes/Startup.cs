﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace UrlAndRoutes
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            app.UseStatusCodePages();
            app.UseDeveloperExceptionPage();
            app.UseStaticFiles();
            app.UseMvc(routes =>
            {
                routes.MapRoute(name: "MyRouteCatchAll",template: "{controller=Home}/{action=Index}/{id?}/{*catchall}");
                    routes.MapRoute(name: "MyRouteOptional",template: "{controller=Home}/{action=Index}/{id?}");
                routes.MapRoute(name: "MyRoute", template: "{controller=Home}/{action=Index}/{id=DedaultId}");
                routes.MapRoute("", "X{controller}/{action}");
                routes.MapRoute(name: "default", template: "{controller=Admin}/{action=Index}");
                routes.MapRoute(name: "",template: "Public/{controller=Home}/{action=Index}");
            });
        }
    }
}
