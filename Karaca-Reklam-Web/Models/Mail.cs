using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace Karaca_Reklam_Web.Models
{
    public class Mail
    {
        public static void MailSender(string body)
        {
            var fromAddress = new MailAddress("mrtkrc41@gmail.com");
            var toAddress = new MailAddress("mrtkrc41@gmail.com");
            const string subject = "Karaca Yazılım | karacayazilim.com Sitenizden Gelen İletişim Formu";
            using (var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, "cencored for github")
            })
            {
                using (var message = new MailMessage(fromAddress, toAddress) { Subject = subject, Body = body })
                {
                    smtp.Send(message);
                }
            }
        }
    }
}