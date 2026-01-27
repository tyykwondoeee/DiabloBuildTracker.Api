using DiabloBuildTracker.Api.Data;
using DiabloBuildTracker.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DiabloBuildTracker.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillUpgradesController : ControllerBase
    {
        private readonly AppDbContext _context;
        public SkillUpgradesController(AppDbContext context) => _context = context;

        // GET: api/SkillUpgrades
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SkillUpgrade>>> GetSkillUpgrades()
            => await _context.SkillUpgrades.ToListAsync();

        // GET: api/SkillUpgrades/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SkillUpgrade>> GetSkillUpgrade(int id)
        {
            var upgrade = await _context.SkillUpgrades.FindAsync(id);
            return upgrade == null ? NotFound() : upgrade;
        }

        // POST: api/SkillUpgrades
        [HttpPost]
        public async Task<ActionResult<SkillUpgrade>> PostSkillUpgrade(SkillUpgrade upgrade)
        {
            _context.SkillUpgrades.Add(upgrade);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetSkillUpgrade), new { id = upgrade.Id }, upgrade);
        }

        // PUT: api/SkillUpgrades/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSkillUpgrade(int id, SkillUpgrade upgrade)
        {
            if (id != upgrade.Id) return BadRequest();
            _context.Entry(upgrade).State = EntityState.Modified;

            try { await _context.SaveChangesAsync(); }
            catch (DbUpdateConcurrencyException)
            {
                if (!SkillUpgradeExists(id)) return NotFound();
                else throw;
            }

            return NoContent();
        }

        // DELETE: api/SkillUpgrades/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSkillUpgrade(int id)
        {
            var upgrade = await _context.SkillUpgrades.FindAsync(id);
            if (upgrade == null) return NotFound();

            _context.SkillUpgrades.Remove(upgrade);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        private bool SkillUpgradeExists(int id) => _context.SkillUpgrades.Any(e => e.Id == id);
    }
}
