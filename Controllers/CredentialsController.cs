using Microsoft.AspNetCore.Mvc;
using WebApplication2.Repositories;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CredentialsController : Controller
    {
        private readonly ICredentialsRepo _credRepo;


        public CredentialsController(ICredentialsRepo credRepo)
        {
            _credRepo = credRepo;

        }
        // GET api/person/getcred
        [HttpGet("getcred")]
        public async Task<IActionResult> GetCred()
        {
            try
            {
                var response = await _credRepo.GetCred();
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
