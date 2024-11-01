using Hackaton.API.Controllers;
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
        public DbSet<Team> Teams { get; set; }
        public DbSet<ProjectAward> ProjectAwards { get; set; }
        public DbSet<Assessment> Assessments { get; set; }
        public DbSet<HackathonEdition> HackathonEditions { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<HackathonEdition>().HasKey(h => h.ID_Hackathon); 
            modelBuilder.Entity<Assessment>().HasKey(h => h.ID_Assessment);
            modelBuilder.Entity<Mentor>().HasKey(h => h.ID_Mentor);
            modelBuilder.Entity<Participant>().HasKey(h => h.ID_Participant);
            modelBuilder.Entity<Project>().HasKey(h => h.ID_Project);
            modelBuilder.Entity<ProjectAward>().HasKey(h => h.ID_Award);
            modelBuilder.Entity<Team>().HasKey(h => h.ID_Team);

            modelBuilder.Entity<Team>()
                .HasOne(t => t.HackathonEdition)
                .WithMany(h => h.Teams)
                .HasForeignKey(t => t.ID_Hackathon);

            modelBuilder.Entity<Participant>()
                .HasOne(p => p.Team)
                .WithMany(t => t.Participants)
                .HasForeignKey(p => p.ID_Team);

            modelBuilder.Entity<Mentor>()
                .HasOne(m => m.HackathonEdition)
                .WithMany(h => h.Mentors)
                .HasForeignKey(m => m.ID_Hackathon);

            modelBuilder.Entity<Project>()
                .HasOne(p => p.Team)
                .WithOne() 
                .HasForeignKey<Project>(p => p.ID_Team);

            modelBuilder.Entity<Assessment>()
                .HasOne(a => a.Project)
                .WithMany(p => p.Assessments)
                .HasForeignKey(a => a.ID_Project);

            modelBuilder.Entity<Assessment>()
                .HasOne(a => a.Mentor)
                .WithMany(m => m.assessments)
                .HasForeignKey(a => a.ID_Mentor);

            modelBuilder.Entity<ProjectAward>()
                .HasOne(pa => pa.Project)
                .WithOne()
                .HasForeignKey<Project>(p => p.ID_Project);

            modelBuilder.Entity<ProjectAward>()
                .HasOne(pa => pa.HackathonEdition)
                .WithMany(h => h.Awards)
                .HasForeignKey(pa => pa.ID_Hackathon);
        }
    }
    }
}
