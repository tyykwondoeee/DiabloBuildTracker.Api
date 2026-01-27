using DiabloBuildTracker.Api.Data;
using DiabloBuildTracker.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DiabloBuildTracker.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillCategoriesController : ControllerBase
    {
        private readonly AppDbContext _context;
        public SkillCategoriesController(AppDbContext context) => _context = context;

        // GET: api/SkillCategories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SkillCategory>>> GetSkillCategories()
            => await _context.SkillCategories.ToListAsync();

        // GET: api/SkillCategories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SkillCategory>> GetSkillCategory(int id)
        {
            var category = await _context.SkillCategories.FindAsync(id);
            return category == null ? NotFound() : category;
        }

        // POST: api/SkillCategories
        [HttpPost]
        public async Task<ActionResult<SkillCategory>> PostSkillCategory(SkillCategory category)
        {
            _context.SkillCategories.Add(category);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetSkillCategory), new { id = category.Id }, category);
        }

        // PUT: api/SkillCategories/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSkillCategory(int id, SkillCategory category)
        {
            if (id != category.Id) return BadRequest();
            _context.Entry(category).State = EntityState.Modified;

            try { await _context.SaveChangesAsync(); }
            catch (DbUpdateConcurrencyException)
            {
                if (!SkillCategoryExists(id)) return NotFound();
                else throw;
            }

            return NoContent();
        }

        // DELETE: api/SkillCategories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSkillCategory(int id)
        {
            var category = await _context.SkillCategories.FindAsync(id);
            if (category == null) return NotFound();

            _context.SkillCategories.Remove(category);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        private bool SkillCategoryExists(int id) => _context.SkillCategories.Any(e => e.Id == id);
    }
}
