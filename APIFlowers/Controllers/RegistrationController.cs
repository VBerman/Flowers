using APIFlowers.Database.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIFlowers.Controllers
{
    [ApiController, Route("api/[controller]")]
    public class RegistrationController : ControllerBase
    {
        private readonly Database.EFContext context;
        public RegistrationController(Database.EFContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Registration(RegistrationModel model)
        {
            if (ModelState.IsValid)
            {
                ulong phoneULong;
                var succParse = ulong.TryParse(model.Phone, out phoneULong);
                if (!succParse)
                {
                    return Problem(statusCode: 400, title: "Pnone incorrect");
                }
                if (await context.Clients.AnyAsync(c => c.Phone == phoneULong))
                {
                    return Problem(statusCode: 400, title: "Phone is already in use");
                }
                

                var client = new Client()
                {
                    FullName = model.FullName,
                    Phone = phoneULong,
                    HashPassword = HashWorker.GetHashString(model.Password)
                };

                await context.Clients.AddAsync(client);
                await context.SaveChangesAsync();
                return Ok();
            }
            return BadRequest(ModelState);
        }
    }
    public class RegistrationModel
    {
        [Required, Phone]
        public string Phone { get; set; }
        [Required, MinLength(4), MaxLength(32)]
        public string Password { get; set; }
        [Required, MinLength(4)]
        public string FullName { get; set; }
    }
}
