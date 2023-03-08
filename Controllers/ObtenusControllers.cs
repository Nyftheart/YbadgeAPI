using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using YbadgesAPI.Data;
using YbadgesAPI.Models;

namespace YbadgesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObtenusControllers : ControllerBase
    {
        private readonly ArchiDB _context;

        public ObtenusControllers(ArchiDB context)
        {
            _context = context;
        }

        // GET: api/ObtenusControllers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Obtenu>>> GetObtenu()
        {
            if (_context.Obtenu == null)
            {
                return NotFound();
            }
            return await _context.Obtenu.ToListAsync();
        }

        // GET: api/ObtenusControllers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Obtenu>> GetObtenu(int id)
        {
            if (_context.Obtenu == null)
            {
                return NotFound();
            }
            var obtenu = await _context.Obtenu.FindAsync(id);

            if (obtenu == null)
            {
                return NotFound();
            }

            return obtenu;
        }

        // PUT: api/ObtenusControllers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutObtenu(int id, Obtenu obtenu)
        {
            if (id != obtenu.ID)
            {
                return BadRequest();
            }

            _context.Entry(obtenu).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ObtenuExists(id))
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

        // POST: api/ObtenusControllers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Obtenu>> PostObtenu(Obtenu obtenu)
        {
            if (_context.Obtenu == null)
            {
                return Problem("Entity set 'ArchiDB.Obtenu'  is null.");
            }
            _context.Obtenu.Add(obtenu);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetObtenu", new { id = obtenu.ID }, obtenu);
        }

        // DELETE: api/ObtenusControllers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteObtenu(int id)
        {
            if (_context.Obtenu == null)
            {
                return NotFound();
            }
            var obtenu = await _context.Obtenu.FindAsync(id);
            if (obtenu == null)
            {
                return NotFound();
            }

            _context.Obtenu.Remove(obtenu);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ObtenuExists(int id)
        {
            return (_context.Obtenu?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}