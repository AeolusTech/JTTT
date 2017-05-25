using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace JTTT
{
    class MailSender
    {
        public MailSender(string logfilepath)
        {
            logger = logfilepath;
        }


        public void Sendmail(string AdresEmail, string tagToSearch, string filepath)
        {
            try
            {
                var message = new MailMessage();
                message.From = new MailAddress("dotnetijava2017@gmail.com", "Platformy Programistyczne");
                message.To.Add(new MailAddress(AdresEmail));
                message.Subject = tagToSearch;
                message.Body = "Znaleziono nowy obraz z tagiem \"" + tagToSearch + "\"";
                message.Attachments.Add(new Attachment(filepath));
                var smtp = new SmtpClient("smtp.gmail.com");
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("dotnetijava2017@gmail.com", "poiuytrewq1");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.Send(message);
                Console.WriteLine("Udalo sie wyslac wiadomosc!\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("Nie udalo sie wyslac wiadomosci. Blad:\n" + e.ToString());
            }

        }

        // fields

        private string logger;
    }
}
