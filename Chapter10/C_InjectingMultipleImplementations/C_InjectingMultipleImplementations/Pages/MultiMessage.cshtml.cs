using System.Collections.Generic;
using C_InjectingMultipleImplementations.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace C_InjectingMultipleImplementations.Pages
{
    public class MultiMessageModel : PageModel
    {
		private readonly IEnumerable<IMessageSender> _messageSenders;
		public MultiMessageModel(IEnumerable<IMessageSender> messageSenders)
		{
			_messageSenders = messageSenders;
		}

		public void OnGet(string username)
        {
			foreach (var messageSender in _messageSenders)
			{
				messageSender.SendMessage(username);
			}
		}
    }
}
