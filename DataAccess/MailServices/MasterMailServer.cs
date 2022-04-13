using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Net;



namespace DataAccess.MailServices
{
    public abstract class MasterMailServer
    {
        private SmtpClient smtpClient;
        protected string senderMail { get; set; }
        protected string password { get; set; }
        protected string host { get; set; }
        protected int port { get; set; }
        protected bool ssl { get; set; }

        protected void initializeSmtpClient()
        {
            smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential(senderMail, password);
            smtpClient.Host = host;
            smtpClient.Port = port;
            smtpClient.EnableSsl = ssl;

        }

        public void sendMail(string subject, string body, List<string> recipientMail)
        {
            var mailMessagge = new MailMessage();

            try
            {
                mailMessagge.From = new MailAddress(senderMail);

                foreach(string mail in recipientMail)
                {
                    mailMessagge.To.Add(mail);

                }

                mailMessagge.Subject = subject;
                mailMessagge.Body = body;
                mailMessagge.Priority = MailPriority.Normal;
                smtpClient.Send(mailMessagge);
            }
            catch (Exception ex)
            {
               
            }
            finally
            {
                mailMessagge.Dispose();
                smtpClient.Dispose();

            }
        }
    }
}
