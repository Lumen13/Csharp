﻿using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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
    
        public class ApplicationContext : DbContext
        {
            public DbSet<User> Users { get; set; }

            public ApplicationContext()
            {
                Database.EnsureCreated();
            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("data source=localhost;" +
                    "initial catalog=TestAppDb;" +
                    "Integrated Security=True;");
            }
        }    

        static void Main(string[] args)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                // создаем три объекта User
                User user1 = new User { Name = "Tom", Age = 33 };
                User user2 = new User { Name = "Alice", Age = 26 };
                User user3 = new User { Name = "Jack", Age = 30 };

                // добавляем их в бд
                db.Users.Add(user1);
                db.Users.Add(user2);
                db.Users.Add(user3);
                db.SaveChanges();
                Console.WriteLine("Объекты успешно сохранены");

                // получаем объекты из бд и выводим на консоль
                var users = db.Users.ToList();
                Console.WriteLine("Список объектов:");
                foreach (User u in users)
                {
                    Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
                }
            }
            Console.Read();
        }
    }
}
