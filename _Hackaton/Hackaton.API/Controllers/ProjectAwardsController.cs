using Hackaton.API.Data;
using Hackaton.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hackaton.API.Controllers
{
    [ApiController]
    [Route("/api/awards")]
    public class ProjectAwardsController : ControllerBase
    {
        private readonly DataContext _context;
        public ProjectAwardsController(DataContext context)
        {
            _context = context;

        }

        //get por lista => select * from owners
        [HttpGet]

        public async Task<ActionResult> Get()
        {
            return Ok(await _context.ProjectAwards.ToListAsync());
        }

        // get con parametros
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var ProjectAwards = await _context.ProjectAwards.FirstOrDefaultAsync(x => x.ID==id);
            if (ProjectAwards == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(ProjectAwards);
            }
        }

        //Post para insertar

        [HttpPost]

        public async Task<ActionResult> Post(ProjectAward ProjectAwards)
        {
            _context.Add(ProjectAwards);
            await _context.SaveChangesAsync();
            return Ok(ProjectAwards);
        }

        //Put update
        [HttpPut]

        public async Task<ActionResult> Put(ProjectAward ProjectAwards)
        {
            _context.Update(ProjectAwards);
            await _context.SaveChangesAsync();
            return Ok(ProjectAwards);
        }

        //delete
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var FilasAfectadas = await _context.ProjectAwards.Where(a => a.ID==id).ExecuteDeleteAsync();
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
