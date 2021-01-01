using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MockSchoolManagement.Areas.Business.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockSchoolManagement
{
    public class Startup
    {
        #region inisialize
        private IConfiguration _configuration;
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        #endregion
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc()
                .AddXmlSerializerFormatters();
            services.AddSingleton<IStudentRepository, MockStudentRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,ILogger<Startup> logger)
        {
            if (env.IsDevelopment())
            {
                DeveloperExceptionPageOptions developerExceptionPageOptions = new DeveloperExceptionPageOptions
                {
                    SourceCodeLineCount = 3
                };
                app.UseDeveloperExceptionPage(developerExceptionPageOptions);
            }


            //添加静态文件中间件
            app.UseStaticFiles();

            app.UseRouting();
            //app.UseMvcWithDefaultRoute();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                   name: "default",
                   pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
