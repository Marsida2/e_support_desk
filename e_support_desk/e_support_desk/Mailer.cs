﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S22.Imap;
using Limilabs.Client.IMAP;
using Limilabs.Mail;
using System.Net.Mail;
using System.Configuration;
using System.Net;

namespace e_support_desk
{
    public enum Tipi
    {
        kredenciale,
        id_ceshtje,
        rap_ceshtje,
        automatik
    }

    class Mailer
    {
        private string email;
        private string fjalekalimi;
        private MailAddress from;
        private SmtpClient client;

        public Mailer()
        {
            email = "esuppdesk@gmail.com";
            fjalekalimi = "Q1w2e3r4.";
            from = new MailAddress(email);
            client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential(email, fjalekalimi),
                EnableSsl = true
            };
        }

        public void Fillo()
        {
            Read_unseen();
            Start_receiving();
        }

        private void Dergo_email(string to, Tipi tipi, string str1="", string str2 = "")
        {
            string subject, body;

            switch (tipi)
            {
                case Tipi.kredenciale:
                    subject = "Miresevini ne E-Support";
                    body = "Miresevini ne grupin e klienteve te E-Support!\n" +
                            "Kredencialet tuaja jane: \n" +
                            "Email: " + to.ToString() + "\n" +
                            "Fjalekalimi: " + str1 + "\n" +
                            "Me keto te dhena ju mund te aksesoni online ceshtjet tuaja aktive.\n" +
                            "Faleminderit!";
                    break;
                case Tipi.id_ceshtje:
                    subject = "Ceshtje e re E-Support";
                    body = "Ceshtja me te dhenat e meposhtme sapo u krijua.\n" +
                            "ID ceshtje: " + str1 + "\n" +
                            "Problemi: " + str2 + "\n" +
                            "Ju mund te nqiqni ecurine e ceshtjes ne faqen tone online ose duke na shkruar email me ID e ceshtjes ne subjekt." +
                            "Faleminerit";
                    break;
                case Tipi.rap_ceshtje:
                    subject = "Ceshtje ne E-Support";
                    body = "Gjendja e ceshtjes " + str1 + "eshte si me poshte :\n" +
                            str2 + "\nFaleminderit";
                    break;
                default:
                    subject = "E-Support";
                    body = "Ky eshte mesazh automatik!\n" +
                        "Per me shume informacion vizitoni faqen tone online.\n" +
                        "Faleminderit!";
                    break;
            }

            MailAddress send_to = new MailAddress(to);

            MailMessage message = new MailMessage(from, send_to)
            {
                Subject = subject,
                Body = body
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



        private void Read_unseen()
        {
            using (Imap imap = new Imap())
            {
                imap.ConnectSSL("imap.gmail.com");
                imap.UseBestLogin("esuppdesk@gmail.com", "Q1w2e3r4.");
                imap.SelectInbox();
                List<long> uids = imap.Search(Flag.Unseen);

                foreach (long uid in uids)
                {
                    var eml = imap.GetMessageByUID(uid);
                    IMail email = new MailBuilder()
                        .CreateFromEml(eml);
                    int id = Lexo_id_ceshtje(email.Subject);
                    if(id != 0)
                    {
                        Dergo_email(email.Sender.ToString(), Tipi.rap_ceshtje, id.ToString(), "Te dhenat mbi ecurine e ceshtjes");
                        continue;
                    }
                    else
                    {
                        Dergo_email(email.Sender.ToString(), Tipi.automatik);
                    }
                }
                imap.Close();
            }
        }

        private int Lexo_id_ceshtje(string subject)
        {
            subject = subject.Trim();
            int id = 0;
            try
            {
                id = Convert.ToInt32(subject);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return id;
        }


        private void Start_receiving()
        {
            Task.Run(() =>
            {
                using (ImapClient client = new ImapClient("imap.gmail.com", 993,
                    email, fjalekalimi, AuthMethod.Login, true))
                {
                    if (client.Supports("IDLE") == false)
                    {
                        Console.WriteLine("server does not support imap idle");
                        return;
                    }
                    client.NewMessage += new EventHandler<IdleMessageEventArgs>(On_new_message);
                    while (true) ;
                }
            });
        }

        private void On_new_message(object sender, IdleMessageEventArgs e)
        {
            Console.WriteLine("New message");
            MailMessage m = e.Client.GetMessage(e.MessageUID, FetchOptions.Normal);

            int id = Lexo_id_ceshtje(m.Subject);
            if (id != 0)
                Dergo_email(m.From.ToString(), Tipi.rap_ceshtje, id.ToString(), "Te dhenat mbi ecurine e ceshtjes");
            else
                Dergo_email(m.From.ToString(), Tipi.automatik);
        }
    }
}