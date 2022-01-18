﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiBRQ.banco;

namespace ApiBRQ.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public StatesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<States>>> GetStates()
        {
            return await _context.States.ToListAsync();
        }

        // GET: api/States/5
        [HttpGet("{id}")]
        public async Task<ActionResult<States>> GetStates(int id)
        {
            var states = await _context.States.FindAsync(id);

            if (states == null)
            {
                return NotFound();
            }

            return states;
        }

        // PUT: api/Users/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStates(int id, States states)
        {
            if (id != states.Id)
            {
                return BadRequest();
            }

            _context.Entry(states).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StatesExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Users
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<States>> PostStates(States states)
        {
            _context.States.Add(states);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStates", new { id = states.Id }, states);
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStates(int id)
        {
            var states = await _context.States.FindAsync(id);
            if (states == null)
            {
                return NotFound();
            }

            _context.States.Remove(states);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StatesExists(int id)
        {
            return _context.States.Any(e => e.Id == id);
        }
    }
}

