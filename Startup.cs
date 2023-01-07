using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace WEB_API
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();


        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync("Hello Run Class\n");
            //});
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                  endpoints.MapControllers();
                //endpoints.MapGet("/",async context =>
                //{
                //   await context.Response.WriteAsync("hello from new web API app");
                //});

            });
            
        }
    }
}
