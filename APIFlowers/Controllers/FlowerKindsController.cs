using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIFlowers.Controllers
{
    [ApiController]
    [Route("Flowers/[controller]")]
    public class FlowerKindsController : ControllerBase
    {
        private readonly Database.EFContext context;

        public FlowerKindsController(Database.EFContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get(int? Id = null, string Name = null)
        {
            //   dynamic result;
            var result = await context.FlowerKinds
                                .Where(f => f.Id == Id && f.Name == Name
                                            || f.Name == Name && Id == null
                                            || f.Id == Id && Name == null
                                            || Id == null && Name == null)
                                .Select(f => new { Id = f.Id,
                                    Name = f.Name, Description = f.Description })
                                .ToListAsync();
            return Ok(result);
                
            //TODO optimize
        }

    }
}
