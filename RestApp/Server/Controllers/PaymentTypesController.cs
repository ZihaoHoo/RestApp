using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestApp.Server.IRepository;
using RestApp.Shared.Domain;
using System.Threading.Tasks;

namespace RestApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentTypesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public PaymentTypesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/PaymentTypes
        [HttpGet]
        public async Task<ActionResult> GetPaymentType()
        {
            var paymentTypes = await _unitOfWork.PaymentTypes.GetAll();
            return Ok(paymentTypes);
        }

        // GET: api/PaymentTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetPaymentType(int id)
        {
            var paymentType = await _unitOfWork.PaymentTypes.Get(q => q.Id == id);

            if (paymentType == null)
            {
                return NotFound();
            }

            return Ok(paymentType);
        }

        // PUT: api/PaymentTypes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPaymentType(int id, PaymentType paymentType)
        {
            if (id != paymentType.Id)
            {
                return BadRequest();
            }

            _unitOfWork.PaymentTypes.Update(paymentType);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await PaymentTypeExists(id))
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

        // POST: api/PaymentTypes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PaymentType>> PostPaymentType(PaymentType paymentType)
        {
            await _unitOfWork.PaymentTypes.Insert(paymentType);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetPaymentType", new { id = paymentType.Id }, paymentType);
        }

        // DELETE: api/PaymentTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePaymentType(int id)
        {
            var paymentType = await _unitOfWork.PaymentTypes.Get(q => q.Id == id);
            if (paymentType == null)
            {
                return NotFound();
            }

            await _unitOfWork.PaymentTypes.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> PaymentTypeExists(int id)
        {
            var paymentType = await _unitOfWork.PaymentTypes.Get(q => q.Id == id);
            return paymentType != null;
        }
    }
}
