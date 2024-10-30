﻿using Hackaton.API.Data;
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
            return Ok(await _context.projectAwards.ToListAsync());
        }

        // get con parametros
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var mentor = await _context.projectAwards.FirstOrDefaultAsync(x => x.Id==id);
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

        public async Task<ActionResult> Post(Mentor mentor)
        {
            _context.Add(mentor);
            await _context.SaveChangesAsync();
            return Ok(mentor);
        }

        //Put update
        [HttpPut]

        public async Task<ActionResult> Put(Mentor mentor)
        {
            _context.Update(mentor);
            await _context.SaveChangesAsync();
            return Ok(mentor);
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
