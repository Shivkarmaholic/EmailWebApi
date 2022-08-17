using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

namespace EmailWebApi.Controllers
{

    [Route("api/[Controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService _emailService;

        public EmailController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpPost]
        public IActionResult sendEmail(EmailModel body)
        {
            _emailService.sendEmail(body);
            return Ok();
        }
    }
}
