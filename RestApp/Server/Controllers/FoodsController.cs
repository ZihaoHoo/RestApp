using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestApp.Server.Data;
using RestApp.Server.IRepository;
using RestApp.Shared.Domain;

namespace RestApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodsController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //public FoodsController(ApplicationDbContext context)
        public FoodsController(IUnitOfWork unitOfWork)
        {
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Foods
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<Food>>> GetFood()
        public async Task<IActionResult> GetFood()
        {
            //return await _context.Food.ToListAsync();
            var foods = await _unitOfWork.Foods.GetAll();
            return Ok(foods);
        }

        // GET: api/Foods/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<Food>> GetFood(int id)
        public async Task<IActionResult> GetFood(int id)
        {
            //var food = await _context.Food.FindAsync(id);
            var food = await _unitOfWork.Foods.Get(q => q.Id == id);

            if (food == null)
            {
                return NotFound();
            }

            //return food;
            return Ok(food);
        }

        // PUT: api/Foods/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFood(int id, Food food)
        {
            if (id != food.Id)
            {
                return BadRequest();
            }

            //_context.Entry(food).State = EntityState.Modified;
            _unitOfWork.Foods.Update(food);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!FoodExists(id))
                if (!await FoodExists(id))
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

        // POST: api/Foods
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Food>> PostFood(Food food)
        {
            //_context.Food.Add(food);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Foods.Insert(food);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetFood", new { id = food.Id }, food);
        }

        // DELETE: api/Foods/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFood(int id)
        {
            //var food = await _context.Food.FindAsync(id);
            var food = await _unitOfWork.Foods.Get(q => q.Id == id);
            if (food == null)
            {
                return NotFound();
            }

            //_context.Food.Remove(food);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Foods.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool FoodExists(int id)
        private async Task<bool> FoodExists(int id)
        {
            //return _context.Food.Any(e => e.Id == id);
            var food = await _unitOfWork.Foods.Get(q => q.Id == id);
            return food != null;
        }
    }
}
