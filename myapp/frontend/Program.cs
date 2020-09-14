using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace frontend
{
    public class Program
    {
        [Obsolete]
        public static void Main(string[] args)
        {
           /* ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls12 |
        SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;*/
            CreateHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args).UseContentRoot(Path.Combine(Directory.GetCurrentDirectory())).UseStartup<Startup>();
             
    }
}
