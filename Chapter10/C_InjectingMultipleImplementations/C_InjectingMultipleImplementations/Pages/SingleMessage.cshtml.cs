using C_InjectingMultipleImplementations.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace C_InjectingMultipleImplementations.Pages
{
    public class SingleMessageModel : PageModel
    {
        private readonly IMessageSender _messageSender;

        public SingleMessageModel(IMessageSender messageSender)
        {
            this._messageSender = messageSender;
        }

        public void OnGet(string username)
        {
            _messageSender.SendMessage(username);
        }
    }
}
