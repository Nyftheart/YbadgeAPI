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
    public class BadgesController : ControllerBase
    {
        private readonly ArchiDB _context;

        public BadgesController(ArchiDB context)
        {
            _context = context;
        }

        // GET: api/Badges
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Badge>>> GetBadge()
        {
          if (_context.Badge == null)
          {
              return NotFound();
          }
            return await _context.Badge.ToListAsync();
        }

        // GET: api/Badges/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Badge>> GetBadge(int id)
        {
          if (_context.Badge == null)
          {
              return NotFound();
          }
            var badge = await _context.Badge.FindAsync(id);

            if (badge == null)
            {
                return NotFound();
            }

            return badge;
        }

        // PUT: api/Badges/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBadge(int id, Badge badge)
        {
            if (id != badge.ID)
            {
                return BadRequest();
            }

            _context.Entry(badge).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BadgeExists(id))
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

        // POST: api/Badges
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Badge>> PostBadge(Badge badge)
        {
          if (_context.Badge == null)
          {
              return Problem("Entity set 'ArchiDB.Badge'  is null.");
          }
            _context.Badge.Add(badge);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBadge", new { id = badge.ID }, badge);
        }

        // DELETE: api/Badges/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBadge(int id)
        {
            if (_context.Badge == null)
            {
                return NotFound();
            }
            var badge = await _context.Badge.FindAsync(id);
            if (badge == null)
            {
                return NotFound();
            }

            _context.Badge.Remove(badge);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BadgeExists(int id)
        {
            return (_context.Badge?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
