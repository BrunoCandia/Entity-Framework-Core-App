using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Entity_Framework_Core_App.Data;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Entity_Framework_Core_App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();

            //var host = CreateWebHostBuilder(args).Build();
            //using (var newScope = host.Services.CreateScope())
            //{
            //    var context = newScope.ServiceProvider.GetRequiredService<AppDbContext>();
            //    DbInit.InitializeWithFakeData(context);
            //}

            //host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
