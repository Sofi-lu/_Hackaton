using Hackaton.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hackaton.API.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
            
        }
        
        public DbSet<Mentor> Mentors { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Team> teams { get; set; }
        public DbSet<ProjectAward> projectAwards { get; set; }
        public DbSet<Assessment> assessments { get; set; }
        public DbSet<HackathonEdition> hackathonEditions { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
