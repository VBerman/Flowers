using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace APIFlowers.Controllers
{
    [ApiController]
    [Route("Flowers/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly Database.EFContext context;

        public AuthController(Database.EFContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Auth(AuthModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await context.Clients.FirstOrDefaultAsync(c => c.Phone == model.Phone);
                if (user == null)
                {
                    ModelState.AddModelError("Phone", "This phone not found");
                    return BadRequest(new ValidationProblemDetails(ModelState));

                }
                if (user.HashPassword != HashWorker.GetHashString(model.Password))
                {
                    ModelState.AddModelError("Auth", "Login or password incorrect");
                    return BadRequest(new ValidationProblemDetails(ModelState));
                }
                return Ok();
            }   
            return BadRequest(ModelState);
        }

        
    }
    public class AuthModel
    {
        [Required]
        public ulong Phone { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
