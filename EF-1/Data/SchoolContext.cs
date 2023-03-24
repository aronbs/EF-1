using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_1.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_1.Data
{
    public class SchoolContext : DbContext
    {

        public DbSet<Group> Groups { get; set; }

        public DbSet<Marks> Marks { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Subject> Subjects { get; set; }

        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=SchoolDB;Trusted_Connection=True");
        }
    }
}
