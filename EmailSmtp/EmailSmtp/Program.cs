using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace EmailSmtp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var credentials = new NetworkCredential("xginny12@gmail.com", "**********");
                var mail = new MailMessage()
                {
                    From = new MailAddress("xginny12@gmail.com"),
                    Subject = "아빠에게.",
                    Body = "아빠 이메일로 보낸거야"
                };
                mail.To.Add(new MailAddress("xginny@naver.com"));

                var client = new SmtpClient()
                {
                    Port = 587,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Host = "smtp.gmail.com",
                    EnableSsl = true,
                    Credentials = credentials
                };
                client.Send(mail);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in sending email: " + ex.Message);
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Email sccessfully sent");
            Console.ReadKey();
        }
    }
}

