namespace B_SendingAnEmailWithDI.Services
{
    public interface IEmailSender
    {
        void SendEmail(string username);
    }
}
