using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW2
{
    public class HwContext : DbContext
    {
        public HwContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-TALUG4B\SQLEXPRESS;Database=Profile;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User
            {
                FullName="Хаха Хехеевич",
                HobbyList="Играца и гулять",
                Login="hehe.haha",
                ImagePath="ava1.jpg"
            });
        }
    }
}
