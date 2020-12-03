using APIFlowers.Database;
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
    public class FlowersController : ControllerBase
    {

        protected EFContext context;
        public FlowersController(EFContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get(int? Id = null, string Name = null, int? FlowerKind = null)
        {
            var result = await context.Flowers.Where(f => 
                                            f.Id == Id && f.Name == Name && f.FlowerKindId == FlowerKind 
                                            // all param end
                                            || f.Name == Name && Id == null && FlowerKind == null
                                            || f.Id == Id && Name == null && FlowerKind == null
                                            || f.FlowerKindId == FlowerKind && Name == null && Id == null
                                            // solo param end
                                            || f.FlowerKindId == FlowerKind && f.Name == Name && Id == null
                                            || f.Name == Name && f.Id == Id && FlowerKind == null
                                            || f.FlowerKindId == FlowerKind && f.Id == Id && Name == null
                                            // pair param end
                                            || Id == null && Name == null && FlowerKind == null)
                                            // null param end
                                        .Select(f => new {
                                            Id = f.Id, 
                                            Name = f.Name, 
                                            FlowerKind = f.FlowerKindId, 
                                            BasicPrice = f.BasicPrice, 
                                            Photo = f.PhotoPath, 
                                            Description = f.Description})
                                        .ToListAsync();
            return Ok(result);
        }
    }
}
