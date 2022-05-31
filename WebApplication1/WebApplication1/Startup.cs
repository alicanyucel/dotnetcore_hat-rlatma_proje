using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
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
            services.AddControllersWithViews(options => options.EnableEndpointRouting = false);
            services.AddMvc();
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }
            // www root içindeki css,html,image gibi dosyalarý projede görebilmek için ekliyoruz
            app.UseStaticFiles();

            app.UseStaticFiles();
            
            app.UseRouting();

            app.UseAuthorization();

            //controller/aciton gibi bir default route oluþturur   app.UseMvcWithDefaultRoute();
            // aþaðýda kendimiz bir route yapýsý tanýmladýk            
            //default deðerlerini verdik//
            app.UseMvc(routes => {
                routes.MapRoute(
                name: "default",
            template: "{controller=home}/{action=index}/{id?}");
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
