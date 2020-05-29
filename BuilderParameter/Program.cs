using System;

namespace BuilderParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            var emailService = new EmailService();
            emailService.SendEmail(builder => 
                builder.From("abc@xyz.com")
                    .To("qwe@rty.com")
                    .Subject("Test")
                    .Body("Hello World"));
        }
    }
}