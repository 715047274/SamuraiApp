using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using SamuraiApp.Data;
using SamuraiApp.UI.Controllers;
using IConfiguration = Castle.Core.Configuration.IConfiguration;

namespace SamuraiApp.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Execute(x => x.CreateSamuraiByName("test"));
            Execute(x => x.CreateSamuraiWithHorseByName("test2","horseName"));
        }



        public static string Execute(Func<SamuraiController, string> func)
        {
            using (var context = new SamuraiContext())
            {
                var controller = new SamuraiController(context);
                return func(controller);
            }
        }

        public static string GetConnectionString()
        {
            string fileName = "appsettings.json";
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(fileName).Build();
            return configuration["ConnectionString"];
        }
    }
}
