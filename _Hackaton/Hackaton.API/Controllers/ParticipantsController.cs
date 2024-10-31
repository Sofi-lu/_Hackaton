using Hackaton.API.Data;
using Hackaton.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hackaton.API.Controllers
{
    [ApiController]
    [Route("/api/participants")]
    public class ParticipantsController : ControllerBase
    {
        private readonly DataContext _context;
        public ParticipantsController(DataContext context)
        {
            _context = context;

        }

        //get por lista => select * from owners
        [HttpGet]

        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Participants.ToListAsync());
        }

        // get con parametros
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var Participant = await _context.Participants.FirstOrDefaultAsync(x => x.Id==id);
            if (Participant == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(Participant);
            }
        }

        //Post para insertar

        [HttpPost]

        public async Task<ActionResult> Post(Participant Participant)
        {
            _context.Add(Participant);
            await _context.SaveChangesAsync();
            return Ok(Participant);
        }

        //Put update
        [HttpPut]

        public async Task<ActionResult> Put(Participant Participant)
        {
            _context.Update(Participant);
            await _context.SaveChangesAsync();
            return Ok(Participant);
        }

        //delete
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var FilasAfectadas = await _context.Participants.Where(a => a.Id==id).ExecuteDeleteAsync();
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
