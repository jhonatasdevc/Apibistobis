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
    public class SellCarController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SellCarController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SellCar>>> GetSellCar()
        {
            return await _context.Sell_Car.ToListAsync();
        }

        // GET: api/SellCar/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SellCar>> GetSellCar(int id)
        {
            var SellCar = await _context.Sell_Car.FindAsync(id);

            if (SellCar == null)
            {
                return NotFound();
            }

            return SellCar;
        }

        // PUT: api/Users/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSellCar(int id, SellCar SellCar)
        {
            if (id != SellCar.Id)
            {
                return BadRequest();
            }

            _context.Entry(SellCar).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SellCarExists(id))
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
        public async Task<ActionResult<SellCar>> PostSellCar(SellCar SellCar)
        {
            _context.Sell_Car.Add(SellCar);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSellCar", new { id = SellCar.Id }, SellCar);
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSellCar(int id)
        {
            var SellCar = await _context.Sell_Car.FindAsync(id);
            if (SellCar == null)
            {
                return NotFound();
            }

            _context.Sell_Car.Remove(SellCar);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SellCarExists(int id)
        {
            return _context.Sell_Car.Any(e => e.Id == id);
        }
    }
}

