using Hackaton.API.Data;
using Hackaton.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hackaton.API.Controllers
{
    [ApiController]
    [Route("/api/editions")]
    public class HackatonEditionsController : ControllerBase
    {
        private readonly DataContext _context;


        public HackatonEditionsController(DataContext context)
        {
            _context = context;

        }

        //get por lista => select * from owners
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.hackathonEditions.ToListAsync());
        }

        // get con parametros
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var mentor = await _context.hackathonEditions.FirstOrDefaultAsync(x => x.Id==id);
            if (mentor == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(mentor);
            }
        }

        //Post para insertar

        [HttpPost]

        public async Task<ActionResult> Post(Assessment assessment)
        {
            _context.Add(assessment);
            await _context.SaveChangesAsync();
            return Ok(assessment);
        }

        //Put update
        [HttpPut]

        public async Task<ActionResult> Put(Assessment assessment)
        {
            _context.Update(assessment);
            await _context.SaveChangesAsync();
            return Ok(assessment);
        }

        //delete
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var FilasAfectadas = await _context.Mentors.Where(a => a.Id==id).ExecuteDeleteAsync();
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
