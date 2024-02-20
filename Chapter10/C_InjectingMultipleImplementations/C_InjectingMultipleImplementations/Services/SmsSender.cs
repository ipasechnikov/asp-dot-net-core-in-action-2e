using System;

namespace C_InjectingMultipleImplementations.Services
{
	public class SmsSender : IMessageSender
	{
		public void SendMessage(string message)
		{
			Console.WriteLine($"Sending SMS: {message}");
		}
	}
}
