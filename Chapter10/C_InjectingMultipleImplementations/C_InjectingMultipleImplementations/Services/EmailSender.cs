﻿using System;

namespace C_InjectingMultipleImplementations.Services
{
	public class EmailSender : IMessageSender
	{
		public void SendMessage(string message)
		{
			Console.WriteLine($"Sending Email message: {message}");
		}
	}
}
