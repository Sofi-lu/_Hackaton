using Hackaton.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hackaton.API.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckHackathonEditions();
            await CheckMentor();
            await CheckTeam();
            await CheckParticipants();
            await CheckProject();
            await CheckAssessments();
            await CheckAwards();
        }

        public async Task CheckHackathonEditions()
        {
            if (!_context.HackathonEditions.Any()) {
                _context.HackathonEditions.Add(new Hackathon { Name = "Innovación Verde", StartDate="2024-11-01", EndDate="2024-11-03", topic="Energía Sustentable", organizer="Tech Innovators" });
                _context.HackathonEditions.Add(new Hackathon { Name = "Hackatón Global", StartDate="2024-12-01", EndDate="2024-12-03", topic="Salud Digital", organizer = "InnovateX" });
                _context.HackathonEditions.Add(new Hackathon { Name = "Tecnología Inclusiva", StartDate="2025-01-10", EndDate="2025-01-12", topic="Accesibilidad Digital", organizer = "Code For All" });
                _context.HackathonEditions.Add(new Hackathon { Name = "Innovación Financiera", StartDate="2025-03-15", EndDate="2025-03-17", topic="Fintech y Blockchain", organizer = "Fintech Leaders" });

            }

            await _context.SaveChangesAsync();
        }

        public async Task CheckMentor()
        {
            if (!_context.Mentors.Any())
            {
                _context.Mentors.Add(new Mentor { Name="Sofía González", Experience="Energía Renovable", HackathonID=1});
                _context.Mentors.Add(new Mentor { Name="Pedro Morales", Experience="Salud Digital", HackathonID=2});
                _context.Mentors.Add(new Mentor { Name="Rosa López", Experience="Accesibilidad y Usabilidad", HackathonID=3});
                _context.Mentors.Add(new Mentor { Name="Miguel Torres", Experience="Blockchain y Finanzas", HackathonID=4});

            }

            await _context.SaveChangesAsync();
        }

        public async Task CheckTeam()
        {
            if (!_context.Teams.Any())
            {
                _context.Teams.Add(new Team { Name="GreenTech", memberCount=4, experience="Desarrollo", HackathonID=1});
                _context.Teams.Add(new Team { Name="HealthCoders", memberCount=5, experience="Desarrollo y Diseño", HackathonID=2});
                _context.Teams.Add(new Team { Name="AccessAll", memberCount=3, experience="Inclusión Digital", HackathonID=3});
                _context.Teams.Add(new Team { Name="FinInnovators", memberCount=6, experience="Finanzas y Desarrollo", HackathonID=4});
            }

            await _context.SaveChangesAsync();
        }

        public async Task CheckParticipants()
        {
            if (!_context.Participants.Any())
            {
                _context.Participants.Add(new Participant { Name="Ana Martínez", role="Desarrolladora", TeamID=1 });
                _context.Participants.Add(new Participant { Name="Carlos Rojas", role="Diseñador", TeamID=1 });
                _context.Participants.Add(new Participant { Name="Laura Sánchez", role="Líder de equipo", TeamID=2 });
                _context.Participants.Add(new Participant { Name="Diego Pérez", role="Desarrollador", TeamID=2 });
            }

            await _context.SaveChangesAsync();
        }

        public async Task CheckProject()
        {
            if (!_context.Projects.Any())
            {
                _context.Projects.Add(new Project { Name="SolarSaver", description="Plataforma de ahorro de energía", state="En progreso", dueDate="2024-11-03", TeamID=1});
                _context.Projects.Add(new Project { Name="HealthNow", description="Aplicación de salud digital", state="Finalizado", dueDate="2024-12-03", TeamID=2});
                _context.Projects.Add(new Project { Name="AccessWeb", description="Accesibilidad en sitios web", state="En progreso", dueDate="2025-01-12", TeamID=3});
                _context.Projects.Add(new Project { Name="FinBlocks", description="Plataforma de blockchain", state="En progreso", dueDate="2025-03-17", TeamID=4});


            }

            await _context.SaveChangesAsync();
        }

        public async Task CheckAssessments()
        {
            if (!_context.Assessments.Any())
            {
                _context.Assessments.Add(new Assessment{ Score=85, Feedback="Buen avance en la solución", ProjectID=1, MentorID=1});
                _context.Assessments.Add(new Assessment { Score=90, Feedback="Excelente innovación en salud", ProjectID=2, MentorID=2});
                _context.Assessments.Add(new Assessment { Score=70, Feedback="Faltan detalles de accesibilidad", ProjectID=3, MentorID=3});
                _context.Assessments.Add(new Assessment { Score=95, Feedback="Innovador enfoque financiero", ProjectID=4, MentorID=4});


            }

            await _context.SaveChangesAsync();
        }

        public async Task CheckAwards()
        {
            if (!_context.ProjectAwards.Any())
            {
                _context.ProjectAwards.Add(new ProjectAward { Description="Premio a la Innovación Verde", ProjectID=1, HackathonID=1 });
                _context.ProjectAwards.Add(new ProjectAward { Description="Premio Salud Digital", ProjectID=2, HackathonID=2 });
                _context.ProjectAwards.Add(new ProjectAward { Description="Accesibilidad en Tecnología", ProjectID=3, HackathonID=3 });
                _context.ProjectAwards.Add(new ProjectAward { Description="Fintech Innovador", ProjectID=4, HackathonID=4  });


            }

            await _context.SaveChangesAsync();
        }

    }
}
