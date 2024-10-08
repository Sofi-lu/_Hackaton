﻿using Hackaton.API.Data;
using Hackaton.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace Hackaton.API.Controllers
{
    public class AssessmentsController : ControllerBase
    {
        private readonly DataContext _context;
        public AssessmentsController(DataContext context)
        {
            _context = context;

        }

        //get por lista => select * from owners
        [HttpGet]

        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Assessments.ToListAsync());
        }

        // get con parametros
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var mentor = await _context.Assessments.FirstOrDefaultAsync(x => x.Id==id);
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
