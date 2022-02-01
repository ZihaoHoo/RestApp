using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestApp.Server.IRepository;
using RestApp.Shared.Domain;
using System.Threading.Tasks;

namespace RestApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenusController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //public MenusController(ApplicationDbContext context)
        public MenusController(IUnitOfWork unitOfWork)
        {
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Menus
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<Menu>>> GetMenu()
        public async Task<IActionResult> GetMenu()
        {
            //return await _context.Menu.ToListAsync();
            var menus = await _unitOfWork.Menus.GetAll();
            return Ok(menus);
        }

        // GET: api/Menus/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<Menu>> GetMenu(int id)
        public async Task<IActionResult> GetMenu(int id)
        {
            //var menu = await _context.Menu.FindAsync(id);
            var menu = await _unitOfWork.Menus.Get(q => q.Id == id);

            if (menu == null)
            {
                return NotFound();
            }

            //return menu;
            return Ok(menu);
        }

        // PUT: api/Menus/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMenu(int id, Menu menu)
        {
            if (id != menu.Id)
            {
                return BadRequest();
            }

            //_context.Entry(menu).State = EntityState.Modified;
            _unitOfWork.Menus.Update(menu);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!MenuExists(id))
                if (!await MenuExists(id))
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

        // POST: api/Menus
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Menu>> PostMenu(Menu menu)
        {
            //_context.Menu.Add(menu);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Menus.Insert(menu);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetMenu", new { id = menu.Id }, menu);
        }

        // DELETE: api/Menus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMenu(int id)
        {
            //var menu = await _context.Menu.FindAsync(id);
            var menu = await _unitOfWork.Menus.Get(q => q.Id == id);
            if (menu == null)
            {
                return NotFound();
            }

            //_context.Menu.Remove(menu);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Menus.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool MenuExists(int id)
        private async Task<bool> MenuExists(int id)
        {
            //return _context.Menu.Any(e => e.Id == id);
            var menu = await _unitOfWork.Menus.Get(q => q.Id == id);
            return menu != null;
        }
    }
}
