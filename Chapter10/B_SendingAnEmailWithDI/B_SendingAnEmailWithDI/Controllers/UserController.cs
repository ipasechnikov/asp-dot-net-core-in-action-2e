using B_SendingAnEmailWithDI.Services;
using Microsoft.AspNetCore.Mvc;

namespace B_SendingAnEmailWithDI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly IEmailSender _emailSender;

        public UserController(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        [HttpPost("register")]
        public IActionResult RegisterUser(string username)
        {
            _emailSender.SendEmail(username);
            return Ok("Email sent!");
        }
    }
}
