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
    public class RestaurantsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public RestaurantsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Restaurants
        [HttpGet]
        public async Task<ActionResult> GetRestaurant()
        {
            var restaurants = await _unitOfWork.Restaurants.GetAll(includes: q => q.Include(x => x.Cuisine).Include(x => x.ClosingTime).Include(x => x.PaymentOption));
            return Ok(restaurants);
        }

        // GET: api/Restaurants/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Restaurant>> GetRestaurant(int id)
        {
            var restaurant = await _unitOfWork.Restaurants.Get(q => q.Id == id);

            if (restaurant == null)
            {
                return NotFound();
            }

            return Ok(restaurant);
        }

        // PUT: api/Restaurants/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRestaurant(int id, Restaurant Restaurant)
        {
            if (id != Restaurant.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Restaurants.Update(Restaurant);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (! await RestaurantExists(id))
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

        // POST: api/Restaurants
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Restaurant>> PostRestaurant(Restaurant Restaurant)
        {
            await _unitOfWork.Restaurants.Insert(Restaurant);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetRestaurant", new { id = Restaurant.Id }, Restaurant);
        }

        // DELETE: api/Restaurants/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRestaurant(int id)
        {
            var restaurant = await _unitOfWork.Restaurants.Get(q => q.Id == id);
            if (restaurant == null)
            {
                return NotFound();
            }

            await _unitOfWork.Restaurants.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> RestaurantExists(int id)
        {
            var restaurant = await _unitOfWork.Restaurants.Get(q => q.Id == id);
            return restaurant != null;
        }
    }
}
