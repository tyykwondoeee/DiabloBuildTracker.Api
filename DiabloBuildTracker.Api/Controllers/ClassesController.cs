using Microsoft.AspNetCore.Mvc;
using DiabloBuildTracker.Api.Data;
using DiabloBuildTracker.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace DiabloBuildTracker.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ClassesController(AppDbContext context)
        {
            _context = context;
        }
        // GET: api/Classes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Class>>> GetClasses()
        {
            return await _context.Classes.ToListAsync();
        }
        // GET: api/Classes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Class>> GetClass(int id)
        {
            var c = await _context.Classes.FindAsync(id);
            if (c == null) return NotFound();
            return c;
        }
        // Post: api/Classes
        [HttpPost]
        public async Task<ActionResult<Class>> PostClass(Class c)
        {
            _context.Classes.Add(c);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetClass), new { id = c.Id }, c);
        }
        // PUT: api/Classes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClass(int id, Class c) 
        {
            if (id != c.Id) return BadRequest();
            _context.Entry(c).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }
        // DELETE: api/Classes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClass(int id)
        {
            var c = await _context.Classes.FindAsync(id);
            if (c == null) return NotFound();
            _context.Classes.Remove(c);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
