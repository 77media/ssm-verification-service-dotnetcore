using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAPIApplication.Controllers
{
    [Route("api/[controller]")]
    public class VerifyController : Controller
    {
        // POST api/verify
        [HttpPost]
        public IActionResult Post([FromBody] VerifyRequest value)
        {
            try
            {
                if (value == null || value.LastName == null)
                {
                    return BadRequest();
                }

                // TODO: query a real database or file
                var items = new List<DatabaseUser>();

                items.Add(new DatabaseUser()
                {
                    Id = 1,
                    Membership = "12345",
                    FirstName = "John",
                    LastName = "Doe",
                    ConfirmationNumber = "4567",
                    ScanCode = "890"
                });

                var item = items.Where(x => x.LastName == value.LastName && (x.ConfirmationNumber == value.ConfirmationNumber || x.ScanCode == value.ScanCode)).First();

                if (item == null)
                {
                    return NotFound();
                }

                // TODO: map your own object to the response
                var response = new VerifyResponse()
                {
                    Id = item.Id,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    Membership = item.Membership,
                    Verified = true
                };

                return new ObjectResult(response);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                return BadRequest();
            }

        }
    }
}
