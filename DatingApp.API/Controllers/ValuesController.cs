using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DatingApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class ValuesController : ControllerBase
    {
        private readonly DataContext _context;
        public ValuesController(DataContext context)
        {
            _context = context;

        }
        [HttpGet]
        public async Task<IActionResult> GetValues()
        {
            //throw new Exception("Test Exception");
            var values=await _context.Values.ToListAsync();
            return Ok(values);
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetValue(int id)
        {
            var value=await _context.Values.FirstOrDefaultAsync(x => x.Id == id);
            return Ok(value);
        }
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }
        [HttpDelete]
        public void Delete(int id)
        {

        }

    }
}