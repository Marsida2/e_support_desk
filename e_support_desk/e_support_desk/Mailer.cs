using System;
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
using System.Data.SqlClient;
using System.Data;

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

        public void Dergo_email(string to, Tipi tipi, string str1="", string str2 = "")
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
                            "Ju mund te nqiqni ecurine e ceshtjes ne faqen tone online ose duke na shkruar email me ID e ceshtjes ne subjekt.\n" +
                            "Faleminderit";
                    break;

                case Tipi.rap_ceshtje:
                    subject = "Ceshtje ne E-Support";
                    body = "I nderuar klient,\n" +
                            "Ne llogarine tuaj nuk ekziston ceshtje me id " + str1 + "!\n" +
                            "Ju lutem rishikoni emilet e meparshme.\n" +
                            "Faleminderit!";
                    //marrim te dhenat e ceshtjes nga databaza
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["e_support_conn_string"].ToString());
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "analize_ceshtje";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("id", str1);
                    cmd.Parameters.AddWithValue("email", to);
                    try
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            body = "Pershendetje " + reader["klienti"].ToString() + "!\n";
                            body += "Gjendja e ceshtjes nr." + str1 + " eshte si me poshte :\n";
                            body += "Ceshtja: " + reader["lloji"].ToString() + "\n";
                            body += "Statusi: " + reader["pershkrimi"].ToString() + "\n";
                            body += "Afati kohor: " + reader["afati_kohor"].ToString() + "\n";
                            body += "Pergjegjesi: " + reader["pergjegjesi"].ToString() + "\n";
                            body += "Faleminderit!"; 
                        }
                        reader.Close();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        return;
                    }                    
                    break;

                default:
                    subject = "E-Support";
                    body = "I nderuar klient,\n" +
                        "Mesazhi juaj nuk perpputhet me kriteret e pergjigjeve automatike!\n" +
                        "Per tu informuar rreth ceshtjeve tuaja dergoni ne subject ID e ceshtjes.\n" +
                        "Na vizitoni faqen tone onlin e.\n" +
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
            Task.Run(() =>
           {
               using (Imap imap = new Imap())
               {
                   imap.ConnectSSL("imap.gmail.com");
                   imap.UseBestLogin(email, fjalekalimi);
                   imap.SelectInbox();
                   List<long> uids = imap.Search(Flag.Unseen);

                   foreach (long uid in uids)
                   {
                       var eml = imap.GetMessageByUID(uid);
                       IMail email = new MailBuilder().CreateFromEml(eml);
                       int id = Lexo_id_ceshtje(email.Subject.Trim());
                       if (id != 0)
                           Dergo_email(email.From.ToString(), Tipi.rap_ceshtje, id.ToString(), "Te dhenat mbi ecurine e ceshtjes");
                       else
                           Dergo_email(email.From.ToString(), Tipi.automatik);
                   }
               }
            });
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
