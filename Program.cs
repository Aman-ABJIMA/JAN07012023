using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace WEB_API
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            //Console.WriteLine("Hello, World!");
        }
        public static IHostBuilder CreateHostBuilder(string[] args)
       => Host.CreateDefaultBuilder(args)
           .ConfigureWebHostDefaults(webHost => { webHost.UseStartup<Startup>(); });
    }
}