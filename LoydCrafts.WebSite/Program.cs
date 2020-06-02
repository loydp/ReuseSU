using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace ReuseSU.WebSite
{
    /// <summary>
    /// The class that supports the program that will be run to support the website
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main method of the class that will run first
        /// </summary>
        /// <param name="args">
        /// Any number of arguments are passed in through the args array
        /// </param>
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// Creates a default host that will use the Startup class to start the website
        /// </summary>
        /// <param name="args">
        /// Any number of arguments will be passed in through the args array
        /// </param>
        /// <returns>
        /// Returns an IHostBuilder type containing the created host builder
        /// </returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}