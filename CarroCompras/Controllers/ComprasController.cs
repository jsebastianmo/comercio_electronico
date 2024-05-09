using CarroCompras.Context;
using CarroCompras.Modelos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarroCompras.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComprasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ComprasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Compras
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Compra>>> Get()
        {
            return await _context.Compras.ToListAsync();
        }

        //GET: api/Compras/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Compra>> Get(int id)
        {
            var compra = await _context.Compras.FindAsync(id);
            if (compra == null)
            {
                return NotFound();
            }

            return compra;
        }

        //// POST: api/Compra
        [HttpPost]
        public async Task<ActionResult<Compra>> Post(Compra compra)
        {
            _context.Compras.Add(compra);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = compra.Id }, compra);
        }

        //// DELETE: api/Compra/5
        [HttpDelete]
        public async Task<ActionResult<Compra>> Delete(int id)
        {
            var compra = await _context.Compras.FindAsync(id);
            if (compra == null)
            {
                return NotFound();
            }
            _context.Compras.Remove(compra);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
