using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Cache
{
  public static  class MailCache
    {
        public static string senderMail { get; set; }
        public static string host { get; set; }
        public static int port { get; set; }
        public static int ssl { get; set; }
        public static string PasswordMail { get; set; }
    }
}
