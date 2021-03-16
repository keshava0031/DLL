using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Model
{
    public class UserActions
    {
        public void Mail(string receiver, string subject, string message)
        {
            var senderEmail = new MailAddress("razorpay0031@gmail.com", "Admin");
            var receiverEmail = new MailAddress(receiver, "Receiver");
            var password = "kanini@123";
            var sub = subject;
            var body = message;
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = true,
                Credentials = new NetworkCredential(senderEmail.Address, password)
            };
            using (var mess = new MailMessage(senderEmail, receiverEmail)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(mess);
            }
        }
    }
}
