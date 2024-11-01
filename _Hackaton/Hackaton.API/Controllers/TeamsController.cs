using Hackaton.API.Data;
using Hackaton.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hackaton.API.Controllers
{
    [ApiController]
    [Route("/api/teams")]
    public class TeamsController : ControllerBase
    {
        private readonly DataContext _context;
        public TeamsController(DataContext context)
        {
            _context = context;

        }

        //get por lista => select * from owners
        [HttpGet]

        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Teams.ToListAsync());
        }

        // get con parametros
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var Teams = await _context.Teams.FirstOrDefaultAsync(x => x.ID==id);
            if (Teams == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(Teams);
            }
        }

        //Post para insertar

        [HttpPost]

        public async Task<ActionResult> Post(Team Teams)
        {
            _context.Add(Teams);
            await _context.SaveChangesAsync();
            return Ok(Teams);
        }

        //Put update
        [HttpPut]

        public async Task<ActionResult> Put(Team Teams)
        {
            _context.Update(Teams);
            await _context.SaveChangesAsync();
            return Ok(Teams);
        }

        //delete
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var FilasAfectadas = await _context.Teams.Where(a => a.ID==id).ExecuteDeleteAsync();
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
