using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace DatingApp.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Main method called following method create host builder 
            CreateHostBuilder(args).Build().Run();
        }

        // Following method configure some default. When we start app its going to tell her
        // application to use this thing called a Kestrel web server thats the web server
        // its provided by dot net core thats hosting our API & its going to configure some degfault as well.
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
        // above method does logging, logging has been configured inside this particular method
        // & read configuration files that contain our application settings.
    }
}
