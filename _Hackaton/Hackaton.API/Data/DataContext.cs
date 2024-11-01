using Hackaton.API.Controllers;
using Hackaton.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hackaton.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Mentor> Mentors { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<ProjectAward> ProjectAwards { get; set; }
        public DbSet<Assessment> Assessments { get; set; }
        public DbSet<Hackathon> HackathonEditions { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Hackathon>().HasKey(h => h.ID);
            modelBuilder.Entity<Assessment>().HasKey(h => h.ID);
            modelBuilder.Entity<Mentor>().HasKey(h => h.ID);
            modelBuilder.Entity<Participant>().HasKey(h => h.ID);
            modelBuilder.Entity<Project>().HasKey(h => h.ID);
            modelBuilder.Entity<ProjectAward>().HasKey(h => h.ID);
            modelBuilder.Entity<Team>().HasKey(h => h.ID);

            

        }
    }

}
