using System;
using System.IO;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TestSevPhone.Data.DataBaseModel;
using TestSevPhone.Data.EF;

namespace TestSevPhone.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("Config.json");
            var config = builder.Build();
            string connectionString = config.GetConnectionString("DefaultConnection");
            
            var optionsBuilder = new DbContextOptionsBuilder<EFContext>();
            var sqlserver = optionsBuilder.UseSqlServer(connectionString);
            var options = sqlserver.Options;            

            using (EFContext EFContextObj = new EFContext(options))
            {
                var prod = EFContextObj.Products.Count();
                Console.WriteLine($"{prod} - Кол-во продуктов");
            }
        }
    }
}
