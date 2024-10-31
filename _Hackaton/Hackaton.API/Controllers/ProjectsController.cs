using Hackaton.API.Data;
using Hackaton.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hackaton.API.Controllers
{
    [ApiController]
    [Route("/api/projects")]
    public class ProjectsController : ControllerBase
    {
        private readonly DataContext _context;
        public ProjectsController(DataContext context)
        {
            _context = context;

        }

        //get por lista => select * from owners
        [HttpGet]

        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Projects.ToListAsync());
        }

        // get con parametros
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var project = await _context.Projects.FirstOrDefaultAsync(x => x.ID_Project==id);
            if (project == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(project);
            }
        }

        //Post para insertar

        [HttpPost]

        public async Task<ActionResult> Post(Project project)
        {
            _context.Add(project);
            await _context.SaveChangesAsync();
            return Ok(project);
        }

        //Put update
        [HttpPut]

        public async Task<ActionResult> Put(Project project)
        {
            _context.Update(project);
            await _context.SaveChangesAsync();
            return Ok(project);
        }

        //delete
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var FilasAfectadas = await _context.Projects.Where(a => a.ID_Project==id).ExecuteDeleteAsync();
            if (FilasAfectadas == 0)
            {
                return NotFound();
            }
            else
            {
                return NoContent();
            }
        }
    }
}
