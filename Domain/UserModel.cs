using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.SqlServer;



namespace Domain
{
   public class UserModel
    {
        UserData userData = new UserData();

        public bool LoginUser(string email, string clave)
        {
            return userData.Login(email, clave);

        }
        public string recoverPassword(string userRequesting)
        {
            return userData.recoverPassword(userRequesting);
        }
        public string sendMailApplicant(string email, string nombreSolicitante, string estatusSolicitud, string nombreAutorizador, string folio)
        {
            return userData.sendMailApplicant(email, nombreSolicitante, estatusSolicitud, nombreAutorizador, folio);
        }
        public string sendMailApplicantForFinance(string email, string nombreSolicitante, string estatusSolicitud, string nombreFinanzas, string folio)
        {
            return userData.sendMailApplicantForFinance(email, nombreSolicitante, estatusSolicitud, nombreFinanzas, folio);
        }
        public string sendMailAuthorizer(string email, string nombreFinanzas, string nombreSolicitante, string nombreAutorizador, string folio)
        {
            return userData.sendMailAuthorizer(email, nombreFinanzas, nombreSolicitante, nombreAutorizador, folio);
        }
        public string sendMailAuthorizerForApplicant(string email, string nombreSolicitante, string nombreAutorizador)
        {
            return userData.sendMailAuthorizerForApplicant(email, nombreSolicitante, nombreAutorizador);
        }


    }
}
