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
    public class TablesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public TablesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Tables
        [HttpGet]
        public async Task<ActionResult> GetTables()
        {
            var tables = await _unitOfWork.Tables.GetAll();
            return Ok(tables);
        }

        // GET: api/Tables/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetTable(int id)
        {
            var table = await _unitOfWork.Tables.Get(q => q.Id == id);

            if (table == null)
            {
                return NotFound();
            }

            //return Model;
            return Ok(table);
        }

        // PUT: api/Tables/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTable(int id, Table table)
        {
            if (id != table.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Tables.Update(table);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (! await TableExists(id))
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

        // POST: api/Tables
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Table>> PostTable(Table table)
        {
            await _unitOfWork.Tables.Insert(table);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetTable", new { id = table.Id }, table);
        }

        // DELETE: api/Tables/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTable(int id)
        {
            var table = await _unitOfWork.Tables.Get(q => q.Id == id);
            if (table == null)
            {
                return NotFound();
            }

            await _unitOfWork.Tables.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> TableExists(int id)
        {
            var table = await _unitOfWork.Tables.Get(q => q.Id == id);
            return table != null;
        }
    }
}
