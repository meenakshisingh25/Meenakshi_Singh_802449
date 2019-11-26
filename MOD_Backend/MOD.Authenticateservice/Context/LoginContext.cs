using Microsoft.EntityFrameworkCore;
using MOD.Authenticateservice.Models;

namespace MOD.Authenticateservice.Context
{
    public class LoginContext : DbContext
    {
        public LoginContext(DbContextOptions<LoginContext> options) : base(options)
        {

        }
        public DbSet<user> Users { get; set; }

        public DbSet<Mentor> Mentors { get; set; }
    }
}
