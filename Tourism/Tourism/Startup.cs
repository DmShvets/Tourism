using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tourism.Data;
using Tourism.Data.interfaces;
using Tourism.Data.mocks;
using Tourism.Data.Repository;

namespace Tourism
{
    public class Startup
    {

        private IConfigurationRoot _confstring;

        public Startup(IHostingEnvironment hostingEnvironment)
        {
            _confstring = new ConfigurationBuilder().SetBasePath(hostingEnvironment.ContentRootPath).AddJsonFile("dbsettings.json").Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDBContent>(options => options.UseSqlServer(_confstring.GetConnectionString("DefaultConnection")));
            services.AddTransient<IAllRegions, RegionRepository>();
            services.AddTransient<IRegionCategory, CategoryRepository>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            //app.UseMvcWithDefaultRoute();
            app.UseMvc(routes =>
            {
                routes.MapRoute(name: "default", template: "{controller=Home}/{action=Index}/{id?}");
                routes.MapRoute(name: "categoryFilter", template: "{controller=Regions}/{action}/{category?}");

            });

            using (var Scope = app.ApplicationServices.CreateScope())
            {
                AppDBContent content = Scope.ServiceProvider.GetRequiredService<AppDBContent>();
                DBObjects.Initaial(content);
            } 
        }
    }
}
