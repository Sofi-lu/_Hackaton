﻿using Hackaton.API.Data;
using Hackaton.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hackaton.API.Controllers
{
    [ApiController]
    [Route("/api/editions")]
    public class HackathonEditionsController : ControllerBase
    {
        private readonly DataContext _context;


        public HackathonEditionsController(DataContext context)
        {
            _context = context;

        }

        //get por lista => select * from owners
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.HackathonEditions.ToListAsync());
        }

        // get con parametros
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var HackathonEdition = await _context.HackathonEditions.FirstOrDefaultAsync(x => x.IDHackathon==id);
            if (HackathonEdition == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(HackathonEdition);
            }
        }

        //Post para insertar

        [HttpPost]

        public async Task<ActionResult> Post(HackathonEdition hackatonedition)
        {
            _context.Add(hackatonedition);
            await _context.SaveChangesAsync();
            return Ok(hackatonedition);
        }

        //Put update
        [HttpPut]

        public async Task<ActionResult> Put(HackathonEdition hackatonedition)
        {
            _context.Update(hackatonedition);
            await _context.SaveChangesAsync();
            return Ok(hackatonedition);
        }

        //delete
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var FilasAfectadas = await _context.HackathonEditions.Where(a => a.IDHackathon==id).ExecuteDeleteAsync();
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
