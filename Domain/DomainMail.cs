using DataAccess.Data;
using System.Data;
using Common.Cache;


namespace Domain
{
   public class DomainMail
    {
        public static DataTable traerCorreo(string valor)
        {
            DataMail datos = new DataMail();
            return datos.traerCorreo(valor);

        }
        public static string actualizar(int idCorreo, string senderMail, string correo_password, string correo_host, int correo_port, int correo_ssl)
        {
            DataMail datos = new DataMail();
            MailData obj = new MailData();

            obj.IdCorreo = idCorreo;
            obj.SenderMail = senderMail;
            obj.Password = correo_password;
            obj.Host = correo_host;
            obj.Port = correo_port;
            obj.Ssl = correo_ssl;

            return datos.actualizar(obj);
        }
        }
    }

