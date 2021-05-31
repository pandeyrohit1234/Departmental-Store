using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDepartmentalStore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //DataInsert.AddRole();
            //  DataInsert.AddAddress();
            // DataInsert.AddStaff();
            //DataInsert.AddProduct();
            //DataInsert.AddCategory();
            //DataInsert.AddProductCategory();
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
