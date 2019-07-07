using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace VideoChatApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebHostExtensions.Run(CreateWebHostBuilder(args).Build());
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHostBuilderExtensions.UseStartup<Startup>(WebHost.CreateDefaultBuilder(args));
    }
}
