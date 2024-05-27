using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace learnIte.Service
{
    public class EmailSender : IEmailSender
    {
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var fromEmail = "ilearnAcademies@gmail.com";
            var fromPassword = "zezcnzghhqesgjgw";

            var massage = new MailMessage();
            massage.From = new MailAddress(fromEmail);
            massage.Subject = subject;
            massage.To.Add(email);
            massage.Body = "<html><body> " + htmlMessage + " </body></html>";
            massage.IsBodyHtml = true;


            

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromEmail, fromPassword),
                EnableSsl = true,
            };
            smtpClient.Send(massage);



        }
    }
}
