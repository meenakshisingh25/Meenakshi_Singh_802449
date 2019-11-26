using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MOD.Userservice.Models;

namespace MOD.Userservice.Contextin
{
    public class UserServiceContext:DbContext
    {
        public UserServiceContext(DbContextOptions<UserServiceContext> options):base(options)
        {

        }
        public DbSet<Mentor> Mentors { get; set; }
        public DbSet<user> Users { get; set; }
        public DbSet<Training> Trainings { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Payment> Payments { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=DESKTOP-3KCKKGT\MEENAKSHI;Database=Mentor_On_Demand;Trusted_Connection=True;");
        //}

    }
}
