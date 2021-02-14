using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using S22.Imap;

namespace emailin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MailAddress to = new MailAddress("marsiballkoci@gmail.com");
            MailAddress from = new MailAddress("esuppdesk@gmail.com");

            MailMessage message = new MailMessage(from, to);
            message.Subject = "E-Support ju Mirepret!";
            message.Body = "Miresevini ne grupin e klienteve tone te kenaqur!;";

            SmtpClient client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("esuppdesk@gmail.com", "Q1w2e3r4."),
                EnableSsl = true
            };

            try
            {
                client.Send(message);
            }
            catch (SmtpException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        } 
        
        private void start_receiving() 
        {
            Task.Run(() =>
            {
                using (ImapClient client = new ImapClient("imap.gmail.com", 993,
                    "esuppdesk@gmail.com", "Q1w2e3r4.", AuthMethod.Login, true))
                {
                    if (client.Supports("IDLE") == false)
                    {
                        Console.WriteLine("server does not support imap idle");
                        return;
                    }
                    client.NewMessage += new EventHandler<IdleMessageEventArgs>(on_new_message);
                    while(true) ;
                }
            });
        }

        private void on_new_message(object sender, IdleMessageEventArgs e)
        {
            Console.WriteLine("new message");
            MailMessage m = e.Client.GetMessage(e.MessageUID, FetchOptions.Normal);
            string msg = "From: " + m.From + "\n" + "Subject: " + m.Subject;
            Console.WriteLine(msg);
        }
    }
}

