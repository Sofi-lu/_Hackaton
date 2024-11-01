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
                _context.HackathonEditions.Add(new HackathonEdition { Name = "Innovación Verde", StartDate="2024-11-01", EndDate="2024-11-03", topic="Energía Sustentable", organizer="Tech Innovators" });
                _context.HackathonEditions.Add(new HackathonEdition { Name = "Hackatón Global", StartDate="2024-12-01", EndDate="2024-12-03", topic="Salud Digital", organizer = "InnovateX" });
                _context.HackathonEditions.Add(new HackathonEdition { Name = "Tecnología Inclusiva", StartDate="2025-01-10", EndDate="2025-01-12", topic="Accesibilidad Digital", organizer = "Code For All" });
                _context.HackathonEditions.Add(new HackathonEdition { Name = "Innovación Financiera", StartDate="2025-03-15", EndDate="2025-03-17", topic="Fintech y Blockchain", organizer = "Fintech Leaders" });

            }

            await _context.SaveChangesAsync();
        }

        public async Task CheckMentor()
        {
            if (!_context.Mentors.Any())
            {
                _context.Mentors.Add(new Mentor { Name="Sofía González", Experience="Energía Renovable", ID_Hackathon=1});
                _context.Mentors.Add(new Mentor { Name="Pedro Morales", Experience="Salud Digital", ID_Hackathon=2});
                _context.Mentors.Add(new Mentor { Name="Rosa López", Experience="Accesibilidad y Usabilidad", ID_Hackathon=3});
                _context.Mentors.Add(new Mentor { Name="Miguel Torres", Experience="Blockchain y Finanzas", ID_Hackathon=4});

            }

            await _context.SaveChangesAsync();
        }

        public async Task CheckTeam()
        {
            if (!_context.Teams.Any())
            {
                _context.Teams.Add(new Team { Name="GreenTech", memberCount=4, experience="Desarrollo", ID_Hackathon=1});
                _context.Teams.Add(new Team { Name="HealthCoders", memberCount=5, experience="Desarrollo y Diseño", ID_Hackathon=2});
                _context.Teams.Add(new Team { Name="AccessAll", memberCount=3, experience="Inclusión Digital", ID_Hackathon=3});
                _context.Teams.Add(new Team { Name="FinInnovators", memberCount=6, experience="Finanzas y Desarrollo", ID_Hackathon=4});
            }

            await _context.SaveChangesAsync();
        }

        public async Task CheckParticipants()
        {
            if (!_context.Participants.Any())
            {
                _context.Participants.Add(new Participant { Name="Ana Martínez", role="Desarrolladora", ID_Team=1 });
                _context.Participants.Add(new Participant { Name="Carlos Rojas", role="Diseñador", ID_Team=1 });
                _context.Participants.Add(new Participant { Name="Laura Sánchez", role="Líder de equipo", ID_Team=2 });
                _context.Participants.Add(new Participant { Name="Diego Pérez", role="Desarrollador", ID_Team=2 });
            }

            await _context.SaveChangesAsync();
        }

        public async Task CheckProject()
        {
            if (!_context.Projects.Any())
            {
                _context.Projects.Add(new Project { Name="SolarSaver", description="Plataforma de ahorro de energía", state="En progreso", dueDate="2024-11-03", ID_Team=1});
                _context.Projects.Add(new Project { Name="HealthNow", description="Aplicación de salud digital", state="Finalizado", dueDate="2024-12-03", ID_Team=2});
                _context.Projects.Add(new Project { Name="AccessWeb", description="Accesibilidad en sitios web", state="En progreso", dueDate="2025-01-12", ID_Team=3});
                _context.Projects.Add(new Project { Name="FinBlocks", description="Plataforma de blockchain", state="En progreso", dueDate="2025-03-17", ID_Team=4});


            }

            await _context.SaveChangesAsync();
        }

        public async Task CheckAssessments()
        {
            if (!_context.Assessments.Any())
            {
                _context.Assessments.Add(new Assessment{ Score=85, Feedback="Buen avance en la solución", ID_Project=1, ID_Mentor=1});
                _context.Assessments.Add(new Assessment { Score=90, Feedback="Excelente innovación en salud", ID_Project=2, ID_Mentor=2});
                _context.Assessments.Add(new Assessment { Score=70, Feedback="Faltan detalles de accesibilidad", ID_Project=3, ID_Mentor=3});
                _context.Assessments.Add(new Assessment { Score=95, Feedback="Innovador enfoque financiero", ID_Project=4, ID_Mentor=4});


            }

            await _context.SaveChangesAsync();
        }

        public async Task CheckAwards()
        {
            if (!_context.ProjectAwards.Any())
            {
                _context.ProjectAwards.Add(new ProjectAward { Description="Premio a la Innovación Verde", ID_Project=1, ID_Hackathon=1 });
                _context.ProjectAwards.Add(new ProjectAward { Description="Premio Salud Digital", ID_Project=2, ID_Hackathon=2 });
                _context.ProjectAwards.Add(new ProjectAward { Description="Accesibilidad en Tecnología", ID_Project=3, ID_Hackathon=3 });
                _context.ProjectAwards.Add(new ProjectAward { Description="Fintech Innovador", ID_Project=4, ID_Hackathon=4  });


            }

            await _context.SaveChangesAsync();
        }

    }
}
