using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using S22.Imap;
using Limilabs.Client.IMAP;
using Limilabs.Mail;
using System.Collections.Generic;

namespace emaileautomatike
{
    public partial class Form1 : Form
    {
        static Form1 f;
        public Form1()
        {
            InitializeComponent();
            f = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailAddress to = new MailAddress("marsiballkoci@gmail.com");
            MailAddress from = new MailAddress("esuppdesk@gmail.com");

            MailMessage message = new MailMessage(from, to);
            message.Subject = "E-Support ju Mirepret!";
            message.Body = "test me formen!";

            SmtpClient client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("esuppdesk@gmail.com", "Q1w2e3r4."),
                EnableSsl = true
            };

            try
            {
                client.Send(message);
                MessageBox.Show("Mesazhi u dergua");

            }
            catch (SmtpException ex)
            {
               MessageBox.Show(ex.ToString());
            }
        }

        private void read_unseen()
        {
            using (Imap imap = new Imap())
            {
                imap.ConnectSSL("imap.gmail.com");
                imap.UseBestLogin("esuppdesk@gmail.com", "Q1w2e3r4.");
                imap.SelectInbox();
                imap.SelectInbox();
                List<long> uids = imap.Search(Flag.Unseen);

                foreach (long uid in uids)
                {
                    var eml = imap.GetMessageByUID(uid);
                    IMail email = new MailBuilder()
                        .CreateFromEml(eml);

                    f.Invoke((MethodInvoker)delegate
                    {
                        f.textBox1.AppendText("From: " + email.From + "\nSubject: " + email.Subject + "\n");
                    });
                  
                }
                imap.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            read_unseen();

            start_receiving();
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
                        MessageBox.Show("server does not support imap idle");
                        return;
                    }
                    client.NewMessage += new EventHandler<IdleMessageEventArgs>(on_new_message);
                    while (true) ;
                }
            });
        }

        static void on_new_message(object sender, IdleMessageEventArgs e)
        {
           MessageBox.Show("new message");
            MailMessage m = e.Client.GetMessage(e.MessageUID, FetchOptions.Normal);

            f.Invoke((MethodInvoker)delegate
            {
                f.textBox1.AppendText("From: " + m.From + "\nSubject: " + m.Subject + "\nbody: " + m.Body);
            });
           
            MailAddress to = m.From;
            MailAddress from = new MailAddress("esuppdesk@gmail.com");

            MailMessage message = new MailMessage(from, to);
            message.Subject = "re: E-Support";
            message.Body = "reply automatikisht";

            SmtpClient client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("esuppdesk@gmail.com", "Q1w2e3r4."),
                EnableSsl = true
            };

            try
            {
                client.Send(message);
                MessageBox.Show("Mesazhi u dergua");

            }
            catch (SmtpException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

