using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestApp.Server.IRepository;
using RestApp.Shared.Domain;
using System.Threading.Tasks;

namespace RestApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CuisinesController : ControllerBase
    {
        //Refactored
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //public CuisinesController(ApplicationDbContext context)
        public CuisinesController(IUnitOfWork unitOfWork)
        {
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Cuisines
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<Cuisine>>> GetCuisine()
        public async Task<IActionResult> GetCusines()
        {
            //return await _context.Cuisine.ToListAsync();
            var cuisines = await _unitOfWork.Cuisines.GetAll();
            return Ok(cuisines);
        }

        // GET: api/Cuisines/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<Cuisine>> GetCuisine(int id)
        public async Task<IActionResult> GetCuisine(int id)
        {
            var cuisine = await _unitOfWork.Cuisines.Get(q => q.Id == id);

            if (cuisine == null)
            {
                return NotFound();
            }

            return Ok(cuisine);
        }

        // PUT: api/Cuisines/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCuisine(int id, Cuisine cuisine)
        {
            if (id != cuisine.Id)
            {
                return BadRequest();
            }

            //_context.Entry(cuisine).State = EntityState.Modified;
            _unitOfWork.Cuisines.Update(cuisine);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!CuisineExists(id))
                if (!await CuisineExists(id))
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

        // POST: api/Cuisines
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Cuisine>> PostCuisine(Cuisine cuisine)
        {
            //_context.Cuisine.Add(cuisine);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Cuisines.Insert(cuisine);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetCuisine", new { id = cuisine.Id }, cuisine);
        }

        // DELETE: api/Cuisines/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCuisine(int id)
        {
            //var cuisine = await _context.Cuisine.FindAsync(id);
            var cuisine = await _unitOfWork.Cuisines.Get(q => q.Id == id);
            if (cuisine == null)
            {
                return NotFound();
            }

            //_context.Cuisine.Remove(cuisine);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Cuisines.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool CuisineExists(int id)
        private async Task<bool> CuisineExists(int id)
        {
            //return _context.Cuisine.Any(e => e.Id == id);
            var cuisine = await _unitOfWork.Cuisines.Get(q => q.Id == id);
            return cuisine != null;
        }
    }
}
