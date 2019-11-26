using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MOD.Paymentservice.Models;
using MOD.TrainingService.Models;
using MOD.Userservice.Models;

namespace MOD.Paymentservice.Context
{
    public class PaymentServiceContext:DbContext
    {
        public PaymentServiceContext(DbContextOptions<PaymentServiceContext> options) : base(options)
        {

        }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Training> Trainings { get; set; }
        public DbSet<Mentor> Mentors { get; set; }
        public DbSet<user> Users { get; set; }


        
    }
}
