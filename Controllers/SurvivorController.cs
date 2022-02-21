using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Apocalypse.Models;

namespace Apocalypse.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurvivorController : ControllerBase
    {
        private readonly ApocalyseDbContext _context;

        public SurvivorController(ApocalyseDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Survivor>>> Getsurvivors()
        {
            return await _context.survivors.ToListAsync();
        }
       
        [HttpGet("{id}")]
        public async Task<ActionResult<Survivor>> GetSurvivor(int id)
        {
            var survivor = await _context.survivors.FindAsync(id);

            if (survivor == null)
            {
                return NotFound();
            }

            return survivor;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutSurvivor(int id, Survivor survivor)
        {
            if (id != survivor.SurvivorId)
            {
                return BadRequest();
            }

            _context.Entry(survivor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SurvivorExists(id))
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

        [HttpPost]
        public async Task<ActionResult<Survivor>> PostSurvivor(Survivor survivor)
        {
            _context.survivors.Add(survivor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSurvivor", new { id = survivor.SurvivorId }, survivor);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSurvivor(int id)
        {
            var survivor = await _context.survivors.FindAsync(id);
            if (survivor == null)
            {
                return NotFound();
            }

            _context.survivors.Remove(survivor);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SurvivorExists(int id)
        {
            return _context.survivors.Any(e => e.SurvivorId == id);
        }
    }
}
