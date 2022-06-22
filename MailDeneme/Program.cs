using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MailDeneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {              

                MailMessage message = new MailMessage(
                $"from@gmail.com",
                $"to@gmail.com",
                "deneme | dsadsa Detayı",
                "Mail Body");

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential($"from@gmail.com", $"****")
                };
                smtp.Send(message);
                Console.WriteLine("Başarılı");
                Console.ReadKey();

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
                Console.ReadKey();
            }


        }


    }
}
