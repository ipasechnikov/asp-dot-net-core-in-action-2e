using System;

namespace C_InjectingMultipleImplementations.Services
{
	public class FacebookSender : IMessageSender
	{
		public void SendMessage(string message)
		{
			Console.WriteLine($"Sending Facebook message: {message}");
		}
	}
}
