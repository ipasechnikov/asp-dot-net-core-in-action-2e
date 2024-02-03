using System;

namespace A_SendingAnEmailWithoutDI.Services
{
    public class EmailSender
    {
        private readonly NetworkClient _client;
        private readonly MessageFactory _factory;

        public EmailSender(NetworkClient client, MessageFactory factory)
        {
            _client = client;
            _factory = factory;
        }

        public void SendEmail(string username)
        {
            Email email = _factory.Create(username);
            _client.SendEmail(email);
            Console.WriteLine($"Email sent to {username}!");
        }
    }
}
