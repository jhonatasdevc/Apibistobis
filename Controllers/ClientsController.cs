using System;
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
    public class ClientsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ClientsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Clients>>> GetClients()
        {
            return await _context.Clients.ToListAsync();
        }

        // GET: api/Clients/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Clients>> GetClients(int id)
        {
            var Clients = await _context.Clients.FindAsync(id);

            if (Clients == null)
            {
                return NotFound();
            }

            return Clients;
        }

        // PUT: api/Users/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClients(int id, Clients Clients)
        {
            if (id != Clients.Volvo_id)
            {
                return BadRequest();
            }

            _context.Entry(Clients).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClientsExists(id))
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
        public async Task<ActionResult<Clients>> PostClients(Clients Clients)
        {
            _context.Clients.Add(Clients);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetClients", new { id = Clients.Volvo_id }, Clients);
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClients(int id)
        {
            var Clients = await _context.Clients.FindAsync(id);
            if (Clients == null)
            {
                return NotFound();
            }

            _context.Clients.Remove(Clients);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ClientsExists(int id)
        {
            return _context.Clients.Any(e => e.Volvo_id == id);
        }
    }
}


