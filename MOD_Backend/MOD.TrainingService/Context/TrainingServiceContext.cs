using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MOD.TrainingService.Models;
using MOD.Userservice.Models;

namespace MOD.TrainingService.Context
{
    public class TrainingServiceContext:DbContext
    {
        public TrainingServiceContext(DbContextOptions<TrainingServiceContext> options): base(options)
        {

        }
       
       
        public DbSet<Training> Trainings { get; set; }
        public DbSet<Mentor> Mentors { get; set; }
        public DbSet<user> Users { get; set; }
        
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Payment> Payments { get; set; }
    }
}
