using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MOD.Technologyservice.Models;
using MOD.TrainingService.Models;
using MOD.Userservice.Models;

namespace MOD.Technologyservice.Context
{
    public class TechnologyServiceContext:DbContext
    {
        public TechnologyServiceContext(DbContextOptions<TechnologyServiceContext> options):base(options)
        {

        }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Training> Trainings { get; set; }
        public DbSet<Mentor> Mentors { get; set; }
        public DbSet<user> Users { get; set; }

        
        public DbSet<Payment> Payments { get; set; }

    }
}
