using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestApp.Server.IRepository;
using RestApp.Shared.Domain;
using System.Threading.Tasks;

namespace RestApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public BookingsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Bookings
        [HttpGet]
        public async Task<ActionResult> GetBooking()
        {
            var Bookings = await _unitOfWork.Bookings.GetAll(includes: q => q.Include(x => x.Restaurant).Include(x => x.Customer));
            return Ok(Bookings);
        }

        // GET: api/Restaurants/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetBooking(int id)
        {
            var Booking = await _unitOfWork.Bookings.Get(q => q.Id == id);

            if (Booking == null)
            {
                return NotFound();
            }

            return Ok(Booking);
        }

        // PUT: api/Bookings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBooking(int id, Booking Booking)
        {
            if (id != Booking.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Bookings.Update(Booking);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await BookingExists(id))
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

        // POST: api/Bookings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Booking>> PostRestaurant(Booking Booking)
        {
            await _unitOfWork.Bookings.Insert(Booking);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetBooking", new { id = Booking.Id }, Booking);
        }

        // DELETE: api/Bookings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBooking(int id)
        {
            var booking = await _unitOfWork.Bookings.Get(q => q.Id == id);
            if (booking == null)
            {
                return NotFound();
            }

            await _unitOfWork.Bookings.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> BookingExists(int id)
        {
            var booking = await _unitOfWork.Bookings.Get(q => q.Id == id);
            return booking != null;
        }
    }
}
