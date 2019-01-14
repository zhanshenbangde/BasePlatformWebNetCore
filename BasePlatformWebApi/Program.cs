using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BasePlatformWebApi.Models;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace BasePlatformWebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MySqlDbConetxt ct = new MySqlDbConetxt();
            var data = ct.CapPublished.FirstOrDefault();
            data.StatusName = "adaaaaaaaaaaaaaaa";
            ct.SaveChanges();
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
