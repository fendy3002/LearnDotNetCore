using System;
using System.IO;
using System.Collections.Generic;

using Microsoft.Extensions.Configuration;

namespace consoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            new Paths.PathTest().Run();
            new JSON.Access().Run();
            
            Console.WriteLine(Directory.GetCurrentDirectory());

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            var Configuration = builder.Build();

            // var json = JsonConvert.SerializeObject(Configuration);
            // Console.WriteLine("yourObject:" + json + "<br/>");

            // var jedi = Configuration.GetSection("Jedi").AsEnumerable();
            // json = JsonConvert.SerializeObject(jedi);
            // Console.WriteLine("yourObject:" + json + "<br/>");

            // json = JsonConvert.SerializeObject(Configuration["Country"]);
            // Console.WriteLine("yourObject:" + json + "<br/>");

        }
    }
}
