using A_SendingAnEmailWithoutDI.Services;
using Microsoft.AspNetCore.Mvc;

namespace A_SendingAnEmailWithoutDI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        [HttpPost("register")]
        public IActionResult RegisterUser(string username)
        {
            EmailSender emailSender = new(
                new NetworkClient(
                    new EmailServerSettings
                    {
                        Host = "smtp.server.com",
                        Port = 25
                    }
                ),
                new MessageFactory()
            );

            emailSender.SendEmail(username);
            return Ok("Email sent!");
        }
    }
}
