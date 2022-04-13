using Common.Cache;

namespace DataAccess.MailServices
{
    class SystemSupportMail: MasterMailServer
    {
        public SystemSupportMail()
        {
            senderMail = MailCache.senderMail;
            host = MailCache.host;
            port = MailCache.port;

            if (MailCache.ssl == 1)
            {
                ssl = true;
            }
            else
            {
                ssl = false;
            }
            password = MailCache.PasswordMail;
            initializeSmtpClient();
        }
       
       
    }
}
