using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace E_ProblemDetailsExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValuesController : Controller
    {
        [HttpGet("{myValue?}")]
        public IActionResult Get([Required] string myValue)
        {
            // Never called, due to automatic invalid response generation
            return Ok(myValue);
        }
    }
}
