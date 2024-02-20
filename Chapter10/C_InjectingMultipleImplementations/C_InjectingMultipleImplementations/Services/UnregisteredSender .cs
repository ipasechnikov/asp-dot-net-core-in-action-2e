﻿using System;

namespace C_InjectingMultipleImplementations.Services
{
	public class UnregisteredSender : IMessageSender
	{
		public void SendMessage(string message)
		{
			throw new Exception("I'm never registered so shouldn't be called");
		}
	}
}
