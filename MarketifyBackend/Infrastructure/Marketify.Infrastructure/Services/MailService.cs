namespace Marketify.Infrastructure.Services
{
    public class MailService : IMailService
    {
        readonly IConfiguration _configuration;

        public MailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task SendMessageAsync(string to, string subject, string body, bool isBodyHtml = true)
        {
            await SendMessageAsync(new[] { to }, subject, body, isBodyHtml);
        }

        public async Task SendMessageAsync(string[] tos, string subject, string body, bool isBodyHtml = true)
        {
            MailMessage mail = new()
            {
                IsBodyHtml = isBodyHtml
            };

            foreach (var to in tos)
                mail.To.Add(to);
            mail.Subject = subject;
            mail.Body = body;
            mail.From = new(_configuration["Mail:Username"], "NG E-Ticaret", System.Text.Encoding.UTF8);

            SmtpClient smtp = new()
            {
                Credentials = new NetworkCredential(_configuration["Mail:Username"], _configuration["Mail:Password"]),
                Port = 587,
                EnableSsl = true,
                Host = _configuration["Mail:Host"]
            };

            await smtp.SendMailAsync(mail);
        }
    }
}
