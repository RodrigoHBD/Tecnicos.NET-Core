using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.Hosting;
using UserService.App.Initializer;

namespace UserService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                AppInitializer.Initialize().Wait();
                CreateHostBuilder(args).Build().Run();
            }
            catch (Exception e)
            {
                Console.WriteLine($"FATAL ERROR: {e.Message} ");
                Console.WriteLine($"ERROR STACK TRACE: {e.StackTrace} ");
                Environment.Exit(1);
            }
        }

        
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.ConfigureKestrel(options =>
                    {
                        options.ListenLocalhost(5000, listenOptions =>
                        {
                            listenOptions.Protocols = HttpProtocols.Http2;
                        });
                    });
                    webBuilder.UseStartup<Startup>();
                });
    }
}
