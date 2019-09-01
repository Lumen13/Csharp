using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
//using System.ComponentModel.DataAnnotations;
using System.IO;
using System.ComponentModel.DataAnnotations.Schema;

namespace HelloApp
{
    class Program
    {
        public class User
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
        }
        public class Phone
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Price { get; set; }
            // навигационное свойство
            
            public int CompanyId { get; set; }
            public Company Manufacturer { get; set; }
            
        }

        public class Company
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public class Tablet
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Price { get; set; }
            public string Test { get; set; }
        }
    
        public class ApplicationContext : DbContext
        {
            public DbSet<Phone> Phones { get; set; }
            public DbSet<User> Users { get; set; }
            public DbSet<Tablet> Tablets { get; set; }

            public ApplicationContext(DbContextOptions<ApplicationContext> options)
                :base(options)
            {
                Database.EnsureCreated();
            }

            /*protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                // использование Fluent API
                base.OnModelCreating(modelBuilder);
            }*/
        }    

        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder();

            // установка пути к текущему каталогу
            builder.SetBasePath(Directory.GetCurrentDirectory());
            // получаем конфигурацию из файла appsettings.json
            builder.AddJsonFile("AppConfig.json");
            // создаем конфигурацию
            var config = builder.Build();
            // получаем строку подключения
            string connectionString = config.GetConnectionString("DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            var options = optionsBuilder
                .UseSqlServer(connectionString)
                .Options;

            using (ApplicationContext db = new ApplicationContext(options))
            {
                var users = db.Users.ToList();
                foreach (User u in users)
                {
                    Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
                }
            }

            using (ApplicationContext db = new ApplicationContext(options))
            {
                var phones = db.Phones.ToList();
                foreach (Phone p in phones)
                {
                    Console.WriteLine($"{p.Id}.{p.Name} - {p.Price}.{p.Manufacturer}");
                }
            }

            Console.Read();
        }
    }
}
