
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MusicBox.API
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection service)
        {
            service.AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
                // .AddJsonOptions(opt => {
                //     opt.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                // });
        }
        public void Configure(IApplicationBuilder application, IHostingEnvironment environment)
        {
            if (environment.IsDevelopment())
            {
                application.UseDeveloperExceptionPage();
            }
            
            application.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            application.UseMvc();
        }
    }
}