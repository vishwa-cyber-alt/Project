using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication2.Models;
using WebApplication2.Repositories;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IUserRepo _userRepo;
        

        public PersonController(IUserRepo userRepo)
        {
            _userRepo = userRepo;
           
        }

        // POST api/person/add
        [HttpPost("add")]
        public async Task<IActionResult> AddPerson([FromBody] UserModel data)
        {
            if (data == null)
            {
                return BadRequest(new { error = true, message = "Invalid data." });
            }

            try
            {
                var response = await _userRepo.AddPerson(data);
                return Ok(new { message = "Person Added Successfully!", id = response });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = true, message = ex.Message });
            }
        }

        

        // GET api/person
        [HttpGet]
        public async Task<IActionResult> GetData()
        {
            try
            {
                var response = await _userRepo.GetData();
                if (response == null)
                {
                    return NotFound(new { error = true, message = "No data found." });
                }
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = true, message = ex.Message });
            }
        }
    }
}
