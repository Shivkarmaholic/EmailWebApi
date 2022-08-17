

namespace EmailWebApi.Services.EmailService
{
    public interface IEmailService
    {
        void sendEmail(EmailModel request);
        
    }
}
